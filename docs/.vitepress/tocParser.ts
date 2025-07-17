import { readFileSync } from 'fs';
import { parse } from 'yaml';
import { join } from 'path';

export interface TocItem {
  name: string;
  href?: string;
  items?: TocItem[];
}

export interface VitePressNavItem {
  text: string;
  link?: string;
  items?: VitePressNavItem[];
  collapsed?: boolean;
}

export function parseTocYaml(tocFilePath: string): TocItem[] {
  try {
    const yamlContent = readFileSync(tocFilePath, 'utf-8');
    const parsedYaml = parse(yamlContent);
    
    // Handle different YAML structures
    if (Array.isArray(parsedYaml)) {
      return parsedYaml;
    }
    
    // If it's an object with a root property, extract the items
    if (typeof parsedYaml === 'object' && parsedYaml !== null) {
      // Look for common root properties
      const possibleRoots = ['items', 'toc', 'content'];
      for (const root of possibleRoots) {
        if (parsedYaml[root] && Array.isArray(parsedYaml[root])) {
          return parsedYaml[root];
        }
      }
      
      // If no array found in common roots, return the object as array
      return [parsedYaml];
    }
    
    return [];
  } catch (error) {
    console.error(`Error parsing TOC file ${tocFilePath}:`, error);
    return [];
  }
}

export function convertTocToVitePressSidebar(tocItems: TocItem[], basePath: string = ''): VitePressNavItem[] {
  return tocItems.map(item => {
    const navItem: VitePressNavItem = {
      text: item.name,
      collapsed: false
    };
    
    // Convert href to VitePress link format
    if (item.href) {
      // Remove .md extension and ensure it starts with basePath
      let link = item.href.replace(/\.md$/, '');
      
      // If it doesn't start with /, add the basePath
      if (!link.startsWith('/')) {
        link = basePath + '/' + link;
      }
      
      navItem.link = link;
    }
    
    // Recursively convert child items
    if (item.items && item.items.length > 0) {
      navItem.items = convertTocToVitePressSidebar(item.items, basePath);
    }
    
    return navItem;
  });
}

export function generateReferenceSidebar(tocFilePath: string = '/home/vgmello/shared/repos/momentum-sample/docs/reference/toc.yml'): VitePressNavItem[] {
  const tocItems = parseTocYaml(tocFilePath);
  return convertTocToVitePressSidebar(tocItems, '/reference');
}

export function generateSidebarFromToc(tocFilePath: string, basePath: string = ''): VitePressNavItem[] {
  const tocItems = parseTocYaml(tocFilePath);
  return convertTocToVitePressSidebar(tocItems, basePath);
}