namespace Tautulli.Net.Sdk;

public interface ITautulliUserClient
{
    Task GetUser();
    Task GetUserNames();
    Task GetUserPlayerStats();
    Task GetUserWatchTimeStats();
    Task GetUsers();
}