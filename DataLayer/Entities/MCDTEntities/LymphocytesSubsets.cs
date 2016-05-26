using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class LymphocytesSubsets : LabExams{

        [Key]
        public int Lymphocytes_id {
            get; set;
        }

        public Units CD3 {
            get; set;
        }

        public Units CD4 {
            get; set;
        }

        public Units CD8 {
            get; set;
        }

        public Units T_lymphocytes {
            get; set;
        }
    }
}
