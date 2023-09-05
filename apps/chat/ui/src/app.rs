use std::collections::HashMap;

use leptos::*;
use leptos_meta::*;
use leptos_router::*;

use serde::{Deserialize, Serialize};
use wasm_bindgen::prelude::*;

#[derive(Clone, Debug, Serialize, Deserialize)]
pub enum OuterMessage {
    SetN1 { n: u64 },
    SetStorage { key: String, value: String },
}

#[derive(Clone, Debug, Serialize, Deserialize)]
enum InnerMessage {
    SetN2 { n: u64 },
    SetStorage { key: String, value: String },
    GetStorage { key: String },
}

#[derive(Clone, Debug, Serialize, Deserialize)]
struct Messages {
    outer: RwSignal<Vec<(u64, OuterMessage)>>,
    inner: RwSignal<Vec<(u64, InnerMessage)>>,
}

#[derive(Clone, PartialEq, Serialize, Deserialize)]
struct State {
    n1: RwSignal<u64>,
    n2: RwSignal<u64>,
    dark_mode: RwSignal<bool>,
}

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
struct GlobalState {
    messages: RwSignal<Messages>,
    state: RwSignal<State>,
    loading: RwSignal<HashMap<String, RwSignal<bool>>>,
}

#[component]
pub fn App() -> impl IntoView {
    provide_meta_context();

    provide_context(GlobalState {
        messages: create_rw_signal(Messages {
            outer: create_rw_signal(vec![]),
            inner: create_rw_signal(vec![]),
        }),
        state: create_rw_signal(State {
            n1: create_rw_signal(0),
            n2: create_rw_signal(0),
            dark_mode: create_rw_signal(true),
        }),
        loading: create_rw_signal(HashMap::new()),
    });

    view! {
        <Router>
            <Routes>
                <Route path="" view= move || view! { <div><Home/><span style="display: none">1</span></div> }/>
                <Route path="/" view= move || view! { <div><Home/><span style="display: none">2</span></div> }/>
                <Route path="#" view= move || view! { <div><Home/><span style="display: none">3</span></div> }/>
                <Route path="?" view= move || view! { <div><Home/><span style="display: none">4</span></div> }/>
                <Route path="/*" view= move || view! { <div><Home/><span style="display: none">5</span></div> }/>
                <Route path="***" view= move || view! { <div><Home/><span style="display: none">6</span></div> }/>
                <Route path="**" view= move || view! { <div><Home/><span style="display: none">7</span></div> }/>
                <Route path="*" view= move || view! { <div><Home/><span style="display: none">8</span></div> }/>
            </Routes>
        </Router>
    }
}

#[wasm_bindgen]
extern "C" {
    #[wasm_bindgen(catch)]
    fn setInnerMessages(messagesJson: &str) -> Result<js_sys::Promise, JsValue>;
}

