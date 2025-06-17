using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class DrivingLicense : IEntity //suruculuk melumatlARI
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
