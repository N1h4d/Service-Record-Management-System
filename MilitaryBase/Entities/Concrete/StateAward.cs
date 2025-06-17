using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class StateAward : IEntity// dovlet teltifleri
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string AwardName { get; set; }
        public DateTime AwardDate { get; set; }
        public string OrderNumber { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
