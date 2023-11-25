use borsh::BorshSerialize;
use serde_json::json;

// const GAS_PRICE_IN_NEAR: f64 = 0.0001;
const NEAR_PRICE_IN_USD: f64 = 6.68;

fn gas_to_usd(gas: u64) -> f64 {
    (gas as f64) / 1e16 * NEAR_PRICE_IN_USD
}

fn tokens_to_usd(tokens: u128) -> f64 {
    (tokens as f64) / 1e24 * NEAR_PRICE_IN_USD
}

fn print_usd(result: near_workspaces::result::ExecutionFinalResult) {
    println!(
        "total_gas_burnt_usd: {:#?}",
        gas_to_usd(result.total_gas_burnt.as_gas())
    );
    result.outcomes().iter().for_each(|outcome| {
        println!("outcome (success: {:#?}):", outcome.is_success());
        println!(
            "  outcome_gas_burnt_usd: {:#?}",
            gas_to_usd(outcome.gas_burnt.as_gas())
        );
        println!(
            "  outcome_tokens_burnt_usd: {:#?}",
            tokens_to_usd(outcome.tokens_burnt.as_near())
        );
    });
}

#[tokio::main]
async fn main() -> anyhow::Result<()> {
    let contract_path = std::path::Path::new(env!("CARGO_MANIFEST_DIR"))
        .join("../dist/dice.wasm")
        .display()
        .to_string();

    let worker = near_workspaces::sandbox().await?;
    let wasm = std::fs::read(contract_path)?;
    let contract = worker.dev_deploy(&wasm).await?;
    // let contract_id = contract.id();

    // new(contract)
    let result = contract.call("new").transact().await?;
    println!("\n\nnew: {result:#?}");
    print_usd(result);

    // roll_within_bounds(contract, '')
    let result = contract
        .call("roll_within_bounds")
        .args_json(json!({
            "max": 2000,
            "rolls": [1_i32, 5_i32, 4_i32, 4_i32, 5_i32]
        }))
        .transact()
        .await?;
    println!("\n\nroll_within_bounds(contract, ''): {result:#?}");
    print_usd(result.clone());
    match result.into_result() {
        Ok(result) => {
            assert_eq!(result.json().ok(), Some(995_i32));
        }
        Err(_) => {
            panic!("Expected Some(ExecutionResult<Value>)");
        }
    }

    // roll_within_bounds_borsh(contract, '')
    let result = contract
        .call("roll_within_bounds_borsh")
        .args((|| {
            let mut args = Vec::new();
            2000_u64.serialize(&mut args).unwrap();
            vec![2u8, 2, 6, 4, 5].serialize(&mut args).unwrap();
            args
        })())
        .transact()
        .await?;
    println!("\n\nroll_within_bounds_borsh(contract, ''): {result:#?}");
    print_usd(result.clone());
    match result.into_result() {
        Ok(result) => {
            let n = result.borsh::<Option<u64>>().ok();
            println!("n: {n:#?}");
            assert_eq!(n, Some(Some(1715)));
        }
        Err(_) => {
            panic!("Expected Some(ExecutionResult<Value>)");
        }
    }

    // generate_random_number(contract, '')
    let result = contract
        .call("generate_random_number")
        .args_json(json!({
            "key": "key",
            "proof": "proof",
            "max": 2000,
        }))
        .transact()
        .await?;
    println!("\n\ngenerate_random_number(contract, ''): {result:#?}");
    print_usd(result.clone());
    match result.into_result() {
        Ok(result) => match result.json::<u64>().ok() {
            Some(n) => {
                println!("n: {n:#?}");
            }
            None => {
                panic!("Expected Some(u64)");
            }
        },
        Err(_) => {
            panic!("Expected Some(ExecutionResult<Value>)");
        }
    }

    Ok(())
}
