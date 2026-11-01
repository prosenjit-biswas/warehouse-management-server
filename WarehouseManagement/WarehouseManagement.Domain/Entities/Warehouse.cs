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
    }
}
