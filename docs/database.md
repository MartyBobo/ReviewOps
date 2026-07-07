# Database

ReviewOps Copilot uses PostgreSQL with EF Core and Npgsql.

## Local PostgreSQL

Docker Compose starts PostgreSQL 17:

```bash
docker compose up -d
docker compose ps
docker compose down
```

The local container is named `reviewops-postgres`.

## Connection String

`.env.example` provides the development connection string:

```text
ConnectionStrings__ReviewOpsDb=Host=localhost;Port=5432;Database=reviewops;Username=reviewops;Password=reviewops
```

## Ownership

EF Core configuration, migrations, and database adapters belong in `ReviewOps.Infrastructure`. Domain objects should not reference EF Core types.
