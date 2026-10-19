# Device Authentication

## Goals

- Prove device identity to the backend.
- Prevent cloned devices from joining the fleet.
- Allow certificate rotation and revocation.

## Phase 1 Concept

Devices are represented by a serial number, public key fingerprint, and certificate record. Production devices should use per-device certificates provisioned during manufacturing.

SCX-TODO: Add certificate enrollment service and hardware secure element support.
