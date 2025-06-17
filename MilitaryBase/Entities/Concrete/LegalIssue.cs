using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class LegalIssue : IEntity // Məsuliyyətə Cəlb Edilmə
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string IncidentDetails { get; set; }
        public DateTime IncidentDate { get; set; }
        public string Verdict { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
