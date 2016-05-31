using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class KFT : LabExams {

       
        public double BUN {
            get; set;
        }

        public double Creatinine {
            get; set;
        }

        public double uricAcid {
            get; set;
        }
    }
}
