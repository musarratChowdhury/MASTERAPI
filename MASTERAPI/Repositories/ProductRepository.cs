using MASTERAPI.Data;
using MASTERAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MASTERAPI.Repositories
{
    public class ProductRepository : Repository<Product, int>,IProductRepository
    {
        public ProductRepository(IAppDbContext context) : base((DbContext)context)
        {
        }
    }
}
