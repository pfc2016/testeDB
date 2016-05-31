using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class LymphocytesSubsets : LabExams{

     /*   [Key]
        public int Lymphocytes_id {
            get; set;
        }*/
        public double Lymphocytes_units
        {
            get; set;
        }
        public double CD3 {
            get; set;
        }

        public double CD4 {
            get; set;
        }

        public double CD8 {
            get; set;
        }

        public  double T_lymphocytes {
            get; set;
        }
    }
}
