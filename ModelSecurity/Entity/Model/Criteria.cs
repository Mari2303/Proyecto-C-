
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    class Criteria
    {
        public int Id { get; set; }
        
        public string name { get; set; }  
              
        public DateTime DeleteAt { get; set; }
        public DateTime CreateAt { get; set; }

    }
}