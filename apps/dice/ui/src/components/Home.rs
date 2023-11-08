use std::collections::HashMap;

use crate::components::DarkModeButton::*;
use crate::near::backend::*;
use crate::near::rpc::*;
use crate::state::*;

use leptos::{logging::log, *};

use futures::StreamExt;

#[component]
pub fn Home(router: i32) -> impl IntoView {
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
                    .map_err(|err| err.to_string())?
                    .text()
                    .await
                    .map_err(|err| err.to_string())?;

                log!(
                    "Home () / response create_local_resource / json: {:?}",
                    json
                );

                let obj: Vec<ResultWrapper> = serde_json::from_str(&json).unwrap();

                Ok::<Vec<ResultWrapper>, String>(obj)
            };

            let transactions =
                futures::stream::unfold((0, None), |(page_index, cursor)| async move {
                    match (page_index, cursor) {
                        (page_index, None) if page_index > 0 => None,
                        (page_index, cursor) => {
                            let page = load_page(cursor).await;
                            match page {
                                Ok(page) => {
                                    // let _transaction_list = page
                                    //     .iter()
                                    //     .map(|result_wrapper| match result_wrapper {
                                    //         ResultWrapper {
                                    //             result:
                                    //                 Some(DataWrapper {
                                    //                     data:
                                    //                         ResultData::TransactionListByAccountId(
                                    //                             transaction_list_by_account_id,
                                    //                         ),
                                    //                 }),
                                    //             ..
                                    //         } => Ok(transaction_list_by_account_id),
                                    //         _ => Err("transaction".to_string()),
                                    //     })
                                    //     .collect::<Vec<_>>();

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
                                                futures::stream::iter(
                                                    transaction_list.items.clone(),
                                                ),
                                                (page_index + 1, next_cursor),
                                            ))
                                        }
                                        _ => None,
                                    }
                                }
                                Err(err) => {
                                    log!(
                                        "Home () / response create_local_resource / err: {:?}",
                                        err
                                    );

                                    None
                                }
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
            <div class="flex" class:dark={move || global_state2.clone().unwrap().state.get().dark_mode.get()}>
                <DarkModeButton />
                <div class="min-h-screen min-w-full bg-gray-50 dark:bg-gray-900">
                    <div class="">
                        <div
                            class="text-gray-700 dark:text-gray-200 text-xs"
                        >
                            global_state: <pre>{move || global_state_json}</pre>
                        </div>
                        <div
                            class="text-gray-700 dark:text-gray-200 text-xs"
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
                                                        {
                                                            transaction.actions.iter().map(|action|match action {
                                                                    | TransactionAction::FunctionCall(FunctionCallArgs { args, method_name, .. }) => {
                                                                        let args : Vec<u8> = base64::Engine::decode(&base64::engine::general_purpose::STANDARD, args).unwrap();
                                                                        let args_str = std::str::from_utf8(&args).unwrap();
                                                                        Some(format!("method_name: {} / args: {}", method_name, args_str))
                                                                    },
                                                                    | _ => None
                                                                }).flatten().collect::<Vec<_>>()
                                                        }
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
                                                                    {status.result.as_ref().unwrap().receipts_outcome.iter().map(|outcome| {

                                                                            let status = &outcome.outcome.status;
                                                                            let value = status.get("SuccessValue").unwrap().to_owned();

                                                                            let value = base64::Engine::decode(&base64::engine::general_purpose::STANDARD, value).unwrap();
                                                                            let value_str = std::str::from_utf8(&value).unwrap();
                                                                            Some(format!("value: {}", value_str))
                                                                        }).flatten().collect::<Vec<_>>()}
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
                            class="text-gray-700 dark:text-gray-200"
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
