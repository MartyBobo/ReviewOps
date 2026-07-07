# Deployment

Deployment is not implemented in Sprint 0. This document records the intended direction for later sprints.

## Current State

- The backend builds as a .NET 10 solution.
- Local infrastructure runs with Docker Compose and PostgreSQL 17.
- CI/CD and production Dockerfiles are planned for later work.

## Expected Services

Future deployments should include:

- ASP.NET Core API service
- Worker service
- PostgreSQL database
- React frontend

## Configuration

Runtime configuration should come from environment variables. Secrets must be stored in the deployment platform's secret manager, not in Git.
