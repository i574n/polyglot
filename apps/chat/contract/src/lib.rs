use near_sdk::borsh::{self, BorshDeserialize, BorshSerialize};
use near_sdk::{env, log, near_bindgen, AccountId, PanicOnDefault};
use std::collections::BTreeMap;

#[near_bindgen]
#[derive(PanicOnDefault, BorshDeserialize, BorshSerialize)]
pub struct State {
    alias_map: BTreeMap<String, BTreeMap<AccountId, (u64, i32)>>,
}

#[near_bindgen]
impl State {
    #[init]
    pub fn new() -> Self {
        Self {
            alias_map: BTreeMap::new(),
        }
    }

    #[payable]
    pub fn claim_alias(&mut self, alias: String) {
        let account_id = env::signer_account_id();
        let timestamp = env::block_timestamp();

        log!(format!("claim_alias / alias: {alias:#?} / account_id: {account_id:#?} / timestamp: {timestamp:#?}"));

        if alias == "" {
            env::panic_str("Invalid alias");
        }

        for (_, account_map) in self.alias_map.iter_mut() {
            account_map.remove(&account_id);
        }

        match self.alias_map.get_mut(&alias) {
            Some(accounts) => {
                let index = accounts.len() as i32;
                accounts.insert(account_id, (timestamp, index));
            },
            None => {
                let mut new_map = BTreeMap::new();
                new_map.insert(account_id, (timestamp, 0));
                self.alias_map.insert(alias, new_map);
            },
        };
    }

    pub fn get_env_data() -> (u64, u64) {
        let block_timestamp = env::block_timestamp();
        let epoch_height = env::epoch_height();

        let storage_usage = env::storage_usage();

        log!(format!("get_env_data / block_timestamp: {block_timestamp:#?} / epoch_height: {epoch_height:#?} // storage_usage: {storage_usage:#?}"));

        (block_timestamp, epoch_height)
    }

    #[result_serializer(borsh)]
    pub fn get_env_data_borsh() -> (u64, u64) {
        Self::get_env_data()
    }

    pub fn get_account_info(&self, account_id: AccountId) -> Option<(String, (u64, i32))> {
        log!(format!("get_account_info / account_id: {account_id:#?}"));

        self.alias_map.iter().find_map(|(alias, accounts)| {
            if let Some(info) = accounts.get(&account_id) {
                Some((alias.clone(), *info))
            } else {
                None
            }
        })
    }

    #[result_serializer(borsh)]
    pub fn get_account_info_borsh(&self, #[serializer(borsh)] account_id: AccountId) -> Option<(String, (u64, i32))> {
        self.get_account_info(account_id)
    }

    pub fn get_alias_map(&self, alias: String) -> Option<BTreeMap<AccountId, (u64, i32)>> {
        log!(format!("get_alias_map / alias: {alias:#?}"));

        self.alias_map.get(&alias).cloned()
    }

    #[result_serializer(borsh)]
    pub fn get_alias_map_borsh(&self, #[serializer(borsh)] alias: String) -> Option<BTreeMap<AccountId, (u64, i32)>> {
        self.get_alias_map(alias)
    }
}
