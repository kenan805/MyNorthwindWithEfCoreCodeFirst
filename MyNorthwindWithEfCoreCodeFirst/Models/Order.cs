using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNorthwindWithEfCoreCodeFirst.Models
{
    public class Order : BaseEntity
    {
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipRegion { get; set; }
        public string? ShipPostalCode { get; set; }
        public string? ShipCountry { get; set; }

        // Foreign Key
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        // Relational Property
        public virtual Customer? Customer { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual List<OrderDetail>? OrderDetails { get; set; }
    }
}
