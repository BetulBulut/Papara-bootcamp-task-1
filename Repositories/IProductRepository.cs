using RestfulApiProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestfulApiProject.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAll();
    Task<Product> GetById(int id);
    Task Add(Product product);
    Task Update(Product product);
    Task Delete(int id);
}
