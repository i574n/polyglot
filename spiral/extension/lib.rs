use wasm_bindgen::prelude::*;
use wasm_bindgen::JsCast;
use web_sys::{ HtmlInputElement, Window };

#[wasm_bindgen]
extern "C" {
    #[wasm_bindgen(js_namespace = console)]
    fn log(value: &str);
}

#[wasm_bindgen]
pub fn app(window: Window) -> Result<(), JsValue> {
    let document = window.document().unwrap();
    let closure = Closure::wrap(
        Box::new(move || {
            let inputs = document.get_elements_by_tag_name("input");
            log(&format!("inputs.length()={}", inputs.length()));
            for i in 0..inputs.length() {
                let input = inputs.item(i).unwrap().dyn_into::<HtmlInputElement>().unwrap();
                let cursor_position = input.selection_start().unwrap().unwrap_or(0);
                let value = input.value().to_uppercase();
                input.set_value(&value);
                input.set_selection_range(cursor_position, cursor_position).unwrap();
            }
        }) as Box<dyn FnMut()>
    );

    let id = window.set_interval_with_callback_and_timeout_and_arguments_0(closure.as_ref().unchecked_ref(), 1000)?;

    let window_clone = window.clone();
    let cancel_closure = Closure::wrap(
        Box::new(move || {
            window_clone.clear_interval_with_handle(id);
        }) as Box<dyn FnMut()>
    );

    window.set_timeout_with_callback_and_timeout_and_arguments_0(cancel_closure.as_ref().unchecked_ref(), 3600000)?;

    closure.forget();
    cancel_closure.forget();

    Ok(())
}
