import { test, expect } from "@playwright/test";

test("test", async ({ page }) => {
  await page.goto("http://localhost:3000/popup.html");

  await expect(page).toHaveTitle("dice");
});
