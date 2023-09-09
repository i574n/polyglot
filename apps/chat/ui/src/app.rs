use std::collections::HashMap;

use chat::components::DarkModeButton::*;
use chat::near::backend::*;
use chat::near::rpc::*;
use chat::state::{State, *};

use leptos::*;
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

                // let obj_json = serde_json::to_string_pretty(&transactions).unwrap();

                // Some(obj_json)

                // only the first 2
                let transactions = transactions.into_iter().take(2).collect::<Vec<_>>();

                Some(transactions)
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
                                        // <pre>{move || match response.get() {
                                        //     None => "loading...".to_string(),
                                        //     Some(None) => "None".to_string(),
                                        //     Some(Some(text)) => text,
                                        // }}</pre>
                                        {move || match response.get() {
                                            None => view! { <>{"loading...".to_string()}</> },
                                            Some(None) => view! { <>{"None".to_string()}</> },
                                            Some(Some(transactions)) => view! {
                                                <><For
                                                    each=move || transactions.clone()
                                                    key=|transaction| transaction.hash.to_owned()
                                                    view=move |transaction| view! {
                                                        <Await
                                                            future=move || fetch_transaction_status(transaction.hash.to_owned())
                                                            bind:status
                                                        >
                                                            <div>{status.result.as_ref().map(|result|result.receipts_outcome.len())
                                                            }</div>
                                                        </Await>
                                                    }
                                                /></>
                                            },
                                        }}
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
