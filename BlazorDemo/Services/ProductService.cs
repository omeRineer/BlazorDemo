using BlazorDemo.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorDemo.Services
{
    public class ProductService:IProductService
    {
        private readonly HttpClient _httpClient;
        private string Url { get; } = "https://my-json-server.typicode.com/omerineer/FakeDB/products/";

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>(Url);
        }

        public async Task<Product> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>(Url + id);
        }
    }
}
