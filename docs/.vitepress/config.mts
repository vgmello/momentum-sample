import { defineConfig, type MarkdownOptions } from "vitepress";
import MermaidExample from "./mermaidjs.mjs";
import { generateReferenceSidebar } from "./tocParser";

const allMarkdownTransformers: MarkdownOptions = {
    theme: {
        light: "github-light",
        dark: "github-dark",
    },

    config: (md) => {
        MermaidExample(md);
    },
};

export default defineConfig({
    title: "Billing Solution",
    description: "Comprehensive billing management system with Cashiers, Invoices, and Bills",
    markdown: allMarkdownTransformers,
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
                        text: "Cashiers",
                        collapsed: false,
                        items: [{ text: "Cashiers Overview", link: "cashiers/" }],
                    },
                    {
                        text: "Invoices",
                        collapsed: false,
                        items: [{ text: "Invoices Overview", link: "invoices/" }],
                    },
                    {
                        text: "Bills",
                        collapsed: false,
                        items: [{ text: "Bills Overview", link: "bills/" }],
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
            "/reference": {
                base: "/reference/",
                items: generateReferenceSidebar(),
            },
        },

        socialLinks: [{ icon: "github", link: "https://github.com/" }],

        footer: {
            message: "Billing Service Documentation",
            copyright: "Copyright © 2025 Billing Team",
        },
    },
    lastUpdated: true,
    cleanUrls: true,
});
