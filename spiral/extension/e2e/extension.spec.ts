import { test, expect } from "./fixtures"

test("popup localhost", async ({ page }) => {
  await page.goto("http://localhost:3000/popup")
  await expect(page.locator("body")).toHaveText("Loading...")
})

test("popup extension", async ({ page, extensionId }) => {
  await page.goto(`chrome-extension://${extensionId}/popup.html`)
  await expect(page.locator("body")).toHaveText("Loading...")
})
