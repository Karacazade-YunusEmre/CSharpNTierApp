using System.ComponentModel.DataAnnotations;
using NTierApp.Business.Abstract;
using NTierApp.Business.ValidationRules.FluentValidation;
using NTierApp.DataAccess.Abstract;
using NTierApp.Entities.Concrete;

namespace NTierApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private static ProductValidator? _productValidator;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
            _productValidator ??= new ProductValidator();
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal
                .GetAll(p => p.ProductName != null && p.ProductName.ToLower().Contains(productName.ToLower())).ToList();
        }

        public void Add(Product product)
        {
            _Validate(product);
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _Validate(product);
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                Console.WriteLine("Silme işlemi sırasında hata oluştu!");
            }
        }

        private static void _Validate(Product product)
        {
            if (_productValidator != null)
            {
                var result = _productValidator.Validate(product);
                if (result.Errors.Count > 0)
                {
                    throw new ValidationException(result.ToString());
                }
            }
        }
    }
}