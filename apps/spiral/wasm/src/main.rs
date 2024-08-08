fn print_usd(result: near_workspaces::result::ExecutionFinalResult) {
    // const GAS_PRICE_IN_NEAR: f64 = 0.0001;
    const NEAR_PRICE_IN_USD: f64 = 6.68;

    fn gas_to_usd(gas: u64) -> f64 {
        (gas as f64) / 1e16 * NEAR_PRICE_IN_USD
    }

    fn tokens_to_usd(tokens: u128) -> f64 {
        (tokens as f64) / 1e24 * NEAR_PRICE_IN_USD
    }

    println!(
        "gas_to_usd(result.total_gas_burnt.as_gas()): {:.6} ({:#?})",
        gas_to_usd(result.total_gas_burnt.as_gas()),
        result.total_gas_burnt.as_gas()
    );
    result.outcomes().iter().for_each(|outcome| {
        println!("outcome (success: {:#?}):", outcome.is_success());
        println!(
            "  gas_to_usd(outcome.gas_burnt.as_gas()): {:.6} ({:#?})",
            gas_to_usd(outcome.gas_burnt.as_gas()),
            outcome.gas_burnt.as_gas()
        );
        println!(
            "  tokens_to_usd(outcome.tokens_burnt.as_yoctonear()): {:.6} ({:#?})",
            tokens_to_usd(outcome.tokens_burnt.as_yoctonear()),
            outcome.tokens_burnt.as_yoctonear()
        );
    });
}

#[tokio::main]
async fn main() -> anyhow::Result<()> {
    let wasm_path = std::env::var("WASM_PATH").unwrap();

    let worker = near_workspaces::sandbox().await?;
    let wasm = std::fs::read(wasm_path)?;
    let contract = worker.dev_deploy(&wasm).await?;

    let result = contract.call("state_main").transact().await?;

    let logs = result.logs();
    logs.iter().for_each(|log| {
        println!("{}", log.trim());
    });

    println!("\n\n state_main transact result: {result:#?}");

    println!("\n\n print_usd:");
    print_usd(result.clone());

    let result2 = result.clone().into_result();
    println!("\n\n result.into_result(): {result2:#?}");

    let receipt_failures = result.receipt_failures();
    println!("\n\n receipt_failures: {receipt_failures:#?}");

    let receipt_outcomes = result.receipt_outcomes();
    println!("\n\n receipt_outcomes: {receipt_outcomes:#?}");

    let json: Result<String, near_workspaces::error::Error> = result.clone().json();
    println!("\n\n json: {json:#?}");

    let borsh: Result<String, near_workspaces::error::Error> = result.clone().borsh();
    println!("\n\n borsh: {borsh:#?}");

    println!("\n\n worker: {:#?}", worker);
    println!("\n\n contract: {:#?}", contract);

    if receipt_failures.len() == 0 {
        Ok(())
    } else {
        // let err = receipt_failures
        //     .iter()
        //     .map(|outcome| {
        //         let result = <near_workspaces::result::ExecutionOutcome as Clone>::clone(outcome)
        //             .into_result();
        //         format!("outcome.into_result(): {:#?}", result)
        //     })
        //     .collect::<Vec<_>>();
        // println!("\n\n err: {:#?}", err);
        // let err = format!("{:#?}", err);
        // let err = anyhow::anyhow!(err);
        let err = anyhow::anyhow!("<error>");
        Err(err)
    }
}
