using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class MilitaryServiceDto : IDto
    {
        public int PersonalInformationId { get; set; }
        public string MilitaryRank { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string OrderNumber { get; set; }
    }

}
