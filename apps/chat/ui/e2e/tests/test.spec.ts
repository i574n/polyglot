import { test, expect } from "@playwright/test";

test("test", async ({ page }) => {
  await page.goto("http://localhost:3000/");

  await expect(page).toHaveTitle("ui");

  await page.click("text=+");
  await page.click("text=+");

  await page.waitForSelector("td:has-text('9')");
});
