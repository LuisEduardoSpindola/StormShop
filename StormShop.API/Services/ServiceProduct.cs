using StormShop.API.Data;
using StormShop.API.Repositories; // Certifique-se de incluir o namespace correto

namespace StormShop.API.Services
{
    public class ServiceProduct
    {
        public RepositoryProduct _RepositoryProduct { get; set; }

        public ServiceProduct(AplicationContext context)
        {
            _RepositoryProduct = new RepositoryProduct(context);
        }
    }
}
