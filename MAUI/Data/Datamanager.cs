using Domain.Entities.ExcerciseEntities;
using System.Text.Json;

namespace BestMauiApp.Data;

public static class Datamanager
{
    // TODO: Add fields for BaseAddress, Url, and authorizationKey
    static readonly string BaseAddress = "https://localhost:7254";
    static readonly string Url = $"{BaseAddress}/api/";

    static HttpClient client;

    private static async Task<HttpClient> GetClient()
    {
        if (client != null)
            return client;

        client = new HttpClient();

        //if (string.IsNullOrEmpty(authorizationKey))
        //{
        //    authorizationKey = await client.GetStringAsync($"{Url}login");
        //    authorizationKey = JsonSerializer.Deserialize<string>(authorizationKey);
        //}

        //client.DefaultRequestHeaders.Add("Authorization", authorizationKey);
        client.DefaultRequestHeaders.Add("Accept", "application/json");

        return client;
    }

    public static async Task<List<Excercise>> GetAll()
    {
        if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            return new List<Excercise>();

        var client = await GetClient();
        string result = await client.GetStringAsync($"{Url}/Excercise/all");

        return JsonSerializer.Deserialize<List<Excercise>>(result);
    }

    public static async Task<Excercise> Add(string partName, string supplier, string partType)
    {
        throw new NotImplementedException();
    }

    public static async Task Update(Excercise part)
    {
        throw new NotImplementedException();
    }

    public static async Task Delete(string partID)
    {
        throw new NotImplementedException();
    }
}
