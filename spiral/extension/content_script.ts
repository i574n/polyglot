import * as extension from "./pkg/extension_bg.wasm.js";

const isExtension = typeof chrome.runtime !== 'undefined';

console.log('content_script.ts / isExtension:', isExtension);

const sendMessage = (data) => new Promise(resolve => chrome.runtime.sendMessage(data, (response) => resolve(response)));


window.onload = async () => {
    console.log('content_script.ts / window.onload');

    extension.app(window);
};

if (isExtension) {
    chrome.runtime.onMessage.addListener((request, sender, sendResponse) => {
        console.log('content_script.ts onMessage. request:', request, 'sender:', sender);
    });
}
