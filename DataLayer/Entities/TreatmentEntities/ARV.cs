using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.TreatmentEntities {
    public class ARV : Medication{

        [Key]
        public int ARV_id {
            get; set;
        }

        public string ARV_class {
            get; set;
        }

    }
}
