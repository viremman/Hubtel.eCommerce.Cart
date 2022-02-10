using System.ComponentModel.DataAnnotations.Schema;

namespace Hubtel.eCommerce.Cart.Api.Entities
{
    public class Cart : BaseEntity
    {
        //foreign key to item entity
        [ForeignKey("Item")]
        public int ItemID { get; set; }
        //public Item Item { get; set; }

        //foreign key to customer entity
        [ForeignKey("Customer")]
        public string PhoneNumber { get; set; }
        //public Customer Customer { get; set; }

        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
