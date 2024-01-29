# dice_contract

```ps1
near call i574n.near new --accountId=i574n.near
near deploy --accountId=i574n.near --wasmFile=dist/dice.wasm
```

```ps1
$env:NEAR_ENV = "mainnet"
near call i574n.near generate_random_number --accountId=i574n.near --args="{\`"key\`": \`"\`", \`"proof\`": \`"\`", \`"max\`": 1}" --gas 40000000000000

```
