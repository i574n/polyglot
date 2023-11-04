use leptos::{logging::log, *};
use leptos_router::*;
use serde::{Deserialize, Serialize};
use std::collections::HashMap;
use wasm_bindgen::prelude::*;

#[derive(Clone, Debug, Serialize, Deserialize)]
pub enum OuterMessage {
    SetS1 { s: String },
    SetAccountId { account_id: String },
    SetNetworkId { network_id: String },
    SetStorage { key: String, value: Option<String> },
}

#[derive(Clone, Debug, Serialize, Deserialize)]
pub enum InnerMessage {
    Ack,
    SetS2 { s: String },
    SetStorage { key: String, value: String },
    GetStorage { key: String },
}

#[derive(Clone, Debug, Serialize, Deserialize)]
pub struct Messages {
    pub outer: RwSignal<Vec<(u64, OuterMessage)>>,
    pub inner: RwSignal<Vec<(u64, InnerMessage)>>,
}

#[derive(Clone, PartialEq, Serialize, Deserialize)]
pub struct State {
    pub dark_mode: RwSignal<bool>,
    pub account_id: RwSignal<String>,
    pub network_id: RwSignal<String>,
    pub s1: RwSignal<String>,
    pub s2: RwSignal<String>,
}

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct GlobalState {
    pub messages: RwSignal<Messages>,
    pub state: RwSignal<State>,
    pub loading: RwSignal<HashMap<String, RwSignal<bool>>>,
}

#[wasm_bindgen]
extern "C" {
    #[wasm_bindgen(catch)]
    fn setOuterMessagesAsync(messagesJson: &str) -> Result<js_sys::Promise, JsValue>;

    #[wasm_bindgen(catch)]
    fn setInnerMessagesAsync(messagesJson: &str) -> Result<js_sys::Promise, JsValue>;

    #[wasm_bindgen(catch)]
    fn setOuterMessages(messagesJson: &str) -> Result<JsValue, JsValue>;

    #[wasm_bindgen(catch)]
    fn setInnerMessages(messagesJson: &str) -> Result<JsValue, JsValue>;
}

#[wasm_bindgen]
pub async fn set_outer_messages_async(messages_json: &str) -> Result<JsValue, JsValue> {
    let promise = setOuterMessagesAsync(messages_json)?;
    Ok(wasm_bindgen_futures::JsFuture::from(promise).await?)
}

#[wasm_bindgen]
pub async fn set_inner_messages_async(messages_json: &str) -> Result<JsValue, JsValue> {
    let promise = setInnerMessagesAsync(messages_json)?;
    Ok(wasm_bindgen_futures::JsFuture::from(promise).await?)
}

#[wasm_bindgen]
pub fn set_outer_messages(messages_json: &str) -> Result<JsValue, JsValue> {
    setOuterMessages(messages_json)
}

#[wasm_bindgen]
pub fn set_inner_messages(messages_json: &str) -> Result<JsValue, JsValue> {
    setInnerMessages(messages_json)
}

#[wasm_bindgen]
pub async fn set_outer_messages_state(messages_json: String) -> Result<JsValue, JsValue> {
    let global_state = use_context::<GlobalState>();

    match global_state {
        Some(global_state) => {
            global_state
                .messages
                .get_untracked()
                .outer
                .update(|outer| *outer = serde_json::from_str(&messages_json).unwrap());
        }
        None => (),
    }

    Ok(JsValue::from_str(&format!(
        "set_outer_messages_state: {}",
        messages_json
    )))
}

#[wasm_bindgen]
pub async fn set_inner_messages_state(messages_json: String) -> Result<JsValue, JsValue> {
    let global_state = use_context::<GlobalState>();

    match global_state {
        Some(global_state) => {
            global_state
                .messages
                .get_untracked()
                .inner
                .update(|inner| *inner = serde_json::from_str(&messages_json).unwrap());
        }
        None => (),
    }

    Ok(JsValue::from_str(&format!(
        "set_inner_messages_state: {}",
        messages_json
    )))
}

fn _use_set_inner_messages_async() -> leptos::Action<String, Result<JsValue, JsValue>> {
    create_action(|json: &String| {
        let json = json.to_owned();
        async move { set_inner_messages_async(&json).await }
    })
}

fn _use_set_outer_messages_async() -> leptos::Action<String, Result<JsValue, JsValue>> {
    create_action(|json: &String| {
        let json = json.to_owned();
        async move { set_outer_messages_async(&json).await }
    })
}

