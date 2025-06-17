using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Entities.Concrete
{
    public class MilitaryFitness : IEntity // herbi xidtmeye uygunluq (yararliliq)
    {
        public int Id { get; set; }
        public int PersonalInformationId { get; set; }
        public string FitnessCategory { get; set; }
        public DateTime EvaluationDate { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}
