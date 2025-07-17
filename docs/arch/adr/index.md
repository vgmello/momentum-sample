---
title: Architectural Decision Records
---

# Architectural Decision Records (ADRs)

This page serves as a catalog for all Architectural Decision Records (ADRs) made for this project.

> An ADR is a short document that captures an important architectural decision, including its context and consequences.

## Log

The following table lists all ADRs in chronological order. Each title links to the full ADR document.

<!--@include: ./table.md-->

### Status Meanings

::: tip

-   **Proposed**: A decision has been proposed and is under review.
-   **Accepted**: The decision has been approved and should be followed.
-   **Deprecated**: The decision was accepted but is no longer recommended. It should be avoided in new code.
-   **Superseded**: The decision has been replaced by a new ADR.

:::

## How to Propose a New ADR

1.  **Copy the template:** Create a new file in this directory (`/adrs/`) by copying the `TEMPLATE.md` file.
2.  **Name the file:** Use the format `NNN-short-title.md`, where `NNN` is the next sequential number.
3.  **Fill out the template:** Detail the context, decision, and consequences.
4.  **Submit a Pull Request:** Open a PR to have the ADR reviewed and discussed by the team.
5.  **Update this log:** Once the ADR's status is finalized, add or update its entry in the table on this page.

## Why this page is important

Keeping a log of these decisions helps us:

-   Understand the "why" behind our architecture.
-   Onboard new team members more effectively.
-   Avoid repeating past mistakes or discussions.
