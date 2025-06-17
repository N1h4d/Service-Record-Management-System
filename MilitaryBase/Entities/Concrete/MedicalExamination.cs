using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class MedicalExamination : IEntity // muayinenin neticeleri, burda tibbi muayinelerin neticeleri saxlanir
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string ExaminationType { get; set; }
        public DateTime ExaminationDate { get; set; }
        public string Result { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
