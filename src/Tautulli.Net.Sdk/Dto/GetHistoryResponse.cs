using System.Text.Json.Serialization;

namespace Tautulli.Net.Sdk.Dto;

public record Datum(
    [property: JsonPropertyName("date")] int Date,
    [property: JsonPropertyName("duration")]
    int Duration,
    [property: JsonPropertyName("friendly_name")]
    string FriendlyName,
    [property: JsonPropertyName("full_title")]
    string FullTitle,
    [property: JsonPropertyName("grandparent_rating_key")]
    int GrandparentRatingKey,
    [property: JsonPropertyName("grandparent_title")]
    string GrandparentTitle,
    [property: JsonPropertyName("original_title")]
    string OriginalTitle,
    [property: JsonPropertyName("group_count")]
    int GroupCount,
    [property: JsonPropertyName("group_ids")]
    string GroupIds,
    [property: JsonPropertyName("guid")] string Guid,
    [property: JsonPropertyName("ip_address")]
    string IpAddress,
    [property: JsonPropertyName("live")] int Live,
    [property: JsonPropertyName("location")]
    string Location,
    [property: JsonPropertyName("machine_id")]
    string MachineId,
    [property: JsonPropertyName("media_index")]
    int MediaIndex,
    [property: JsonPropertyName("media_type")]
    string MediaType,
    [property: JsonPropertyName("originally_available_at")]
    string OriginallyAvailableAt,
    [property: JsonPropertyName("parent_media_index")]
    int ParentMediaIndex,
    [property: JsonPropertyName("parent_rating_key")]
    int ParentRatingKey,
    [property: JsonPropertyName("parent_title")]
    string ParentTitle,
    [property: JsonPropertyName("paused_counter")]
    int PausedCounter,
    [property: JsonPropertyName("percent_complete")]
    int PercentComplete,
    [property: JsonPropertyName("platform")]
    string Platform,
    [property: JsonPropertyName("product")]
    string Product,
    [property: JsonPropertyName("player")] string Player,
    [property: JsonPropertyName("rating_key")]
    int RatingKey,
    [property: JsonPropertyName("reference_id")]
    int ReferenceId,
    [property: JsonPropertyName("relayed")]
    int Relayed,
    [property: JsonPropertyName("row_id")] int RowId,
    [property: JsonPropertyName("secure")] int Secure,
    [property: JsonPropertyName("session_key")]
    object SessionKey,
    [property: JsonPropertyName("started")]
    int Started,
    [property: JsonPropertyName("state")] object State,
    [property: JsonPropertyName("stopped")]
    int Stopped,
    [property: JsonPropertyName("thumb")] string Thumb,
    [property: JsonPropertyName("title")] string Title,
    [property: JsonPropertyName("transcode_decision")]
    string TranscodeDecision,
    [property: JsonPropertyName("user")] string User,
    [property: JsonPropertyName("user_id")]
    int UserId,
    [property: JsonPropertyName("watched_status")]
    int WatchedStatus,
    [property: JsonPropertyName("year")] int Year
);

public record GetHistoryResponse(
    [property: JsonPropertyName("draw")] int Draw,
    [property: JsonPropertyName("recordsTotal")]
    int RecordsTotal,
    [property: JsonPropertyName("recordsFiltered")]
    int RecordsFiltered,
    [property: JsonPropertyName("total_duration")]
    string TotalDuration,
    [property: JsonPropertyName("filter_duration")]
    string FilterDuration,
    [property: JsonPropertyName("data")] IReadOnlyList<Datum> Data
);