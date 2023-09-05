State.init({
    n1: 0,
    n2: 0,
    outerMessages: [],
    innerMessages: [],
})

const code = `
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <script type="module">
        console.log('## 1')

        import 'https://bafybeieub4rjgkbrmxyik3w5rk7qlshog2vg2mfu2rhojsnvnmch2fqpky.ipfs.nftstorage.link/ipfs/bafybeieub4rjgkbrmxyik3w5rk7qlshog2vg2mfu2rhojsnvnmch2fqpky/1-2FJZ4R6O.js'

    </script>
    <link rel="icon" href="https://i574n.github.io/polyglot/apps/chat/ui/dist/favicon-f1d578da7a480441.ico">
    <link rel="stylesheet" href="https://i574n.github.io/polyglot/apps/chat/ui/dist/tailwind-d7bed9dea032553d-SXGQQNWX.css">
    <link rel="stylesheet" href="https://i574n.github.io/polyglot/apps/chat/ui/dist/components-61317960c9987b2e-YWB32TZ5.css">

    <base href="https://bafybeieub4rjgkbrmxyik3w5rk7qlshog2vg2mfu2rhojsnvnmch2fqpky.ipfs.nftstorage.link/ipfs/bafybeieub4rjgkbrmxyik3w5rk7qlshog2vg2mfu2rhojsnvnmch2fqpky/">

    <title>ui</title>

    <link rel="preload" href="https://bafybeieub4rjgkbrmxyik3w5rk7qlshog2vg2mfu2rhojsnvnmch2fqpky.ipfs.nftstorage.link/ipfs/bafybeieub4rjgkbrmxyik3w5rk7qlshog2vg2mfu2rhojsnvnmch2fqpky/chat-179a505a6307f144_bg.wasm" as="fetch" type="application/wasm" crossorigin="">

    <script type="text/javascript">

        console.log('## 2')
        window.top.postMessage("loaded", "*")

        let messageCount = 0
        let retryCount = 0
        window.addEventListener("message", async (event) => {
            console.log('## 3', event.data, { event })

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

        async function setInnerMessages(messagesJson) {
            console.log('## 4', (event || {}).data, { messagesJson, event })
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
            value={state.n1}
            onChange={(event) => {
                console.log("## 5", event.data, { event })
                const n = Number(event.target.value) || 0
                const id = Math.floor(999999999 * Math.random())
                State.update({
                    n1: n,
                    outerMessages: [...state.outerMessages, [id, { SetN1: { n } }]],
                })
            }}
        />
        <div>
            <iframe
                className="w-100"
                srcDoc={code}
                message={{
                    outerMessages: state.outerMessages,
                    innerMessages: state.innerMessages,
                }}
                onMessage={(state) => {
                    console.log("## 6", state)
                    if (typeof state === "object") {
                        const newMessages = (state.innerMessages || []).map(([id, message]) => {
                            if (message.SetN2) {
                                State.update({ n2: message.SetN2.n })
                                return [[id, null], []]
                            } else if (message.SetStorage) {
                                Storage.set(message.SetStorage.key, message.SetStorage.value)
                                return [[id, null], []]
                            } else if (message.GetStorage) {
                                const value = Storage.get(message.GetStorage.key)
                                const outerMessage = { SetStorage: { key: message.GetStorage.key, value } }
                                const newId = Math.floor(999999999 * Math.random())
                                return [[id, null], [[newId, outerMessage]]]
                            } else {
                                return [[id, message], []]
                            }
                        })
                        const newInnerMessages = newMessages.map(([message, _]) => message)
                        const innerMessages = newInnerMessages.filter(([_, message]) => message)
                        const oldIds = new Set(newInnerMessages.filter(([_, message]) => !message).map(([id, _]) => id))
                        const newOuterMessages = newMessages.flatMap(([_, messages]) => messages)
                        const outerMessages = (state.outerMessages || [])
                            .filter(([id, _]) => !oldIds.has(id))
                            .concat(newOuterMessages)
                        console.log("## 7", { outerMessages, innerMessages })
                        State.update({ outerMessages, innerMessages })
                    }
                }}
            />
        </div>
        <pre>
            state = {JSON.stringify(state)}
            dark-mode = {Storage.get('dark-mode')}
            context = {JSON.stringify(context)}
        </pre>
    </div>
)
