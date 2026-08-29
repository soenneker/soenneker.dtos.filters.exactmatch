[![](https://img.shields.io/nuget/v/soenneker.dtos.filters.exactmatch.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.exactmatch/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.exactmatch/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.exactmatch/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.filters.exactmatch.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.exactmatch/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.exactmatch/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.exactmatch/actions/workflows/codeql.yml)

# Soenneker.Dtos.Filters.ExactMatch

Selects records whose named field equals a supplied scalar value.

## Install

```bash
dotnet add package Soenneker.Dtos.Filters.ExactMatch
```

## What you get

- `ExactMatchFilter` — Selects records whose named field equals a supplied scalar value.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `ExactMatchFilter.Value` | Scalar value the target field must equal; its JSON type should match the field being queried. | Scalar value the target field must equal; its JSON type should match the field being queried. |
