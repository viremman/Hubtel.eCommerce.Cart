using Hubtel.eCommerce.Cart.Api.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.eCommerce.Cart.Api.Data.Seeds
{
    public static class DefaultData
    {

        public static void SeedCarts(ApplicationDbContext context)
        {
            if (!context.Carts.Any())
            {
                var carts = new List<Entities.Cart>
                {
                    new Entities.Cart{ItemID = 1, CreatedAt = DateTime.Now, ItemName = "Pen", PhoneNumber = "0244198940", Quantity = 2, UnitPrice = 3},
                    new Entities.Cart{ItemID = 2, CreatedAt = DateTime.Now, ItemName = "Book", PhoneNumber = "0244198640", Quantity = 1, UnitPrice = 13},
                    new Entities.Cart{ItemID = 3, CreatedAt = DateTime.Now, ItemName = "Wrapper", PhoneNumber = "0240198940", Quantity = 6, UnitPrice = 7},
                    new Entities.Cart{ItemID = 4, CreatedAt = DateTime.Now, ItemName = "Cover", PhoneNumber = "0244568940", Quantity = 10, UnitPrice = 4},
                    new Entities.Cart{ItemID = 5, CreatedAt = DateTime.Now, ItemName = "Phone", PhoneNumber = "0244348940", Quantity = 1, UnitPrice = 1000},
                    new Entities.Cart{ItemID = 6, CreatedAt = DateTime.Now, ItemName = "Chair", PhoneNumber = "0244178940", Quantity = 3, UnitPrice = 900}
                };

                context.AddRange(carts);
                context.SaveChanges();
            }
        }
    }
}
