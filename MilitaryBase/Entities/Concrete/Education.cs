using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class Education : IEntity// sexsin tehsil melumatlarini saxlayan cedvel
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string EducationLevel { get; set; }
        public string InstitutionName { get; set; }
        public string Faculty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DiplomaNumber { get; set; }

        public PersonalInformation PersonalInformation { get; set; }
    }
}
