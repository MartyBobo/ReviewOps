# Codex Instructions for ReviewOps Copilot

## Project Rules

- Keep the backend in C# and .NET.
- Preserve Clean Architecture dependency direction.
- Implement one ticket at a time from `Docs/Development_Plan.md`.
- Keep `Docs/Development_Plan.md` local and ignored. Never stage or commit it.
- Write or update tests before finalizing behavior.
- Run `dotnet format --verify-no-changes`, `dotnet build`, and `dotnet test` before each backend commit.
- Run frontend lint, typecheck, and tests before each frontend commit once the frontend exists.
- Never commit secrets, `.env`, database volumes, generated local certificates, or API tokens.
- Prefer clear names over clever abstractions.
- Keep endpoints thin; put business behavior in application handlers and domain methods.
- The app must run in demo mode without OpenAI, Google, or email credentials.

## Sprint 0 Notes

- `ReviewOps.Domain` and `ReviewOps.Application` are protected by NetArchTest dependency rules.
- `ReviewOps.Infrastructure` owns EF Core, external providers, email, AI adapters, and clock implementations.
- `ReviewOps.Api` and `ReviewOps.Worker` are composition roots.
- Local PostgreSQL runs through `docker-compose.yml` using the `reviewops-postgres` container.
