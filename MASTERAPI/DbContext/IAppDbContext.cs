using MASTERAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MASTERAPI.Data
{
    public interface IAppDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }

        int SaveChanges();
    }
}