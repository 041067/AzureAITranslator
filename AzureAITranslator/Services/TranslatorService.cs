namespace AzureAITranslator.Services;

using System.Net.Http.Json;
using System.Text.Json;

public sealed class TranslatorService
{
    private readonly IConfiguration _config;
    private readonly HttpClient _httpClient;

    public TranslatorService(IConfiguration config)
    {
        _config = config;
        _httpClient = new HttpClient();
    }

    public async Task<string> TranslateAsync(string text)
    {
        var endpoint = _config["Translator:Endpoint"];
        var key = _config["Translator:Key"];
        var region = _config["Translator:Region"];

        var uri = $"{endpoint}/translate?api-version=3.0&from=en&to=pt-br";

        using var request = new HttpRequestMessage(HttpMethod.Post, uri);
        request.Headers.Add("Ocp-Apim-Subscription-Key", key);
        request.Headers.Add("Ocp-Apim-Subscription-Region", region);

        request.Content = JsonContent.Create(new[]
        {
            new { Text = text }
        });

        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadFromJsonAsync<JsonElement>();

        return json[0]
            .GetProperty("translations")[0]
            .GetProperty("text")
            .GetString();
    }
}
