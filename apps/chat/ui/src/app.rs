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

#[component]
fn Home() -> impl IntoView {
    let (row_count, set_row_count) = create_signal(1);
    let (dark_mode, set_dark_mode) = create_signal(true);

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
