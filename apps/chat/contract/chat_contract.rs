#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)]
use std::cell::RefCell;
use std::rc::Rc;
#[near_sdk::near_bindgen]
#[derive(near_sdk::PanicOnDefault, borsh::BorshDeserialize, borsh::BorshSerialize)]
pub struct State((u32, near_sdk::store::IterableSet<String>, near_sdk::store::IterableSet<String>, near_sdk::store::LookupMap<String, String>, near_sdk::store::LookupMap<String, std::collections::HashMap<String, (u64, u32)>>));
#[near_sdk::near_bindgen]
impl State {
    #[init]
    pub fn new() -> Self {
        Self(chat_contract_new())
    }
    pub fn is_valid_alias(&self, alias: String) -> bool {
        chat_contract_is_valid_alias(alias)
    }
    pub fn generate_cid(&self, content: Vec<u8>) -> String {
        chat_contract_generate_cid(content)
    }
    #[result_serializer(borsh)]
    pub fn generate_cid_borsh(&self, #[serializer(borsh)] content: Vec<u8>) -> String {
        self.generate_cid(content)
    }
    pub fn claim_alias(&mut self, alias: String) {
        let state = &mut self.0;
        chat_contract_claim_alias(&mut state.1, &mut state.2, &mut state.3, &mut state.4, alias)
    }
    pub fn get_account_info(&self, account_id: near_sdk::AccountId) -> Option<(String, u64, u32)> {
        chat_contract_get_account_info(&self.0.3, &self.0.4, account_id.to_string())
    }
    pub fn get_alias_map(&self, alias: String) -> Option<std::collections::HashMap<String, (u64, u32)>> {
        chat_contract_get_alias_map(&self.0.4, alias)
    }
    #[result_serializer(borsh)]
    pub fn get_alias_map_borsh(&self, #[serializer(borsh)] alias: String) -> Option<std::collections::HashMap<String, (u64, u32)>> {
        self.get_alias_map(alias)
    }
}
fn spiral_trace_hold<T: Clone>(fresh: &std::rc::Rc<dyn Fn() -> T>) -> T {
    use std::sync::OnceLock;
    static SLOT: OnceLock<usize> = OnceLock::new();
    let raw = *SLOT.get_or_init(|| Box::into_raw(Box::new((*fresh)())) as usize);
    unsafe { (*(raw as *const T)).clone() }
}
#[cfg(target_arch = "wasm32")]
fn spiral_trace_near_log(text: &str) {
    use std::sync::atomic::{AtomicUsize, Ordering};
    static LOGGED: AtomicUsize = AtomicUsize::new(0);
    let cs: Vec<char> = text.chars().collect();
    for c in cs.chunks(15000) {
        let s: String = c.iter().collect();
        let used = LOGGED.load(Ordering::Relaxed);
        let budget = 16000usize.saturating_sub(used);
        if budget < 13 {
            break;
        }
        let s = if s.len() <= budget {
            s
        } else {
            let mut end = budget - 12;
            while !s.is_char_boundary(end) {
                end -= 1;
            }
            format!("{} [truncated]", &s[..end])
        };
        LOGGED.store(used + s.len(), Ordering::Relaxed);
        near_sdk::env::log_str(&s);
    }
}
fn string_slice(value: &str, from: i64, to: i64) -> Rc<str> {
    let bytes = value.as_bytes();
    let length = bytes.len() as i64;
    if from < 0 || from > length || to < from - 1 || to >= length { std::process::abort(); }
    if to < from { return { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) }; }
    // A slice that starts or ends inside a code point fails like the C and Delphi backends (abort / Halt(3)).
    if (bytes[from as usize] & 0xC0) == 0x80 || (to + 1 < length && (bytes[(to + 1) as usize] & 0xC0) == 0x80) { std::process::exit(3); }
    let slice = &bytes[from as usize..(to + 1) as usize];
    match std::str::from_utf8(slice) { Ok(text) => Rc::<str>::from(text), Err(error) => Rc::<str>::from(std::str::from_utf8(&slice[..error.valid_up_to()]).unwrap_or("")) }
}
struct Mut0 { l0: i64 }
struct Mut1 { l0: Rc<dyn Fn(Rc<str>) -> ()> }
struct Mut2 { l0: bool }
struct Mut3 { l0: Rc<str> }
#[derive(Clone)]
enum US0 {
    US0_0,
    US0_1,
    US0_2,
    US0_3,
    US0_4,
}
impl US0 {
    fn tag(&self) -> i32 {
        match self {
            US0::US0_0 => 0,
            US0::US0_1 => 1,
            US0::US0_2 => 2,
            US0::US0_3 => 3,
            US0::US0_4 => 4,
        }
    }
}
struct Mut4 { l0: US0 }
#[derive(Clone)]
enum US1 {
    US1_0(US0),
    US1_1,
}
impl US1 {
    fn tag(&self) -> i32 {
        match self {
            US1::US1_0(..) => 0,
            US1::US1_1 => 1,
        }
    }
}
struct Mut5 { l0: i32, l1: US1 }
#[derive(Clone)]
enum US2 {
    US2_0(Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>),
    US2_1,
}
impl US2 {
    fn tag(&self) -> i32 {
        match self {
            US2::US2_0(..) => 0,
            US2::US2_1 => 1,
        }
    }
}
#[derive(Clone)]
enum US3 {
    US3_0(std::string::String),
    US3_1,
}
impl US3 {
    fn tag(&self) -> i32 {
        match self {
            US3::US3_0(..) => 0,
            US3::US3_1 => 1,
        }
    }
}
fn method1(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = Rc::<str>::from(std::env::var(&*v0).unwrap_or_default());
    v1.clone()
}
fn method2(mut v0: i32, mut v1: Rc<RefCell<Mut5>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn closure2() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method0(mut v0: US0) -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("TRACE_LEVEL"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = method1(v1.clone());
    ;
    ;
    ;
    ;
    ;
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Critical"); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<str> = Rc::<str>::from(v3.to_lowercase());
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
    let mut v6: Rc<str> = Rc::<str>::from(v5.to_lowercase());
    let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Info"); } LIT.with(|lit| lit.clone()) };
    let mut v8: Rc<str> = Rc::<str>::from(v7.to_lowercase());
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(v11.to_lowercase());
    let mut v13: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new(Vec::new()));
    let mut v14: US0 = US0::US0_0;
    v13.borrow_mut().push((v11.clone(), v14.clone()));
    let mut v15: US0 = US0::US0_1;
    v13.borrow_mut().push((v9.clone(), v15.clone()));
    let mut v16: US0 = US0::US0_2;
    v13.borrow_mut().push((v7.clone(), v16.clone()));
    let mut v17: US0 = US0::US0_3;
    v13.borrow_mut().push((v5.clone(), v17.clone()));
    let mut v18: US0 = US0::US0_4;
    v13.borrow_mut().push((v3.clone(), v18.clone()));
    let mut v19: US0 = US0::US0_0;
    v13.borrow_mut().push((v12.clone(), v19.clone()));
    let mut v20: US0 = US0::US0_1;
    v13.borrow_mut().push((v10.clone(), v20.clone()));
    let mut v21: US0 = US0::US0_2;
    v13.borrow_mut().push((v8.clone(), v21.clone()));
    let mut v22: US0 = US0::US0_3;
    v13.borrow_mut().push((v6.clone(), v22.clone()));
    let mut v23: US0 = US0::US0_4;
    v13.borrow_mut().push((v4.clone(), v23.clone()));
    let mut v24: Rc<Vec<(Rc<str>, US0)>> = Rc::new(v13.borrow().clone());
    let mut v25: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new((v24).as_ref().clone()));
    let mut v26: i32 = (v25.clone().borrow().len() as i32);
    let mut v27: US1 = US1::US1_1;
    let mut v28: Rc<RefCell<Mut5>> = Rc::new(RefCell::new(Mut5 { l0: 0i32, l1: v27.clone() }));
    while method2(v26, v28.clone()) {
        let mut v30: i32 = v28.borrow().l0.clone();
        let mut v31: i32 = v30.wrapping_neg();
        let mut v32: i32 = v31.wrapping_add(v26);
        let mut v33: i32 = v32.wrapping_sub(1i32);
        let mut v34: US1 = v28.borrow().l1.clone();
        let (mut v35, mut v36): (Rc<str>, US0) = v25.clone().borrow()[v33 as usize].clone();
        let mut v43: US1 = match &v34 {
            US1::US1_1 => { // None
                let mut v38: bool = v35 == v2 ;
                if v38 {
                    US1::US1_0(v36.clone())
                } else {
                    US1::US1_1
                }
            }
            US1::US1_0(v37) => { // Some
                let mut v37: US0 = v37.clone();
                v34.clone()
            }
        };
        let mut v44: i32 = v30.wrapping_add(1i32);
        v28.borrow_mut().l0 = v44;
        v28.borrow_mut().l1 = v43.clone();
        ()
    };
    let mut v45: US1 = v28.borrow().l1.clone();
    let mut v46: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
    let mut v47: Rc<dyn Fn(Rc<str>) -> ()> = closure2();
    let mut v48: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: v47.clone() }));
    let mut v49: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: true }));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v50.clone() }));
    let mut v54: US0 = match &v45 {
        US1::US1_1 => { // None
            v0.clone()
        }
        US1::US1_0(v52) => { // Some
            let mut v52: US0 = v52.clone();
            v52.clone()
        }
    };
    let mut v55: Rc<RefCell<Mut4>> = Rc::new(RefCell::new(Mut4 { l0: v54.clone() }));
    let mut v56: Option<i64> = None;
    (v46.clone(), v48.clone(), v49.clone(), v51.clone(), v55.clone(), v56.clone())
}
fn closure1() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_0;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = method0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure3() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_0;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = method0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure0() -> Rc<dyn Fn() -> (u32, near_sdk::store::IterableSet<String>, near_sdk::store::IterableSet<std::string::String>, near_sdk::store::LookupMap<String, std::string::String>, near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (u32, near_sdk::store::IterableSet<String>, near_sdk::store::IterableSet<std::string::String>, near_sdk::store::LookupMap<String, std::string::String>, near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>)> = Rc::new(move || -> (u32, near_sdk::store::IterableSet<String>, near_sdk::store::IterableSet<std::string::String>, near_sdk::store::LookupMap<String, std::string::String>, near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>) {
        let mut v54: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v54); };
        let mut v143: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v144, mut v145, mut v146, mut v147, mut v148, mut v149): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v143) };
        let mut v211: US0 = US0::US0_2;
        v148.borrow_mut().l0 = v211.clone();
        let mut v261: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("account_set"); } LIT.with(|lit| lit.clone()) };
        let mut v262: &[u8] = { let owned: Rc<str> = (v261).clone(); Box::leak(owned.as_bytes().to_vec().into_boxed_slice()) };
        let mut v290: near_sdk::store::IterableSet<String> = near_sdk::store::IterableSet::new(v262);
        let mut v300: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("alias_set"); } LIT.with(|lit| lit.clone()) };
        let mut v301: &[u8] = { let owned: Rc<str> = (v300).clone(); Box::leak(owned.as_bytes().to_vec().into_boxed_slice()) };
        let mut v307: near_sdk::store::IterableSet<std::string::String> = near_sdk::store::IterableSet::new(v301);
        let mut v317: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("account_map"); } LIT.with(|lit| lit.clone()) };
        let mut v318: &[u8] = { let owned: Rc<str> = (v317).clone(); Box::leak(owned.as_bytes().to_vec().into_boxed_slice()) };
        let mut v324: near_sdk::store::LookupMap<String, std::string::String> = near_sdk::store::LookupMap::new(v318);
        let mut v334: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("alias_map"); } LIT.with(|lit| lit.clone()) };
        let mut v335: &[u8] = { let owned: Rc<str> = (v334).clone(); Box::leak(owned.as_bytes().to_vec().into_boxed_slice()) };
        let mut v341: near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>> = near_sdk::store::LookupMap::new(v335);
        (2u32, v290, v307, v324, v341)
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure4() -> Rc<dyn Fn(std::string::String) -> bool> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> bool> = Rc::new(move |mut v0: std::string::String| -> bool {
        let mut v2: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v2); };
        let mut v4: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v5, mut v6, mut v7, mut v8, mut v9, mut v10): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v4) };
        let mut v11: US0 = US0::US0_2;
        v9.borrow_mut().l0 = v11.clone();
        let mut v12: bool = { let alias: &str = &(v0); alias.len() > 0 && alias.len() < 64 && !alias.starts_with('-') && !alias.ends_with('-') && alias.chars().all(|c| c.is_alphanumeric() || c == '-') };
        v12
    }); } CLOSURE.with(|closure| closure.clone())
}
fn closure5() -> Rc<dyn Fn(Vec<u8>) -> std::string::String> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Vec<u8>) -> std::string::String> = Rc::new(move |mut v0: Vec<u8>| -> std::string::String {
        let mut v2: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v2); };
        let mut v4: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v5, mut v6, mut v7, mut v8, mut v9, mut v10): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v4) };
        let mut v11: US0 = US0::US0_2;
        v9.borrow_mut().l0 = v11.clone();
        let mut v12: std::string::String = { let mut varint = unsigned_varint::encode::u64_buffer(); let codec_bytes = unsigned_varint::encode::u64(0x55, &mut varint).to_vec(); let mut hasher: sha2::Sha256 = sha2::Digest::new(); sha2::Digest::update(&mut hasher, &(v0)); let multihash: Vec<u8> = [0x12u8, 32].into_iter().chain(sha2::Digest::finalize(hasher).into_iter()).collect(); let cid_bytes = [vec![1u8], codec_bytes, multihash].concat(); multibase::encode(multibase::Base::Base32Lower, &cid_bytes) };
        v12.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method3(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let mut v1070: u64 = { #[cfg(target_arch = "wasm32")] let (h, m, s) = { let secs = near_sdk::env::block_timestamp() / 1_000_000_000; ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; #[cfg(all(windows, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C)] struct St([u16; 8]); unsafe extern "system" { fn GetLocalTime(t: *mut St); } let mut t = St([0; 8]); unsafe { GetLocalTime(&mut t) }; (t.0[4] as u64, t.0[5] as u64, t.0[6] as u64) }; #[cfg(all(unix, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C, align(8))] struct Tm([i32; 16]); unsafe extern "C" { fn localtime_r(t: *const std::os::raw::c_long, tm: *mut Tm) -> *mut Tm; } let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0) as std::os::raw::c_long; let mut tm = Tm([0; 16]); unsafe { localtime_r(&secs, &mut tm) }; (tm.0[2] as u64, tm.0[1] as u64, tm.0[0] as u64) }; #[cfg(not(any(windows, unix, target_arch = "wasm32")))] let (h, m, s) = { let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0); ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; h * 3600 + m * 60 + s };
    let mut v1071: u64 = v1070.wrapping_div(3600u64);
    let mut v1072: bool = v1071 < 10u64;
    let mut v1075: Rc<str> = if v1072 {
        let mut v1073: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v1073.clone()
    } else {
        let mut v1074: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v1074.clone()
    };
    let mut v1093: Rc<str> = Rc::<str>::from(format!("{:?}", v1071));
    let mut v1098: Rc<str> = Rc::<str>::from(format!("{}{}", v1075, v1093));
    let mut v1109: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) };
    let mut v1110: Rc<str> = Rc::<str>::from(format!("{}{}", v1098, v1109));
    let mut v1115: u64 = v1070.wrapping_div(60u64);
    let mut v1116: u64 = v1115.wrapping_rem(60u64);
    let mut v1117: bool = v1116 < 10u64;
    let mut v1120: Rc<str> = if v1117 {
        let mut v1118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v1118.clone()
    } else {
        let mut v1119: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v1119.clone()
    };
    let mut v1121: Rc<str> = Rc::<str>::from(format!("{:?}", v1116));
    let mut v1122: Rc<str> = Rc::<str>::from(format!("{}{}", v1120, v1121));
    let mut v1123: Rc<str> = Rc::<str>::from(format!("{}{}", v1110, v1122));
    let mut v1124: Rc<str> = Rc::<str>::from(format!("{}{}", v1123, v1109));
    let mut v1125: u64 = v1070.wrapping_rem(60u64);
    let mut v1126: bool = v1125 < 10u64;
    let mut v1129: Rc<str> = if v1126 {
        let mut v1127: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v1127.clone()
    } else {
        let mut v1128: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v1128.clone()
    };
    let mut v1130: Rc<str> = Rc::<str>::from(format!("{:?}", v1125));
    let mut v1131: Rc<str> = Rc::<str>::from(format!("{}{}", v1129, v1130));
    let mut v1132: Rc<str> = Rc::<str>::from(format!("{}{}", v1124, v1131));
    v1132.clone()
}
fn method6(mut v0: Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v1));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method5(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method6(v2.clone(), v20.clone());
    let mut v25: Rc<str> = v2.borrow().l0.clone();
    v25.clone()
}
fn method4() -> Rc<str> {
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[94m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
    let mut v11: u8 = v10.clone().as_bytes()[0i32 as usize];
    let mut v12: Rc<str> = method5(v11);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v12));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v19));
    v23.clone()
}
fn method9(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v2 >= v1;
        if v3 {
            return v1;
        } else {
            let mut v4: u8 = v0.clone().as_bytes()[v2 as usize];
            let mut v5: bool = v4 == b' ';
            let mut v11: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'\t';
                if v6 {
                    true
                } else {
                    let mut v7: bool = v4 == b'\r';
                    if v7 {
                        true
                    } else {
                        let mut v8: bool = v4 == b'\n';
                        v8
                    }
                }
            };
            if v11 {
                let mut v12: i32 = v2.wrapping_add(1i32);
                (v0, v1, v2) = (v0.clone(), v1, v12);
                continue;
            } else {
                return v2;
            }
        }
    }
}
fn method10(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: bool = v1 <= 0i32;
        if v2 {
            return -1i32;
        } else {
            let mut v3: i32 = v1.wrapping_sub(1i32);
            let mut v4: u8 = v0.clone().as_bytes()[v3 as usize];
            let mut v5: bool = v4 == b' ';
            let mut v7: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'/';
                v6
            };
            if v7 {
                (v0, v1) = (v0.clone(), v3);
                continue;
            } else {
                return v3;
            }
        }
    }
}
fn method8(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: i32 = 0i32;
    let mut v3: i32 = method9(v0.clone(), v1, v2);
    let mut v4: i32 = v1.wrapping_sub(1i32);
    let mut v12: Rc<str> = string_slice(&v0.clone(), v3 as i64, v4 as i64);
    let mut v16: i32 = (v12.clone().len() as i32);
    let mut v17: i32 = method10(v12.clone(), v16);
    let mut v25: Rc<str> = string_slice(&v12.clone(), 0i32 as i64, v17 as i64);
    v25.clone()
}
fn method11(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v20.clone());
    let mut v25: Rc<str> = v2.borrow().l0.clone();
    v25.clone()
}
fn method13(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method14(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("alias"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method15(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method16(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method17(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("block_timestamp"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method18(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("signer_account_id"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method19(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("predecessor_account_id"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method20(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method12(mut v0: std::string::String, mut v1: u64, mut v2: std::string::String, mut v3: std::string::String) -> Rc<str> {
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v4.clone() }));
    method13(v5.clone());
    method14(v5.clone());
    method15(v5.clone());
    let mut v109: std::string::String = format!("{:#?}", v0);
    let mut v111: Rc<str> = Rc::<str>::from(v109);
    method6(v5.clone(), v111.clone());
    method16(v5.clone());
    method17(v5.clone());
    method15(v5.clone());
    let mut v172: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v5.clone(), v172.clone());
    method16(v5.clone());
    method18(v5.clone());
    method15(v5.clone());
    let mut v203: std::string::String = format!("{:#?}", v2);
    let mut v205: Rc<str> = Rc::<str>::from(v203);
    method6(v5.clone(), v205.clone());
    method16(v5.clone());
    method19(v5.clone());
    method15(v5.clone());
    let mut v232: std::string::String = format!("{:#?}", v3);
    let mut v234: Rc<str> = Rc::<str>::from(v232);
    method6(v5.clone(), v234.clone());
    method20(v5.clone());
    let mut v260: Rc<str> = v5.borrow().l0.clone();
    v260.clone()
}
fn method7(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: std::string::String, mut v9: u64, mut v10: std::string::String, mut v11: std::string::String) -> Rc<str> {
    let mut v12: i64 = v0.borrow().l0.clone();
    let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v15));
    let mut v17: Rc<str> = method11(v12);
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v7));
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v15));
    let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chat_contract.claim_alias"); } LIT.with(|lit| lit.clone()) };
    let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v31));
    let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v47));
    let mut v53: Rc<str> = method12(v8.clone(), v9, v10.clone(), v11.clone());
    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v48, v53));
    method8(v54.clone())
}
fn closure7() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        println!("{}", v0);
        ()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method21(mut v0: Option<std::string::String>) -> Option<std::string::String> {
    v0.clone()
}
fn closure8() -> Rc<dyn Fn((std::string::String)) -> US3> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((std::string::String)) -> US3> = Rc::new(move |mut v0: (std::string::String)| -> US3 {
        let mut v1: std::string::String = (v0);
        US3::US3_0(v1.clone())
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method22() -> Rc<str> {
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[93m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
    let mut v11: u8 = v10.clone().as_bytes()[0i32 as usize];
    let mut v12: Rc<str> = method5(v11);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v12));
    let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    v15.clone()
}
fn method25(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("account_alias"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method24(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    method13(v2.clone());
    method25(v2.clone());
    method15(v2.clone());
    method6(v2.clone(), v0.clone());
    method20(v2.clone());
    let mut v28: Rc<str> = v2.borrow().l0.clone();
    v28.clone()
}
fn method23(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = method11(v9);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v10));
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chat_contract.claim_alias / alias already claimed"); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v26));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v32));
    let mut v34: Rc<str> = method24(v8.clone());
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v34));
    method8(v35.clone())
}
fn method26(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = method11(v9);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v10));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chat_contract.claim_alias"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = method24(v8.clone());
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    method8(v21.clone())
}
fn closure6() -> Rc<dyn Fn(&mut near_sdk::store::IterableSet<String>, &mut near_sdk::store::IterableSet<std::string::String>, &mut near_sdk::store::LookupMap<String, std::string::String>, &mut near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, std::string::String) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&mut near_sdk::store::IterableSet<String>, &mut near_sdk::store::IterableSet<std::string::String>, &mut near_sdk::store::LookupMap<String, std::string::String>, &mut near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, std::string::String) -> ()> = Rc::new(move |mut v0: &mut near_sdk::store::IterableSet<String>, mut v1: &mut near_sdk::store::IterableSet<std::string::String>, mut v2: &mut near_sdk::store::LookupMap<String, std::string::String>, mut v3: &mut near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, mut v4: std::string::String| -> () {
        let mut v6: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v6); };
        let mut v8: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v9, mut v10, mut v11, mut v12, mut v13, mut v14): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
        let mut v15: US0 = US0::US0_2;
        v13.borrow_mut().l0 = v15.clone();
        let mut v61: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::signer_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let mut v97: String = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::predecessor_account_id().to_string(); #[cfg(not(target_arch = "wasm32"))] let v = String::from("a"); v };
        let mut v147: u64 = { #[cfg(target_arch = "wasm32")] let v = near_sdk::env::block_timestamp(); #[cfg(not(target_arch = "wasm32"))] let v = 1u64; v };
        { let _ = spiral_trace_hold(&v6); };
        let (mut v176, mut v177, mut v178, mut v179, mut v180, mut v181): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
        let mut v182: US0 = v180.borrow().l0.clone();
        let mut v187: i32 = match &v182 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
        };
        let mut v188: bool = v178.borrow().l0.clone();
        let mut v189: bool = v188 == false;
        let mut v191: bool = if v189 {
            false
        } else {
            let mut v190: bool = 20i32 >= v187;
            v190
        };
        let mut v192: bool = v191 == false;
        let mut v269: US2 = if v192 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v6); };
            let (mut v196, mut v197, mut v198, mut v199, mut v200, mut v201): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
            let mut v202: Rc<str> = method3(v196.clone(), v197.clone(), v198.clone(), v199.clone(), v200.clone(), v201.clone());
            let mut v203: Rc<str> = method4();
            let mut v205: std::string::String = v61.to_string();
            let mut v207: std::string::String = v97.to_string();
            let mut v208: Rc<str> = method7(v196.clone(), v197.clone(), v198.clone(), v199.clone(), v200.clone(), v201.clone(), v202.clone(), v203.clone(), v4.clone(), v147, v205.clone(), v207.clone());
            { let _ = spiral_trace_hold(&v6); };
            let (mut v211, mut v212, mut v213, mut v214, mut v215, mut v216): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
            let mut v217: i64 = v211.borrow().l0.clone();
            let mut v218: i64 = v217.wrapping_add(1i64);
            v211.borrow_mut().l0 = v218;
            let mut v219: Rc<dyn Fn(Rc<str>) -> ()> = closure7();
            let mut v220: bool = cfg!(target_arch = "wasm32");
            if v220 {
                let mut v221: Rc<str> = v214.borrow().l0.clone();
                let mut v222: bool = v221.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v244: Rc<str> = if v222 {
                    v208.clone()
                } else {
                    let mut v223: bool = v208.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v223 {
                        let mut v224: Rc<str> = v214.borrow().l0.clone();
                        v224.clone()
                    } else {
                        let mut v225: Rc<str> = v214.borrow().l0.clone();
                        let mut v236: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v237: Rc<str> = Rc::<str>::from(format!("{}{}", v225, v236));
                        let mut v242: Rc<str> = Rc::<str>::from(format!("{}{}", v237, v208));
                        v242.clone()
                    }
                };
                let mut v246: i32 = ((v244.chars().count() + 14999) / 15000) as i32;
                let mut v257: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v258: bool = v208 != v257 ;
                let mut v264: bool = if v258 {
                    let mut v263: bool = v246 <= 1i32;
                    v263
                } else {
                    false
                };
                if v264 {
                    v214.borrow_mut().l0 = v244.clone();
                    ()
                } else {
                    v214.borrow_mut().l0 = v257.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v244); };
                    ()
                }
            } else {
                println!("{}", v208);
                ()
            };
            let mut v267: Rc<dyn Fn(Rc<str>) -> ()> = v212.borrow().l0.clone();
            v267(v208.clone());
            US2::US2_0(v211.clone(), v212.clone(), v213.clone(), v214.clone(), v215.clone(), v216.clone())
        };
        let mut v292: bool = { let alias: &str = &(v4.clone()); alias.len() > 0 && alias.len() < 64 && !alias.starts_with('-') && !alias.ends_with('-') && alias.chars().all(|c| c.is_alphanumeric() || c == '-') };
        let mut v293: bool = v292 == false;
        if v293 {
            let mut v294: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chat_contract.claim_alias / invalid alias"); } LIT.with(|lit| lit.clone()) };
            near_sdk::env::panic_str(&*v294);
            ()
        };
        let mut v295: Option<std::string::String> = (v2).get(&(v61.clone())).cloned();
        let mut v395: Option<std::string::String> = method21(v295.clone());
        let mut v396: Rc<dyn Fn((std::string::String)) -> US3> = closure8();
        let mut v397: Option<US3> = v395.map(|x| v396(x));
        let mut v428: US3 = US3::US3_1;
        let mut v429: US3 = v397.unwrap_or(v428);
        match &v429 {
            US3::US3_0(v447) => { // Some
                let mut v447: std::string::String = v447.clone();
                let mut v454: bool = v447 == v4 ;
                if v454 {
                    { let _ = spiral_trace_hold(&v6); };
                    let (mut v461, mut v462, mut v463, mut v464, mut v465, mut v466): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                    let mut v467: US0 = v465.borrow().l0.clone();
                    let mut v472: i32 = match &v467 {
                        US0::US0_4 => { // Critical
                            50i32
                        }
                        US0::US0_1 => { // Debug
                            20i32
                        }
                        US0::US0_2 => { // Info
                            30i32
                        }
                        US0::US0_0 => { // Verbose
                            10i32
                        }
                        US0::US0_3 => { // Warning
                            40i32
                        }
                    };
                    let mut v473: bool = v463.borrow().l0.clone();
                    let mut v474: bool = v473 == false;
                    let mut v476: bool = if v474 {
                        false
                    } else {
                        let mut v475: bool = 40i32 >= v472;
                        v475
                    };
                    let mut v477: bool = v476 == false;
                    let mut v523: US2 = if v477 {
                        US2::US2_1
                    } else {
                        { let _ = spiral_trace_hold(&v6); };
                        let (mut v481, mut v482, mut v483, mut v484, mut v485, mut v486): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                        let mut v487: Rc<str> = method3(v481.clone(), v482.clone(), v483.clone(), v484.clone(), v485.clone(), v486.clone());
                        let mut v488: Rc<str> = method22();
                        let mut v489: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v447)).s() });
                        let mut v490: Rc<str> = method23(v481.clone(), v482.clone(), v483.clone(), v484.clone(), v485.clone(), v486.clone(), v487.clone(), v488.clone(), v489.clone());
                        { let _ = spiral_trace_hold(&v6); };
                        let (mut v493, mut v494, mut v495, mut v496, mut v497, mut v498): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                        let mut v499: i64 = v493.borrow().l0.clone();
                        let mut v500: i64 = v499.wrapping_add(1i64);
                        v493.borrow_mut().l0 = v500;
                        let mut v501: Rc<dyn Fn(Rc<str>) -> ()> = closure7();
                        let mut v502: bool = cfg!(target_arch = "wasm32");
                        if v502 {
                            let mut v503: Rc<str> = v496.borrow().l0.clone();
                            let mut v504: bool = v503.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let mut v512: Rc<str> = if v504 {
                                v490.clone()
                            } else {
                                let mut v505: bool = v490.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                if v505 {
                                    let mut v506: Rc<str> = v496.borrow().l0.clone();
                                    v506.clone()
                                } else {
                                    let mut v507: Rc<str> = v496.borrow().l0.clone();
                                    let mut v508: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                    let mut v509: Rc<str> = Rc::<str>::from(format!("{}{}", v507, v508));
                                    let mut v510: Rc<str> = Rc::<str>::from(format!("{}{}", v509, v490));
                                    v510.clone()
                                }
                            };
                            let mut v514: i32 = ((v512.chars().count() + 14999) / 15000) as i32;
                            let mut v515: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let mut v516: bool = v490 != v515 ;
                            let mut v518: bool = if v516 {
                                let mut v517: bool = v514 <= 1i32;
                                v517
                            } else {
                                false
                            };
                            if v518 {
                                v496.borrow_mut().l0 = v512.clone();
                                ()
                            } else {
                                v496.borrow_mut().l0 = v515.clone();
                                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v512); };
                                ()
                            }
                        } else {
                            println!("{}", v490);
                            ()
                        };
                        let mut v521: Rc<dyn Fn(Rc<str>) -> ()> = v494.borrow().l0.clone();
                        v521(v490.clone());
                        US2::US2_0(v493.clone(), v494.clone(), v495.clone(), v496.clone(), v497.clone(), v498.clone())
                    };
                    ()
                } else {
                    { let _ = spiral_trace_hold(&v6); };
                    let (mut v526, mut v527, mut v528, mut v529, mut v530, mut v531): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                    let mut v532: US0 = v530.borrow().l0.clone();
                    let mut v537: i32 = match &v532 {
                        US0::US0_4 => { // Critical
                            50i32
                        }
                        US0::US0_1 => { // Debug
                            20i32
                        }
                        US0::US0_2 => { // Info
                            30i32
                        }
                        US0::US0_0 => { // Verbose
                            10i32
                        }
                        US0::US0_3 => { // Warning
                            40i32
                        }
                    };
                    let mut v538: bool = v528.borrow().l0.clone();
                    let mut v539: bool = v538 == false;
                    let mut v541: bool = if v539 {
                        false
                    } else {
                        let mut v540: bool = 20i32 >= v537;
                        v540
                    };
                    let mut v542: bool = v541 == false;
                    let mut v639: US2 = if v542 {
                        US2::US2_1
                    } else {
                        { let _ = spiral_trace_hold(&v6); };
                        let (mut v546, mut v547, mut v548, mut v549, mut v550, mut v551): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                        let mut v552: Rc<str> = method3(v546.clone(), v547.clone(), v548.clone(), v549.clone(), v550.clone(), v551.clone());
                        let mut v553: Rc<str> = method4();
                        let mut v560: Option<std::string::String> = Some(v447.clone());
                        let mut v571: Rc<RefCell<Vec<std::string::String>>> = Rc::new(RefCell::new(v560.clone().into_iter().collect::<Vec<_>>()));
                        let mut v572: u64 = (v571.clone().borrow().len() as u64);
                        let mut v573: bool = v572 == 0u64;
                        let mut v593: Rc<str> = if v573 {
                            let mut v574: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("None"); } LIT.with(|lit| lit.clone()) };
                            v574.clone()
                        } else {
                            let mut v575: std::string::String = v571.clone().borrow()[0u64 as usize].clone();
                            let mut v576: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v575)).s() });
                            let mut v587: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Some "); } LIT.with(|lit| lit.clone()) };
                            let mut v588: Rc<str> = Rc::<str>::from(format!("{}{}", v587, v576));
                            v588.clone()
                        };
                        let mut v606: Rc<str> = method26(v546.clone(), v547.clone(), v548.clone(), v549.clone(), v550.clone(), v551.clone(), v552.clone(), v553.clone(), v593.clone());
                        { let _ = spiral_trace_hold(&v6); };
                        let (mut v609, mut v610, mut v611, mut v612, mut v613, mut v614): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                        let mut v615: i64 = v609.borrow().l0.clone();
                        let mut v616: i64 = v615.wrapping_add(1i64);
                        v609.borrow_mut().l0 = v616;
                        let mut v617: Rc<dyn Fn(Rc<str>) -> ()> = closure7();
                        let mut v618: bool = cfg!(target_arch = "wasm32");
                        if v618 {
                            let mut v619: Rc<str> = v612.borrow().l0.clone();
                            let mut v620: bool = v619.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let mut v628: Rc<str> = if v620 {
                                v606.clone()
                            } else {
                                let mut v621: bool = v606.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                if v621 {
                                    let mut v622: Rc<str> = v612.borrow().l0.clone();
                                    v622.clone()
                                } else {
                                    let mut v623: Rc<str> = v612.borrow().l0.clone();
                                    let mut v624: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                    let mut v625: Rc<str> = Rc::<str>::from(format!("{}{}", v623, v624));
                                    let mut v626: Rc<str> = Rc::<str>::from(format!("{}{}", v625, v606));
                                    v626.clone()
                                }
                            };
                            let mut v630: i32 = ((v628.chars().count() + 14999) / 15000) as i32;
                            let mut v631: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let mut v632: bool = v606 != v631 ;
                            let mut v634: bool = if v632 {
                                let mut v633: bool = v630 <= 1i32;
                                v633
                            } else {
                                false
                            };
                            if v634 {
                                v612.borrow_mut().l0 = v628.clone();
                                ()
                            } else {
                                v612.borrow_mut().l0 = v631.clone();
                                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v628); };
                                ()
                            }
                        } else {
                            println!("{}", v606);
                            ()
                        };
                        let mut v637: Rc<dyn Fn(Rc<str>) -> ()> = v610.borrow().l0.clone();
                        v637(v606.clone());
                        US2::US2_0(v609.clone(), v610.clone(), v611.clone(), v612.clone(), v613.clone(), v614.clone())
                    };
                    { if let Some(accounts) = (v3).get_mut(&(v447)) { accounts.remove(&(v61.clone())); } };
                    { (v2).insert((v61).clone(), (v4).clone()); };
                    let mut v641: bool = v0.insert(v61.clone());
                    let mut v643: bool = v1.insert(v4.clone());
                    { let accounts = match (v3).get(&(v4.clone())) { None => { let mut accounts = std::collections::HashMap::new(); accounts.insert((v61).clone(), (v147, 0u32)); accounts } Some(previous) => { let mut ordered = previous.iter().collect::<Vec<_>>(); ordered.sort_unstable_by_key(|(_, (_, index))| *index); let mut accounts = ordered.iter().enumerate().map(|(i, (account_id, (timestamp, _)))| ((*account_id).clone(), (*timestamp, i as u32))).collect::<std::collections::HashMap<_, _>>(); accounts.insert((v61).clone(), (v147, ordered.len() as u32)); accounts } }; (v3).insert((v4).clone(), accounts); };
                    ()
                }
            }
            _ => {
                { let _ = spiral_trace_hold(&v6); };
                let (mut v646, mut v647, mut v648, mut v649, mut v650, mut v651): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                let mut v652: US0 = v650.borrow().l0.clone();
                let mut v657: i32 = match &v652 {
                    US0::US0_4 => { // Critical
                        50i32
                    }
                    US0::US0_1 => { // Debug
                        20i32
                    }
                    US0::US0_2 => { // Info
                        30i32
                    }
                    US0::US0_0 => { // Verbose
                        10i32
                    }
                    US0::US0_3 => { // Warning
                        40i32
                    }
                };
                let mut v658: bool = v648.borrow().l0.clone();
                let mut v659: bool = v658 == false;
                let mut v661: bool = if v659 {
                    false
                } else {
                    let mut v660: bool = 20i32 >= v657;
                    v660
                };
                let mut v662: bool = v661 == false;
                let mut v718: US2 = if v662 {
                    US2::US2_1
                } else {
                    { let _ = spiral_trace_hold(&v6); };
                    let (mut v666, mut v667, mut v668, mut v669, mut v670, mut v671): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                    let mut v672: Rc<str> = method3(v666.clone(), v667.clone(), v668.clone(), v669.clone(), v670.clone(), v671.clone());
                    let mut v673: Rc<str> = method4();
                    let mut v675: Option<std::string::String> = match &v429 {
                        US3::US3_1 => { // None
                            let mut v674: Option<std::string::String> = None;
                            v674.clone()
                        }
                        _ => unreachable!(),
                    };
                    let mut v676: Rc<RefCell<Vec<std::string::String>>> = Rc::new(RefCell::new(v675.clone().into_iter().collect::<Vec<_>>()));
                    let mut v677: u64 = (v676.clone().borrow().len() as u64);
                    let mut v678: bool = v677 == 0u64;
                    let mut v684: Rc<str> = if v678 {
                        let mut v679: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("None"); } LIT.with(|lit| lit.clone()) };
                        v679.clone()
                    } else {
                        let mut v680: std::string::String = v676.clone().borrow()[0u64 as usize].clone();
                        let mut v681: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<std::string::String>") } } (&&W(&v680)).s() });
                        let mut v682: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Some "); } LIT.with(|lit| lit.clone()) };
                        let mut v683: Rc<str> = Rc::<str>::from(format!("{}{}", v682, v681));
                        v683.clone()
                    };
                    let mut v685: Rc<str> = method26(v666.clone(), v667.clone(), v668.clone(), v669.clone(), v670.clone(), v671.clone(), v672.clone(), v673.clone(), v684.clone());
                    { let _ = spiral_trace_hold(&v6); };
                    let (mut v688, mut v689, mut v690, mut v691, mut v692, mut v693): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v8) };
                    let mut v694: i64 = v688.borrow().l0.clone();
                    let mut v695: i64 = v694.wrapping_add(1i64);
                    v688.borrow_mut().l0 = v695;
                    let mut v696: Rc<dyn Fn(Rc<str>) -> ()> = closure7();
                    let mut v697: bool = cfg!(target_arch = "wasm32");
                    if v697 {
                        let mut v698: Rc<str> = v691.borrow().l0.clone();
                        let mut v699: bool = v698.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v707: Rc<str> = if v699 {
                            v685.clone()
                        } else {
                            let mut v700: bool = v685.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v700 {
                                let mut v701: Rc<str> = v691.borrow().l0.clone();
                                v701.clone()
                            } else {
                                let mut v702: Rc<str> = v691.borrow().l0.clone();
                                let mut v703: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v704: Rc<str> = Rc::<str>::from(format!("{}{}", v702, v703));
                                let mut v705: Rc<str> = Rc::<str>::from(format!("{}{}", v704, v685));
                                v705.clone()
                            }
                        };
                        let mut v709: i32 = ((v707.chars().count() + 14999) / 15000) as i32;
                        let mut v710: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v711: bool = v685 != v710 ;
                        let mut v713: bool = if v711 {
                            let mut v712: bool = v709 <= 1i32;
                            v712
                        } else {
                            false
                        };
                        if v713 {
                            v691.borrow_mut().l0 = v707.clone();
                            ()
                        } else {
                            v691.borrow_mut().l0 = v710.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v707); };
                            ()
                        }
                    } else {
                        println!("{}", v685);
                        ()
                    };
                    let mut v716: Rc<dyn Fn(Rc<str>) -> ()> = v689.borrow().l0.clone();
                    v716(v685.clone());
                    US2::US2_0(v688.clone(), v689.clone(), v690.clone(), v691.clone(), v692.clone(), v693.clone())
                };
                match &v429 {
                    US3::US3_1 => { // None
                        ()
                    }
                    _ => unreachable!(),
                };
                { (v2).insert((v61).clone(), (v4).clone()); };
                let mut v720: bool = v0.insert(v61.clone());
                let mut v722: bool = v1.insert(v4.clone());
                { let accounts = match (v3).get(&(v4.clone())) { None => { let mut accounts = std::collections::HashMap::new(); accounts.insert((v61).clone(), (v147, 0u32)); accounts } Some(previous) => { let mut ordered = previous.iter().collect::<Vec<_>>(); ordered.sort_unstable_by_key(|(_, (_, index))| *index); let mut accounts = ordered.iter().enumerate().map(|(i, (account_id, (timestamp, _)))| ((*account_id).clone(), (*timestamp, i as u32))).collect::<std::collections::HashMap<_, _>>(); accounts.insert((v61).clone(), (v147, ordered.len() as u32)); accounts } }; (v3).insert((v4).clone(), accounts); };
                ()
            }
        }
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method29(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("account_id"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method30(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method28(mut v0: String, mut v1: Rc<str>) -> Rc<str> {
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v2.clone() }));
    method13(v3.clone());
    method29(v3.clone());
    method15(v3.clone());
    let mut v57: std::string::String = format!("{:#?}", v0);
    let mut v59: Rc<str> = Rc::<str>::from(v57);
    method6(v3.clone(), v59.clone());
    method16(v3.clone());
    method30(v3.clone());
    method15(v3.clone());
    method6(v3.clone(), v1.clone());
    method20(v3.clone());
    let mut v89: Rc<str> = v3.borrow().l0.clone();
    v89.clone()
}
fn method27(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: String, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = method11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chat_contract.get_account_info"); } LIT.with(|lit| lit.clone()) };
    let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v27));
    let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v28, v33));
    let mut v35: Rc<str> = method28(v8.clone(), v9.clone());
    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v34, v35));
    method8(v36.clone())
}
fn closure9() -> Rc<dyn Fn(&near_sdk::store::LookupMap<String, std::string::String>, &near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, String) -> Option<(String, u64, u32)>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&near_sdk::store::LookupMap<String, std::string::String>, &near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, String) -> Option<(String, u64, u32)>> = Rc::new(move |mut v0: &near_sdk::store::LookupMap<String, std::string::String>, mut v1: &near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, mut v2: String| -> Option<(String, u64, u32)> {
        let mut v4: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v4); };
        let mut v6: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v7, mut v8, mut v9, mut v10, mut v11, mut v12): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
        let mut v13: US0 = US0::US0_2;
        v11.borrow_mut().l0 = v13.clone();
        let mut v14: Option<(String, u64, u32)> = (v0).get(&(v2.clone())).and_then(|alias| (v1).get(alias).and_then(|accounts| accounts.get(&(v2.clone())).map(|(timestamp, index)| (alias.clone(), *timestamp, *index))));
        { let _ = spiral_trace_hold(&v4); };
        let (mut v17, mut v18, mut v19, mut v20, mut v21, mut v22): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
        let mut v23: US0 = v21.borrow().l0.clone();
        let mut v28: i32 = match &v23 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
        };
        let mut v29: bool = v19.borrow().l0.clone();
        let mut v30: bool = v29 == false;
        let mut v32: bool = if v30 {
            false
        } else {
            let mut v31: bool = 20i32 >= v28;
            v31
        };
        let mut v33: bool = v32 == false;
        let mut v99: US2 = if v33 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v4); };
            let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
            let mut v43: Rc<str> = method3(v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone());
            let mut v44: Rc<str> = method4();
            let mut v51: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Option<(String, u64, u32)>>") } } (&&W(&v14)).s() });
            let mut v66: Rc<str> = method27(v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v43.clone(), v44.clone(), v2.clone(), v51.clone());
            { let _ = spiral_trace_hold(&v4); };
            let (mut v69, mut v70, mut v71, mut v72, mut v73, mut v74): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v6) };
            let mut v75: i64 = v69.borrow().l0.clone();
            let mut v76: i64 = v75.wrapping_add(1i64);
            v69.borrow_mut().l0 = v76;
            let mut v77: Rc<dyn Fn(Rc<str>) -> ()> = closure7();
            let mut v78: bool = cfg!(target_arch = "wasm32");
            if v78 {
                let mut v79: Rc<str> = v72.borrow().l0.clone();
                let mut v80: bool = v79.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v88: Rc<str> = if v80 {
                    v66.clone()
                } else {
                    let mut v81: bool = v66.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v81 {
                        let mut v82: Rc<str> = v72.borrow().l0.clone();
                        v82.clone()
                    } else {
                        let mut v83: Rc<str> = v72.borrow().l0.clone();
                        let mut v84: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v85: Rc<str> = Rc::<str>::from(format!("{}{}", v83, v84));
                        let mut v86: Rc<str> = Rc::<str>::from(format!("{}{}", v85, v66));
                        v86.clone()
                    }
                };
                let mut v90: i32 = ((v88.chars().count() + 14999) / 15000) as i32;
                let mut v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v92: bool = v66 != v91 ;
                let mut v94: bool = if v92 {
                    let mut v93: bool = v90 <= 1i32;
                    v93
                } else {
                    false
                };
                if v94 {
                    v72.borrow_mut().l0 = v88.clone();
                    ()
                } else {
                    v72.borrow_mut().l0 = v91.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v88); };
                    ()
                }
            } else {
                println!("{}", v66);
                ()
            };
            let mut v97: Rc<dyn Fn(Rc<str>) -> ()> = v70.borrow().l0.clone();
            v97(v66.clone());
            US2::US2_0(v69.clone(), v70.clone(), v71.clone(), v72.clone(), v73.clone(), v74.clone())
        };
        v14.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
