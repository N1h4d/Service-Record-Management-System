using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ReserveService : IEntity // ehtiyyatta xidmet
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public DateTime ServicePeriodStart { get; set; }
        public DateTime ServicePeriodEnd { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
