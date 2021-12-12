using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNorthwindWithEfCoreCodeFirst.Models
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        // Foreign Key 
        public int CategoryId { get; set; }

        // Relational Property
        public virtual Category? Category { get; set; }
        public virtual List<OrderDetail>? OrderDetails { get; set; }
    }
}
