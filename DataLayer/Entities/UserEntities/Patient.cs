using DataLayer.Entities.DiagnosisEntities;
using DataLayer.Entities.MCDT;
using DataLayer.Entities.PatientEntities;
using DataLayer.Entities.Visitas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities {
    public class Patient : User {

        [Key]
        public int Patient_id {
            get; set;
        }

        public AgeGroup Patient_Age_Group {
            get; set;
        }

        public RiskFactorsManager RiskFactorManager {
            get; set;
        }

        public AllergiesManager AllergiesManager {
            get; set;
        }

        public FamilyHistoryManager FamilyHistoryManager {
            get; set;
        }

        /// <summary>
        /// O doente vai ter vários tipos de MCDTs
        /// </summary>
        public List<MCDTManager> MCDT_manager {
            get; set;
        }

        /// <summary>
        /// O doente vai ter vários registos clínicos 
        /// </summary>
        public List<ClinicRegistryManager> Clinic_registry {
            get; set;
        }

        public TreatmentPlan Patient_treatment_plan {
            get; set;
        }

        public Admission Patient_admission {
            get; set;
        }

        public List<PatientDiagnosisManager> Patient_diagnosis_manager {
            get; set;
        }
    }
}
