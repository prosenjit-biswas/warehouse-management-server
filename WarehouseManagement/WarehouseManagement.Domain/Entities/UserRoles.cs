using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Domain.Entities
{
    public class UserRoles
    { 
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }


        public User user { get; set; }
        public Role role { get; set; }

    }
}
