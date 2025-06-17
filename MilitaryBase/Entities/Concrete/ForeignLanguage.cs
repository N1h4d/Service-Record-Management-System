using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class ForeignLanguage : IEntity
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string Language { get; set; }
        public string ProficiencyLevel { get; set; } // seviye
        public PersonalInformation PersonalInformation { get; set; }
    }
}
