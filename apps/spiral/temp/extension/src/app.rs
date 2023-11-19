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
            <Home window />
        </Router>
    }
}

pub fn use_location_host(window: &'static web_sys::Window) -> (String, String, String) {
    let location = window.location();
    let protocol = location.protocol().unwrap();
    let host = location.host().unwrap();
    let port = location.port().unwrap();

    let result = (protocol, host, port);
    log!("app:use_location_host () / result: {:#?}", result);

    result
}

#[component]
fn Home(window: &'static web_sys::Window) -> impl IntoView {
    log!("Home ()");

    let (_protocol, host, _port) = use_location_host(window);

    let _cancel = match host.as_str() {
        "libgen.is" => Some(crate::js::use_interval(
            window,
            |document| {
                let _state = crate::timer::update(&document);
            },
            1000,
            Some(3600000),
        )),
        _ => None,
    };

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
        let hash = crate::leptos_dom::helpers::location_hash().unwrap_or("".to_string());
        log!(
            "Home () / window_event_listener ev::hashchange / location_hash(): {:#?}",
            hash
        );
    });

    let (location_text, set_location_text) = create_signal("".to_string());
    let set_location_text_2 = set_location_text.clone();

    create_effect(move |_| {
        let new_location_text = format_location(&location2, |url| url);
        log!("Home () / new_location_text: {:#?}", new_location_text);
        set_location_text_2.set(new_location_text);
    });

    create_effect(move |_| {
        log!(
            "Home () / router1.pathname() effect: {:#?}",
            router1.pathname().get()
        )
    });
    create_effect(move |_| {
        log!(
            "Home () / router2.possible_branches()** effect: {:#?}",
            router2.possible_branches()
        )
    });
    create_effect(move |_| log!("Home () / route_data** effect: {:#?}", route_data));
    create_effect(move |_| log!("Home () / query_map.get() effect: {:#?}", query_map.get()));
    create_effect(move |_| {
        log!(
            "Home () / params_map.get()** effect: {:#?}",
            params_map.get()
        )
    });
    create_effect(move |_| {
        log!(
            "Home () / location1.search.get() effect: {:#?}",
            location1.search.get()
        )
    });
    create_effect(move |_| log!("Home () / router3 effect: {:#?}", router3.base().path()));

    create_effect(move |_| {
        let hash = location3.hash.get();
        let hash = hash.strip_prefix('#').unwrap_or("");
        log!("Home () / location3.hash.get(): {:#?}", hash);

        {
            let hash_url = leptos_router::Url::try_from(hash);
            log!("Home () / hash_url: {:#?}", hash_url);
        }

        let json = js_sys::decode_uri_component(&hash)
            .unwrap()
            .as_string()
            .unwrap();
        log!("Home () / hash json: {:#?}", json);
    });

    let (location_href, set_location_href) = create_signal("".to_string());

    create_effect(move |_| {
        let new_location_href = window.location().href().ok().unwrap_or("".to_string());
        set_location_href.set(new_location_href.clone());

        crate::timer::set_albums().unwrap();

        log!(
            "Home () / create_effect all url changes / location4.state.get(): {:#?} / new_location_href: {:#?}",
            location4.state.get(),
            new_location_href
        );
    });

    create_effect(move |_| {
        log!(
            "Home () / location_href.get() effect: {:#?}",
            location_href.get()
        )
    });

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
                <div>
                    <input
                        prop:value={move || location_text.get()}
                        on:keyup={move |ev: web_sys::KeyboardEvent| {
                            set_location_text.set(event_target_value(&ev));
                        }}
                    />
                    <button
                        on:click=move |_| navigate(&location_text.get(), Default::default())
                    >
                        navigate
                    </button>
                </div>
                <div>
                    global_state_json: <pre>{move || global_state_json}</pre>
                </div>
            </div>
        </>
    }
}
