using MASTERAPI.Model;

namespace MASTERAPI.Services
{
    public interface ICategoryService
    {
        Task<bool> AddCategoryAsync(Category category);
    }
}