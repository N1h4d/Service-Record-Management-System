using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ProfessionalDevelopment : IEntity// ixtisas artirma
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string CourseName { get; set; }
        public DateTime CompletionDate { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
