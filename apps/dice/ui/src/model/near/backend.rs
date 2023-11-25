use serde::{Deserialize, Serialize};

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
pub struct TransferArgs {
    pub deposit: String,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(rename_all = "camelCase")]
pub struct DeployContractArgs {
    pub code: String,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(rename_all = "camelCase")]
pub struct Permission {
    #[serde(rename = "type")]
    pub permission_type: String,
    pub contract_id: Option<String>,
    pub method_names: Option<Vec<String>>,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
pub struct AccessKey {
    pub nonce: u8,
    pub permission: Permission,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(rename_all = "camelCase")]
pub struct AddKeyArgs {
    pub public_key: String,
    pub access_key: AccessKey,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(rename_all = "camelCase")]
pub struct FunctionCallArgs {
    pub method_name: String,
    pub args: String,
    pub gas: u64,
    pub deposit: String,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(tag = "kind", content = "args")]
#[serde(rename_all = "camelCase")]
pub enum TransactionAction {
    FunctionCall(FunctionCallArgs),
    AddKey(AddKeyArgs),
    DeployContract(DeployContractArgs),
    Transfer(TransferArgs),
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(rename_all = "camelCase")]
pub struct Transaction {
    pub hash: String,
    pub signer_id: String,
    pub receiver_id: String,
    pub block_hash: String,
    pub block_timestamp: u64,
    pub actions: Vec<TransactionAction>,
    pub status: String,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(rename_all = "camelCase")]
pub struct TransactionCursor {
    pub timestamp: String,
    pub index_in_chunk: u8,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
pub struct TransactionListByAccountId {
    pub items: Vec<Transaction>,
    pub cursor: Option<TransactionCursor>,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(rename_all = "camelCase")]
pub struct ContractById {
    pub code_hash: String,
    pub transaction_hash: Option<String>,
    pub timestamp: Option<u64>,
    pub locked: bool,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(rename_all = "camelCase")]
pub struct AccountTransactionsCount {
    pub in_transactions_count: u64,
    pub out_transactions_count: u64,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(untagged)]
pub enum ResultData {
    AccountTransactionsCount(AccountTransactionsCount),
    ContractById(ContractById),
    TransactionListByAccountId(TransactionListByAccountId),
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
pub struct DataWrapper {
    pub data: ResultData,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(rename_all = "camelCase")]
pub struct ErrorDataInner {
    pub code: String,
    pub http_status: u32,
    pub path: String,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
pub struct ErrorData {
    pub message: String,
    pub code: i32,
    pub data: ErrorDataInner,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
pub struct ErrorWrapper {
    pub error: ErrorData,
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
#[serde(untagged)]
pub enum ErrorWrapperEnum {
    ErrorWrapper(ErrorWrapper),
    ErrorData(ErrorData),
}

#[derive(Clone, Debug, Eq, Hash, Ord, PartialEq, PartialOrd, Deserialize, Serialize)]
pub struct ResultWrapper {
    pub result: Option<DataWrapper>,
    pub error: Option<ErrorWrapperEnum>,
}

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct IdInput {
    pub id: String,
}

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
#[serde(rename_all = "camelCase")]
pub struct TransactionListByAccountIdInput {
    pub account_id: String,
    pub limit: u8,
    pub cursor: Option<TransactionCursor>,
}

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
#[serde(untagged)]
pub enum InputData {
    IdInput(IdInput),
    TransactionListByAccountIdInput(TransactionListByAccountIdInput),
}
