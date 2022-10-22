using NTierApp.Entities.Abstract;

namespace NTierApp.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public String? CategoryName { get; set; }

    }
}
