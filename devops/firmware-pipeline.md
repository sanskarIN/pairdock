# Firmware Build Pipeline Concept

## Pipeline

1. Restore ESP-IDF toolchain.
2. Build firmware for each board revision.
3. Run host unit tests.
4. Run static analysis.
5. Sign firmware package.
6. Publish OTA manifest.
7. Upload release artifact to backend.

