use std::collections::HashMap;

use crate::state::{State, *};

use leptos::{logging::log, *};
use leptos_meta::*;
use leptos_router::*;

#[component]
pub fn App(window: &'static web_sys::Window) -> impl IntoView {
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
                <Route path="" view= move || view! { <div><Home window /><span style="display: none">1</span></div> }/>
                <Route path="/" view= move || view! { <div><Home window /><span style="display: none">2</span></div> }/>
                <Route path="#" view= move || view! { <div><Home window /><span style="display: none">3</span></div> }/>
                <Route path="?" view= move || view! { <div><Home window /><span style="display: none">4</span></div> }/>
                <Route path="/*" view= move || view! { <div><Home window /><span style="display: none">5</span></div> }/>
                <Route path="***" view= move || view! { <div><Home window /><span style="display: none">6</span></div> }/>
                <Route path="**" view= move || view! { <div><Home window /><span style="display: none">7</span></div> }/>
                <Route path="*" view= move || view! { <div><Home window /><span style="display: none">8</span></div> }/>
            </Routes>
        </Router>
    }
}

pub fn use_location_host(window: &'static web_sys::Window) -> (String, String, String) {
    let location = window.location();
    let protocol = location.protocol().unwrap();
    let host = location.host().unwrap();
    let port = location.port().unwrap();

    let result = (protocol, host, port);
    log!(
        "app:use_location_host () / result: {:#?}",
        result
    );

    result
}

#[component]
fn Home(window: &'static web_sys::Window) -> impl IntoView {
    log!("Home ()");

    let (_protocol, host, _port) = use_location_host(window);

    match host.as_str() {
        "libgen.is" => crate::timer::run(window).unwrap(),
        _ => ()
    }

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

    view! {
        <>
            {(|| {
                log!("Home () / render1");
                view! {<></>}
            })()}
            <MessagesProcessor window />
            {(|| {
                log!("Home () / render2");
                view! {<></>}
            })()}
            <div class:dark={move || global_state2.clone().unwrap().state.get().dark_mode.get()}>
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

                                    </td>
                                    <td
                                        class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                                    >

                                    </td>
                                    <td
                                        class="whitespace-nowrap px-4 py-2 text-gray-700 dark:text-gray-200"
                                    >
                                        ?
                                    </td>
                                </tr>

                                <For
                                    each=move || 0..1
                                    key=|i| *i
                                    let:i
                                >
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

                                                    </span>
                                                }
                                            } else {
                                                view! {
                                                    <span></span>
                                                }
                                            }}
                                        </td>
                                    </tr>
                                </For>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </>
    }
}
