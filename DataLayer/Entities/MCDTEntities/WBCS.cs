using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class WBCS : LabExams{

        [Key]
        public int WBCS_id {
            get; set;
        }

        public Units Basophil {
            get; set;
        }

        public Units Eosinophil {
            get; set;
        }

        public Units Monocytes {
            get; set;
        }

        public Units Neutrophil {
            get; set;
        }
    }
}
