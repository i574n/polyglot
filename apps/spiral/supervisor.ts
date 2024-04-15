import * as crypto from "../../lib/spiral/crypto"
import * as path from "path"
import * as fs from "fs"

const fileExists = async (path: string) => !!(await fs.promises.stat(path).catch((_e) => false))

const sleep = async (ms: number) => new Promise((resolve) => setTimeout(resolve, ms))

export function throttle<T extends (...args: any[]) => Promise<U>, U>(func: T, limit: number) {
  let inThrottle: boolean
  let lastResult: U

  return async function (...args: Parameters<T>) {
    if (!inThrottle) {
      inThrottle = true
      lastResult = await func(...args)
      setTimeout(() => (inThrottle = false), limit)
      return lastResult
    }
    return lastResult
  }
}

export const getFileTokenRange = async (repositoryRoot: string, text: string) => {
  const targetDir = path.join(repositoryRoot, 'target/polyglot/spiral_eval')
  if (!fs.existsSync(targetDir)) {
      fs.mkdirSync(targetDir, { recursive: true })
  }

  const hashHex = crypto.hash_text(text)

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
