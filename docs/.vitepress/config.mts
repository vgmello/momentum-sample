import { defineConfig } from "vitepress";

// https://vitepress.dev/reference/site-config
export default defineConfig({
    title: "Billing Solution",
    description: "An App Template",
    themeConfig: {
        nav: [
            { text: "Home", link: "/" },
            { text: "API", link: "/api/" },
            { text: "Events", link: "/events/" },
            { text: "Guide", link: "/guide/" },
            { text: "Architecture", link: "/arch/" },
            { text: "Reference", link: "/reference/Billing" },
        ],

        search: {
            provider: "local",
        },

        sidebar: {
            "/arch/": {
                base: "/arch/",
                items: [
                    {
                        text: "Architecture",
                        collapsed: false,
                        items: [
                            { text: "Overview", link: "/" },
                            { text: "Infrastructure", link: "/" },
                            { text: "ADRs", link: "adr/", collapsed: true },
                        ],
                    },
                    {
                        text: "Data",
                        collapsed: false,
                        items: [{ text: "Databases", link: "/database" }],
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
                    {
                        base: "/guide/cashiers/",
                        text: "Cashiers",
                        collapsed: false,
                        items: [{ text: "Overview", link: "/" }],
                    },
                    {
                        base: "/guide/invoices",
                        text: "Invoices",
                        collapsed: false,
                        items: [{ text: "Overview", link: "/" }],
                    },
                ],
            },
            "/reference": [],
        },

        socialLinks: [{ icon: "github", link: "https://github.com/vuejs/vitepress" }],

        footer: {
            message: "Billing Service Documentation",
            copyright: "Copyright © 2025 Billing Team",
        },
    },
    lastUpdated: true,
    cleanUrls: true,
});
