using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class FamilyInformationDto : IDto
    {
        public int PersonalInformationId { get; set; }
        public string Relationship { get; set; }
        public string FullName { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
    }

}
