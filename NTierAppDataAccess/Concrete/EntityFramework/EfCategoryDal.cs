using NTierApp.DataAccess.Abstract;
using NTierApp.Entities.Concrete;

namespace NTierApp.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthWindContext>, ICategoryDal
    {
    }
}
