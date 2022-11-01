namespace Tautulli.Net.Sdk;

public interface ITautulliServerClient
{
    Task GetServerFriendlyName();
    Task GetServerId();
    Task GetServerIdentity();
    Task GetServersList();
    Task GetServersPref();
    Task GetServersInfo();
    Task GetTautulliInfo();

}