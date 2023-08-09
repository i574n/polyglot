use near_sdk::borsh::{self, BorshDeserialize, BorshSerialize};
use near_sdk::{env, log, near_bindgen, AccountId, PanicOnDefault};
use std::collections::HashMap;

#[near_bindgen]
#[derive(PanicOnDefault, BorshDeserialize, BorshSerialize)]
pub struct State {
    version: u32,
    alias_map: HashMap<String, HashMap<AccountId, (u64, u32)>>,
    account_map: HashMap<AccountId, String>,
}

#[near_bindgen]
impl State {
    #[init]
    pub fn new() -> Self {
        Self {
            version: 1,
            alias_map: HashMap::new(),
            account_map: HashMap::new(),
        }
    }

    fn is_valid_alias(alias: &str) -> bool {
        alias.len() > 0
            && alias.len() < 64
            && !alias.starts_with('-')
            && !alias.ends_with('-')
            && alias.chars().all(|c| c.is_alphanumeric() || c == '-')
    }

    #[payable]
    pub fn claim_alias(&mut self, alias: String) {
        let account_id = env::signer_account_id();
        let timestamp = env::block_timestamp();

        log!(format!("claim_alias / alias: {alias:#?} / account_id: {account_id:#?} / timestamp: {timestamp:#?}"));

        if !Self::is_valid_alias(&alias) {
            env::panic_str("Invalid alias");
        }

        if let Some(previous_alias) = self.account_map.get(&account_id) {
            if *previous_alias == alias {
                log!("Alias already claimed");
                return;
            }

            self.alias_map
                .get_mut(previous_alias)
                .unwrap()
                .remove(&account_id);
        }

        self.account_map.insert(account_id.clone(), alias.clone());

        let new_alias_account_map = match self.alias_map.get(&alias) {
            None => {
                let mut new_map = HashMap::new();
                new_map.insert(account_id, (timestamp, 0u32));
                new_map
            }
            Some(accounts) => {
                let mut accounts_vec = accounts.iter().collect::<Vec<_>>();
                accounts_vec.sort_unstable_by_key(|(_, (_, index))| index);
                let mut new_map = accounts_vec
                    .iter()
                    .enumerate()
                    .map(|(i, (account_id, (timestamp, _)))| {
                        ((*account_id).clone(), (*timestamp, i as u32))
                    })
                    .collect::<HashMap<_, _>>();
                new_map.insert(account_id, (timestamp, accounts_vec.len() as u32));
                new_map
            }
        };

        self.alias_map.insert(alias, new_alias_account_map);
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

    pub fn get_account_info(&self, account_id: AccountId) -> Option<(String, (u64, u32))> {
        log!(format!("get_account_info / account_id: {account_id:#?}"));

        self.account_map.get(&account_id).and_then(|alias| {
            self.alias_map
                .get(alias)
                .map(|accounts| (alias.clone(), *accounts.get(&account_id).unwrap()))
        })
    }

    #[result_serializer(borsh)]
    pub fn get_account_info_borsh(
        &self,
        #[serializer(borsh)] account_id: AccountId,
    ) -> Option<(String, (u64, u32))> {
        self.get_account_info(account_id)
    }

    pub fn get_alias_map(&self, alias: String) -> Option<HashMap<AccountId, (u64, u32)>> {
        log!(format!("get_alias_map / alias: {alias:#?}"));

        self.alias_map.get(&alias).cloned()
    }

    #[result_serializer(borsh)]
    pub fn get_alias_map_borsh(
        &self,
        #[serializer(borsh)] alias: String,
    ) -> Option<HashMap<AccountId, (u64, u32)>> {
        self.get_alias_map(alias)
    }
}
