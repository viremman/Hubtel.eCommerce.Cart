using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.eCommerce.Cart.Api.Entities
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            Carts = new HashSet<Cart>();
        }

        [Key]
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Cart> Carts { get; set; }
    }
}
