using System;using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class LFT : LabExams {

        [Key]
        public int LFT_id {
            get; set;
        }

        public Units SGT {
            get; set;
        }

        public Units AST {
            get; set;
        }

        public Units LDH {
            get; set;
        }

        public Units Alkaline {
            get; set;
        }

        public Units Bilirubin {
            get; set;
        }

    }
}
