using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class HealthRecord : IEntity // saglamliq melumatlari
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string MedicalCondition { get; set; }
        public DateTime DiagnosisDate { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
