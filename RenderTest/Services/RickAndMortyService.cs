using Microsoft.AspNetCore.Components;
using RenderTest.Models;
using RenderTest.Services.IServices;
using System.Net.Http.Json;

namespace RenderTest.Services
{
    public class RickAndMortyService : IRickAndMortyService
    {

        private readonly HttpClient _httpClient;

        const string url = "https://rickandmortyapi.com/api/character";
        public RickAndMortyService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<RickAndMorty> Get()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<RickAndMorty>(url);
                return response;
            }
            catch (Exception e)
            {
                return null;
            }
           
        }

    }
}
