using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    class RoleUserDTO
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public RoleDto Role { get; set; }
        public int IdUser { get; set; }
        public UserDTO User { get; set;  }
    }
}
