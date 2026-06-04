using Soenneker.Dtos.Filters.Base;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.Filters.ExactMatch;

/// <summary>
/// A generic object for handling exact match filtering during querying
/// </summary>
public sealed class ExactMatchFilter : FilterBase
{
    /// <summary>
    /// The value that the field must match.
    /// </summary>
    [JsonPropertyName("value")]
    [JsonProperty("value")]
    public object? Value { get; set; }
}
