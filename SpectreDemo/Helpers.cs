using Spectre.Console;

namespace SpectreDemo;

public static class Helpers
{
    public static async Task<string> FetchApiDataAsync(string apiUrl)
    {
        using HttpClient client = new();
        try
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            AnsiConsole.MarkupLine($"[red]Error fetching API data:[/] {ex.Message}");
            return string.Empty;
        }
    }
    
}