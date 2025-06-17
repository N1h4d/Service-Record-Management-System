using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SkillLevel : IEntity// meharet ve ixtisas dereceleeri
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string SkillName { get; set; }
        public DateTime CertificationDate { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
