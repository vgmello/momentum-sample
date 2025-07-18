import type { MarkdownIt } from "markdown-it";

export function snippetPluginExt(md: MarkdownIt) {
    const VUE_SENSITIVE_LANGS = new Set(["csharp", "cs", "java", "typescript", "ts", "tsx", "cpp", "c", "h"]);

    const originalSnippetRenderer = md.renderer.rules.fence!;

    md.renderer.rules.fence = (...args) => {
        const [tokens, idx] = args;
        const token = tokens[idx];

        const [src] = token.src ?? [];

        if (!src) return originalSnippetRenderer(...args);

        if (token.content) {
            const lang = token.info.split(/[\s{:]/)[0];

            if (VUE_SENSITIVE_LANGS.has(lang)) {
                // Fix: escape all '<' characters to prevent them from being treated as HTML tags.
                token.content = token.content.replace(/</g, "&lt;");
            }
        }

        return originalSnippetRenderer(...args);
    };
}
