namespace Tautulli.Net.Sdk;

public interface ITautulliLibrariesClient
{
    Task GetLibraries();
    Task GetLibrary();
    Task GetLibraryMediaInfo();
    Task GetLibraryNames();
    Task GetLibraryUserStats();
    Task GetLibraryWatchTimeStats();

}