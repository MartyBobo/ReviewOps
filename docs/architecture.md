# Architecture

ReviewOps Copilot uses Clean Architecture to keep product behavior separate from infrastructure concerns.

## Layers

- `ReviewOps.Domain` contains enterprise rules, entities, value objects, enums, and domain services.
- `ReviewOps.Contracts` contains DTOs and API-facing contracts shared across boundaries.
- `ReviewOps.Application` contains use cases, commands, queries, validation, and application abstractions.
- `ReviewOps.Infrastructure` contains EF Core persistence, external review providers, AI adapters, email, and time services.
- `ReviewOps.Api` exposes HTTP endpoints and composes application services.
- `ReviewOps.Worker` runs background jobs and composes scheduled processing services.

## Dependency Direction

Allowed dependency flow is inward:

```text
Domain -> no project dependencies
Contracts -> no project dependencies
Application -> Domain, Contracts
Infrastructure -> Application, Domain, Contracts
Api -> Application, Infrastructure, Contracts
Worker -> Application, Infrastructure, Contracts
```

Architecture tests in `tests/ReviewOps.ArchitectureTests` enforce that `Domain` does not depend on outer layers and that `Application` does not depend on `Infrastructure`, `Api`, or `Worker`.

## Composition

`Api` and `Worker` are the only executable projects. They should wire dependencies at startup and delegate business behavior to application handlers and domain methods.
