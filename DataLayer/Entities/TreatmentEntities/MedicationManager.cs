using DataLayer.Entities.Visitas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.TreatmentEntities {
    public class MedicationManager {

        [Key]
        public int MedicationManager_id {
            get; set;
        }

        /// <summary>
        /// Navigation prop
        /// </summary>
        public virtual ClinicRegistryManager Clinic_registry_manager {
            get; set;
        }

        public virtual List<Medication> Medications {
            get; set;
        }



    }
}
