using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Domain.Entities
{
    public class Role : BaseEntity
    {
        
        public required string Name { get; set; }

        public ICollection<UserRoles> UserRoles { get; set; }

    }
}
