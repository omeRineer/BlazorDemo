using BlazorDemo.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorDemo.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly HttpClient _httpClient;
        private string Url { get; } = "https://my-json-server.typicode.com/omerineer/FakeDB/categories/";

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Category>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<Category>>(Url);
        }

    }
}
