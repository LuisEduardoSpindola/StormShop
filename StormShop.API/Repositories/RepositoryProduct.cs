using StormShop.API.Data;
using StormShop.API.Models;

namespace StormShop.API.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>
    {
        public RepositoryProduct(AplicationContext context) : base(context)
        {
        }
    }
}
