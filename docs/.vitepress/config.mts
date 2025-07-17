import { defineConfig } from "vitepress";

// https://vitepress.dev/reference/site-config
export default defineConfig({
    title: "Billing Solution",
    description: "Comprehensive billing management system with Cashiers, Invoices, and Bills",
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
                            { text: "Clean Architecture Overview", link: "/" },
                            { text: "Event-Driven Architecture", link: "events" },
                            { text: "Database Design", link: "database" },
                            { text: "Background Processing", link: "background-processing" },
                        ],
                    },
                    {
                        text: "Patterns",
                        collapsed: false,
                        items: [
                            { text: "CQRS Implementation", link: "cqrs" },
                            { text: "Error Handling", link: "error-handling" },
                            { text: "Testing Strategies", link: "testing" },
                        ],
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
                        base: "/guide/invoices/",
                        text: "Invoices",
                        collapsed: false,
                        items: [{ text: "Overview", link: "/" }],
                    },
                    {
                        base: "/guide/bills/",
                        text: "Bills",
                        collapsed: false,
                        items: [{ text: "Overview", link: "/" }],
                    },
                    {
                        text: "Developer Guide",
                        collapsed: false,
                        items: [
                            { text: "Development Setup", link: "dev-setup" },
                            { text: "First Contribution", link: "first-contribution" },
                            { text: "Debugging Tips", link: "debugging" },
                        ],
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
