using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class DrivingLicenseDto : IDto
    {
        public int PersonalInformationId { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; }
    }
}
