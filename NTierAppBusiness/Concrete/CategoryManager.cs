using NTierApp.Business.Abstract;
using NTierApp.DataAccess.Abstract;
using NTierApp.Entities.Concrete;

namespace NTierApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();

        }
    }
}
