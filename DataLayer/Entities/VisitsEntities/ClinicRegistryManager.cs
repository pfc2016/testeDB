using DataLayer.Entities.TreatmentEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Visitas {
    public class ClinicRegistryManager {

        [Key]
        public int ClinicRegistryManager_id {
            get; set;
        }

        /// <summary>
        /// Navigation prop
        /// </summary>
        public Patient Clinic_patient {
            get; set;
        }

        /// <summary>
        /// O doente pode ter vários medicamentos 
        /// </summary>
        public virtual List<MedicationManager> Medication_manager {
            get; set;
        }

        public Staff Clinic_registry_doctor {
            get; set;
        }

        public TherapyManager Therapy_manager {
            get; set;
        }

    }
}
