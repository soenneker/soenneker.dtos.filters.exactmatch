using Soenneker.Dtos.Filters.Base;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.Filters.ExactMatch;

/// <summary>
/// Selects records whose named field equals a supplied scalar value.
/// </summary>
public sealed class ExactMatchFilter : FilterBase
{
    /// <summary>
    /// Scalar value the target field must equal; its JSON type should match the field being queried.
    /// </summary>
    [JsonPropertyName("value")]
    [JsonProperty("value")]
    public object? Value { get; set; }
}
