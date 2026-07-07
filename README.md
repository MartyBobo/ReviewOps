# ReviewOps Copilot

ReviewOps Copilot is a portfolio-ready review operations SaaS built around a C#/.NET Clean Architecture backend. The product will ingest customer reviews, analyze sentiment, detect review spikes, alert operators, and power a React dashboard in later sprints.

Sprint 0 establishes the repository foundation: solution layout, dependency direction, shared build settings, local PostgreSQL, and architecture guardrails.

## Prerequisites

- .NET SDK 10.0.100 or newer compatible feature band
- Docker Desktop with Docker Compose
- Git

## Getting Started

```bash
git clone <repository-url>
cd ReviewOps
dotnet restore
dotnet build
copy .env.example .env
docker compose up -d
dotnet test
```

The API project currently exposes a minimal health endpoint at `/health`.

## Solution Layout

```text
src/
  ReviewOps.Domain/
  ReviewOps.Contracts/
  ReviewOps.Application/
  ReviewOps.Infrastructure/
  ReviewOps.Api/
  ReviewOps.Worker/
tests/
  ReviewOps.UnitTests/
  ReviewOps.IntegrationTests/
  ReviewOps.ArchitectureTests/
docs/
  architecture.md
  api.md
  database.md
  ai-analysis.md
  deployment.md
```

`Docs/Development_Plan.md` is the local, ignored implementation plan. Lowercase `docs/` contains tracked project documentation.

## Common Commands

```bash
dotnet restore
dotnet build
dotnet test
dotnet format --verify-no-changes
docker compose up -d
docker compose down
```

Run the architecture tests directly with:

```bash
dotnet test tests/ReviewOps.ArchitectureTests/ReviewOps.ArchitectureTests.csproj
```

## License

This project is licensed under the Apache License 2.0. See `LICENSE` for details.
