using System.Net;
using FluentAssertions;

namespace Tautulli.Net.Sdk.Tests;

public class TautulliApiFakeHandler : HttpClientHandler
{
    public string ApiPath { get; } = "/api/v2";
    public string Host { get; init; } = "fakeurl.com";
    public string ApiKey { get; init; } = "fakeApiKey";
    public string Command { get; }
    public IReadOnlyDictionary<string, string> Parameters { get; }
    public string Response { get; }

    public TautulliApiFakeHandler(string command, IReadOnlyDictionary<string, string> parameters, string response)
    {
        Command = command;
        Parameters = parameters;
        Response = response;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        request.RequestUri.PathAndQuery.Should()
            .Contain(ApiPath)
            .And.Contain($"apikey={ApiKey}")
            .And.Contain($"cmd={Command}");
        request.RequestUri.Host.Should().Be(Host);
        
        foreach(var parameter in Parameters)
        {
            request.RequestUri.PathAndQuery.Should().Contain($"{parameter.Key}={parameter.Value}");
        }

        return Task.FromResult(new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.OK,
            Content = new StringContent(Response)
        });
    }
}