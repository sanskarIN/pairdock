# ADR 0001: Platform Architecture

## Status

Accepted

## Context

PairDock needs to support firmware, cloud APIs, multiple applications, manufacturing, and future fleet operations.

## Decision

Use a modular repository with explicit source boundaries:

- C/C++/assembly firmware.
- ASP.NET Core Clean Architecture backend.
- C# desktop, mobile, web dashboard, SDK, and tools.
- Shared versioned protocol contracts.
- SQL-first database schema.

## Consequences

- More folders upfront.
- Clear expansion path beyond 1000 meaningful files.
- Independent teams can own firmware, cloud, app, tooling, and manufacturing areas.

