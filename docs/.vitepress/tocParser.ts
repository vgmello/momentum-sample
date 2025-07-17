import { readFileSync } from "fs";
import { parse } from "yaml";

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
        const yamlContent = readFileSync(tocFilePath, "utf-8");
        const parsedYaml = parse(yamlContent);

        if (Array.isArray(parsedYaml)) {
            return parsedYaml;
        }

        if (typeof parsedYaml === "object" && parsedYaml !== null) {
            const possibleRoots = ["items", "toc", "content"];
            for (const root of possibleRoots) {
                if (parsedYaml[root] && Array.isArray(parsedYaml[root])) {
                    return parsedYaml[root];
                }
            }

            return [parsedYaml];
        }

        return [];
    } catch (error) {
        console.error(`Error parsing TOC file ${tocFilePath}:`, error);
        return [];
    }
}

export function convertTocToVitePressSidebar(tocItems: TocItem[], collapsed: boolean = true, basePath: string = ""): VitePressNavItem[] {
    return tocItems.map((item) => {
        const navItem: VitePressNavItem = {
            text: item.name,
            collapsed: collapsed,
        };

        if (item.href) {
            let link = item.href.replace(/\.md$/, "");

            if (!link.startsWith("/")) {
                link = basePath + "/" + link;
            }

            navItem.link = link;
        }

        if (item.items && item.items.length > 0) {
            navItem.items = convertTocToVitePressSidebar(item.items, true, basePath);
        }

        return navItem;
    });
}

export function generateReferenceSidebar(tocFilePath: string = "reference/toc.yml"): VitePressNavItem[] {
    const tocItems = parseTocYaml(tocFilePath);
    return convertTocToVitePressSidebar(tocItems, false);
}

export function generateSidebarFromToc(tocFilePath: string, basePath: string = ""): VitePressNavItem[] {
    const tocItems = parseTocYaml(tocFilePath);
    return convertTocToVitePressSidebar(tocItems, false, basePath);
}
