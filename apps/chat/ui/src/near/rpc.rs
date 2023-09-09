use serde::{Deserialize, Serialize};
use std::collections::HashMap;


#[derive(Serialize, Deserialize, Debug)]
pub struct RpcInput {
    pub jsonrpc: String,
    pub id: String,
    pub method: String,
    pub params: Vec<String>,
}

#[derive(Serialize, Deserialize, Debug)]
pub struct ErrorCauseInfo {
    pub error_message: String,
}
#[derive(Serialize, Deserialize, Debug)]
pub struct ErrorCause {
    pub name: String,
    pub info: ErrorCauseInfo,
}
#[derive(Serialize, Deserialize, Debug)]
pub struct RpcError {
    pub name: String,
    pub cause: ErrorCause,
    pub code: i32,
    pub message: String,
    pub data: String,
}

#[derive(Serialize, Deserialize, Debug)]
pub struct RpcResponse {
    pub jsonrpc: String,
    pub result: Option<TransactionStatus>,
    pub error: Option<RpcError>,
}

#[derive(Serialize, Deserialize, Debug)]
pub struct TransactionStatus {
    pub receipts: Vec<Receipt>,
    pub receipts_outcome: Vec<ReceiptsOutcome>,
}

#[derive(Serialize, Deserialize, Debug)]
pub struct Receipt {
    pub predecessor_id: String,
    pub receipt: ReceiptDetail,
    pub receipt_id: String,
    pub receiver_id: String,
}

#[derive(Serialize, Deserialize, Debug)]
#[serde(rename_all = "PascalCase")]
pub struct ReceiptDetail {
    pub action: ActionDetail,
}

#[derive(Serialize, Deserialize, Debug)]
pub struct ActionDetail {
    pub actions: Vec<HashMap<String, TransferDetail>>,
    pub gas_price: String,
    pub input_data_ids: Vec<String>,
    pub output_data_receivers: Vec<String>,
    pub signer_id: String,
    pub signer_public_key: String,
}

#[derive(Serialize, Deserialize, Debug)]
pub struct TransferDetail {
    pub deposit: String,
}

#[derive(Serialize, Deserialize, Debug)]
pub struct ReceiptsOutcome {
    pub block_hash: String,
    pub id: String,
    pub outcome: OutcomeDetail,
}

#[derive(Serialize, Deserialize, Debug)]
pub struct OutcomeDetail {
    pub executor_id: String,
    pub gas_burnt: u64,
    pub logs: Vec<String>,
    pub metadata: Metadata,
    pub receipt_ids: Vec<String>,
    pub status: HashMap<String, String>,
}

#[derive(Serialize, Deserialize, Debug)]
pub struct Metadata {
    pub gas_profile: Vec<GasProfile>,
    pub version: u8,
}

#[derive(Serialize, Deserialize, Debug)]
pub struct GasProfile {
    pub cost: String,
    pub cost_category: String,
    pub gas_used: String,
}

pub async fn fetch_transaction_status(hash: String) -> RpcResponse {
    let input_obj = RpcInput {
        jsonrpc: "2.0".to_string(),
        id: "dontcare".to_string(),
        method: "EXPERIMENTAL_tx_status".to_string(),
        params: vec![hash, "bowen".to_string()],
    };

    // let input_json = serde_json::to_string(&input_obj).unwrap();

    let url = "https://rpc.mainnet.near.org";

    let json = reqwest_wasm::Client::builder()
        .build()
        .unwrap()
        .post(url)
        .json(&input_obj)
        .send()
        .await
        .unwrap()
        .text()
        .await
        .unwrap();

    let obj: RpcResponse = serde_json::from_str(&json).unwrap();

    obj
}
