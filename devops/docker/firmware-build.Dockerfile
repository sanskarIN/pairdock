FROM ubuntu:24.04
RUN apt-get update && apt-get install -y cmake ninja-build build-essential git python3 && rm -rf /var/lib/apt/lists/*
WORKDIR /workspace
COPY firmware ./firmware
RUN cmake -S firmware -B firmware/build && cmake --build firmware/build
