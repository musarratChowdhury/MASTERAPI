using MASTERAPI.Model;

namespace MASTERAPI.Services
{
    public interface IProductService
    {
        IList<Product> GetAllProducts();   
        Task<bool> AddProductAsync(Product product);
    }
}