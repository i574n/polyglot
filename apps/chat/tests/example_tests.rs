use serde_json::json;
use workspaces::AccountId;
use std::collections::BTreeMap;

#[tokio::main]
async fn main() -> anyhow::Result<()> {
    let contract_path = std::path::Path::new(env!("CARGO_MANIFEST_DIR")).join("../contract/res/chat.wasm").display().to_string();

    let worker = workspaces::sandbox().await?;
    let wasm = std::fs::read(contract_path)?;
    let contract = worker.dev_deploy(&wasm).await?;
    let contract_id = contract.id();

    // new(contract)
    let outcome =
        contract
            .call("new")
            .transact()
            .await?;
    println!("\n\nnew: {outcome:#?}");

    // get_env_data(contract)
    let result: (u64, u64) =
        contract
            .view("get_env_data")
            .await?
            .json()?;
    println!("\n\nget_env_data(contract): {result:#?}");

    // claim_alias(contract, '')
    let outcome =
        contract
            .call("claim_alias")
            .args_json(json!({
                "alias": "",
            }))
            .transact()
            .await?;
    println!("\n\nclaim_alias(contract, ''): {outcome:#?}");

    // dev_create_account(account1)
    let account1 = worker.dev_create_account().await?;
    println!("\n\ndev_create_account(account1): {account1:#?}");

    // claim_alias(account1, alias1)
    let outcome =
        account1
            .call(contract_id, "claim_alias")
            .args_json(json!({
                "alias": "alias1",
            }))
            .transact()
            .await?;
    println!("\n\nclaim_alias(account1, alias1): {outcome:#?}");

    // get_account_info(account1)
    let result: Option<(String, (u64, i32))> =
        account1
            .view(contract_id, "get_account_info")
            .args_json(json!({
                "account_id": account1.id(),
            }))
            .await?
            .json()?;
    println!("\n\nget_account_info(account1): {result:#?}");

    // get_alias_map(account1, alias1)
    let result: Option<BTreeMap<AccountId, (u64, i32)>> =
        account1
            .view(contract_id, "get_alias_map")
            .args_json(json!({
                "alias": "alias1",
            }))
            .await?
            .json()?;
    println!("\n\nget_alias_map(account1, alias1): {result:#?}");

    // dev_create_account(account2)
    let account2 = worker.dev_create_account().await?;
    println!("\n\ndev_create_account(account2): {account2:#?}");

    // get_env_data_borsh(account1)
    let result: (u64, u64) =
        account1
            .view(contract_id, "get_env_data_borsh")
            .await?
            .borsh()?;
    println!("\n\nget_env_data_borsh(account1): {result:#?}");

    // claim_alias(account2, alias2)
    let outcome =
        account2
            .call(contract_id, "claim_alias")
            .args_json(json!({
                "alias": "alias2",
            }))
            .transact()
            .await?;
    println!("\n\nclaim_alias(alias2): {outcome:#?}");

    // get_account_info_borsh(account2)
    let result: Option<(String, (u64, i32))> =
        account2
            .view(contract_id, "get_account_info_borsh")
            .args_borsh(account2.id())
            .await?
            .borsh()?;
    println!("\n\nget_account_info_borsh(account2): {result:#?}");

    // get_alias_map(alias2)
    let result: Option<BTreeMap<AccountId, (u64, i32)>> =
        account2
            .view(contract_id, "get_alias_map")
            .args_json(json!({
                "alias": "alias2",
            }))
            .await?
            .json()?;
    println!("\n\nget_alias_map(alias2): {result:#?}");

    // get_env_data(account2)
    let result: (u64, u64) =
        account2
            .view(contract_id, "get_env_data")
            .await?
            .json()?;
    println!("\n\nget_env_data(account2): {result:#?}");

    // claim_alias(account2, alias1)
    let outcome =
        account2
            .call(contract_id, "claim_alias")
            .args_json(json!({
                "alias": "alias1",
            }))
            .transact()
            .await?;
    println!("\n\nclaim_alias(account2, alias1): {outcome:#?}");

    // get_account_info(account2)
    let result: Option<(String, (u64, i32))> =
        account2
            .view(contract_id, "get_account_info")
            .args_json(json!({
                "account_id": account2.id(),
            }))
            .await?
            .json()?;
    println!("\n\nget_account_info(account2): {result:#?}");

    // get_alias_map(account2, alias1)
    let result: Option<BTreeMap<AccountId, (u64, i32)>> =
        account2
            .view(contract_id, "get_alias_map")
            .args_json(json!({
                "alias": "alias1",
            }))
            .await?
            .json()?;
    println!("\n\nget_alias_map(account2, alias1): {result:#?}");

    Ok(())
}
