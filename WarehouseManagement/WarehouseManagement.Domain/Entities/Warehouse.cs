using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Domain.Entities
{
    public class Warehouse : BaseEntity
    {
        public required string Name { get; set; }
        public string? Location {  get; set; }
        public ICollection<Product> Products {  get; set; }

        public ICollection<StockMovement> StockMovements { get; set; }
        public ICollection<Stock> Stocks   { get; set; }
    }
}
