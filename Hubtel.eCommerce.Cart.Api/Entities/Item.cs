using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.eCommerce.Cart.Api.Entities
{
    public class Item : BaseEntity
    {
        public Item()
        {
            Carts = new HashSet<Cart>();
        }

        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        public ICollection<Cart> Carts { get; set; }
    }
}
