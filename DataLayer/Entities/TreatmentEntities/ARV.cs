using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.TreatmentEntities {
    public class ARV : Medication{

        public ARVClass ARV_class {
            get; set;
        }

    }
}
