import { test, expect } from "./fixtures"

test("popup localhost", async ({ page }) => {
  await page.goto("https://localhost:5000/popup")
  await expect(page.locator("body")).toHaveText(/Loading\.\.\..*?/)
})

test("popup extension", async ({ page, extensionId }) => {
  await page.goto(`chrome-extension://${extensionId}/popup.html`)
  await expect(page.locator("body")).toHaveText(/Loading\.\.\..*?/)
})

test("libgen", async ({ page }) => {
  await page.goto("https://libgen.is")
  await page.type("#searchform", "aaA")
  await expect(page.locator("#searchform")).toHaveValue("AAA")
})
