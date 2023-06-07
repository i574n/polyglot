import * as extension from "./pkg/extension";
import wasm from "./pkg/extension_bg.wasm";

const isExtension = typeof chrome.runtime !== 'undefined';

console.log('content_script.ts / isExtension:', isExtension);

const sendMessage = (data) => new Promise(resolve => chrome.runtime.sendMessage(data, (response) => resolve(response)));


window.onload = async () => {
    console.log('content_script.ts / window.onload');

    // const buffer = Uint8Array.from(atob(String(wasm)), c => c.charCodeAt(0));

    // const imports = extension.__wbg_get_imports();


    const wasmUrl = isExtension ? chrome.runtime.getURL(wasm) : wasm;

    const wasmRequest = fetch(wasmUrl);
    const exports = await extension.default(wasmRequest);


    // const exports = await sendMessage({ wasm: true });

    console.log('content_script.ts / exports:', exports);





    // const module = await WebAssembly.compile(wasmBuffer);
    // console.log('wasm', module, typeof module);

    // const instance = await WebAssembly.instantiate(module);
    // console.log('instance', instance, typeof instance);

    // initSync(wasm);

    // new response with application/wasm
    // const response = new Response(wasmBuffer, {
    //     headers: {
    //         "Content-Type": "application/wasm",
    //     },
    // });







    // const wasmUrl = isExtension ? chrome.runtime.getURL(wasm) : wasm;

    // // const wasmRequest = fetch(wasmUrl);
    // // await extension.default(wasmRequest);

    // const response = await fetch(wasmUrl);
    // const bytes = await response.arrayBuffer();
    // // const module = await WebAssembly.compile(buffer);
    // await extension.default(bytes);

    // // const wasmResponse = await fetch(wasmRequest);
    // // const buffer = await wasmResponse.arrayBuffer();
    // // const module = await WebAssembly.compile(buffer);
    // // extension.initSync(module)

    // extension.app(window);
};


if (isExtension) {
    chrome.runtime.onMessage.addListener((request, sender, sendResponse) => {
        console.log('content_script.ts / onMessage / request:', request, '/ sender:', sender);
    });
}
