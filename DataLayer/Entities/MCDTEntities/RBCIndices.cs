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

        public double MCH {
            get; set;
        }

        public double MCHC {
            get; set;
        }

        public double MCV {
            get; set;
        }

        public  double Amylase {
            get; set;
        }

        public double Cholesterol {
            get; set;
        }

        public double CPK {
            get; set;
        }

        public double Globulin {
            get; set;
        }

    }
}
