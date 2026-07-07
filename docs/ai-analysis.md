# AI Analysis

ReviewOps Copilot will support AI-assisted review analysis while remaining usable in demo mode without external credentials.

## Providers

The default Sprint 0 configuration uses a deterministic provider:

```text
Ai__Provider=RuleBased
```

Future OpenAI integration should be isolated behind application abstractions and implemented in `ReviewOps.Infrastructure`.

## Configuration

AI-related environment keys are listed in `.env.example`:

```text
Ai__Provider=RuleBased
OpenAi__ApiKey=
OpenAi__Model=
```

Never commit real API keys or generated analysis fixtures that contain private customer data.
