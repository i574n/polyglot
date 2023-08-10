use near_sdk::borsh::{self, BorshDeserialize, BorshSerialize};
use near_sdk::store::vec::Vector;
use near_sdk::{env, log, near_bindgen, PanicOnDefault};

#[near_bindgen]
#[derive(PanicOnDefault, BorshDeserialize, BorshSerialize)]
pub struct State {
    version: u32,
    seeds: Vector<u8>,
}

const MAX_SEEDS: usize = 500;

#[near_bindgen]
impl State {
    #[init]
    pub fn new() -> Self {
        Self {
            version: 1,
            seeds: Vector::new(b"seeds".to_vec()),
        }
    }

    pub fn contribute_seed(&mut self, seed: Vec<u8>) {
        self.seeds.extend(seed);

        let seed_excess_len = (self.seeds.len() as i32) - MAX_SEEDS as i32;
        if seed_excess_len > 0 {
            let seed_excess: Vec<_> = self.seeds.drain(0..seed_excess_len as u32).collect();
            log!(format!("contribute_seed / seed_excess: {seed_excess:#?}"));
        }
    }

    pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) {
        self.contribute_seed(seed)
    }

    fn get_logger() -> fable_library_rust::Native_::Func1<fable_library_rust::String_::string, ()> {
        fable_library_rust::Native_::Func1::from(|s| {
            log!(s.to_string());
        })
    }

    pub fn generate_random_number(&mut self, max: u64) -> u64 {
        let seed = env::random_seed();
        let seed_log = seed.clone();
        self.contribute_seed(seed);

        let block_timestamp = env::block_timestamp();
        let signer_account_id = env::signer_account_id();
        let account_balance = env::account_balance();
        let block_height = env::block_height();
        let epoch_height = env::epoch_height();

        let mut entropy: Vec<u8> = Vec::new();
        entropy.extend(&self.seeds);
        entropy.extend(block_timestamp.to_le_bytes());
        entropy.extend(signer_account_id.as_bytes());
        entropy.extend(account_balance.to_le_bytes());
        entropy.extend(block_height.to_le_bytes());
        entropy.extend(epoch_height.to_le_bytes());

        let hash_u8 = env::keccak512(&entropy);
        let hash_vec = hash_u8.iter().map(|x| *x as i32).collect::<Vec<i32>>();
        let hash_seq = fable_library_rust::Seq_::ofList((&hash_vec).into());
        let rolls = dice::Polyglot::Dice::rotateNumbers(6, hash_seq);
        let rolls_list = fable_library_rust::List_::ofSeq(rolls);

        let rolls_list_log: Vec<i32> = rolls_list.clone().into();

        log!(format!("generate_random_number / max: {max:#?} / seed: {seed_log:?} / block_timestamp: {block_timestamp:#?} / signer_account_id: {signer_account_id:#?} / account_balance: {account_balance:#?} / block_height: {block_height:#?} / epoch_height: {epoch_height:#?} / entropy: {entropy:?} / hash_vec: {hash_vec:?} / rolls_list: {rolls_list_log:?}"));

        let sequential_roll = dice::Polyglot::Dice::createSequentialRoller(rolls_list);
        let result = dice::Polyglot::Dice::rollProgressively(
            Some(Self::get_logger()),
            sequential_roll,
            false,
            max as i32,
        );

        result as u64
    }

    pub fn roll_within_bounds(&self, max: i32, rolls: Vec<i32>) -> Option<i32> {
        log!(format!(
            "roll_within_bounds / max: {max:#?} / rolls: {rolls:?}"
        ));
        dice::Polyglot::Dice::rollWithinBounds(Some(Self::get_logger()), max, (&rolls).into())
    }

    #[result_serializer(borsh)]
    pub fn roll_within_bounds_borsh(
        &self,
        #[serializer(borsh)] max: i32,
        #[serializer(borsh)] rolls: Vec<i32>,
    ) -> Option<i32> {
        self.roll_within_bounds(max, rolls)
    }
}
