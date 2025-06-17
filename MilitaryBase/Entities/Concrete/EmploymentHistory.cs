using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class EmploymentHistory : IEntity // emek fealiyyweti
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string OrganizationName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
