# API

The API is an ASP.NET Core project in `src/ReviewOps.Api`.

## Current Endpoints

```text
GET /health
```

Returns `200 OK` with `OK` when the API process is running.

## Direction

Future API work should keep endpoints thin. Request handling should validate and dispatch application commands or queries, while domain rules remain inside `ReviewOps.Domain`.

## Local URL

The default development URL is configured through `.env.example`:

```text
ASPNETCORE_URLS=http://localhost:5080
```
