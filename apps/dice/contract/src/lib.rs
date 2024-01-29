use near_sdk::borsh::{self, BorshDeserialize, BorshSerialize};
use near_sdk::store::vec::Vector;
use near_sdk::{env, log, near_bindgen, PanicOnDefault};

pub struct Util {}

impl Util {
    fn stream_u8_to_list(
        s: fable_library_rust::Native_::LrcPtr<dice::Dice::UH0>,
    ) -> dice::Dice::UH1 {
        match s.as_ref() {
            dice::Dice::UH0::UH0_0(n, f) => {
                dice::Dice::UH1::UH1_0(*n, Self::stream_u8_to_list(f()).into())
            }
            dice::Dice::UH0::UH0_1 => dice::Dice::UH1::UH1_1,
        }
    }

    fn list_u8_to_vec(s: fable_library_rust::Native_::LrcPtr<dice::Dice::UH1>) -> Vec<u8> {
        match s.as_ref() {
            dice::Dice::UH1::UH1_0(n, f) => {
                let mut v = Self::list_u8_to_vec(f.clone());
                v.insert(0, *n);
                v
            }
            dice::Dice::UH1::UH1_1 => vec![],
        }
    }

    fn vec_u8_to_list(v: Vec<u8>) -> dice::Dice::UH1 {
        v.iter().rev().fold(dice::Dice::UH1::UH1_1, |acc, x| {
            dice::Dice::UH1::UH1_0(*x, acc.into())
        })
    }

    fn vec_u8_to_stream(v: Vec<u8>) -> dice::Dice::UH0 {
        v.iter().rev().fold(dice::Dice::UH0::UH0_1, |acc, x| {
            dice::Dice::UH0::UH0_0(
                *x,
                fable_library_rust::Native_::Func0::new(move || acc.clone().into()),
            )
        })
    }
}

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
                if s.len() == 0 || *count_ref % 6 == 0 {
                    log!(acc_ref.clone().drain(..acc_ref.len() - 1));
                    *acc_ref = String::new();
                }
                acc_ref.push_str(&(s.to_string() + "\n"));
            }
        };

        fable_library_rust::Native_::Func1::new(closure)
    }

    pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
        let seed = env::random_seed();
        let block_timestamp = env::block_timestamp();
        let signer_account_id = env::signer_account_id();
        let account_balance = env::account_balance();
        let block_height = env::block_height();
        let epoch_height = env::epoch_height();

        let entropy: Vec<u8> = vec![
            seed.clone(),
            block_timestamp.to_le_bytes().to_vec(),
            block_height.to_le_bytes().to_vec(),
            epoch_height.to_le_bytes().to_vec(),
            account_balance.as_yoctonear().to_le_bytes().to_vec(),
            signer_account_id.as_bytes().to_vec(),
            self.seeds.iter().map(|x| *x).collect::<Vec<u8>>(),
            key.clone().into_bytes(),
            proof.clone().into_bytes(),
        ]
        .concat();

        let hash_u8 = env::keccak512(&entropy);
        self.contribute_seed(hash_u8.clone());

        let hash_stream = Util::vec_u8_to_stream(hash_u8.clone());
        let rolls_list = Util::stream_u8_to_list(dice::Dice::rotate_numbers(6)(hash_stream.into()));

        {
            let rolls_list_log = Util::list_u8_to_vec(rolls_list.clone().into());
            let signer_account_id_log = signer_account_id.as_str();
            log!(format!("generate_random_number / max: {max:#?} / key: {key:?} / proof: {proof:?} / block_timestamp: {block_timestamp:#?} / block_height: {block_height:#?} / epoch_height: {epoch_height:#?} / account_balance: {account_balance:#?} / signer_account_id: {signer_account_id_log:?}\n / seed: {seed:?}\n / entropy: {entropy:?}\n / hash_u8: {hash_u8:?}\n / rolls_list: {rolls_list_log:?}"));
        }

        let logger = Self::get_logger();
        let sequential_roll =
            dice::Dice::create_sequential_roller(Some(logger.clone()))(rolls_list.into());
        let result =
            dice::Dice::roll_progressively(Some(logger.clone()))(sequential_roll)(true)(max);
        logger("".into());
        result as u64
    }

    pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
        log!(format!(
            "roll_within_bounds / max: {max:#?} / rolls: {rolls:?}"
        ));
        let rolls = Util::vec_u8_to_list(rolls);
        let logger = Self::get_logger();
        let result = dice::Dice::roll_within_bounds(Some(logger.clone()))(max)(rolls.into());
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
