#![allow(special_module_name)]

use crate::js::log;
use wasm_bindgen::prelude::*;
use wasm_bindgen::JsCast;
use web_sys::{HtmlInputElement, Window};

pub fn run(window: &Window) -> Result<(), JsValue> {
    let document = window.document().unwrap();
    let closure = Closure::wrap(Box::new(move || {
        let inputs = document.get_elements_by_tag_name("input");
        log(&format!("inputs.length(): {}", inputs.length()));

        let valid_inputs = (0..inputs.length())
            .filter_map(|i| {
                let input = inputs.item(i)?.dyn_into::<HtmlInputElement>().unwrap();
                match input.type_().as_str() {
                    "password" | "checkbox" | "number" | "hidden" | "submit" | "file" | "radio"
                    | "color" | "email" | "range" => None,
                    _ => Some(input),
                }
            })
            .collect::<Vec<HtmlInputElement>>();

        log(&format!("valid_inputs.len(): {}", valid_inputs.len()));

        for i in 0..valid_inputs.len() {
            let input = &valid_inputs[i];
            let cursor_position = input.selection_start().unwrap().unwrap_or(0);
            let value = input.value().to_uppercase();
            input.set_value(&value);
            input
                .set_selection_range(cursor_position, cursor_position)
                .unwrap_or_else(|x| {
                    log(&format!("set_selection_range error: {:?}", x));
                });
        }
    }) as Box<dyn FnMut()>);

    let id = window
        .set_interval_with_callback_and_timeout_and_arguments_0(
            closure.as_ref().unchecked_ref(),
            1000,
        )
        .unwrap();

    let window_clone = window.clone();
    let cancel_closure = Closure::wrap(Box::new(move || {
        window_clone.clear_interval_with_handle(id);
    }) as Box<dyn FnMut()>);

    window.set_timeout_with_callback_and_timeout_and_arguments_0(
        cancel_closure.as_ref().unchecked_ref(),
        3600000,
    )?;

    closure.forget();
    cancel_closure.forget();

    Ok(())
}
