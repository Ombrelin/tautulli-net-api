namespace Tautulli.Net.Sdk;

public interface ITautulliPlaysClient
{
    Task GetPlaysByDate();
    Task GetPlaysByDayOfWeek();
    Task GetPlaysByHourOfDay();
    Task GetPlaysBySourceResolution();
    Task GetPlaysByStreamResolution();
    Task GetPlaysByStreamType();
    Task GetPlaysByTop10Platforms();
    Task GetPlaysByTop10Users();
    Task GetPlaysByMonth();

}