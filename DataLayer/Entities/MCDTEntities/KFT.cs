using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class KFT : LabExams {

        [Key]
        public int KFT_id {
            get; set;
        }

        public Units BUN {
            get; set;
        }

        public Units Creatinine {
            get; set;
        }

        public Units uricAcid {
            get; set;
        }
    }
}
