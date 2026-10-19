# OTA Update Guide

## OTA Flow

1. Firmware version is uploaded to backend.
2. Backend verifies metadata and signature.
3. Device checks manifest compatibility.
4. Device downloads package over secure transport.
5. Device verifies hash and signature.
6. Device installs to inactive partition.
7. Device reboots and confirms health.
8. Backend records rollout result.

## Rollback

The firmware must keep enough state to rollback when the new image fails health checks.

SCX-TODO: Add full signed package builder and rollback tests in Phase 2.
