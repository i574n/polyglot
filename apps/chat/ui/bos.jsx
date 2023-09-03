State.init({
    n1: 0,
    n2: 0,
})

const code = `
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <script type="module">
        console.log('## 1');
        import 'https://i574n.github.io/polyglot/apps/chat/ui/dist/rna/1-W2C24UHG.js'
    </script>
    <link rel="icon" href="https://i574n.github.io/polyglot/apps/chat/ui/dist/rna/favicon-f1d578da7a480441.ico">
    <link rel="stylesheet" href="https://i574n.github.io/polyglot/apps/chat/ui/dist/rna/tailwind-d7bed9dea032553d-SXGQQNWX.css">
    <link rel="stylesheet" href="https://i574n.github.io/polyglot/apps/chat/ui/dist/rna/components-61317960c9987b2e-YWB32TZ5.css">
    <base href="https://i574n.github.io/polyglot/apps/chat/ui/dist/rna/">
    <title>ui</title>
    <link rel="preload" href="https://i574n.github.io/polyglot/apps/chat/ui/dist/rna/chat-354387c45f6dd069_bg.wasm" as="fetch" type="application/wasm" crossorigin="">

    <script type="text/javascript">
        console.log('## 2');
        window.top.postMessage("loaded", "*");
        window.addEventListener("message", async (event) => {
            console.log('## 3',{event});
            event.source.postMessage({n2:event.data.n1*2}, "*");
        }, false);
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
            onChange={(e) => {
                console.log("## 4", { e })
                State.update({ n1: Number(e.target.value) || 0 })
            }}
        />
        <div>
            <iframe
                className="w-100"
                srcDoc={code}
                message={{ n1: state.n1 }}
                onMessage={(state) => {
                    console.log("## 5 ", state)
                    if (typeof state === "object") {
                        State.update({ n2: state.n2 })
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
