public class ApiDataReader : IApiDataReader
{
    public async Task<string> Read(string baseAddress, string requestUri)
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseAddress);
        HttpResponseMessage response = await client.GetAsync(requestUri);

        //check if it posible to catch data
        response.EnsureSuccessStatusCode();

        //extract json string from response
        return await response.Content.ReadAsStringAsync();
        
    }
}