using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class AcademicDegree : IEntity // elmi derece
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string DegreeName { get; set; }
        public string Institution { get; set; }
        public DateTime AwardDate { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
