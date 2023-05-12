using MASTERAPI.Data;
using MASTERAPI.Model;
using MASTERAPI.UnitOfWork;

namespace MASTERAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;

        public CategoryService(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> AddCategoryAsync(Category category)
        {
            try
            {
                _unitOfWork.Categories.Add(category);
                _unitOfWork.Save(); 
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return false;
            }
        }
    }
}
