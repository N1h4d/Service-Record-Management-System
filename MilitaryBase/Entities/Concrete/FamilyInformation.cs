using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class FamilyInformation : IEntity// aile melumatlari
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string Relationship { get; set; }
        public string FullName { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