pub fn use_set_inner_messages() -> impl Fn(String) -> Result<JsValue, JsValue> {
    |json| set_inner_messages(&json)
}

pub fn _use_set_outer_messages() -> impl Fn(String) -> Result<JsValue, JsValue> {
    |json| set_outer_messages(&json)
}

pub const DARK_MODE_KEY: &str = "dark-mode";

#[component]
pub fn MessagesProcessor(window: &'static web_sys::Window) -> impl IntoView {
    log!("MessagesProcessor ()");

    let global_state1 = use_context::<GlobalState>();
    // let global_state2 = use_context::<GlobalState>();
    let global_state_resource = create_resource(
        move || global_state1.clone(),
        |global_state| async move {
            log!("MessagesProcessor / global_state_resource");
            global_state
        },
    );
    let global_state_json = create_memo(move |_| {
        log!("MessagesProcessor / global_state_json memo");
        global_state_resource.with(|global_state| match global_state {
            Some(Some(global_state)) => serde_json::to_string(global_state).unwrap(),
            _ => "".to_string(),
        })
    });

    // let set_outer_messages = use_set_outer_messages_async();
    // let set_inner_messages = use_set_inner_messages_async();
    // let set_outer_messages = use_set_outer_messages();
    let set_inner_messages = use_set_inner_messages();

    let global_state = use_context::<GlobalState>();
    create_effect(move |_| {
        log!("MessagesProcessor () / create_effect");
        let global_state = global_state.clone().unwrap();
        let messages = global_state.messages.get();
        let outer_messages = messages.outer.get();
        let outer_messages_len = outer_messages.len();

        let new_messages = if outer_messages.len() == 0 {
            (vec![], vec![])
        } else {
            outer_messages
                .into_iter()
                .map(|message| match message.clone() {
                    (id, OuterMessage::SetS1 { s }) => {
                        let s2 = s.to_uppercase();
                        global_state.state.update(|state| {
                            state.s1.set(s);
                            state.s2.set(s2.clone());
                        });
                        (None, vec![(id, InnerMessage::SetS2 { s: s2 })])
                    }
                    (id, OuterMessage::SetStorage { key, value }) => {
                        match key.as_str() {
                            DARK_MODE_KEY => {
                                if let Some(value) = value {
                                    let dark_mode = serde_json::from_str::<bool>(&value).unwrap();
                                    global_state.state.get().dark_mode.set(dark_mode);
                                }
                            }
                            _ => log!(
                                "MessageProcessor () / create_effect / invalid message / message: {:#?}",
                                message
                            ),
                        }
                        global_state.loading.update(|loading| {
                            match loading.get(&key) {
                                Some(loading) => loading.set(false),
                                _ => (),
                            };
                        });
                        (None, vec![(id, InnerMessage::Ack)])
                    }
                    (id, OuterMessage::SetAccountId { account_id }) => {
                        global_state.state.get().account_id.set(account_id);
                        (None, vec![(id, InnerMessage::Ack)])
                    }
                    (id, OuterMessage::SetNetworkId { network_id }) => {
                        global_state.state.get().network_id.set(network_id);
                        (None, vec![(id, InnerMessage::Ack)])
                    }
                })
                .fold((vec![], vec![]), |(outer, inner), (outer2, inner2)| {
                    (
                        outer.into_iter().chain(outer2.into_iter()).collect(),
                        inner.into_iter().chain(inner2.into_iter()).collect(),
                    )
                })
        };

        if new_messages.1.len() > 0 {
            messages.inner.update(|inner| {
                inner.extend(new_messages.1.clone());
            });

            let json = serde_json::to_string(&new_messages.1).unwrap();
            // set_inner_messages.dispatch(json);
            // let result = set_inner_messages.value().get();
            let result = set_inner_messages(json);
            log!(
                "MessagesProcessor () / create_effect / set_inner_messages / result: {:#?}",
                result
            );
        }

        if new_messages.0.len() != outer_messages_len {
            messages.outer.set(new_messages.0.clone());

            // let json = serde_json::to_string(&new_messages.0).unwrap();
            // // set_outer_messages.dispatch(json);
            // // let result = set_outer_messages.value().get();
            // let result = set_outer_messages(json);
            // log!(
            //     "MessagesProcessor / set_outer_messages / result: {:#?}",
            //     result
            // );
        }
    });

    fn format_location(location: &Location, url_fn: impl Fn(Url) -> Url) -> String {
        let pathname = location.pathname.get();
        let search = location.search.get();
        let hash = location.hash.get();
        let url = Url {
            origin: "".to_string(),
            search_params: ParamsMap::default(),
            pathname,
            search,
            hash,
        };
        let url = url_fn(url);
        format!(
            "{}{}{}{}",
            url.pathname,
            if url.search == "" { "" } else { "?" },
            url.search,
            url.hash
        )
    }

    let router1 = use_router();
    let router2 = use_router();
    let router3 = use_router();
    let route_data: Option<String> = use_route_data();

    let query_map = use_query_map();
    let params_map = use_params_map();
    let location1 = use_location();
    let location2 = use_location();
    let location3 = use_location();
    let location4 = use_location();
    // let location5 = use_location();
    let navigate = use_navigate();
    // let navigate2 = use_navigate();

    window_event_listener(ev::hashchange, move |_| {
        let hash = crate::state::leptos_dom::helpers::location_hash().unwrap_or("".to_string());
        log!(
            "MessagesProcessor () / window_event_listener ev::hashchange / location_hash(): {:#?}",
            hash
        );
    });

    let (location_text, set_location_text) = create_signal("".to_string());
    let set_location_text_2 = set_location_text.clone();

    create_effect(move |_| {
        let new_location_text = format_location(&location2, |url| url);
        log!(
            "MessagesProcessor () / new_location_text: {:#?}",
            new_location_text
        );
        set_location_text_2.set(new_location_text);
    });

    create_effect(move |_| {
        log!(
            "MessagesProcessor () / router1.pathname() effect: {:#?}",
            router1.pathname().get()
        )
    });
    create_effect(move |_| {
        log!(
            "MessagesProcessor () / router2.possible_branches()** effect: {:#?}",
            router2.possible_branches()
        )
    });
    create_effect(move |_| {
        log!(
            "MessagesProcessor () / route_data** effect: {:#?}",
            route_data
        )
    });
    create_effect(move |_| {
        log!(
            "MessagesProcessor () / query_map.get() effect: {:#?}",
            query_map.get()
        )
    });
    create_effect(move |_| {
        log!(
            "MessagesProcessor () / params_map.get()** effect: {:#?}",
            params_map.get()
        )
    });
    create_effect(move |_| {
        log!(
            "MessagesProcessor () / location1.search.get() effect: {:#?}",
            location1.search.get()
        )
    });
    create_effect(move |_| {
        log!(
            "MessagesProcessor () / router3 effect: {:#?}",
            router3.base().path()
        )
    });

    create_effect(move |_| {
        let hash = location3.hash.get();
        let hash = hash.strip_prefix('#').unwrap_or("");
        log!("MessagesProcessor () / location3.hash.get(): {:#?}", hash);

        {
            let hash_url = leptos_router::Url::try_from(hash);
            log!("MessagesProcessor () / hash_url: {:#?}", hash_url);
        }

        let json = js_sys::decode_uri_component(&hash)
            .unwrap()
            .as_string()
            .unwrap();
        log!("MessagesProcessor () / hash json: {:#?}", json);
    });

    let (location_href, set_location_href) = create_signal("".to_string());

    create_effect(move |_| {
        let new_location_href = window
            .location()
            .href()
            .ok()
            .unwrap_or("".to_string());
        set_location_href.set(new_location_href.clone());

        log!(
            "MessagesProcessor () / location4.state.get(): {:#?} / new_location_href: {:#?}",
            location4.state.get(),
            new_location_href
        );
    });

    create_effect(move |_| {
        log!(
            "MessagesProcessor () / location_href.get() effect: {:#?}",
            location_href.get()
        )
    });

    view! {
        <>
            {(|| {
                log!("MessagesProcessor () / render");
                view! {<>
                    <div class="flex">
                        <input
                            class="text-black flex-1"
                            prop:value={move || location_text.get()}
                            on:keyup={move |ev: web_sys::KeyboardEvent| {
                                set_location_text.set(event_target_value(&ev));
                            }}
                        />
                        <button
                            class="bg-amber-600 hover:bg-sky-700 px-2 text-white rounded-sm"
                            on:click=move |_| navigate(&location_text.get(), Default::default())
                        >
                            ?
                        </button>
                    </div>

                    <td
                        class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                    >
                        global_state_json: {move || global_state_json}
                    </td>
                    </>}
            })()}
        </>
    }
}
