using MASTERAPI.Data;
using MASTERAPI.Model;
using MASTERAPI.UnitOfWork;
using Microsoft.AspNetCore.Http.HttpResults;

namespace MASTERAPI.Services
{
    public class ProductService : IProductService
    {
        private IApplicationUnitOfWork _unitOfWork;

        public ProductService(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> AddProductAsync(Product product)
        {
            try
            {
                _unitOfWork.Products.Add(product);
                _unitOfWork.Save();
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return false;   
            }
        }

        public  IList<Product> GetAllProducts()
        {
           return  _unitOfWork.Products.GetAll();
        }
    }
}
