using NTierApp.Entities.Concrete;

namespace NTierApp.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByProductName(string productName);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
