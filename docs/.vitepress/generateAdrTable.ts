import { writeFileSync } from "node:fs";
import { join } from "node:path";
import { generateAdrTable } from "./adrParser";

const adrDir = join(import.meta.dirname, "../arch/adr");
const tableContent = generateAdrTable(adrDir);
const outputPath = join(adrDir, "table.md");

writeFileSync(outputPath, tableContent, "utf-8");
console.log(`✅ ADR table generated at: ${outputPath}`);
