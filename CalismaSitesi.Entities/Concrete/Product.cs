using CalismaSitesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalismaSitesi.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitInPrice { get; set; }
        public Category Category { get; set; }
        public ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
