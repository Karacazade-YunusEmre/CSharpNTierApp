using NTierApp.Business.Abstract;
using NTierApp.DataAccess.Abstract;
using NTierApp.Entities.Concrete;

namespace NTierApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll().Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll().Where(p => p.ProductName != null && p.ProductName.ToLower().Contains(productName.ToLower())).ToList();
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
    }
}
