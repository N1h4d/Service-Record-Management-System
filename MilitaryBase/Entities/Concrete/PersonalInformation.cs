using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class PersonalInformation : IEntity // sexsi melumatlar
    {
        public int PersonalInformationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Citizenship { get; set; }
        public string FIN { get; set; }
        public string BloodType { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ICollection<Education>? Educations { get; set; }
        public ICollection<EmploymentHistory>? EmploymentHistories { get; set; }
        public ICollection<MilitaryService>? MilitaryServices { get; set; }
        public ICollection<CombatExperience>? CombatExperiences { get; set; }
        public ICollection<ServiceAgreement>? ServiceAgreements { get; set; }
        public ICollection<ForeignTrip>? ForeignTrips { get; set; }
        public ICollection<StateAward>? StateAwards { get; set; }
        public ICollection<ForeignLanguage>? ForeignLanguages { get; set; }
        public ICollection<FamilyInformation>? FamilyInformations { get; set; }
        public ICollection<LegalIssue>? LegalIssues { get; set; }
        public ICollection<HealthRecord>? HealthRecords { get; set; }
        public ICollection<MedicalExamination>? MedicalExaminations { get; set; }
        public ICollection<SkillLevel>? SkillLevels { get; set; }
        public ICollection<ProfessionalDevelopment>? ProfessionalDevelopments { get; set; }
        public ICollection<AcademicDegree>? AcademicDegrees { get; set; }
        public ICollection<Attestation>? Attestations { get; set; }
        public ICollection<ReserveService>? ReserveServices { get; set; }
        public ICollection<MilitaryFitness>? MilitaryFitnesses { get; set; }
        public ICollection<DrivingLicense>? DrivingLicenses { get; set; }
    }
}
