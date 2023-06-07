import * as extension from "./pkg/extension";
import wasm from "./pkg/extension_bg.wasm";

console.log('service_worker.ts');

const isExtension = typeof chrome.runtime !== 'undefined';

self.onmessage = async (event) => {
    console.log('service_worker.ts / onmessage / event:', event);
    //     const wasmBuffer = Uint8Array.from(atob(String(event.data)), c => c.charCodeAt(0));
    //     const module = await WebAssembly.compile(wasmBuffer);
    //     const instance = await WebAssembly.instantiate(module);
    //     // Send the instance exports back to the main thread
    //     postMessage(instance.exports);
}

chrome.runtime.onInstalled.addListener(() => {
    console.log('service_worker.ts / chrome.runtime.onInstalled');
});

// const sendBackMessage = (tabId, data) => new Promise(resolve => chrome.runtime.sendMessage(tabId, data, (response) => resolve(response)));

chrome.runtime.onMessage.addListener((request, sender, sendResponse) => {
    console.log('service_worker.js / onMessage / request:', request, '/ sender:', sender);

    if (request.wasm) {
        const wasmUrl = isExtension ? chrome.runtime.getURL(wasm) : wasm;

        (async () => {
            const wasmRequest = fetch(wasmUrl);
            const exports = await extension.default(wasmRequest);

            console.log('service_worker.js / exports', exports);

            // await sendBackMessage(sender.tab.id, { exports });

            sendResponse({ exports });
        })();



        // const response = await fetch(wasmUrl);
        // const bytes = await response.arrayBuffer();
        // // const module = await WebAssembly.compile(buffer);
        // await extension.default(bytes);


        // const buffer = Uint8Array.from(Object.values(request.wasm.buffer));
        // // const wasmModule = new WebAssembly.Module(wasmBuffer);
        // const module = await WebAssembly.compile(buffer);
        // const instance = await WebAssembly.instantiate(module, request.wasm.imports);

        // console.log('service_worker.js / instance', instance);

        // sendResponse({ exports });


        // chrome.tabs.sendMessage(sender.tab.id, { exports });

        // console.log('service_worker.js / wasmUrl', {wasmUrl, response, lastError: chrome.runtime.lastError});

        return true;
    }
});
