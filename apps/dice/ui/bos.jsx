const newId = () => Math.floor(99999999999999999 * Math.random())

State.init({
    s1: "",
    s2: "",
    outerMessages: [
        [newId(), { SetAccountId: { account_id: context.accountId || "" } }],
        [newId(), { SetNetworkId: { network_id: context.networkId || "" } }],
    ],
    innerMessages: [],
})

const code = `
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <script type="module">
        console.log('## 1')

        // import 'https://local.near.org:5000/1-IST6ACLQ.js'
        import 'https://bafybeibujudaihiybcyynd34w6exdx523h7ju5xenvfax7gt66aw5nw5ui.ipfs.nftstorage.link/ipfs/bafybeibujudaihiybcyynd34w6exdx523h7ju5xenvfax7gt66aw5nw5ui/1-IST6ACLQ.js'

    </script>
    <link rel="stylesheet" href="https://bafybeih3tjkulzcrecyrw3szw4yv7unq3mv6p6jqrihujoljpdmsp6rdcm.ipfs.nftstorage.link/ipfs/bafybeih3tjkulzcrecyrw3szw4yv7unq3mv6p6jqrihujoljpdmsp6rdcm/tailwind-d7bed9dea032553d-SXGQQNWX.css">
    <link rel="stylesheet" href="https://bafybeih3tjkulzcrecyrw3szw4yv7unq3mv6p6jqrihujoljpdmsp6rdcm.ipfs.nftstorage.link/ipfs/bafybeih3tjkulzcrecyrw3szw4yv7unq3mv6p6jqrihujoljpdmsp6rdcm/components-61317960c9987b2e-YWB32TZ5.css">

    <!-- <base href="https://local.near.org:5000/"> -->
    <base href="https://bafybeibujudaihiybcyynd34w6exdx523h7ju5xenvfax7gt66aw5nw5ui.ipfs.nftstorage.link/ipfs/bafybeibujudaihiybcyynd34w6exdx523h7ju5xenvfax7gt66aw5nw5ui/">

    <title>ui</title>

    <!-- <link rel="preload" href="https://local.near.org:5000/chat-1730b9add8ed355c_bg.wasm" as="fetch" type="application/wasm" crossorigin=""> -->
    <link rel="preload" href="https://bafybeibujudaihiybcyynd34w6exdx523h7ju5xenvfax7gt66aw5nw5ui.ipfs.nftstorage.link/ipfs/bafybeibujudaihiybcyynd34w6exdx523h7ju5xenvfax7gt66aw5nw5ui/chat-1730b9add8ed355c_bg.wasm" as="fetch" type="application/wasm" crossorigin="">

    <script type="text/javascript">

        console.log('## 2')
        window.top.postMessage("loaded", "*")

        let messageCount = 0
        let retryCount = 0
        window.addEventListener("message", async (event) => {
            console.log('## 3', JSON.stringify(event.data), { event })

            while (true) {
                try {
                    if (retryCount > 0 && messageCount === 0) {
                        await new Promise((resolve) => setTimeout(() => resolve(), 60))
                    }
                    if (event.data.outerMessages.length) {
                        await set_outer_messages_state(JSON.stringify(event.data.outerMessages))
                    }
                    if (event.data.innerMessages) {
                        await set_inner_messages_state(JSON.stringify(event.data.innerMessages))
                    }
                    messageCount++
                } catch (e) {
                    retryCount++
                    console.log('message error:', e, 'retryCount:', retryCount)
                }
                if (messageCount > 0) {
                    break;
                }
            }
        }, false)

        async function setOuterMessagesAsync(messagesJson) {
            console.log('## 4', JSON.stringify((event || {}).data), messagesJson, event)
            window.top.postMessage({ outerMessages: JSON.parse(messagesJson) }, "*")
            return \`setOuterMessages / messagesJson: '\${messagesJson}'\`
        }
        async function setInnerMessagesAsync(messagesJson) {
            console.log('## 5', JSON.stringify((event || {}).data), messagesJson, event)
            window.top.postMessage({ innerMessages: JSON.parse(messagesJson) }, "*")
            return \`setInnerMessages / messagesJson: '\${messagesJson}'\`
        }
        function setOuterMessages(messagesJson) {
            console.log('## 4.1', JSON.stringify((event || {}).data), messagesJson, event)
            window.top.postMessage({ outerMessages: JSON.parse(messagesJson) }, "*")
            return \`setOuterMessages / messagesJson: '\${messagesJson}'\`
        }
        function setInnerMessages(messagesJson) {
            console.log('## 5.1', JSON.stringify((event || {}).data), messagesJson, event)
            window.top.postMessage({ innerMessages: JSON.parse(messagesJson) }, "*")
            return \`setInnerMessages / messagesJson: '\${messagesJson}'\`
        }
    </script>
</head>
<body>
</body>
</html>
`

return (
    <div>
        <input
            value={state.s1}
            onChange={(event) => {
                console.log("## 6", JSON.stringify(event.data), { event })
                const s = event.target.value || ""
                State.update({
                    s1: s,
                    outerMessages: [...state.outerMessages, [newId(), { SetS1: { s } }]],
                })
            }}
        />
        <pre className="rbt-close-sm m-0">
            state = {JSON.stringify(state)}
            dark-mode = {Storage.get("dark-mode")}
            context = {JSON.stringify(context)}
        </pre>
        <iframe
            className="w-100 min-vh-100"
            srcDoc={code}
            message={{
                outerMessages: state.outerMessages,
                innerMessages: state.innerMessages,
            }}
            onMessage={(messages) => {
                console.log("## 7", JSON.stringify(messages))
                if (typeof messages === "object") {
                    const newMessages = [...state.innerMessages, ...(messages.innerMessages || [])].map(
                        ([id, message]) => {
                            if (message.SetS2) {
                                State.update({ s2: message.SetS2.s })
                                return [[id, null], []]
                            } else if (message.SetStorage) {
                                Storage.set(message.SetStorage.key, message.SetStorage.value)
                                return [[id, null], []]
                            } else if (message.GetStorage) {
                                const value = Storage.get(message.GetStorage.key)
                                const outerMessage = { SetStorage: { key: message.GetStorage.key, value } }
                                return [[id, null], [[newId(), outerMessage]]]
                            } else if (message === "Ack") {
                                return [[id, null], []]
                            } else {
                                return [[id, message], []]
                            }
                        }
                    )
                    const newInnerMessages = newMessages.map(([message, _]) => message)
                    const innerMessages = newInnerMessages.filter(([_, message]) => message)
                    const oldIds = new Set(newInnerMessages.filter(([_, message]) => !message).map(([id, _]) => id))
                    const newOuterMessages = newMessages.flatMap(([_, messages]) => messages)
                    const outerMessages = [...state.outerMessages, ...(messages.outerMessages || [])]
                        .filter(([id, _]) => !oldIds.has(id))
                        .concat(newOuterMessages)
                    console.log("## 8", JSON.stringify({ outerMessages, innerMessages }))
                    State.update({ outerMessages, innerMessages })
                }
            }}
        />
    </div>
)
