using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    class ExperiencieDTO
    {
        public int Id { get; set; }
        public string NameExperience { get; set; }
        public DateTime DataTime { get; set; }
        public DateTime DurationDays { get; set; }
        public DateTime DurationMonth { get; set; }
        public DateTime DurationYears { get; set; }
        public string Summary { get; set; }
        public string Methodologies { get; set; }
        public string Transfer { get; set; }
        public string DateRegistration { get; set; }
        public int UserId1 { get; set; }
        public int InstitutionId1 { get; set; }
        public int IntitutionId2 { get; set; }

    }
}
