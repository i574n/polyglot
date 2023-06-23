import { PlaywrightTestConfig, devices } from "@playwright/test"
import path from "path"

const PORT = process.env.PORT || 3000

const baseURL = `http://localhost:${PORT}`

export default {
  timeout: 10 * 1000,
  testDir: path.join(__dirname, "e2e"),
  retries: process.env.CI ? 2 : 0,
  outputDir: "test-results/",

  webServer: [
    {
      command: "cd dist && npx serve",
      url: baseURL,
      timeout: 30 * 1000,
      reuseExistingServer: false, // !process.env.CI,
    },
  ],

  use: {
    baseURL,
    trace: "retry-with-trace",
  },

  projects: [
    {
      name: "Desktop Chrome",
      use: {
        ...devices["Desktop Chrome"],
      },
    },
    // {
    //   name: 'Desktop Firefox',
    //   use: {
    //     ...devices['Desktop Firefox'],
    //   },
    // },
    // {
    //   name: 'Desktop Safari',
    //   use: {
    //     ...devices['Desktop Safari'],
    //   },
    // },
    // Test against mobile viewports.
    // {
    //   name: 'Mobile Chrome',
    //   use: {
    //     ...devices['Pixel 5'],
    //   },
    // },
    // {
    //   name: 'Mobile Safari',
    //   use: devices['iPhone 12'],
    // },
  ],
} as PlaywrightTestConfig
