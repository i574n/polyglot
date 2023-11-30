pub mod app;
pub mod components;
pub mod dice_ui_wasm;
pub mod js;
pub mod model;
pub mod state;

pub fn main() {
    dice_ui_wasm::main()
}
