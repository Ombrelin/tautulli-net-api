using System.Text.Json.Serialization;

namespace Tautulli.Net.Sdk.Dto;

public class GetHistoryRequest
{
    [property: JsonPropertyName("grouping")]
    private int? Grouping { get; init; }

    [property: JsonPropertyName("include_activity")]
    int? IncludeActivity { get; init; }

    [property: JsonPropertyName("user")] string? User { get; init; }

    [property: JsonPropertyName("user_id")]
    int? UserId { get; init; }

    [property: JsonPropertyName("rating_key")]
    int? RatingKey { get; init; }

    [property: JsonPropertyName("parent_rating_key")]
    int? ParentRatingKey { get; init; }

    [property: JsonPropertyName("grandparent_rating_key")]
    int? GrandparentRatingKey { get; init; }

    [property: JsonPropertyName("start_date")]
    string? StartDate { get; init; }

    [property: JsonPropertyName("before")] string? Before { get; init; }
    [property: JsonPropertyName("after")] string? After { get; init; }

    [property: JsonPropertyName("section_id")]
    int? SectionId { get; init; }

    [property: JsonPropertyName("media_type")]
    string? MediaType { get; init; }

    [property: JsonPropertyName("transcode_decision")]
    string? TranscodeDecision { get; init; }

    [property: JsonPropertyName("guid")] string? Guid { get; init; }

    [property: JsonPropertyName("order_column")]
    string? OrderColumn { get; init; }

    [property: JsonPropertyName("order_dir")]
    string? OrderDir { get; init; }

    [property: JsonPropertyName("start")] int? start { get; init; }
    [property: JsonPropertyName("length")] int? length { get; init; }

    [property: JsonPropertyName("search")] string? search { get; init; }
};