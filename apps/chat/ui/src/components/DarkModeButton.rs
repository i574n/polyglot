
use leptos::*;
use crate::state::*;
use crate::js::*;


#[component]
pub fn DarkModeButton() -> impl IntoView {
    log!("DarkModeButton ()");

    let global_state = use_context::<GlobalState>().unwrap();
    let global_state2 = use_context::<GlobalState>().unwrap();
    let global_state3 = use_context::<GlobalState>().unwrap();

    // let set_inner_messages = use_set_inner_messages_async();
    let set_inner_messages1 = use_set_inner_messages();
    let set_inner_messages2 = use_set_inner_messages();

    create_effect(move |_| {
        log!("DarkModeButton / dark_mode effect 1 / ##1");
        match window().local_storage() {
            Ok(Some(storage)) => {
                let dark_mode = storage
                    .get_item(DARK_MODE_KEY)
                    .ok()
                    .flatten()
                    .and_then(|value| serde_json::from_str::<bool>(&value).ok());
                log!(
                    "DarkModeButton / dark_mode effect 1 / #2 / dark_mode: {:?}",
                    dark_mode
                );
                match dark_mode {
                    Some(dark_mode) => {
                        global_state.state.get_untracked().dark_mode.set(dark_mode);
                    }
                    _ => (),
                }
            }
            _ => {
                let message = InnerMessage::GetStorage {
                    key: DARK_MODE_KEY.to_string(),
                };
                let new_inner_messages: Vec<_> = global_state
                    .messages
                    .get_untracked()
                    .inner
                    .get_untracked()
                    .into_iter()
                    .chain(vec![(random(), message)].into_iter())
                    .collect();

                global_state.loading.update(|loading| {
                    match loading.get(DARK_MODE_KEY) {
                        Some(loading) => loading.set(true),
                        _ => {
                            loading.insert(DARK_MODE_KEY.to_string(), create_rw_signal(true));
                        }
                    };
                });

                let json = serde_json::to_string(&new_inner_messages).unwrap();
                // set_inner_messages.dispatch(json);
                // let result = set_inner_messages.value().get();
                let result = set_inner_messages1(json);
                log!(
                    "DarkModeButton / set_inner_messages / result: {:#?}",
                    result
                );
            }
        }
    });

    let loading = create_memo(move |_| {
        log!("DarkModeButton / loading memo");
        global_state2.loading.get_untracked()
    });

    let (loaded, set_loaded) = create_signal(false);

    create_effect(move |_| {
        log!("DarkModeButton / dark_mode effect 2 / ##1");
        let dark_mode = global_state.clone().state.get_untracked().dark_mode.get();
        log!("DarkModeButton / dark_mode effect 2 / ##2");
        let dark_mode_loading = loading()
            .get(DARK_MODE_KEY)
            .map(|x| x.get())
            .unwrap_or(false);
        log!(
            "DarkModeButton / dark_mode effect 2 / ##3 / dark_mode_loading: {:#?} / loaded: {:#?}",
            dark_mode_loading,
            loaded()
        );
        if !dark_mode_loading {
            if !loaded() {
                set_loaded.set(true);
            } else {
                let json = serde_json::to_string(&dark_mode).unwrap();
                log!(
                    "DarkModeButton / dark_mode effect 2 / ##4 / json: {:#?}",
                    json
                );
                match window().local_storage() {
                    Ok(Some(storage)) => match storage.set_item(DARK_MODE_KEY, &json) {
                        Result::Err(error) => {
                            log!("DarkModeButton / dark_mode effect / error: {:#?}", error);
                        }
                        _ => (),
                    },
                    _ => {
                        let message = InnerMessage::SetStorage {
                            key: DARK_MODE_KEY.to_string(),
                            value: json,
                        };
                        let new_inner_messages: Vec<_> = global_state
                            .messages
                            .get_untracked()
                            .inner
                            .get_untracked()
                            .into_iter()
                            .chain(vec![(random(), message)].into_iter())
                            .collect();

                        let json = serde_json::to_string(&new_inner_messages).unwrap();
                        // set_inner_messages.dispatch(json);
                        // let result = set_inner_messages.value().get();
                        let result = set_inner_messages2(json);
                        log!(
                            "DarkModeButton / set_inner_messages / result: {:#?}",
                            result
                        );
                    }
                }
            }
        }
    });

    view! {
        <button
            class="fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full"
            on:click=move |_| global_state3.state.get().dark_mode.update(|x| *x = !*x)
        >
            {(|| {
                log!("DarkModeButton / render");
                view! {<></>}
            })()}
            {"🌓︎"}
        </button>
    }
}