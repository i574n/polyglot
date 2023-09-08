use std::collections::HashMap;

use leptos::*;
use leptos_meta::*;
use leptos_router::*;

use serde::{Deserialize, Serialize};
use wasm_bindgen::prelude::*;

#[derive(Clone, Debug, Serialize, Deserialize)]
pub enum OuterMessage {
    SetS1 { s: String },
    SetAccountId { account_id: String },
    SetNetworkId { network_id: String },
    SetStorage { key: String, value: Option<String> },
}

#[derive(Clone, Debug, Serialize, Deserialize)]
enum InnerMessage {
    Ack,
    SetS2 { s: String },
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
    dark_mode: RwSignal<bool>,
    account_id: RwSignal<String>,
    network_id: RwSignal<String>,
    s1: RwSignal<String>,
    s2: RwSignal<String>,
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
            dark_mode: create_rw_signal(true),
            account_id: create_rw_signal("".to_string()),
            network_id: create_rw_signal("".to_string()),
            s1: create_rw_signal("".to_string()),
            s2: create_rw_signal("".to_string()),
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

pub fn random() -> u64 {
    (js_sys::Math::random() * 999999999999999999.0) as u64
}

const DARK_MODE_KEY: &str = "dark-mode";

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

fn use_set_inner_messages() -> impl Fn(String) -> Result<JsValue, JsValue> {
    |json| set_inner_messages(&json)
}

fn _use_set_outer_messages() -> impl Fn(String) -> Result<JsValue, JsValue> {
    |json| set_outer_messages(&json)
}

#[component]
fn MessagesProcessor() -> impl IntoView {
    log!("MessagesProcessor ()");

    // let set_outer_messages = use_set_outer_messages_async();
    // let set_inner_messages = use_set_inner_messages_async();
    // let set_outer_messages = use_set_outer_messages();
    let set_inner_messages = use_set_inner_messages();

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
                "MessagesProcessor / set_inner_messages / result: {:#?}",
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

#[derive(Clone, Serialize, Deserialize, Debug)]
#[serde(rename_all = "camelCase")]
struct TransactionCursor {
    timestamp: String,
    index_in_chunk: u8,
}

#[derive(Clone, Serialize, Deserialize, Debug)]
struct TransferArgs {
    deposit: String,
}

#[derive(Clone, Serialize, Deserialize, Debug)]
#[serde(rename_all = "camelCase")]
struct DeployContractArgs {
    code: String,
}

#[derive(Clone, Serialize, Deserialize, Debug)]
#[serde(rename_all = "camelCase")]
struct Permission {
    #[serde(rename = "type")]
    permission_type: String,
    contract_id: Option<String>,
    method_names: Option<Vec<String>>,
}

#[derive(Clone, Serialize, Deserialize, Debug)]
struct AccessKey {
    nonce: u8,
    permission: Permission,
}

#[derive(Clone, Serialize, Deserialize, Debug)]
#[serde(rename_all = "camelCase")]
struct AddKeyArgs {
    public_key: String,
    access_key: AccessKey,
}

#[derive(Clone, Serialize, Deserialize, Debug)]
#[serde(rename_all = "camelCase")]
struct FunctionCallArgs {
    method_name: String,
    args: String,
    gas: u64,
    deposit: String,
}

#[derive(Clone, Serialize, Deserialize, Debug)]
#[serde(tag = "kind", content = "args")]
#[serde(rename_all = "camelCase")]
enum TransactionAction {
    FunctionCall(FunctionCallArgs),
    AddKey(AddKeyArgs),
    DeployContract(DeployContractArgs),
    Transfer(TransferArgs),
}

#[derive(Clone, Serialize, Deserialize, Debug)]
#[serde(rename_all = "camelCase")]
struct Transaction {
    hash: String,
    signer_id: String,
    receiver_id: String,
    block_hash: String,
    block_timestamp: u64,
    actions: Vec<TransactionAction>,
    status: String,
}

#[derive(Serialize, Deserialize, Debug)]
struct TransactionListByAccountId {
    items: Vec<Transaction>,
    cursor: Option<TransactionCursor>,
}

#[derive(Serialize, Deserialize, Debug)]
#[serde(rename_all = "camelCase")]
struct ContractById {
    code_hash: String,
    transaction_hash: String,
    timestamp: u64,
    locked: bool,
}

#[derive(Serialize, Deserialize, Debug)]
#[serde(rename_all = "camelCase")]
struct AccountTransactionsCount {
    in_transactions_count: u64,
    out_transactions_count: u64,
}

#[derive(Serialize, Deserialize, Debug)]
#[serde(untagged)]
enum ResultData {
    AccountTransactionsCount(AccountTransactionsCount),
    ContractById(ContractById),
    TransactionListByAccountId(TransactionListByAccountId),
}

#[derive(Serialize, Deserialize, Debug)]
struct DataWrapper {
    data: ResultData,
}

#[derive(Serialize, Deserialize, Debug)]
#[serde(rename_all = "camelCase")]
struct ErrorDataInner {
    code: String,
    http_status: u32,
    path: String,
}

#[derive(Serialize, Deserialize, Debug)]
struct ErrorData {
    message: String,
    code: i32,
    data: ErrorDataInner,
}

#[derive(Serialize, Deserialize, Debug)]
struct ErrorWrapper {
    error: ErrorData,
}

#[derive(Serialize, Deserialize, Debug)]
struct ResultWrapper {
    result: Option<DataWrapper>,
    error: Option<ErrorWrapper>,
}

#[derive(Serialize, Deserialize, Debug)]
struct IdInput {
    id: String,
}

#[derive(Serialize, Deserialize, Debug)]
#[serde(rename_all = "camelCase")]
struct TransactionListByAccountIdInput {
    account_id: String,
    limit: u8,
    cursor: Option<TransactionCursor>,
}

#[derive(Serialize, Deserialize, Debug)]
#[serde(untagged)]
enum InputData {
    IdInput(IdInput),
    TransactionListByAccountIdInput(TransactionListByAccountIdInput),
}

use futures::StreamExt;

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
            Some(Some(global_state)) => serde_json::to_string_pretty(global_state).unwrap(),
            _ => "".to_string(),
        });
        log!("Home / global_state_json memo / json: {:#?}", json);

        json
    });

    let (row_count, set_row_count) = create_signal(1);

    let (explorer_backend_host, set_explorer_backend_host) =
        create_signal("explorer-backend-mainnet-prod-24ktefolwq-uc.a.run.app".to_string());

    let response = create_resource(
        move || (row_count.get(), explorer_backend_host.get()),
        |(row_count, explorer_backend_host)| async move {
            log!("async_data resource");

            if row_count > 1 {
                let load_page = |cursor: Option<TransactionCursor>| async {
                    let input_obj: HashMap<String, InputData> = HashMap::from_iter(vec![
                        (
                            "0".to_string(),
                            InputData::IdInput(IdInput {
                                id: "i574n.near".to_string(),
                            }),
                        ),
                        (
                            "1".to_string(),
                            InputData::IdInput(IdInput {
                                id: "i574n.near".to_string(),
                            }),
                        ),
                        (
                            "2".to_string(),
                            InputData::TransactionListByAccountIdInput(
                                TransactionListByAccountIdInput {
                                    account_id: "i574n.near".to_string(),
                                    limit: 100,
                                    cursor: cursor,
                                },
                            ),
                        ),
                    ]);

                    let input_json = serde_json::to_string(&input_obj).unwrap();
                    let input = js_sys::encode_uri_component(&input_json);
                    let url = format!("https://{}/trpc/account.transactionsCount,contract.byId,transaction.listByAccountId?batch=1&input={}", explorer_backend_host, input);

                    let json = reqwest_wasm::Client::builder()
                        .build()
                        .unwrap()
                        .get(url)
                        .send()
                        .await
                        .unwrap()
                        .text()
                        .await
                        .unwrap();

                    let obj: Vec<ResultWrapper> = serde_json::from_str(&json).unwrap();

                    obj
                };

                let transactions =
                    futures::stream::unfold((0, None), |(page_index, cursor)| async move {
                        match (page_index, cursor) {
                            (page_index, None) if page_index > 0 => None,
                            (page_index, cursor) => {
                                let page = load_page(cursor).await;
                                let transaction_list = page.iter().find_map(|result_wrapper| {
                                    result_wrapper
                                        .result
                                        .as_ref()
                                        .map(|result| match &result.data {
                                            ResultData::TransactionListByAccountId(
                                                transaction_list_by_account_id,
                                            ) => Some(transaction_list_by_account_id),
                                            _ => None,
                                        })
                                        .flatten()
                                });

                                match transaction_list {
                                    Some(transaction_list) => {
                                        let next_cursor = if transaction_list.items.is_empty() {
                                            None
                                        } else {
                                            transaction_list.cursor.clone()
                                        };
                                        Some((
                                            futures::stream::iter(transaction_list.items.clone()),
                                            (page_index + 1, next_cursor),
                                        ))
                                    }
                                    _ => None,
                                }
                            }
                        }
                    })
                    .flatten()
                    .collect::<Vec<_>>()
                    .await;

                let obj_json = serde_json::to_string_pretty(&transactions).unwrap();

                Some(obj_json)
            } else {
                None
            }
        },
    );

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
                                        class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200 text-left text-xs"
                                    >
                                        global_state: <pre>{move || global_state_json}</pre>
                                    </td>
                                    <td
                                        class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200 text-left text-xs"
                                    >
                                        <pre>{move || match response.get() {
                                            None => "loading...".to_string(),
                                            Some(None) => "None".to_string(),
                                            Some(Some(text)) => text,
                                        }}</pre>
                                    </td>
                                    <td
                                        class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                                    >
                                        <input
                                            prop:value=explorer_backend_host
                                            on:keyup={move |event: web_sys::KeyboardEvent| {
                                                set_explorer_backend_host(event_target_value(&event));
                                            }}
                                        />
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
