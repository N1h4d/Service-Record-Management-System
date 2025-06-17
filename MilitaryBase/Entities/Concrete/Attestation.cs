using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class Attestation : IEntity //attestasiya , ele bil ki sexsin atestasitya prosesine aid melumatlari saxlanir
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public DateTime AttestationDate { get; set; }
        public string Decision { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
