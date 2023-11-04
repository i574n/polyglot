#![allow(special_module_name)]

pub mod js;
pub mod timer;
pub mod app;
pub mod state;

use leptos::{logging::log, *};
use wasm_bindgen::prelude::*;
use web_sys::{Window};

#[wasm_bindgen]
pub fn app(window: &Window) -> Result<(), JsValue> {
    _ = console_log::init_with_level(log::Level::Debug);
    console_error_panic_hook::set_once();

    log!("csr mode - mounting to body");

    let window : std::rc::Rc<Window> = std::rc::Rc::new(window.clone());
    let window : &'static Window = Box::leak(Box::new(window));

    mount_to_body(move || {
        view! { <crate::app::App window /> }
    });

    Ok(())
}
