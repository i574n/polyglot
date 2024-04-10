import * as crypto from "crypto"
import * as path from "path"
import * as fs from "fs"

const fileExists = async (path: string) => !!(await fs.promises.stat(path).catch((_e) => false))

const sleep = async (ms: number) => new Promise((resolve) => setTimeout(resolve, ms))

export const getFileTokenRange = async (targetDir: string, text: string) => {
  const hash = crypto.createHash("sha256")
  hash.update(text, "utf8")
  const hashHex = hash.digest("hex")

  const codeDir = path.join(targetDir, "packages", hashHex)

  if (!(await fileExists(codeDir))) {
    fs.mkdirSync(codeDir, { recursive: true })
  }

  const codeFile = path.join(codeDir, "main.spi")
  const tokensFile = path.join(codeDir, "tokens.json")

  console.log(`supervisor.getFileTokenRange / codeDir: ${codeDir}`)

  if (!(await fileExists(codeFile))) {
    await fs.promises.writeFile(codeFile, text, "utf8")
  }

  const timeout = 4000
  const start = Date.now()
  let tokensText = "[]"
  const elapsed = Date.now() - start
  while (elapsed < timeout) {
    if (await fileExists(tokensFile)) {
      tokensText = await fs.promises.readFile(tokensFile, "utf8")
      break
    }
    await sleep(60)
  }
  console.log(`supervisor.getFileTokenRange / elapsed: ${Date.now() - start}`)

  const tokens = new Uint32Array(JSON.parse(tokensText))

  return tokens
}
