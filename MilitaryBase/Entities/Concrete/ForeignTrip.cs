using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class ForeignTrip : IEntity // xarici seferler
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string Country { get; set; }
        public string Purpose { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
