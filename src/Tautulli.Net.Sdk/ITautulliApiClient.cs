using Tautulli.Net.Sdk.Dto;

namespace Tautulli.Net.Sdk;

public interface ITautulliApiClient
{
    Task GetActivity();
    Task GetApiKey();
    Task GetChildrenMetaData();
    Task GetCollectionsTables();
    Task<GetHistoryResponse> GetHistory(string authToken, string tautulliServerHost, GetHistoryRequest request);
    Task GetHomeStats();
    Task GetItemUserStats();
    Task GetItemWatchTimeStats();
    
    Task GetMetaData();
    Task GetNewRatingKeys();
    Task GetOldRatingKeys();
    



}