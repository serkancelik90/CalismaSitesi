using CalismaSitesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalismaSitesi.Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
