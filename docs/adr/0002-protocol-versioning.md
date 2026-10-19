# ADR 0002: Protocol Versioning

## Status

Accepted

## Context

Firmware, apps, backend, SDKs, tools, and manufacturing systems must exchange messages safely over time.

## Decision

Every protocol message uses an envelope with:

- `protocolVersion`
- `messageType`
- `messageId`
- `timestampUtc`
- `payload`

## Consequences

- Older components can reject unsupported versions clearly.
- New optional fields can be added without breaking Phase 1 contracts.
- Binary transport can map to the same conceptual message family later.
