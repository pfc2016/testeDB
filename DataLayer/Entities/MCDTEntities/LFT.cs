using System;using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class LFT : LabExams {

   /*     [Key]
        public int LFT_id {
            get; set;
        }
        */
        public double SGT {
            get; set;
        }

        public double AST {
            get; set;
        }

        public double LDH {
            get; set;
        }

        public double Alkaline {
            get; set;
        }

        public double Bilirubin {
            get; set;
        }

    }
}
