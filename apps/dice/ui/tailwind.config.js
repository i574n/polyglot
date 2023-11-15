const colors = require("tailwindcss/colors")

/** @type {import('tailwindcss').Config} */
module.exports = {
    darkMode: "class",
    content: {
        files: ["*.html", "./**/*.rs"],
    },
    theme: {
        nightwind: {
            typography: true,
            transitionDuration: '1000ms'
        },
        colors: {
            gray: colors.zinc,
        },
    },
    plugins: [require("nightwind"), require("@tailwindcss/typography")],
}
