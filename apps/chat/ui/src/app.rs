use leptos::*;
use leptos_meta::*;
use leptos_router::*;

#[component]
pub fn App() -> impl IntoView {
    provide_meta_context();

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

use serde::{Deserialize, Serialize};

#[derive(Serialize, Deserialize)]
enum OuterMessage {
    SetN1 { n: i32 },
}

#[derive(Serialize, Deserialize)]
enum InnerMessage {
    SetN2 { n: i32 },
}

#[derive(Serialize, Deserialize)]
struct Messages {
    outer: Vec<OuterMessage>,
    inner: Vec<InnerMessage>,
}

#[derive(Clone, PartialEq, Serialize, Deserialize)]
struct State {
    n1: RwSignal<i32>,
    n2: RwSignal<i32>,
}

use wasm_bindgen::prelude::*;

#[wasm_bindgen]
extern "C" {
    #[wasm_bindgen(catch)]
    fn jsTest(param: &str) -> Result<js_sys::Promise, JsValue>;
}

#[wasm_bindgen]
pub async fn js_test() -> Result<JsValue, JsValue> {
    let promise = jsTest("test")?;
    Ok(wasm_bindgen_futures::JsFuture::from(promise).await?)
}

const DARK_MODE_KEY: &str = "dark-mode";

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

#[component]
fn Home() -> impl IntoView {
    let (dark_mode, set_dark_mode) = create_signal(
        window()
            .local_storage()
            .ok()
            .flatten()
            .and_then(|storage| {
                storage
                    .get_item(DARK_MODE_KEY)
                    .ok()
                    .flatten()
                    .and_then(|value| serde_json::from_str::<bool>(&value).ok())
            })
            .unwrap_or(true),
    );

    create_effect(move |_| {
        if let Ok(Some(storage)) = window().local_storage() {
            let json = serde_json::to_string(&dark_mode).unwrap();
            if storage.set_item(DARK_MODE_KEY, &json).is_err() {
                log::error!("error while trying to set item in localStorage");
            }
        }
    });

    let (state, set_state) = create_signal(State {
        n1: create_rw_signal(0),
        n2: create_rw_signal(0),
    });

    let state_resource = create_resource(state, |state| async move { state });
    let state_json =
        create_memo(move |_| state_resource.with(|state| serde_json::to_string(&state).unwrap()));

    create_effect(move |_| {
        spawn_local(async {
            let messages = Messages {
                outer: vec![OuterMessage::SetN1 { n: 1 }],
                inner: vec![],
            };
            let json = serde_json::to_string(&messages).unwrap();
            log!("json1: {:#?}", json);
            let json_urlencoded = js_sys::encode_uri_component(&json);
            log!("json_urlencoded: {:#?}", json_urlencoded);

            log!("TEST: {:#?}", js_test().await.unwrap());
        })
    });

    let (row_count, set_row_count) = create_signal(1);

    let router1 = use_router();
    let router2 = use_router();
    let route_data: Option<String> = use_route_data();

    let query_map = use_query_map();
    let params_map = use_params_map();
    let location1 = use_location();
    let location2 = use_location();
    let location3 = use_location();
    let location4 = use_location();
    let location5 = use_location();
    let navigate = use_navigate();
    let navigate2 = use_navigate();

    window_event_listener(ev::hashchange, move |_| {
        let hash = location_hash().unwrap_or("".to_string());
        log!("location_hash(): {:#?}", hash);
    });

    let (location_text, set_location_text) = create_signal("".to_string());
    let set_location_text_2 = set_location_text.clone();

    create_effect(move |_| {
        set_location_text_2.set(format_location(&location2, |url| url));
    });

    create_effect(move |_| log!("router.pathname(): {:#?}", router1.pathname().get()));
    create_effect(move |_| {
        log!(
            "router.possible_branches(): {:#?}",
            router2.possible_branches()
        )
    });
    create_effect(move |_| log!("route_data: {:#?}", route_data));
    create_effect(move |_| log!("query_map: {:#?}", query_map.get()));
    create_effect(move |_| log!("params_map: {:#?}", params_map.get()));
    create_effect(move |_| log!("location.search: {:#?}", location1.search.get()));
    create_effect(move |_| {
        let hash = location3.hash.get();
        let hash = hash.strip_prefix('#').unwrap_or("");
        log!("location.hash: {:#?}", hash);
        let hash_url = Url::try_from(hash);
        log!("hash_url: {:#?}", hash_url);

        let json = js_sys::decode_uri_component(&hash)
            .unwrap()
            .as_string()
            .unwrap();
        log!("json2: {:#?}", json);

        let messages: Messages = serde_json::from_str(&json).unwrap_or(Messages {
            outer: vec![],
            inner: vec![],
        });

        if messages.outer.len() > 0 {
            let new_messages = messages
                .outer
                .into_iter()
                .map(|message| match message {
                    OuterMessage::SetN1 { n } => {
                        let n2 = n * 2;
                        set_state.update(|state| {
                            state.n1.set(n);
                            state.n2.set(n2);
                        });
                        (None, vec![InnerMessage::SetN2 { n: n2 }])
                    }
                })
                .fold((vec![], vec![]), |(outer, inner), (outer2, inner2)| {
                    (
                        outer2.into_iter().chain(outer).collect(),
                        inner2.into_iter().chain(inner).collect(),
                    )
                });

            let new_messages = Messages {
                outer: new_messages.0,
                inner: new_messages.1,
            };

            let hash = if new_messages.outer.len() > 0 || new_messages.inner.len() > 0 {
                let json = serde_json::to_string(&new_messages).unwrap();
                log!("json3: {:#?}", json);
                let encoded_json = js_sys::encode_uri_component(&json).as_string().unwrap();
                format!("#{}", encoded_json)
            } else {
                "".to_string()
            };

            let new_location = format_location(&location5, |url| Url {
                hash: hash.to_owned(),
                ..url
            });
            navigate2(&new_location, Default::default());
        }
    });
    create_effect(move |_| log!("location.state: {:#?}", location4.state.get()));

    view! {
        <div class:dark={move || dark_mode()}>
            <button
                class="fixed bottom-4 right-4 bg-gray-500 text-white p-2 rounded-full"
                on:click=move |_| set_dark_mode.update(|x| *x = !*x)
            >
                {"🌓︎"}
            </button>
            <div class="min-h-screen w-full bg-gray-50 dark:bg-gray-900">
                <div class="my-0 mx-auto max-w-3xl text-center">
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
                                    state: {move || state_json}
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
    }
}
