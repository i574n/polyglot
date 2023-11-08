pub fn random() -> u64 {
    (js_sys::Math::random() * 999999999999999999.0) as u64
}
