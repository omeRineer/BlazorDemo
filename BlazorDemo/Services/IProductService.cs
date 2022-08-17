using BlazorDemo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDemo.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<bool> Add(Product product);
    }
}
