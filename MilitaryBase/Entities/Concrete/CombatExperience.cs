using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CombatExperience : IEntity //doyus istiraki , doyusde istirak etmis sexsin meluamtlari saxlanir
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string OperationName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InjuryDetails { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
