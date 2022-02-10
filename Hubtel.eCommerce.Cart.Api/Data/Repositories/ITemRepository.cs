using Hubtel.eCommerce.Cart.Api.Data.Context;
using Hubtel.eCommerce.Cart.Api.Data.Interfaces;

namespace Hubtel.eCommerce.Cart.Api.Data.Repositories
{
    public class ITemRepository : GenericRepository<Entities.Item>, IItem
    {
        public ITemRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