#[wasm_bindgen]
pub async fn set_inner_messages(messages_json: &str) -> Result<JsValue, JsValue> {
    let promise = setInnerMessages(messages_json)?;
    Ok(wasm_bindgen_futures::JsFuture::from(promise).await?)
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

pub fn random() -> u64 {
    (js_sys::Math::random() * 999999999999999999.0) as u64
}

const DARK_MODE_KEY: &str = "dark-mode";

#[component]
fn MessagesProcessor() -> impl IntoView {
    log!("MessagesProcessor ()");

    let global_state = use_context::<GlobalState>();
    create_effect(move |_| {
        log!("MessagesProcessor / state effect");
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
                    (id, OuterMessage::SetN1 { n }) => {
                        let n2 = n * 2;
                        global_state.state.update(|state| {
                            state.n1.set(n);
                            state.n2.set(n2);
                        });
                        (None, vec![(id, InnerMessage::SetN2 { n: n2 })])
                    }
                    (_, OuterMessage::SetStorage { key, value }) => {
                        match key.as_str() {
                            DARK_MODE_KEY => {
                                let dark_mode = serde_json::from_str::<bool>(&value).unwrap();
                                global_state.state.get().dark_mode.set(dark_mode);
                            }
                            _ => log!(
                                "MessageProcessor / invalid message / message: {:#?}",
                                message
                            ),
                        }
                        global_state.loading.update(|loading| {
                            match loading.get(&key) {
                                Some(loading) => loading.set(false),
                                _ => (),
                            };
                        });
                        (None, vec![])
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
            spawn_local(async move {
                let result = set_inner_messages(&json).await.unwrap();
                log!(
                    "MessagesProcessor / spawn_local set_inner_messages / result: {:#?}",
                    result
                );
            })
        }

        if new_messages.0.len() != outer_messages_len {
            messages.outer.set(new_messages.0);
        }
    });

    view! {
        <>
            {(|| {
                log!("MessagesProcessor / render");
                view! {<></>}
            })()}
        </>
    }
}

#[component]
fn DarkModeButton() -> impl IntoView {
    log!("DarkModeButton ()");

    let global_state = use_context::<GlobalState>().unwrap();
    let global_state2 = use_context::<GlobalState>().unwrap();
    let global_state3 = use_context::<GlobalState>().unwrap();

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
                spawn_local(async move {
                    let result = set_inner_messages(&json).await.unwrap();
                    log!(
                        "DarkModeButton / spawn_local set_inner_messages / result: {:#?}",
                        result
                    );
                })
            }
        }
    });

    let loading = create_memo(move |_| {
        log!("DarkModeButton / loading memo");
        global_state2.loading.get_untracked()
    });

    create_effect(move |_| {
        log!("DarkModeButton / dark_mode effect 2 / ##1");
        let dark_mode = global_state.clone().state.get_untracked().dark_mode.get();
        log!("DarkModeButton / dark_mode effect 2 / ##2");
        let dark_mode_loading = loading()
            .get(DARK_MODE_KEY)
            .map(|x| x.get())
            .unwrap_or(false);
        log!(
            "DarkModeButton / dark_mode effect 2 / ##3 / dark_mode_loading: {:#?}",
            dark_mode_loading
        );
        if !dark_mode_loading {
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
                    spawn_local(async move {
                        let result = set_inner_messages(&json).await.unwrap();
                        log!(
                            "DarkModeButton / spawn_local set_inner_messages / result: {:#?}",
                            result
                        );
                    })
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

#[component]
fn Home() -> impl IntoView {
    log!("Home ()");

    let global_state1 = use_context::<GlobalState>();
    let global_state2 = use_context::<GlobalState>();
    let global_state_resource = create_resource(
        move || global_state1.clone(),
        |global_state| async move {
            log!("Home / global_state_resource");
            global_state
        },
    );

    let global_state_json = create_memo(move |_| {
        let json = global_state_resource.with(|global_state| match global_state {
            Some(Some(global_state)) => serde_json::to_string(global_state).unwrap(),
            _ => "".to_string(),
        });
        log!("Home / global_state_json memo / json: {:#?}", json);

        json
    });

    let (row_count, set_row_count) = create_signal(1);

    view! {
        <>
            {(|| {
                log!("Home / render1");
                view! {<></>}
            })()}
            <MessagesProcessor />
            {(|| {
                log!("Home / render2");
                view! {<></>}
            })()}
            <div class:dark={move || global_state2.clone().unwrap().state.get().dark_mode.get()}>
                <DarkModeButton />
                <div class="min-h-screen w-full bg-gray-50 dark:bg-gray-900">
                    <div class="my-0 mx-auto max-w-3xl text-center">
                        <table class="min-w-full divide-y-2 divide-gray-200 bg-white text-sm dark:divide-gray-700 dark:bg-gray-900">
                            <thead class="ltr:text-left rtl:text-right">
                                <tr>
                                    <th
                                        class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white"
                                    >
                                        1
                                    </th>
                                    <th
                                        class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white"
                                    >
                                        2
                                    </th>
                                    <th
                                        class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white"
                                    >
                                        3
                                    </th>
                                    <th
                                        class="whitespace-nowrap px-4 py-2 font-medium text-gray-900 dark:text-white"
                                    >
                                        4
                                    </th>
                                </tr>
                            </thead>

                            <tbody class="divide-y divide-gray-200 dark:divide-gray-700">

                                <tr class="odd:bg-gray-50 dark:odd:bg-gray-800/50">
                                    <td
                                        class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                                    >
                                        global_state: {move || global_state_json}
                                    </td>
                                    <td
                                        class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                                    >
                                        ?
                                    </td>
                                    <td
                                        class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                                    >
                                        ?
                                    </td>
                                    <td
                                        class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                                    >
                                        ?
                                    </td>
                                </tr>

                                <For
                                    each=move || 0..row_count()
                                    key=|i| *i
                                    view=move |i| view! {
                                        <tr class="odd:bg-gray-50 dark:odd:bg-gray-800/50">
                                            <td
                                                class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                                            >
                                                {i * 3 + 1}
                                            </td>
                                            <td
                                                class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                                            >
                                                {i * 3 + 2}
                                            </td>
                                            <td
                                                class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                                            >
                                                {i * 3 + 3}
                                            </td>
                                            <td
                                                class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                                            >
                                                {if i == 0 {
                                                    view! {
                                                        <span>
                                                            <button
                                                                class="bg-amber-600 hover:bg-sky-700 px-2 text-white rounded-sm"
                                                                on:click=move |_| set_row_count.update(|count| *count += 1)
                                                            >
                                                                +
                                                            </button>
                                                        </span>
                                                    }
                                                } else {
                                                    view! {
                                                        <span></span>
                                                    }
                                                }}
                                            </td>
                                        </tr>
                                    }
                                />
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </>
    }
}
