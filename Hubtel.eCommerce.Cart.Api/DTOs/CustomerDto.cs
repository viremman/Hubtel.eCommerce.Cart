using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.eCommerce.Cart.Api.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
