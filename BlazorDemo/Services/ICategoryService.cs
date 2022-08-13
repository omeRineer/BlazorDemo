using BlazorDemo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDemo.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAll();
    }
}
