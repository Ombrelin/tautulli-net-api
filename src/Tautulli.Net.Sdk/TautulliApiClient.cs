using System.Text.Json;
using System.Web;
using Tautulli.Net.Sdk.Dto;
using Tautulli.Net.Sdk.Json;

namespace Tautulli.Net.Sdk;

public class TautulliApiClient : ITautulliApiClient
{
    private static readonly string TautulliClientName = "Tautulli Client";
    private static readonly string TautulliApiPath = "api/v2";
    private readonly IHttpClientFactory httpClientFactory;

    public TautulliApiClient(IHttpClientFactory httpClientFactory)
    {
        this.httpClientFactory = httpClientFactory;
    }

    public Task GetActivity()
    {
        throw new NotImplementedException();
    }

    public Task GetApiKey()
    {
        throw new NotImplementedException();
    }

    public Task GetChildrenMetaData()
    {
        throw new NotImplementedException();
    }

    public Task GetCollectionsTables()
    {
        throw new NotImplementedException();
    }

    public async Task<GetHistoryResponse> GetHistory(string authToken, string tautulliServerHost, GetHistoryRequest request)
    {
        HttpClient client = this.httpClientFactory.CreateClient(TautulliClientName);
        
        Dictionary<string,string> queryParameters = request
            .GetType()
            .GetProperties()
            .ToDictionary(property => property.Name, property => property.GetValue(request).ToString());

        queryParameters["apikey"] = authToken;
        queryParameters["cmd"] = "get_history";
        
        var queryString = $"{string.Join("&", queryParameters.Select(kvp => $"{kvp.Key}={HttpUtility.UrlEncode(kvp.Value)}"))}";
        
        HttpResponseMessage response = await client.GetAsync($"{tautulliServerHost}/{TautulliApiPath}?{queryString}");

        string responseBodyJson = await response.Content.ReadAsStringAsync();
         
        GetHistoryResponse result = JsonSerializer.Deserialize(
            responseBodyJson,
            TautulliClientJsonContext.Default.GetHistoryResponse
        ) ?? throw new Exception("Error deserializing response");

        return result;
    }

    public Task GetHomeStats()
    {
        throw new NotImplementedException();
    }

    public Task GetItemUserStats()
    {
        throw new NotImplementedException();
    }

    public Task GetItemWatchTimeStats()
    {
        throw new NotImplementedException();
    }

    public Task GetMetaData()
    {
        throw new NotImplementedException();
    }

    public Task GetNewRatingKeys()
    {
        throw new NotImplementedException();
    }

    public Task GetOldRatingKeys()
    {
        throw new NotImplementedException();
    }
}