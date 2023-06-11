const isExtension = typeof chrome.runtime !== 'undefined';

console.log('service_worker.ts / isExtension:', isExtension);

self.onmessage = async (event) => {
    console.log('service_worker.ts / onmessage / event:', event);
}

chrome.runtime.onInstalled.addListener(() => {
    console.log('service_worker.ts / chrome.runtime.onInstalled');
});

// const sendBackMessage = (tabId, data) => new Promise(resolve => chrome.runtime.sendMessage(tabId, data, (response) => resolve(response)));

chrome.runtime.onMessage.addListener((request, sender, sendResponse) => {
    console.log('service_worker.js / onMessage / request:', request, '/ sender:', sender);
});
