# Secrets Management

## Rules

- Use `.env.example`, never real `.env` files.
- Store production secrets in a managed secret store.
- Rotate API keys and signing keys.
- Limit local developer credentials.
- Keep firmware signing keys outside CI logs.
