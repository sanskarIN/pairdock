# Binary Packet Concept

The Phase 1 protocol uses JSON for clarity. A future constrained transport can use a binary packet with the same message families.

## Header

| Field | Size | Notes |
| --- | ---: | --- |
| Magic | 2 bytes | `SC` |
| Version | 1 byte | Protocol major version |
| Message Type | 1 byte | Command, telemetry, status |
| Flags | 1 byte | Ack, encrypted, compressed |
| Sequence | 4 bytes | Monotonic per session |
| Payload Length | 2 bytes | Big-endian |
| Header CRC | 2 bytes | Header validation |

## Payload

Payload can be JSON, CBOR, MessagePack, or protobuf in future phases.

