using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ModelExperience
{
    class UserRol
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeleteAt { get; set; }
    }
}