#![allow(special_module_name)]

use crate::js::log;
use wasm_bindgen::prelude::*;
use wasm_bindgen::JsCast;
use web_sys::{HtmlInputElement, Window};

pub fn update(document: &web_sys::Document) -> (u32, usize) {
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

    (inputs.length(), valid_inputs.len())
}

pub fn run(window: &Window) -> Result<(), JsValue> {
    let _cancel = crate::js::use_interval(
        window,
        |document| {
            let _state = update(&document);
        },
        1000,
        Some(3600000),
    );

    Ok(())
}
