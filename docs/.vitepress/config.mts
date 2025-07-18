import { defineConfig, type MarkdownOptions } from "vitepress";
import MermaidExample from "./mermaidjs.mjs";
import { generateReferenceSidebar } from "./tocParser";
import { generateAdrSidebar } from "./adrParser";
import { snippetPluginExt } from "./plugins/snippet";

const allMarkdownTransformers: MarkdownOptions = {
    theme: {
        light: "github-light",
        dark: "github-dark",
    },

    config: (md) => {
        MermaidExample(md);
        snippetPluginExt(md);
    },
};

export default defineConfig({
    title: "Billing Solution",
    description: "Comprehensive billing management system with Cashiers, Invoices, and Bills",
    markdown: allMarkdownTransformers,
    async transformPageData(pageData) {
        // This runs before Vue compilation and allows us to modify the final HTML
        return pageData;
    },
    transformHtml: (code, id, ctx) => {
        // Add v-pre to Vue-sensitive language code blocks to prevent Vue compilation
        // This catches both regular code blocks and snippet imports
        return code.replace(
            /<pre([^>]*?)class="([^"]*?language-(csharp|cs|java|typescript|ts|tsx|cpp|c|h)[^"]*?)"([^>]*?)(?<!v-pre[^>]*?)>/g,
            '<pre$1class="$2"$4 v-pre>'
        );
    },
    vue: {
        compilerOptions: {
            isCustomElement: (tag) => {
                // Treat common XML documentation tags as custom elements to prevent Vue from trying to parse them
                return ['summary', 'param', 'returns', 'response', 'example', 'remarks', 'c', 'code', 'see', 'seealso', 'exception', 'value', 'typeparam'].includes(tag);
            }
        }
    },
    themeConfig: {
        nav: [
            { text: "Home", link: "/" },
            { text: "API", link: "http://localhost:8101/scalar" },
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
                base: "/arch",
                items: [
                    {
                        text: "Architecture",
                        collapsed: false,
                        items: [
                            { text: "Overview", link: "/" },
                            { text: "Event-Driven Architecture", link: "/eda" },
                            { text: "Database Design", link: "/database" },
                            { text: "Background Processing", link: "/background-processing" },
                            generateAdrSidebar(),
                        ],
                    },
                    {
                        text: "Patterns",
                        collapsed: false,
                        items: [
                            { text: "CQRS Implementation", link: "/cqrs" },
                            { text: "Error Handling", link: "/error-handling" },
                            { text: "Testing Strategies", link: "/testing" },
                        ],
                    },
                ],
            },
            "/guide/": {
                base: "/guide",
                items: [
                    {
                        text: "Introduction",
                        collapsed: false,
                        items: [
                            { text: "Billing Solution", link: "/" },
                            { text: "Getting Started", link: "/getting-started" },
                        ],
                    },
                    {
                        text: "Cashiers",
                        collapsed: false,
                        items: [{ text: "Cashiers Overview", link: "/cashiers/" }],
                    },
                    {
                        text: "Invoices",
                        collapsed: false,
                        items: [{ text: "Invoices Overview", link: "/invoices/" }],
                    },
                    {
                        text: "Bills",
                        collapsed: false,
                        items: [{ text: "Bills Overview", link: "/bills/" }],
                    },
                    {
                        text: "Developer Guide",
                        collapsed: false,
                        items: [
                            { text: "Documentation Layout", link: "/documentation-layout" },
                            { text: "Running Database Queries and Commands", link: "/dbcommand-usage-guide.md" },
                            { text: "Debugging Tips", link: "debugging" },
                        ],
                    },
                ],
            },
            "/reference": {
                base: "/reference",
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
