import { writeFileSync } from "fs";
import { join } from "path";
import { generateAdrTable } from "./adrParser";

// This script generates the ADR table.md file
const adrDir = join(__dirname, "../arch/adr");
const tableContent = generateAdrTable(adrDir);
const outputPath = join(adrDir, "table.md");

writeFileSync(outputPath, tableContent, "utf-8");
console.log(`ADR table generated at: ${outputPath}`);