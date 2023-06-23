/// <reference types="chrome"/>

// import * as chrome from "chrome"
// declare const chrome: any

function getBrowserInstance() {
  return chrome || (window as any).browser
}

const isExtension = typeof getBrowserInstance().runtime !== "undefined"

console.log("service_worker.ts / isExtension:", isExtension)

self.onmessage = async (event) => {
  console.log("service_worker.ts / onmessage / event:", event)
}

function stringToId(str: string): number {
  let hash = 42
  for (let i = 0; i < str.length; i++) {
    hash = (hash << 5) + hash + str.charCodeAt(i)
  }
  return Math.round(Math.abs(hash / 4))
}

function generateUnblockRule(filter: string): chrome.declarativeNetRequest.Rule {
  return {
    id: stringToId(filter),
    priority: 1,
    action: {
      type: chrome.declarativeNetRequest.RuleActionType.MODIFY_HEADERS,
      responseHeaders: [
        { header: "x-frame-options", operation: chrome.declarativeNetRequest.HeaderOperation.REMOVE },
        { header: "content-security-policy", operation: chrome.declarativeNetRequest.HeaderOperation.REMOVE },
      ],
    },
    condition: {
      urlFilter: `*${filter}*`,
      resourceTypes: [
        chrome.declarativeNetRequest.ResourceType.MAIN_FRAME,
        chrome.declarativeNetRequest.ResourceType.SUB_FRAME,
      ],
    },
  }
}

chrome.runtime.onInstalled.addListener(() => {
  console.log("service_worker.ts / chrome.runtime.onInstalled")
})

chrome.runtime.onMessage.addListener((request, sender, sendResponse) => {
  console.log("service_worker.js / onMessage / request:", request, "/ sender:", sender)

  if (request.message && request.message.includes("WebAssembly")) {
    let filter = sender.url || sender.tab?.url || sender.origin || ""
    const matches = filter.match(/^https?\:\/\/([^\/?#]+)(?:[\/?#]|$)/i)
    filter = (matches && matches[1]) || ""
    if (!filter) {
      console.log("service_worker.js / onMessage / no filter")
    } else {
      ;(async () => {
        const rule = generateUnblockRule(filter)

        await chrome.declarativeNetRequest.updateDynamicRules({ addRules: [rule] })

        if (chrome.runtime.lastError) {
          console.log(
            "service_worker.js / onMessage / updateDynamicRules / rule:",
            rule,
            "/ error:",
            chrome.runtime.lastError
          )
        } else {
          console.log("service_worker.js / onMessage / updateDynamicRules / rule:", rule)
        }

        if (sender.tab?.id) {
          await chrome.tabs.reload(sender.tab.id)
        }

        sendResponse({ rule })
      })()
      return true
    }
  }
})
