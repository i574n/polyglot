use serde_json::json;
use std::collections::HashMap;
use workspaces::AccountId;

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
        .join("../contract/res/chat.wasm")
        .display()
        .to_string();

    let worker = workspaces::sandbox().await?;
    let wasm = std::fs::read(contract_path)?;
    let contract = worker.dev_deploy(&wasm).await?;
    let contract_id = contract.id();

    // new(contract)
    let result = contract.call("new").transact().await?;
    println!("\n\nnew: {result:#?}");
    print_usd(result);

    // get_env_data(contract)
    let result: (u64, u64) = contract.view("get_env_data").await?.json()?;
    println!("\n\nget_env_data(contract): {result:#?}");

    // claim_alias(contract, '')
    let result = contract
        .call("claim_alias")
        .args_json(json!({
            "alias": "",
        }))
        .transact()
        .await?;
    println!("\n\nclaim_alias(contract, ''): {result:#?}");
    print_usd(result);

    // dev_create_account(account1)
    let account1 = worker.dev_create_account().await?;
    println!("\n\ndev_create_account(account1): {account1:#?}");

    // claim_alias(account1, alias1)
    let result = account1
        .call(contract_id, "claim_alias")
        .args_json(json!({
            "alias": "alias1",
        }))
        .transact()
        .await?;
    println!("\n\nclaim_alias(account1, alias1): {result:#?}");
    print_usd(result);

    // claim_alias(account1, alias1)
    let result = account1
        .call(contract_id, "claim_alias")
        .args_json(json!({
            "alias": "alias1",
        }))
        .transact()
        .await?;
    println!("\n\nclaim_alias(account1, alias1): {result:#?}");
    print_usd(result);

    // get_account_info(account1)
    let result: Option<(String, (u64, u32))> = account1
        .view(contract_id, "get_account_info")
        .args_json(json!({
            "account_id": account1.id(),
        }))
        .await?
        .json()?;
    println!("\n\nget_account_info(account1): {result:#?}");
    match result {
        Some((alias, (_, index))) => {
            assert_eq!(alias, "alias1");
            assert_eq!(index, 0);
        }
        None => {
            panic!("Expected Some((alias, (_, index)))");
        }
    }

    // get_alias_map(account1, alias1)
    let result: Option<HashMap<AccountId, (u64, u32)>> = account1
        .view(contract_id, "get_alias_map")
        .args_json(json!({
            "alias": "alias1",
        }))
        .await?
        .json()?;
    println!("\n\nget_alias_map(account1, alias1): {result:#?}");
    match result {
        Some(map) => match map.iter().collect::<Vec<_>>().as_slice() {
            [(account_id, (_, index))] => {
                assert_eq!(*account_id, account1.id());
                assert_eq!(*index, 0);
            }
            _ => {
                panic!("Expected [(account_id, (_, index))]");
            }
        },
        None => {
            panic!("Expected Some(map)");
        }
    }

    // dev_create_account(account2)
    let account2 = worker.dev_create_account().await?;
    println!("\n\ndev_create_account(account2): {account2:#?}");

    // get_env_data_borsh(account1)
    let result: (u64, u64) = account1
        .view(contract_id, "get_env_data_borsh")
        .await?
        .borsh()?;
    println!("\n\nget_env_data_borsh(account1): {result:#?}");

    // claim_alias(account2, alias2)
    let result = account2
        .call(contract_id, "claim_alias")
        .args_json(json!({
            "alias": "alias2",
        }))
        .transact()
        .await?;
    println!("\n\nclaim_alias(alias2): {result:#?}");
    print_usd(result);

    // get_account_info_borsh(account2)
    let result: Option<(String, (u64, u32))> = account2
        .view(contract_id, "get_account_info_borsh")
        .args_borsh(account2.id())
        .await?
        .borsh()?;
    println!("\n\nget_account_info_borsh(account2): {result:#?}");
    match result {
        Some((alias, (_, index))) => {
            assert_eq!(alias, "alias2");
            assert_eq!(index, 0);
        }
        None => {
            panic!("Expected Some((alias, (_, index)))");
        }
    }

    // get_alias_map(alias2)
    let result: Option<HashMap<AccountId, (u64, u32)>> = account2
        .view(contract_id, "get_alias_map")
        .args_json(json!({
            "alias": "alias2",
        }))
        .await?
        .json()?;
    println!("\n\nget_alias_map(alias2): {result:#?}");
    match result {
        Some(map) => match map.iter().collect::<Vec<_>>().as_slice() {
            [(account1_id, (_, index1))] => {
                assert_eq!(*account1_id, account2.id());
                assert_eq!(*index1, 0);
            }
            _ => {
                panic!("Expected [(account1_id, (_, index1))]");
            }
        },
        None => {
            panic!("Expected Some(map)");
        }
    }

    // get_env_data(account2)
    let result: (u64, u64) = account2.view(contract_id, "get_env_data").await?.json()?;
    println!("\n\nget_env_data(account2): {result:#?}");

    // claim_alias(account2, alias1)
    let result = account2
        .call(contract_id, "claim_alias")
        .args_json(json!({
            "alias": "alias1",
        }))
        .transact()
        .await?;
    println!("\n\nclaim_alias(account2, alias1): {result:#?}");
    print_usd(result);

    // get_account_info(account2)
    let result: Option<(String, (u64, u32))> = account2
        .view(contract_id, "get_account_info")
        .args_json(json!({
            "account_id": account2.id(),
        }))
        .await?
        .json()?;
    println!("\n\nget_account_info(account2): {result:#?}");
    match result {
        Some((alias, (_, index))) => {
            assert_eq!(alias, "alias1");
            assert_eq!(index, 1);
        }
        None => {
            panic!("Expected Some((alias, (_, index)))");
        }
    }

    // get_alias_map(account2, alias1)
    let result: Option<HashMap<AccountId, (u64, u32)>> = account2
        .view(contract_id, "get_alias_map")
        .args_json(json!({
            "alias": "alias1",
        }))
        .await?
        .json()?;
    println!("\n\nget_alias_map(account2, alias1): {result:#?}");
    match result {
        Some(map) => {
            let mut accounts_vec = map.iter().collect::<Vec<_>>();
            accounts_vec.sort_by_key(|(_, (_, index))| *index);
            match accounts_vec.as_slice() {
                [(account1_id, (_, index1)), (account2_id, (_, index2))] => {
                    assert_eq!(*account1_id, account1.id());
                    assert_eq!(*index1, 0);
                    assert_eq!(*account2_id, account2.id());
                    assert_eq!(*index2, 1);
                }
                _ => {
                    panic!("Expected [(account1_id, (_, index1)), (account2_id, (_, index2))]");
                }
            }
        }
        None => {
            panic!("Expected Some(map)");
        }
    }

    // get_alias_map(account2, alias2)
    let result: Option<HashMap<AccountId, (u64, u32)>> = account2
        .view(contract_id, "get_alias_map")
        .args_json(json!({
            "alias": "alias2",
        }))
        .await?
        .json()?;
    println!("\n\nget_alias_map(account2, alias2): {result:#?}");
    match result {
        Some(map) => match map.iter().collect::<Vec<_>>().as_slice() {
            [] => (),
            _ => {
                panic!("Expected []");
            }
        },
        None => {
            panic!("Expected Some(map)");
        }
    }

    // get_env_data(account1)
    let result: (u64, u64) = account1.view(contract_id, "get_env_data").await?.json()?;
    println!("\n\nget_env_data(account1): {result:#?}");

    // claim_alias(account1, alias2)
    let result = account1
        .call(contract_id, "claim_alias")
        .args_json(json!({
            "alias": "alias2",
        }))
        .transact()
        .await?;
    println!("\n\nclaim_alias(account1, alias2): {result:#?}");
    print_usd(result);

    // get_account_info(account1)
    let result: Option<(String, (u64, u32))> = account1
        .view(contract_id, "get_account_info")
        .args_json(json!({
            "account_id": account1.id(),
        }))
        .await?
        .json()?;
    println!("\n\nget_account_info(account1): {result:#?}");
    match result {
        Some((alias, (_, index))) => {
            assert_eq!(alias, "alias2");
            assert_eq!(index, 0);
        }
        None => {
            panic!("Expected Some((alias, (_, index)))");
        }
    }

    // get_alias_map(account1, alias2)
    let result: Option<HashMap<AccountId, (u64, u32)>> = account1
        .view(contract_id, "get_alias_map")
        .args_json(json!({
            "alias": "alias2",
        }))
        .await?
        .json()?;
    println!("\n\nget_alias_map(account1, alias2): {result:#?}");
    match result {
        Some(map) => match map.iter().collect::<Vec<_>>().as_slice() {
            [(account1_id, (_, index1))] => {
                assert_eq!(*account1_id, account1.id());
                assert_eq!(*index1, 0);
            }
            _ => {
                panic!("Expected [(account1_id, (_, index1))]");
            }
        },
        None => {
            panic!("Expected Some(map)");
        }
    }

    // get_alias_map(account1, alias1)
    let result: Option<HashMap<AccountId, (u64, u32)>> = account1
        .view(contract_id, "get_alias_map")
        .args_json(json!({
            "alias": "alias1",
        }))
        .await?
        .json()?;
    println!("\n\nget_alias_map(account1, alias1): {result:#?}");
    match result {
        Some(map) => match map.iter().collect::<Vec<_>>().as_slice() {
            [(account1_id, (_, index1))] => {
                assert_eq!(*account1_id, account2.id());
                assert_eq!(*index1, 1);
            }
            _ => {
                panic!("Expected [(account1_id, (_, index1))]");
            }
        },
        None => {
            panic!("Expected Some(map)");
        }
    }

    // get_env_data(account1)
    let result: (u64, u64) = account1.view(contract_id, "get_env_data").await?.json()?;
    println!("\n\nget_env_data(account1): {result:#?}");

    // claim_alias(account1, alias1)
    let result = account1
        .call(contract_id, "claim_alias")
        .args_json(json!({
            "alias": "alias1",
        }))
        .transact()
        .await?;
    println!("\n\nclaim_alias(account1, alias1): {result:#?}");
    print_usd(result);

    // get_account_info(account1)
    let result: Option<(String, (u64, u32))> = account1
        .view(contract_id, "get_account_info")
        .args_json(json!({
            "account_id": account1.id(),
        }))
        .await?
        .json()?;
    println!("\n\nget_account_info(account1): {result:#?}");
    match result {
        Some((alias, (_, index))) => {
            assert_eq!(alias, "alias1");
            assert_eq!(index, 1);
        }
        None => {
            panic!("Expected Some((alias, (_, index)))");
        }
    }

    // get_alias_map(account1, alias1)
    let result: Option<HashMap<AccountId, (u64, u32)>> = account1
        .view(contract_id, "get_alias_map")
        .args_json(json!({
            "alias": "alias1",
        }))
        .await?
        .json()?;
    println!("\n\nget_alias_map(account1, alias1): {result:#?}");
    match result {
        Some(map) => {
            let mut accounts_vec = map.iter().collect::<Vec<_>>();
            accounts_vec.sort_by_key(|(_, (_, index))| *index);
            match accounts_vec.as_slice() {
                [(account1_id, (_, index1)), (account2_id, (_, index2))] => {
                    assert_eq!(*account1_id, account2.id());
                    assert_eq!(*index1, 0);
                    assert_eq!(*account2_id, account1.id());
                    assert_eq!(*index2, 1);
                }
                _ => {
                    panic!("Expected [(account1_id, (_, index1)), (account2_id, (_, index2))]");
                }
            }
        }
        None => {
            panic!("Expected Some(map)");
        }
    }

    // get_alias_map(account1, alias2)
    let result: Option<HashMap<AccountId, (u64, u32)>> = account1
        .view(contract_id, "get_alias_map")
        .args_json(json!({
            "alias": "alias2",
        }))
        .await?
        .json()?;
    println!("\n\nget_alias_map(account1, alias2): {result:#?}");
    match result {
        Some(map) => match map.iter().collect::<Vec<_>>().as_slice() {
            [] => (),
            _ => {
                panic!("Expected []");
            }
        },
        None => {
            panic!("Expected Some(map)");
        }
    }

    Ok(())
}