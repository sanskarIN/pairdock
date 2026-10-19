# Contributing To PairDock

PairDock is a professional Wi-Fi + Bluetooth smart device platform made by Sanskar.

## Standards

- Keep modules cohesive and named by domain behavior.
- Add tests or a documented test plan for new behavior.
- Update protocol docs when changing firmware-backend-app contracts.
- Keep security implications explicit.
- Do not add empty files only to increase file count.

## Branch Naming

Use prefixes:

- `feature/`
- `fix/`
- `docs/`
- `firmware/`
- `security/`
- `release/`

## Review Checklist

- Build passes for touched projects.
- Public APIs have clear DTOs and validation.
- Firmware interfaces are mockable.
- UI changes honor design-system tokens.
- Logs avoid secrets and personal data.
- Documentation reflects changed behavior.
