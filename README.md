[![](https://img.shields.io/nuget/v/soenneker.dtos.filters.exactmatch.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.exactmatch/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.exactmatch/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.exactmatch/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.filters.exactmatch.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.exactmatch/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.exactmatch/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.exactmatch/actions/workflows/codeql.yml)

# Soenneker.Dtos.Filters.ExactMatch

Represents a structured equality filter with a target field and JSON-compatible value.

## Installation

```bash
dotnet add package Soenneker.Dtos.Filters.ExactMatch
```

## Usage

```csharp
using Soenneker.Dtos.Filters.ExactMatch;

var statusFilter = new ExactMatchFilter
{
    Field = "status",
    Value = "active"
};

var tenantFilter = new ExactMatchFilter
{
    Field = "tenantId",
    Value = 42
};
```

Both System.Text.Json and Newtonsoft.Json serialize the properties as `field` and `value`:

```json
{
  "field": "status",
  "value": "active"
}
```

`Value` is typed as `object?` so its JSON type can match the queried field. After deserializing untyped input, System.Text.Json commonly stores it as `JsonElement`, while Newtonsoft.Json commonly uses `JValue`, `JObject`, or `JArray`. Convert and validate it against server-owned field metadata before building a query.

The DTO does not require a scalar at runtime, define how null equality behaves, validate field names, perform type coercion, or execute a filter. Allow-list `Field`, reject unsupported value shapes, and parameterize the converted value. Never concatenate either property into a query expression.
