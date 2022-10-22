using NTierApp.Entities.Concrete;

namespace NTierApp.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
