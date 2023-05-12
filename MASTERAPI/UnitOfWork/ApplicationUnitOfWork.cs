using MASTERAPI.Data;
using MASTERAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MASTERAPI.UnitOfWork
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {


        public IProductRepository Products { get; set; }
        public ICategoryRepository Categories { get; set; }
        public ApplicationUnitOfWork(IAppDbContext dbContext,
                                     IProductRepository productRepository,
                                     ICategoryRepository categoryRepository) : base((DbContext)dbContext)
        {
            Products = productRepository;
            Categories = categoryRepository;
        }
    }
}
