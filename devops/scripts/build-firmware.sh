#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
ROOT_DIR="$SCRIPT_DIR/../.."

cmake -S "$ROOT_DIR/firmware" -B "$ROOT_DIR/firmware/build"
cmake --build "$ROOT_DIR/firmware/build"
