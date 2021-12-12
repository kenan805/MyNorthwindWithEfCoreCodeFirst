using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNorthwindWithEfCoreCodeFirst.Models
{
    public class OrderDetail : BaseEntity
    {
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }

        // Foreign Key
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        // Relational Property
        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
