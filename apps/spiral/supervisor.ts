import * as crypto from "../../lib/spiral/crypto"
import * as path from "path"
import * as fs from "fs"

import * as list from '../../deps/Fable/src/fable-library-ts/List';
import * as array from '../../deps/Fable/src/fable-library-ts/Array';
import * as double from '../../deps/Fable/src/fable-library-ts/Double';
import * as seq from '../../deps/Fable/src/fable-library-ts/Seq';
import * as core from '../../deps/Fable/src/fable-library-ts/FSharp.Core';

export const _FSharpList = () => list.FSharpList;
export const _array_map = () => array.map;
export const _double_max = () => double.max;
export const _seq = () => seq.ofSeq;
export const _core = () => core.Operators_NullArg;

const fileExists = async (path: string) => !!(await fs.promises.stat(path).catch((_e) => false))

const sleep = async (ms: number) => new Promise((resolve) => setTimeout(resolve, ms))

export function throttle<T extends (...args: Parameters<T>) => Promise<Awaited<ReturnType<T>>>>(
  func: T,
  limit: number
) {
  let inThrottle = false
  let lastResult: Awaited<ReturnType<T>>
  let timeoutId: ReturnType<typeof setTimeout>

  return async function (...args: Parameters<T>): Promise<Awaited<ReturnType<T>>> {
    if (!inThrottle) {
      inThrottle = true
      try {
        lastResult = await func(...args)
      } catch (ex) {
        console.error(`throttle / ex: ${ex}`)
        inThrottle = false
        clearTimeout(timeoutId)
        throw ex
      }
      timeoutId = setTimeout(() => (inThrottle = false), limit)
    }
    return lastResult
  }
}

export const getFileTokenRange = async (workspaceRoot: string, text: string) => {
  const targetDir = path.join(workspaceRoot, "target/polyglot/spiral_eval")
  if (!fs.existsSync(targetDir)) {
    fs.mkdirSync(targetDir, { recursive: true })
  }

  const hashHex = crypto.hash_text(text)

  const codeDir = path.join(targetDir, "tokens", hashHex)

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
  while (Date.now() - start < timeout) {
    if (await fileExists(tokensFile)) {
      const text = await fs.promises.readFile(tokensFile, "utf8")
      if (text.length > 0) {
        tokensText = text
        break
      }
    }
    await sleep(60)
  }
  console.log(`supervisor.getFileTokenRange / elapsed: ${Date.now() - start} / tokensText.length: ${tokensText.length}`)

  const tokens = new Uint32Array(JSON.parse(tokensText))

  return tokens
}
