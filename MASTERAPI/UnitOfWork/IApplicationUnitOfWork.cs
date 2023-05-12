using MASTERAPI.Repositories;

namespace MASTERAPI.UnitOfWork
{
    public interface IApplicationUnitOfWork:IUnitOfWork
    {
        ICategoryRepository Categories { get; set; }
        IProductRepository Products { get; set; }
    }
}