import { defineConfig } from "vitepress";

// https://vitepress.dev/reference/site-config
export default defineConfig({
    title: "Billing Solution",
    description: "An App Template",
    themeConfig: {
        // https://vitepress.dev/reference/default-theme-config
        nav: [
            { text: "Home", link: "/" },
            { text: "API", link: "/api/" },
            { text: "Events", link: "/events/" },
            { text: "Architecture", link: "/arch/" },
            { text: "Guide", link: "/guide/" },
            { text: "Reference", link: "/reference/" },
        ],

        sidebar: {
            "/arch/": {
                base: "/arch/",
                items: [
                    {
                        text: "Architecture",
                        collapsed: false,
                        items: [
                            { text: "Overview", link: "/" },
                            { text: "ADRs", link: "/" },
                            { text: "Infrastructure", link: "/" },
                        ],
                    },
                    {
                        text: "Data",
                        collapsed: false,
                        items: [{ text: "Databases", link: "/" }],
                    },
                ],
            },
            "/guide/": {
                base: "/guide/",
                items: [
                    {
                        text: "Introduction",
                        collapsed: false,
                        items: [
                            { text: "Billing Solution", link: "/" },
                            { text: "Getting Started", link: "getting-started" },
                        ],
                    },
                ],
            },
            "/reference": [],
        },

        socialLinks: [{ icon: "github", link: "https://github.com/vuejs/vitepress" }],
    },
    lastUpdated: true,
    cleanUrls: true,
});
