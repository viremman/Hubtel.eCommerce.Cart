using Hubtel.eCommerce.Cart.Api.Data.Context;
using Hubtel.eCommerce.Cart.Api.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.eCommerce.Cart.Api.Data.Repositories
{
    public class CartRepository : GenericRepository<Entities.Cart>, ICart
    {
        public CartRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
