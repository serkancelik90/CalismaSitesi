using CalismaSitesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalismaSitesi.Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
