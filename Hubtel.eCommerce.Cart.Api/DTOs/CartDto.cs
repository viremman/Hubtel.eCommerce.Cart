using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.eCommerce.Cart.Api.DTOs
{
    public class CartDto
    {
        public int? Id { get; set; }
        public int ItemID { get; set; }

        public string PhoneNumber { get; set; }

        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
