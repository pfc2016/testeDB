using DataLayer.Entities.PatientEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.TreatmentEntities {
    public class Medication {

        [Key]
        public int Medication_id {
            get; set;
        }

        public string Medication_name {
            get; set;
        }

        public DateTime Medication_start_date {
            get; set;
        }

        public DateTime Medication_end_date {
            get; set;
        }

        public int Medication_dosage {
            get; set;
        }

        public MedicationFrequency Medication_frequency {
            get; set;
        }

        public MedicationAdministration Medication_administration {
            get; set;
        }

        /// <summary>
        /// Navigation prop
        /// </summary>
        public virtual MedicationManager Medication_manager {
            get; set;
        }

    }
}
