use std::collections::HashMap;

use crate::components::DarkModeButton::*;
use crate::near::backend::*;
use crate::near::rpc::*;
use crate::state::{State, *};

use leptos::{logging::log, *};
use leptos_meta::*;
use leptos_router::*;

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
                <Route path="" view= move || view! { <Home router=1 /> }/>
                <Route path="/" view= move || view! { <Home router=2 /> }/>
                <Route path="#" view= move || view! { <Home router=3 /> }/>
                <Route path="?" view= move || view! { <Home router=4 /> }/>
                <Route path="/*" view= move || view! { <Home router=5 /> }/>
                <Route path="***" view= move || view! { <Home router=6 /> }/>
                <Route path="**" view= move || view! { <Home router=7 /> }/>
                <Route path="*" view= move || view! { <Home router=8 /> }/>
            </Routes>
        </Router>
    }
}

use futures::StreamExt;

#[component]
fn Home(router: i32) -> impl IntoView {
    log!("Home () / router: {:?}", router);

    let global_state1 = use_context::<GlobalState>();
    let global_state2 = use_context::<GlobalState>();
    let global_state_resource = create_local_resource(
        move || global_state1.clone(),
        |global_state| async move {
            log!("Home () / global_state_resource create_local_resource");
            global_state
        },
    );

    let global_state_json = create_memo(move |_| {
        let json = global_state_resource.with(|global_state| match global_state {
            Some(Some(global_state)) => serde_json::to_string_pretty(global_state).unwrap(),
            _ => "".to_string(),
        });
        log!(
            "Home () / global_state_json create_memo / json: {:#?}",
            json
        );

        json
    });

    let (explorer_backend_host, set_explorer_backend_host) =
        create_signal("explorer-backend-mainnet-prod-24ktefolwq-uc.a.run.app".to_string());

    let response = create_local_resource(
        move || explorer_backend_host.get(),
        |explorer_backend_host| async move {
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

                log!(
                    "Home () / response create_local_resource / json: {:?}",
                    json
                );

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

            let transactions = transactions.into_iter().take(4).collect::<Vec<_>>();

            let transactions_json = serde_json::to_string_pretty(&transactions).unwrap();

            log!(
                "Home () / response create_local_resource / transactions_json: {:?}",
                transactions_json
            );

            transactions
        },
    );

    view! {
        <>
            {(|| {
                log!("Home () / render1");
                view! {<></>}
            })()}
            <MessagesProcessor />
            {(|| {
                log!("Home () / render2");
                view! {<></>}
            })()}
            <div class:dark={move || global_state2.clone().unwrap().state.get().dark_mode.get()}>
                <DarkModeButton />
                <div class="min-h-screen w-full bg-gray-50 dark:bg-gray-900">
                    <div class="my-0 mx-auto max-w-3xl text-center">
                        <div
                            class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200 text-left text-xs"
                        >
                            global_state: <pre>{move || global_state_json}</pre>
                        </div>
                        <div
                            class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200 text-left text-xs"
                        >
                            // <pre>{move || match response.get() {
                            //     None => "loading...".to_string(),
                            //     Some(None) => "None".to_string(),
                            //     Some(Some(text)) => text,
                            // }}</pre>
                            {move || match response.get() {
                                None => view! { <>{"loading...".to_string()}</> },
                                Some(transactions) => view! { <>
                                    <div class="flex">
                                        <div>
                                            transactions:
                                        </div>
                                        <div>
                                            <For
                                                each=move || transactions.clone()
                                                key=|transaction| transaction.hash.to_owned()
                                                let:transaction
                                            >
                                                <div class="flex">
                                                    <pre>
                                                        {{
                                                            let x = transaction.actions.iter().map(|action|match action {
                                                                    | crate::app::TransactionAction::FunctionCall(FunctionCallArgs { args, method_name, .. }) => {
                                                                        let args : Vec<u8> = base64::Engine::decode(&base64::engine::general_purpose::STANDARD, args).unwrap();
                                                                        let args_str = std::str::from_utf8(&args).unwrap();
                                                                        Some(format!("method_name: {} / args: {}", method_name, args_str))
                                                                    },
                                                                    | _ => None
                                                                }).flatten().collect::<Vec<_>>();
                                                            x
                                                        }}
                                                        {format!("transaction: {:#?}", transaction.clone())}
                                                    </pre>
                                                    <div class="flex">
                                                        <div>
                                                            transaction status:
                                                        </div>
                                                        <div>
                                                            <Await
                                                                future=move || fetch_transaction_status(transaction.hash.to_owned())
                                                                let:status
                                                            >
                                                                <pre>
                                                                    {{
                                                                        let x = status.result.as_ref().unwrap().receipts_outcome.iter().map(|outcome| {

                                                                            let status = &outcome.outcome.status;
                                                                            let value = status.get("SuccessValue").unwrap().to_owned();

                                                                            let value = base64::Engine::decode(&base64::engine::general_purpose::STANDARD, value).unwrap();
                                                                            let value_str = std::str::from_utf8(&value).unwrap();
                                                                            Some(format!("value: {}", value_str))
                                                                        }).flatten().collect::<Vec<_>>();
                                                                        x
                                                                    }}
                                                                    {format!("status: {:#?}", status)}
                                                                    // {status.result.as_ref().map(|result|format!("receipts_outcome: {:#?}", result.receipts_outcome))}
                                                                </pre>
                                                            </Await>
                                                        </div>
                                                    </div>
                                                </div>
                                            </For>
                                        </div>
                                    </div>
                                </> },
                            }}
                        </div>
                        <div
                            class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                        >
                            <input
                                class="bg-gray-50 dark:bg-gray-900"
                                prop:value=explorer_backend_host
                                on:keyup={move |event: web_sys::KeyboardEvent| {
                                    set_explorer_backend_host(event_target_value(&event));
                                }}
                            />
                        </div>
                    </div>
                </div>
            </div>
        </>
    }
}
