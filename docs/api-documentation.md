# API Documentation

## Base Path

Development base URL:

```text
https://localhost:7241/api
```

## Main Resources

- `POST /api/auth/login`
- `POST /api/auth/register`
- `GET /api/devices`
- `POST /api/devices`
- `GET /api/devices/{deviceId}`
- `POST /api/devices/{deviceId}/commands`
- `POST /api/telemetry/ingest`
- `GET /api/firmware`
- `POST /api/firmware`
- `GET /api/health`

## Error Envelope

```json
{
  "traceId": "00-example",
  "code": "validation_failed",
  "message": "The request is invalid.",
  "details": []
}
```

SCX-TODO: Generate OpenAPI examples in Phase 2.
