use serde_json::json;

// const GAS_PRICE_IN_NEAR: f64 = 0.0001;
const NEAR_PRICE_IN_USD: f64 = 6.68;

fn gas_to_usd(gas: u64) -> f64 {
    (gas as f64) / 1e16 * NEAR_PRICE_IN_USD
}

fn tokens_to_usd(tokens: u128) -> f64 {
    (tokens as f64) / 1e24 * NEAR_PRICE_IN_USD
}

fn print_usd(result: workspaces::result::ExecutionFinalResult) {
    println!(
        "total_gas_burnt_usd: {:#?}",
        gas_to_usd(result.total_gas_burnt)
    );
    result.outcomes().iter().for_each(|outcome| {
        println!("outcome (success: {:#?}):", outcome.is_success());
        println!(
            "  outcome_gas_burnt_usd: {:#?}",
            gas_to_usd(outcome.gas_burnt)
        );
        println!(
            "  outcome_tokens_burnt_usd: {:#?}",
            tokens_to_usd(outcome.tokens_burnt)
        );
    });
}

#[tokio::main]
async fn main() -> anyhow::Result<()> {
    let contract_path = std::path::Path::new(env!("CARGO_MANIFEST_DIR"))
        .join("../contract/res/dice.wasm")
        .display()
        .to_string();

    let worker = workspaces::sandbox().await?;
    let wasm = std::fs::read(contract_path)?;
    let contract = worker.dev_deploy(&wasm).await?;
    // let contract_id = contract.id();

    // new(contract)
    let result = contract.call("new").transact().await?;
    println!("\n\nnew: {result:#?}");
    print_usd(result);

    // get_env_data(contract)
    let result: (u64, u64) = contract.view("get_env_data").await?.json()?;
    println!("\n\nget_env_data(contract): {result:#?}");

    // fixed_roll(contract, '')
    let result = contract
        .call("fixed_roll")
        .args_json(json!({
            "max": 2000,
            "rolls": [1_i32, 5_i32, 4_i32, 4_i32, 5_i32]
        }))
        .transact()
        .await?;
    println!("\n\nfixed_roll(contract, ''): {result:#?}");
    print_usd(result.clone());
    match result.into_result() {
        Ok(result) => {
            assert_eq!(result.json().ok(), Some(995_i32));
        }
        Err(err) => {
            panic!("Expected Some(result). {err:#?}");
        }
    }

    Ok(())
}
