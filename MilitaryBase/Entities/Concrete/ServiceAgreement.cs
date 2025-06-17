using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // sexsin herbi xidmete aid imzaladigi muqavileninc melumatlarini saxlayit
    public class ServiceAgreement : IEntity
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public DateTime AgreementDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string OrderNumber { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
