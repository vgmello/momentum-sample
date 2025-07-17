import { readdirSync, readFileSync } from "fs";
import { join } from "path";
import { VitePressNavItem } from "./tocParser";
import matter from "gray-matter";

export interface AdrMetadata {
    number: string;
    title: string;
    status: string;
    date: string;
}

export function parseAdrFile(filePath: string): AdrMetadata | null {
    try {
        const content = readFileSync(filePath, "utf-8");
        const { data } = matter(content);
        
        if (data.number && data.title) {
            return {
                number: data.number,
                title: data.title,
                status: data.status || "Unknown",
                date: data.date || ""
            };
        }
        return null;
    } catch (error) {
        console.error(`Error parsing ADR file ${filePath}:`, error);
        return null;
    }
}

export function generateAdrSidebarItems(adrDir: string = "arch/adr"): VitePressNavItem[] {
    try {
        const files = readdirSync(adrDir);
        const adrFiles = files
            .filter(file => file.startsWith("adr-") && file.endsWith(".md"))
            .sort(); // Sort by filename to maintain ADR number order

        const adrItems: VitePressNavItem[] = adrFiles.map(file => {
            const filePath = join(adrDir, file);
            const metadata = parseAdrFile(filePath);
            
            if (metadata) {
                return {
                    text: `${metadata.number}: ${metadata.title}`,
                    link: `/adr/${file.replace(".md", "")}`
                };
            }
            
            // Fallback: parse from filename
            const match = file.match(/adr-(\d+)-(.*?)\.md/);
            if (match) {
                const number = `ADR-${match[1]}`;
                const title = match[2]
                    .split("-")
                    .map(word => word.charAt(0).toUpperCase() + word.slice(1))
                    .join(" ");
                
                return {
                    text: `${number}: ${title}`,
                    link: `/adr/${file.replace(".md", "")}`
                };
            }
            
            return {
                text: file.replace(".md", ""),
                link: `/adr/${file.replace(".md", "")}`
            };
        });

        return [
            { text: "ADR Overview", link: "/adr/" },
            { text: "ADR Table", link: "/adr/table" },
            ...adrItems
        ];
    } catch (error) {
        console.error("Error generating ADR sidebar items:", error);
        return [];
    }
}

export function generateAdrSidebar(adrDir: string = "arch/adr"): VitePressNavItem[] {
    return [
        {
            text: "Architectural Decision Records",
            collapsed: false,
            items: generateAdrSidebarItems(adrDir)
        }
    ];
}

export function generateAdrTable(adrDir: string = "arch/adr"): string {
    try {
        const files = readdirSync(adrDir);
        const adrFiles = files
            .filter(file => file.startsWith("adr-") && file.endsWith(".md"))
            .sort();

        let tableContent = `# Architectural Decision Records

## All ADRs

| Number | Title | Status | Date |
|--------|-------|--------|------|
`;

        adrFiles.forEach(file => {
            const filePath = join(adrDir, file);
            const metadata = parseAdrFile(filePath);
            
            if (metadata) {
                const link = `[${metadata.number}](${file.replace(".md", "")})`;
                const statusBadge = `<Badge type="${getStatusBadgeType(metadata.status)}" text="${metadata.status}" />`;
                const formattedDate = metadata.date ? formatDate(metadata.date) : "-";
                tableContent += `| ${link} | ${metadata.title} | ${statusBadge} | ${formattedDate} |\n`;
            } else {
                // Fallback: parse from filename
                const match = file.match(/adr-(\d+)-(.*?)\.md/);
                if (match) {
                    const number = `ADR-${match[1]}`;
                    const title = match[2]
                        .split("-")
                        .map(word => word.charAt(0).toUpperCase() + word.slice(1))
                        .join(" ");
                    const link = `[${number}](${file.replace(".md", "")})`;
                    tableContent += `| ${link} | ${title} | <Badge type="info" text="Unknown" /> | - |\n`;
                }
            }
        });

        return tableContent;
    } catch (error) {
        console.error("Error generating ADR table:", error);
        return "# Architectural Decision Records\n\nError generating ADR table.";
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
        const dateObj = typeof date === "string" ? new Date(date) : date;
        if (isNaN(dateObj.getTime())) {
            return date.toString();
        }
        return dateObj.toISOString().split("T")[0]; // Returns YYYY-MM-DD format
    } catch {
        return date.toString();
    }
}