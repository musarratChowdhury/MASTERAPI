using MASTERAPI.Data;
using MASTERAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MASTERAPI.Repositories
{
    public class CategoryRepository:Repository<Category,int>,ICategoryRepository
    {
        public CategoryRepository(IAppDbContext context) : base((DbContext)context)
        {
            
        }
    }
}
