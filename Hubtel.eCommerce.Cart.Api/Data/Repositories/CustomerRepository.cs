using Hubtel.eCommerce.Cart.Api.Data.Context;
using Hubtel.eCommerce.Cart.Api.Data.Interfaces;
using Hubtel.eCommerce.Cart.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.eCommerce.Cart.Api.Data.Repositories
{
    public class CustomerRepository : GenericRepository<Entities.Customer>, ICustomer
    {
        public CustomerRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
