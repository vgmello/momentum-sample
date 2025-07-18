import type { MarkdownIt } from "markdown-it";

export function snippetPluginExt(md: MarkdownIt) {
    const VUE_SENSITIVE_LANGS = new Set(["csharp", "cs", "java", "typescript", "ts", "tsx", "cpp", "c", "h"]);

    // Override the fence renderer with a custom implementation
    md.renderer.rules.fence = (tokens, idx, options, env, renderer) => {
        const token = tokens[idx];
        const info = token.info ? md.utils.unescapeAll(token.info).trim() : '';
        const lang = info.split(/[\s{:]/)[0];
        const content = token.content;

        // Determine if this language needs v-pre
        const needsVPre = VUE_SENSITIVE_LANGS.has(lang);
        
        // Build attributes
        const attrs: string[] = [];
        if (lang) {
            attrs.push(`class="${options.langPrefix}${md.utils.escapeHtml(lang)}"`);
        }
        if (needsVPre) {
            attrs.push('v-pre');
        }
        
        const attrStr = attrs.length > 0 ? ` ${attrs.join(' ')}` : '';
        const escapedContent = md.utils.escapeHtml(content);
        
        return `<pre${attrStr}><code>${escapedContent}</code></pre>\n`;
    };
}
