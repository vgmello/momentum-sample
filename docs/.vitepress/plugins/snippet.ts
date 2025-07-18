import type MarkdownIt from 'markdown-it'
import type { RuleBlock } from 'markdown-it/lib/parser_block'
import { readFileSync } from 'fs'
import { resolve } from 'path'

interface SnippetOptions {
  root?: string
}

// Custom snippet plugin that handles C# generics properly
export function snippetPlugin(md: MarkdownIt, options: SnippetOptions = {}) {
  const root = options.root || process.cwd()

  const snippet: RuleBlock = (state, start, end, silent) => {
    const pos = state.bMarks[start] + state.tShift[start]
    const max = state.eMarks[start]

    // Check if line starts with <<<
    if (pos + 3 > max) return false
    if (state.src.slice(pos, pos + 3) !== '<<<') return false

    if (silent) return true

    const match = state.src.slice(pos, max).match(/^<<<\s*(.+)$/)
    if (!match) return false

    const [, rawPath] = match
    let [path, region] = rawPath.split(/[{}]/)
    path = path.trim()

    // Handle relative paths starting with @/
    if (path.startsWith('@/')) {
      path = path.replace('@/', '')
    }

    // Resolve path relative to the docs directory
    const fullPath = resolve(root, path)

    try {
      let content = readFileSync(fullPath, 'utf8')
      
      // Extract specific lines if region is specified
      if (region) {
        const lines = content.split('\n')
        const [startLine, endLine] = region.split('-').map(Number)
        
        if (endLine) {
          content = lines.slice(startLine - 1, endLine).join('\n')
        } else {
          content = lines[startLine - 1] || ''
        }
      }

      // Detect file extension to determine language
      const ext = path.split('.').pop()?.toLowerCase()
      let lang = ext
      
      // Map common extensions to language identifiers
      const langMap: Record<string, string> = {
        'cs': 'csharp',
        'ts': 'typescript',
        'js': 'javascript',
        'py': 'python',
        'java': 'java',
        'cpp': 'cpp',
        'c': 'c'
      }
      
      if (ext && langMap[ext]) {
        lang = langMap[ext]
      }

      // Escape angle brackets in C# and similar languages to prevent Vue parsing
      if (lang === 'csharp' || lang === 'java' || lang === 'typescript' || lang === 'cpp') {
        // Only escape angle brackets that look like generic types
        // This regex matches: <Word> or <Word, Word> patterns
        content = content.replace(/(<)([A-Z][a-zA-Z0-9]*(?:\s*,\s*[A-Z][a-zA-Z0-9]*)*)(>)/g, '&lt;$2&gt;')
      }

      // Create the code block token
      const token_o = state.push('fence', 'code', 0)
      token_o.info = lang || ''
      token_o.content = content
      token_o.markup = '```'
      token_o.map = [start, start + 1]

      state.line = start + 1
      return true

    } catch (err) {
      // If file doesn't exist, create an error block
      const token_o = state.push('fence', 'code', 0)
      token_o.info = 'text'
      token_o.content = `Error: Could not read file ${path}\n${err instanceof Error ? err.message : String(err)}`
      token_o.markup = '```'
      token_o.map = [start, start + 1]

      state.line = start + 1
      return true
    }
  }

  md.block.ruler.before('fence', 'snippet', snippet)
}