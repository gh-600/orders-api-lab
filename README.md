# orders-api · GH-600 lab

Minimal .NET 9 solution used as the starting point for the GH-600 labs.

| Project | Role |
|---|---|
| `src/Orders.Domain` | Domain model (`Order`) |
| `src/Orders.Application` | Use cases |
| `src/Orders.Infrastructure` | Adapters |
| `src/Orders.Api` | Minimal API host |
| `tests/Orders.Tests` | xUnit tests |

`infra/`, `docs/` and `security/` are placeholders, so CODEOWNERS can route reviews by path later.

There is no governance yet: no workflows, CODEOWNERS, ruleset, PR template or agents. Each lab adds them.

```bash
dotnet build Orders.sln
dotnet test Orders.sln
```

Lab rules: public repo in the lab organisation only, no real secrets, nobody on a ruleset bypass list.
