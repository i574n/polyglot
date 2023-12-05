use serde::{Deserialize, Serialize};

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct Block {
    pub block_height: u32,
}

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct Action {
    pub action: String,
    pub method: Option<String>,
}

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct ActionsAgg {
    pub deposit: u64,
}

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct Outcomes {
    pub status: bool,
}

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct OutcomesAgg {
    pub transaction_fee: f64,
}

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct Txn {
    pub receipt_id: String,
    pub predecessor_account_id: String,
    pub receiver_account_id: String,
    pub transaction_hash: String,
    pub included_in_block_hash: String,
    pub block_timestamp: String,
    pub block: Block,
    pub actions: Vec<Action>,
    pub actions_agg: ActionsAgg,
    pub outcomes: Outcomes,
    pub outcomes_agg: OutcomesAgg,
    pub logs: Vec<String>,
}

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct Root {
    pub txns: Vec<Txn>,
}