fn method32(mut v0: std::string::String) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    method13(v2.clone());
    method14(v2.clone());
    method15(v2.clone());
    let mut v4: std::string::String = format!("{:#?}", v0);
    let mut v6: Rc<str> = Rc::<str>::from(v4);
    method6(v2.clone(), v6.clone());
    method20(v2.clone());
    let mut v7: Rc<str> = v2.borrow().l0.clone();
    v7.clone()
}
fn method31(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: std::string::String) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = method11(v9);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v10));
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chat_contract.get_alias_map"); } LIT.with(|lit| lit.clone()) };
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v26));
    let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v32));
    let mut v34: Rc<str> = method32(v8.clone());
    let mut v35: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v34));
    method8(v35.clone())
}
fn closure10() -> Rc<dyn Fn(&near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, std::string::String) -> Option<std::collections::HashMap<String, (u64, u32)>>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(&near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, std::string::String) -> Option<std::collections::HashMap<String, (u64, u32)>>> = Rc::new(move |mut v0: &near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, mut v1: std::string::String| -> Option<std::collections::HashMap<String, (u64, u32)>> {
        let mut v3: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure1();
        { let _ = spiral_trace_hold(&v3); };
        let mut v5: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v6, mut v7, mut v8, mut v9, mut v10, mut v11): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v12: US0 = US0::US0_2;
        v10.borrow_mut().l0 = v12.clone();
        { let _ = spiral_trace_hold(&v3); };
        let (mut v15, mut v16, mut v17, mut v18, mut v19, mut v20): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
        let mut v21: US0 = v19.borrow().l0.clone();
        let mut v26: i32 = match &v21 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
        };
        let mut v27: bool = v17.borrow().l0.clone();
        let mut v28: bool = v27 == false;
        let mut v30: bool = if v28 {
            false
        } else {
            let mut v29: bool = 20i32 >= v26;
            v29
        };
        let mut v31: bool = v30 == false;
        let mut v76: US2 = if v31 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v3); };
            let (mut v35, mut v36, mut v37, mut v38, mut v39, mut v40): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v41: Rc<str> = method3(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone());
            let mut v42: Rc<str> = method4();
            let mut v43: Rc<str> = method31(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v1.clone());
            { let _ = spiral_trace_hold(&v3); };
            let (mut v46, mut v47, mut v48, mut v49, mut v50, mut v51): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v5) };
            let mut v52: i64 = v46.borrow().l0.clone();
            let mut v53: i64 = v52.wrapping_add(1i64);
            v46.borrow_mut().l0 = v53;
            let mut v54: Rc<dyn Fn(Rc<str>) -> ()> = closure7();
            let mut v55: bool = cfg!(target_arch = "wasm32");
            if v55 {
                let mut v56: Rc<str> = v49.borrow().l0.clone();
                let mut v57: bool = v56.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v65: Rc<str> = if v57 {
                    v43.clone()
                } else {
                    let mut v58: bool = v43.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v58 {
                        let mut v59: Rc<str> = v49.borrow().l0.clone();
                        v59.clone()
                    } else {
                        let mut v60: Rc<str> = v49.borrow().l0.clone();
                        let mut v61: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v62: Rc<str> = Rc::<str>::from(format!("{}{}", v60, v61));
                        let mut v63: Rc<str> = Rc::<str>::from(format!("{}{}", v62, v43));
                        v63.clone()
                    }
                };
                let mut v67: i32 = ((v65.chars().count() + 14999) / 15000) as i32;
                let mut v68: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v69: bool = v43 != v68 ;
                let mut v71: bool = if v69 {
                    let mut v70: bool = v67 <= 1i32;
                    v70
                } else {
                    false
                };
                if v71 {
                    v49.borrow_mut().l0 = v65.clone();
                    ()
                } else {
                    v49.borrow_mut().l0 = v68.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v65); };
                    ()
                }
            } else {
                println!("{}", v43);
                ()
            };
            let mut v74: Rc<dyn Fn(Rc<str>) -> ()> = v47.borrow().l0.clone();
            v74(v43.clone());
            US2::US2_0(v46.clone(), v47.clone(), v48.clone(), v49.clone(), v50.clone(), v51.clone())
        };
        let mut v77: Option<std::collections::HashMap<String, (u64, u32)>> = (v0).get(&(v1)).cloned();
        v77.clone()
    }); } CLOSURE.with(|closure| closure.clone())
}
pub fn chat_contract_new() -> (u32, near_sdk::store::IterableSet<String>, near_sdk::store::IterableSet<std::string::String>, near_sdk::store::LookupMap<String, std::string::String>, near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>) {
    closure0()()
}
pub fn chat_contract_is_valid_alias(v0: std::string::String) -> bool {
    closure4()(v0)
}
pub fn chat_contract_generate_cid(v0: Vec<u8>) -> std::string::String {
    closure5()(v0)
}
pub fn chat_contract_claim_alias(v0: &mut near_sdk::store::IterableSet<String>, v1: &mut near_sdk::store::IterableSet<std::string::String>, v2: &mut near_sdk::store::LookupMap<String, std::string::String>, v3: &mut near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, v4: std::string::String) -> () {
    closure6()(v0, v1, v2, v3, v4)
}
pub fn chat_contract_get_account_info(v0: &near_sdk::store::LookupMap<String, std::string::String>, v1: &near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, v2: String) -> Option<(String, u64, u32)> {
    closure9()(v0, v1, v2)
}
pub fn chat_contract_get_alias_map(v0: &near_sdk::store::LookupMap<std::string::String, std::collections::HashMap<String, (u64, u32)>>, v1: std::string::String) -> Option<std::collections::HashMap<String, (u64, u32)>> {
    closure10()(v0, v1)
}
