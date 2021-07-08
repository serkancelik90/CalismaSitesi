using CalismaSitesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalismaSitesi.Entities.Concrete
{
    public class OrderProduct:IEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
