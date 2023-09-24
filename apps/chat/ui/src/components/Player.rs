use leptos::{logging::log, *};

#[component]
pub fn Player() -> impl IntoView {
    log!("Player ()");

    view! {
        <div>
            <video id="video" controls preload="metadata" crossorigin="anonymous">
                <source src="https://bafybeiffucxniuwm2k4rufmn3qvcfxuc3jdqawrzuvtdqxyikgw7nt2dne.ipfs.nftstorage.link/sintel-short.mp4" type="video/mp4" />
                <track label="English" kind="subtitles" srclang="en" src="https://bafybeiffucxniuwm2k4rufmn3qvcfxuc3jdqawrzuvtdqxyikgw7nt2dne.ipfs.nftstorage.link/sintel-en.vtt" default />
            </video>
        </div>
    }
}
