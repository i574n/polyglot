use crate::js::*;
use crate::state::*;
use borsh::{BorshDeserialize, BorshSerialize};
use leptos::{logging::log, *};

async fn build_database() -> Result<rexie::Rexie, rexie::Error> {
    log!("DarkModeButton / build_database");
    let rexie = rexie::Rexie::builder("database")
        .version(1)
        .add_object_store(rexie::ObjectStore::new("store"))
        .build()
        .await?;

    Ok(rexie)
}

async fn set_dark_mode(rexie: &rexie::Rexie, mode: bool) -> Result<(), rexie::Error> {
    log!("DarkModeButton / set_dark_mode / mode: {}", mode);
    let transaction = rexie.transaction(&["store"], rexie::TransactionMode::ReadWrite)?;
    let store = transaction.store("store")?;
    let mode_value = serde_json::json!({ DARK_MODE_KEY: mode }).to_string();

    let mut data = Vec::new();
    mode_value.serialize(&mut data).unwrap();

    let mode_js_value = serde_wasm_bindgen::to_value(&data).unwrap();
    store.put(&mode_js_value, Some(&"data".into())).await?;
    transaction.done().await?;
    Ok(())
}

async fn get_dark_mode(rexie: &rexie::Rexie) -> Result<Option<bool>, rexie::Error> {
    log!("DarkModeButton / get_dark_mode");
    let transaction = rexie.transaction(&["store"], rexie::TransactionMode::ReadOnly)?;
    let store = transaction.store("store")?;
    let mode_value = store.get(&"data".into()).await?;
    let mode_data: Option<serde_json::Value> = serde_wasm_bindgen::from_value(mode_value).unwrap();
    match mode_data {
        Some(mode_data) => {
            let data: Vec<u8> = serde_json::from_value(mode_data).unwrap();
            log!("DarkModeButton / get_dark_mode / data: {:?}", data);
            let json: String = String::deserialize(&mut data.as_slice()).unwrap();
            log!("DarkModeButton / get_dark_mode / json: {:#?}", json);

            let obj = serde_json::from_str::<serde_json::Value>(&json).unwrap();
            let dark_mode = obj[DARK_MODE_KEY].as_bool();
            Ok(dark_mode)
        }
        _ => Ok(None),
    }
}

#[component]
pub fn DarkModeButton() -> impl IntoView {
    log!("DarkModeButton ()");

    let global_state = use_context::<GlobalState>().unwrap();
    let global_state2 = use_context::<GlobalState>().unwrap();
    let global_state3 = use_context::<GlobalState>().unwrap();

    // let set_inner_messages = use_set_inner_messages_async();
    let set_inner_messages1 = use_set_inner_messages();
    let set_inner_messages2 = use_set_inner_messages();

    let database = create_local_resource(
        || (),
        |()| async move {
            log!("DarkModeButton () / database create_local_resource");
            build_database().await.unwrap()
        },
    );

    let dark_mode = create_local_resource(
        move || database.get(),
        |database| async move {
            log!("DarkModeButton () / dark_mode create_local_resource");
            match database {
                Some(database) => get_dark_mode(&database).await.unwrap(),
                None => None,
            }
        },
    );

    create_effect(move |_| {
        log!("DarkModeButton () / create_effect 1 / ##1");

        match window().local_storage() {
            Ok(Some(_storage)) => {
                let dark_mode = dark_mode.get();

                log!(
                    "DarkModeButton / dark_mode effect 0 / ##1.1 / dark_mode: {:#?}",
                    dark_mode
                );

                match dark_mode {
                    Some(Some(dark_mode)) => {
                        global_state.state.get_untracked().dark_mode.set(dark_mode);
                    }
                    _ => (),
                };

                // let dark_mode = storage
                //     .get_item(DARK_MODE_KEY)
                //     .ok()
                //     .flatten()
                //     .and_then(|value| serde_json::from_str::<bool>(&value).ok());
                // log!(
                //     "DarkModeButton / create_effect 1 / #2 / dark_mode: {:?}",
                //     dark_mode
                // );
                // match dark_mode {
                //     Some(dark_mode) => {
                //         global_state.state.get_untracked().dark_mode.set(dark_mode);
                //     }
                //     _ => (),
                // }
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
                    "DarkModeButton () / create_effect 1 / set_inner_messages / result: {:#?}",
                    result
                );
            }
        }
    });

    let loading = create_memo(move |_| {
        log!("DarkModeButton () / loading create_memo");
        global_state2.loading.get_untracked()
    });

    let (loaded, set_loaded) = create_signal(false);

    let set_dark_mode_action = create_action(move |value: &bool| {
        log!(
            "DarkModeButton () / set_dark_mode_action / value: {:#?}",
            value
        );
        let value = value.clone();
        let database = database.get().unwrap();
        async move { set_dark_mode(&database, value).await.unwrap() }
    });

    create_effect(move |_| {
        log!("DarkModeButton () / create_effect 2 / ##1");
        let dark_mode = global_state.clone().state.get_untracked().dark_mode.get();
        log!("DarkModeButton () / create_effect 2 / ##2");
        let dark_mode_loading = loading()
            .get(DARK_MODE_KEY)
            .map(|x| x.get())
            .unwrap_or(false);
        log!(
            "DarkModeButton () / create_effect 2 / ##3 / dark_mode: {:#?} / dark_mode_loading: {:#?} / loaded: {:#?}",
            dark_mode,
            dark_mode_loading,
            loaded()
        );
        if !dark_mode_loading {
            if !loaded() {
                set_loaded.set(true);
            } else {
                log!(
                    "DarkModeButton () / create_effect 2 / ##4 / dark_mode: {:#?}",
                    dark_mode
                );

                match window().local_storage() {
                    Ok(Some(_storage)) => {
                        set_dark_mode_action.dispatch(dark_mode);

                        // match storage.set_item(DARK_MODE_KEY, &json) {
                        //     Result::Err(error) => {
                        //         log!("DarkModeButton () / create_effect 2 / error: {:#?}", error);
                        //     }
                        //     _ => (),
                        // };
                    }
                    _ => {
                        let json = serde_json::to_string(&dark_mode).unwrap();
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
                            "DarkModeButton / create_effect 2 / set_inner_messages / result: {:#?}",
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
                log!("DarkModeButton () / render");
                view! {<></>}
            })()}
            {"🌓︎"}
        </button>
    }
}
