use near_sdk::borsh::{self, BorshDeserialize, BorshSerialize};
use near_sdk::store::vec::Vector;
use near_sdk::{env, log, near_bindgen, PanicOnDefault};

#[near_bindgen]
#[derive(PanicOnDefault, BorshDeserialize, BorshSerialize)]
pub struct State {
    version: u32,
    seeds: Vector<u8>,
}

const MAX_SEEDS: usize = 100;

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
            log!(format!("contribute_seed / seed_excess: {seed_excess:?}"));
        }
    }

    pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) {
        self.contribute_seed(seed)
    }

    fn get_logger() -> fable_library_rust::Native_::Func1<fable_library_rust::String_::string, ()> {
        let count = std::rc::Rc::new(std::cell::RefCell::new(0));
        let acc = std::rc::Rc::new(std::cell::RefCell::new(String::new()));

        let closure = {
            let count = std::rc::Rc::clone(&count);
            let acc = std::rc::Rc::clone(&acc);

            move |s: fable_library_rust::String_::string| {
                let mut count_ref = count.borrow_mut();
                let mut acc_ref = acc.borrow_mut();

                *count_ref += 1;
                if s.len() == 0 || *count_ref % 5 == 0 {
                    log!(acc_ref.clone());
                    *acc_ref = String::new();
                }
                acc_ref.push_str(&(s.to_string() + "\n"));
            }
        };

        fable_library_rust::Native_::Func1::new(closure)
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

        let hash_stream = hash_u8.iter().fold(dice::Dice::UH0::UH0_1, |acc, x| {
            dice::Dice::UH0::UH0_0(
                *x,
                fable_library_rust::Native_::Func0::new(move || acc.clone().into()),
            )
        });

        let rolls = dice::Dice::closure0((), 6)(hash_stream.into());

        fn stream_u8_to_u64(
            s: fable_library_rust::Native_::LrcPtr<dice::Dice::UH0>,
        ) -> dice::Dice::UH1 {
            match s.as_ref() {
                dice::Dice::UH0::UH0_0(n, f) => {
                    dice::Dice::UH1::UH1_0(*n, stream_u8_to_u64(f()).into())
                }
                dice::Dice::UH0::UH0_1 => dice::Dice::UH1::UH1_1,
            }
        }

        fn stream_u64_to_vec(
            s: dice::Dice::UH1,
        ) -> Vec<u8> {
            match s {
                dice::Dice::UH1::UH1_0(n, f) => {
                    let mut v = stream_u64_to_vec(f.as_ref().clone());
                    v.push(n);
                    v
                }
                dice::Dice::UH1::UH1_1 => Vec::new(),
            }
        }

        let rolls_stream: dice::Dice::UH1 = stream_u8_to_u64(rolls);

        let signer_account_id_log = signer_account_id.as_str();
        let rolls_stream_log = stream_u64_to_vec(rolls_stream.clone());

        log!(format!("generate_random_number / max: {max:#?} / seed: {seed_log:?} / block_timestamp: {block_timestamp:#?} / signer_account_id: {signer_account_id_log:?} / account_balance: {account_balance:#?} / block_height: {block_height:#?} / epoch_height: {epoch_height:#?} / entropy: {entropy:?} / hash_u8: {hash_u8:?} / rolls_stream: {rolls_stream_log:?}"));

        let sequential_roll = dice::Dice::closure3((), rolls_stream.into());
        let logger = Self::get_logger();
        let result = dice::Dice::closure8((), Some(logger.clone()))(sequential_roll)(false)(max);
        logger("".into());
        result as u64
    }

    pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
        log!(format!(
            "roll_within_bounds / max: {max:#?} / rolls: {rolls:?}"
        ));
        let rolls = rolls
            .into_iter()
            .rev()
            .fold(dice::Dice::UH1::UH1_1, |acc, x| {
                dice::Dice::UH1::UH1_0(x, acc.into())
            });
        let logger = Self::get_logger();
        let result = dice::Dice::closure77((), Some(logger.clone()))(max)(rolls.into());
        logger("".into());
        result
    }

    #[result_serializer(borsh)]
    pub fn roll_within_bounds_borsh(
        &self,
        #[serializer(borsh)] max: u64,
        #[serializer(borsh)] rolls: Vec<u8>,
    ) -> Option<u64> {
        self.roll_within_bounds(max, rolls)
    }
}
