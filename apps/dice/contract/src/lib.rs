use near_sdk::borsh::{self, BorshDeserialize, BorshSerialize};
use near_sdk::{env, log, near_bindgen, PanicOnDefault};

#[near_bindgen]
#[derive(PanicOnDefault, BorshDeserialize, BorshSerialize)]
pub struct State {
    version: u32,
}

#[near_bindgen]
impl State {
    #[init]
    pub fn new() -> Self {
        Self {
            version: 1,
        }
    }

    #[payable]
    pub fn fixed_roll(&mut self, max: i32, rolls: Vec<i32>) -> Option<i32> {
        let account_id = env::signer_account_id();
        let timestamp = env::block_timestamp();

        log!(format!("fixed_roll / max: {max:#?} / rolls: {rolls:#?} / account_id: {account_id:#?} / timestamp: {timestamp:#?}"));

        dice::Polyglot::Dice::fixedRoll(true, max, (&rolls).into())
    }

    pub fn get_env_data() -> (u64, u64) {
        let block_timestamp = env::block_timestamp();
        let epoch_height = env::epoch_height();

        let storage_usage = env::storage_usage();

        log!(format!("get_env_data / block_timestamp: {block_timestamp:#?} / epoch_height: {epoch_height:#?} // storage_usage: {storage_usage:#?}"));

        (block_timestamp, epoch_height)
    }
}
