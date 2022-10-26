using Ninject.Modules;
using NTierApp.Business.Abstract;
using NTierApp.Business.Concrete;
using NTierApp.DataAccess.Abstract;
using NTierApp.DataAccess.Concrete.EntityFramework;

namespace NTierApp.Business.DependencyResolvers.Ninject;

public class BusinessModule : NinjectModule
{
    public override void Load()
    {
        Bind<IProductService>().To<ProductManager>();
        Bind<ICategoryService>().To<CategoryManager>();

        Bind<IProductDal>().To<EfProductDal>();
        Bind<ICategoryDal>().To<EfCategoryDal>();
    }
}