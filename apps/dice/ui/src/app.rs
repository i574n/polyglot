use std::collections::HashMap;

use crate::components::Home::*;
use crate::state::{State, *};

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
