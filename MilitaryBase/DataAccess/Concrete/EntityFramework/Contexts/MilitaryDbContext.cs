using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class MilitaryDbContext : DbContext
    {
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EmploymentHistory> EmploymentHistories { get; set; }
        public DbSet<MilitaryService> MilitaryServices { get; set; }
        public DbSet<CombatExperience> CombatExperiences { get; set; }
        public DbSet<ServiceAgreement> ServiceAgreements { get; set; }
        public DbSet<ForeignTrip> ForeignTrips { get; set; }
        public DbSet<StateAward> StateAwards { get; set; }
        public DbSet<ForeignLanguage> ForeignLanguages { get; set; }
        public DbSet<FamilyInformation> FamilyInformations { get; set; }
        public DbSet<LegalIssue> LegalIssues { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<MedicalExamination> MedicalExaminations { get; set; }
        public DbSet<SkillLevel> SkillLevels { get; set; }
        public DbSet<ProfessionalDevelopment> ProfessionalDevelopments { get; set; }
        public DbSet<AcademicDegree> AcademicDegrees { get; set; }
        public DbSet<Attestation> Attestations { get; set; }
        public DbSet<ReserveService> ReserveServices { get; set; }
        public DbSet<MilitaryFitness> MilitaryFitnesses { get; set; }
        public DbSet<DrivingLicense> DrivingLicenses { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1MPQGHV\\MSSQLSERVER01;Database=MilitaryBaseDb;User Id=sa;Password=123;TrustServerCertificate=True;");
        }
    }
}
