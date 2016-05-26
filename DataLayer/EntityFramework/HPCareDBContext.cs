using DataLayer.Entities;
using DataLayer.Entities.DiagnosisEntities;
using DataLayer.Entities.MCDT;
using DataLayer.Entities.PatientEntities;
using DataLayer.Entities.TreatmentEntities;
using DataLayer.Entities.Visitas;
using DataLayer.Entities.Visits;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityFramework {
    public class HPCareDBContext : DbContext {

        public HPCareDBContext() : base("HPCareDBContext") { }

        public DbSet<CID> CIDs {
            get; set;
        }

        public DbSet<CIDCode> CIDCodes {
            get; set;
        }

        public DbSet<CIDGenerator> CIDGenerators {
            get; set;
        }

        public DbSet<Diagnosis> Diagnoses {
            get; set;
        }

        public DbSet<Disease> Diseases {
            get; set;
        }

        public DbSet<PatientDiagnosisManager> PatientDiagnosisManagers {
            get; set;
        }

        //kft
        //labexams
        //lft
        //lymphocytessubsets
        //mcdt

        public DbSet<MCDTManager> MCDTManagers {
            get; set;
        }

        public DbSet<MCDTStaffManager> MCDTStaffManagers {
            get; set;
        }

        //physicalexam
        //plateletscount
        //phychiatricexam
        //rbcindices
        //rbcs
        //regularexam
        //viralload
        //wbcs

        public DbSet<Admission> Admissions {
            get; set;
        }

        public DbSet<Calendar> Calendars {
            get; set;
        }

        public DbSet<Intervention> Interventions {
            get; set;
        }

        public DbSet<NextOfKin> NextOfKins {
            get; set;
        }

        public DbSet<NextOfKinManager> NextOfKinManagers {
            get; set;
        }

        public DbSet<TreatmentPlan> TreatmentPlans {
            get; set;
        }

        //arv
        //arvclass
        //medication
        public DbSet<MedicationManager> MedicationManagers {
            get; set;
        }

        //nonarv


        public DbSet<Therapy> Therapies {
            get; set;
        }

        public DbSet<TherapyManager> TherapyManagers {
            get; set;
        }

        public DbSet<AgeGroup> AgeGroups {
            get; set;
        }

        public DbSet<Allergies> Allergies {
            get; set;
        }

        public DbSet<AllergiesManager> AllergiesManagers {
            get; set;
        }

        public DbSet<FamilyHistory> FamilyHistories {
            get; set;
        }

        public DbSet<FamilyHistoryManager> FamilyHistoryManagers {
            get; set;
        }

        //patient

        public DbSet<RiskFactors> RiskFactors {
            get; set;
        }

        public DbSet<RiskFactorsManager> RiskFactorsManagers {
            get; set;
        }

        //staff
        //user

        public DbSet<ClinicRegistryManager> ClinicRegistryManagers {
            get; set;
        }

        //firstVisit
        //HomeVisit

        public DbSet<HomeVisitManager> HomeVisitManagers {
            get; set;
        }

        //SubsequentVisit
        //visit

        public DbSet<VisitManager> VisitManagers {
            get; set;
        }
        
        //COMENTARIO INFORMATIVO 
    }
}
