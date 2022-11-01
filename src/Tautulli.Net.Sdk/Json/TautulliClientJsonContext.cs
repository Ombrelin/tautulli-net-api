using System.Text.Json.Serialization;
using Tautulli.Net.Sdk.Dto;

namespace Tautulli.Net.Sdk.Json;

[JsonSerializable(typeof(GetHistoryResponse))]
[JsonSerializable(typeof(GetHistoryRequest))]
public partial class TautulliClientJsonContext : JsonSerializerContext
{
    
}