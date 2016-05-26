using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class RBCIndices : LabExams{

        [Key]
        public int RBCIndixes_id {
            get; set;
        }

        public Units MCH {
            get; set;
        }

        public Units MCHC {
            get; set;
        }

        public Units MCV {
            get; set;
        }

        public Units Amylase {
            get; set;
        }

        public Units Cholesterol {
            get; set;
        }

        public Units CPK {
            get; set;
        }

        public Units Globulin {
            get; set;
        }

    }
}
