using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    class ExperiencePopulation
    {
        public int Id { get; set; }
      public int   ExperienceId { get; set; }

      public Experience Experience { get; set; }

        public int PopulationGradeId { get; set; }

        public PopulationGrade PopulationGrade { get; set; }
    
      public DateTime DeleteAt { get; set; }
        public DateTime CreateAt { get; set; }

    }
}