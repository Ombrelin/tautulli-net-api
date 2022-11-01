using System.Text.Json;
using FluentAssertions;
using Moq;
using Tautulli.Net.Sdk.Dto;
using Tautulli.Net.Sdk.Json;

namespace Tautulli.Net.Sdk.Tests;

public class TautulliApiClientTests
{
    [Fact]
    public async Task GetHistory_ReturnsCorrectData()
    {
        // Given
        string givenJsonResponse = await File.ReadAllTextAsync("ApiResponses/get_history.json");
        var fakeHandler = new TautulliApiFakeHandler("get_history", new Dictionary<string, string>(), givenJsonResponse);

        IHttpClientFactory httpFactoryMock = GetMockHttpClientFactory(fakeHandler);
        var client = new TautulliApiClient(httpFactoryMock);

        // When
        GetHistoryResponse result = await client.GetHistory(fakeHandler.ApiKey, $"https://{fakeHandler.Host}", new GetHistoryRequest());
        
        // Then
        string jsonResult = JsonSerializer.Serialize(result, TautulliClientJsonContext.Default.GetHistoryResponse);
        jsonResult.Should().Be(jsonResult);
    }

    private static IHttpClientFactory GetMockHttpClientFactory(HttpMessageHandler fakeHandler)
    {
        var httpFactoryMock = new Mock<IHttpClientFactory>();
        httpFactoryMock
            .Setup(mock => mock.CreateClient(It.IsAny<string>()))
            .Returns(new HttpClient(fakeHandler));
        return httpFactoryMock.Object;
    }
}