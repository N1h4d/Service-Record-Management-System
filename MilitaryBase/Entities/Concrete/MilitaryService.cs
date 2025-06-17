using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class MilitaryService : IEntity// herbi xidmet melumatlari
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string MilitaryRank { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string OrderNumber { get; set; }

        public PersonalInformation PersonalInformation { get; set; }
    }
}
