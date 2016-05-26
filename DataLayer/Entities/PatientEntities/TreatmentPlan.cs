using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.PatientEntities {
    public class TreatmentPlan {

        [Key]
        public int Treatment_id {
            get; set;
        }

        public DateTime Treatment_start_date {
            get; set;
        }

        public DateTime Treatment_end_date {
            get; set;
        }

        public TreatmentType Treatment_type {
            get; set;
        }
    }
}
