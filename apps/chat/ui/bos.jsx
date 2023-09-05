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

        import 'https://bafybeidsazlal2qmzpixkwu6lewggm2mrhrvevyclxr67b2cxc545j3foe.ipfs.nftstorage.link/ipfs/bafybeidsazlal2qmzpixkwu6lewggm2mrhrvevyclxr67b2cxc545j3foe/1-3WEHGJYN.js'

    </script>
    <link rel="icon" href="https://i574n.github.io/polyglot/apps/chat/ui/dist/rna/favicon-f1d578da7a480441.ico">
    <link rel="stylesheet" href="https://i574n.github.io/polyglot/apps/chat/ui/dist/rna/tailwind-393535d1fac25469-3TT2HZOJ.css">
    <link rel="stylesheet" href="https://i574n.github.io/polyglot/apps/chat/ui/dist/rna/components-61317960c9987b2e-YWB32TZ5.css">

    <base href="https://bafybeidsazlal2qmzpixkwu6lewggm2mrhrvevyclxr67b2cxc545j3foe.ipfs.nftstorage.link/ipfs/bafybeidsazlal2qmzpixkwu6lewggm2mrhrvevyclxr67b2cxc545j3foe/">

    <title>ui</title>

    <link rel="preload" href="https://bafybeidsazlal2qmzpixkwu6lewggm2mrhrvevyclxr67b2cxc545j3foe.ipfs.nftstorage.link/ipfs/bafybeidsazlal2qmzpixkwu6lewggm2mrhrvevyclxr67b2cxc545j3foe/chat-8438635bfa340716_bg.wasm" as="fetch" type="application/wasm" crossorigin="">

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
            console.log('## 4', event.data, { event })
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
                        const newInnerMessages = (state.innerMessages || []).map(([id, message]) => {
                            if (message.SetN2) {
                                State.update({ n2: message.SetN2.n })
                                return [id, null]
                            } else {
                                return [id, message]
                            }
                        })
                        const innerMessages = newInnerMessages.filter(([_, message]) => message)
                        const oldIds = new Set(newInnerMessages.filter(([_, message]) => !message).map(([id, _]) => id))
                        const outerMessages = (state.outerMessages || []).filter(([id, _]) => !oldIds.has(id))
                        State.update({ outerMessages, innerMessages })
                    }
                }}
            />
        </div>
        <pre>
            state = {JSON.stringify(state)}
            context = {JSON.stringify(context)}
        </pre>
    </div>
)
