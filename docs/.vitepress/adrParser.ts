import { readdirSync, readFileSync } from "node:fs";
import { join } from "node:path";
import matter from "gray-matter";
import { DefaultTheme } from "vitepress";

const ADR_DIR_DEFAULT = "arch/adr";
const ADR_PREFIX = "adr-";
const MD_EXTENSION = ".md";

export interface AdrMetadata {
    number: string;
    title: string;
    status: string;
    date: string;
    fileName: string;
}

/**
 * Generates a VitePress sidebar object for all ADRs.
 */
export function generateAdrSidebar(adrDir: string = ADR_DIR_DEFAULT): DefaultTheme.SidebarItem {
    const adrData = getAdrData(adrDir);

    const adrItems: DefaultTheme.SidebarItem[] = adrData.map((meta) => ({
        text: `${meta.number}: ${meta.title}`,
        link: `/${meta.fileName}`,
    }));

    return {
        text: "ADRs",
        collapsed: true,
        base: "/arch/adr",
        items: [{ text: "Index", link: "/" }, ...adrItems],
    };
}

/**
 * Generates a Markdown table of all ADRs.
 */
export function generateAdrTable(adrDir: string = ADR_DIR_DEFAULT): string {
    const adrData = getAdrData(adrDir);

    if (adrData.length === 0) {
        return "### ⚠️ No ADRs found or an error occurred.";
    }

    const header = `| ID | Title | Status | Date |\n|:-------|:------|:-------|:-----|`;

    const rows = adrData
        .map((meta) => {
            const idLink = `[${meta.number}](${meta.fileName})`;
            const statusBadge = `<Badge type="${getStatusBadgeType(meta.status)}" text="${meta.status}" />`;
            const formattedDate = meta.date ? formatDate(meta.date) : "–";
            return `| ${idLink} | ${meta.title} | ${statusBadge} | ${formattedDate} |`;
        })
        .join("\n");

    return `${header}\n${rows}`;
}

const adrFileRegex = RegExp(/adr-(\d+)-(.*?)\.md/);

/**
 * Parses ADR metadata from a filename as a fallback.
 * Example: "adr-001-some-title.md" -> { number: "ADR-001", title: "Some Title" }
 */
function parseAdrFromFilename(filename: string): Partial<AdrMetadata> {
    const match = adrFileRegex.exec(filename);
    if (!match) return {};

    const number = `ADR-${match[1]}`;
    const title = match[2]
        .split("-")
        .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
        .join(" ");

    return { number, title };
}

/**
 * Fetches and parses all ADRs from a directory, applying fallback logic.
 * This is the single source of truth for ADR data.
 */
function getAdrData(adrDir: string): AdrMetadata[] {
    try {
        const files = readdirSync(adrDir)
            .filter((file) => file.startsWith(ADR_PREFIX) && file.endsWith(MD_EXTENSION))
            .sort();

        return files.map((file) => {
            const filePath = join(adrDir, file);
            const content = readFileSync(filePath, "utf-8");
            const { data: frontmatter } = matter(content);

            let number, title;

            if (frontmatter.number && frontmatter.title) {
                number = frontmatter.number;
                title = frontmatter.title;
            } else {
                const fromFilename = parseAdrFromFilename(file);
                number = fromFilename.number || "ADR-???";
                title = fromFilename.title || "Untitled";
            }

            return {
                number,
                title,
                status: frontmatter.status || "Unknown",
                date: frontmatter.date || "",
                fileName: `${file.replace(MD_EXTENSION, "")}`,
            };
        });
    } catch (error) {
        console.error(`🚨 Failed to get ADR data from ${adrDir}:`, error);
        return [];
    }
}

function getStatusBadgeType(status: string): string {
    switch (status.toLowerCase()) {
        case "accepted":
            return "tip";
        case "proposed":
            return "info";
        case "deprecated":
            return "danger";
        case "superseded":
            return "warning";
        default:
            return "info";
    }
}

function formatDate(date: string | Date): string {
    try {
        const dateObj = new Date(date);
        if (isNaN(dateObj.getTime())) return date.toString(); // Invalid date
        return dateObj.toISOString().split("T")[0]; // YYYY-MM-DD
    } catch {
        return date.toString();
    }
}
