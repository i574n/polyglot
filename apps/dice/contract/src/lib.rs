use near_sdk::borsh::{self, BorshDeserialize, BorshSerialize};
use near_sdk::store::vec::Vector;
use near_sdk::{env, log, near_bindgen, PanicOnDefault};

#[near_bindgen]
#[derive(PanicOnDefault, BorshDeserialize, BorshSerialize)]
pub struct State {
    version: u32,
    seeds: Vector<u8>,
}

const MAX_SEEDS: usize = 50;

#[near_bindgen]
impl State {
    #[init]
    pub fn new() -> Self {
        Self {
            version: 1,
            seeds: Vector::new(b"seeds".to_vec()),
        }
    }

    #[payable]
    pub fn contribute_seed(&mut self, seed: Vec<u8>) {
        if self.seeds.len() >= MAX_SEEDS as u32 {
            let first_item: Vec<_> = self.seeds.drain(0..1).collect();
            log!(format!("contribute_seed / first_item: {first_item:#?}"));
        }

        self.seeds.extend(seed);
    }

    fn get_logger() -> fable_library_rust::Native_::Func1<fable_library_rust::String_::string, ()> {
        fable_library_rust::Native_::Func1::from(|s| {
            log!(s.to_string());
        })
    }

    pub fn generate_random_number(&mut self, max: u64) -> u64 {
        let seed = env::random_seed();
        self.contribute_seed(seed);

        let mut entropy: Vec<u8> = Vec::new();
        for i in 0..self.seeds.len() {
            let previous_seed = self.seeds.get(i).unwrap();
            entropy.push(*previous_seed);
        }

        let block_timestamp = env::block_timestamp();
        let signer_account_id = env::signer_account_id();
        let block_height = env::block_height();
        let epoch_height = env::epoch_height();
        let account_balance = env::account_balance();
        let attached_deposit = env::attached_deposit();

        log!(format!("generate_random_number / max: {max:#?} / block_timestamp: {block_timestamp:#?} / signer_account_id: {signer_account_id:#?} / block_height: {block_height:#?} / epoch_height: {epoch_height:#?} / account_balance: {account_balance:#?} / attached_deposit: {attached_deposit:#?}"));

        entropy.extend(block_timestamp.to_le_bytes());
        entropy.extend(signer_account_id.as_bytes());
        entropy.extend(block_height.to_le_bytes());
        entropy.extend(epoch_height.to_le_bytes());
        entropy.extend(account_balance.to_le_bytes());
        entropy.extend(attached_deposit.to_le_bytes());

        let hash = env::keccak512(&entropy);
        let hash_i32_1 = hash.iter().map(|x| *x as i32).collect::<Vec<i32>>();
        let hash_i32_1_seq = fable_library_rust::Seq_::ofList((&hash_i32_1).into());
        let hash_i32_2 = dice::Polyglot::Dice::rotateNumbers(6, hash_i32_1_seq);
        let hash_i32_2_list = fable_library_rust::List_::ofSeq(hash_i32_2);

        let hash_i32_2_list_log : Vec<i32> = (hash_i32_2_list.clone()).into();
        log!(format!("generate_random_number / entropy: {entropy:?} / hash: {hash:?} / hash_i32_2_list_log: {hash_i32_2_list_log:?}"));

        let sequential_roll = dice::Polyglot::Dice::createSequentialRoller(hash_i32_2_list);
        let number = dice::Polyglot::Dice::rollProgressively(Some(Self::get_logger()), sequential_roll, false, max as i32);

        number as u64
    }

    #[payable]
    pub fn fixed_roll(&mut self, max: i32, rolls: Vec<i32>) -> Option<i32> {
        let account_id = env::signer_account_id();
        let timestamp = env::block_timestamp();

        log!(format!("fixed_roll / max: {max:#?} / rolls: {rolls:#?} / account_id: {account_id:#?} / timestamp: {timestamp:#?}"));

        dice::Polyglot::Dice::rollWithinBounds(Some(Self::get_logger()), max, (&rolls).into())
    }

    pub fn get_env_data() -> (u64, u64) {
        let block_timestamp = env::block_timestamp();
        let epoch_height = env::epoch_height();

        let storage_usage = env::storage_usage();

        log!(format!("get_env_data / block_timestamp: {block_timestamp:#?} / epoch_height: {epoch_height:#?} // storage_usage: {storage_usage:#?}"));

        (block_timestamp, epoch_height)
    }
}
