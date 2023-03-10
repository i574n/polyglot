#![allow(special_module_name)]

pub mod js;
pub mod timer;
pub mod app;
pub mod state;

use leptos::{logging::log, *};
use wasm_bindgen::prelude::*;

#[wasm_bindgen]
pub fn app(window: &web_sys::Window) -> Result<(), JsValue> {
    _ = console_log::init_with_level(log::Level::Debug);
    console_error_panic_hook::set_once();

    log!("csr mode - mounting to body");

    let window : std::rc::Rc<web_sys::Window> = std::rc::Rc::new(window.clone());
    let window : &'static web_sys::Window = Box::leak(Box::new(window));

    mount_to_body(move || {
        view! { <crate::app::App window /> }
    });

    Ok(())
}
