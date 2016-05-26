using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities {
    public class Allergies {

        [Key]
        public int Allergy_id {
            get; set;
        }

        public DateTime Allergy_start_date {
            get; set;
        }

        public DateTime Allergy_end_date {
            get; set;
        }

        public AllergiesManager Allergies_Manager {
            get; set;
        }

        public AllergyCategory AllergyCategory {
            get; set;
        }

    }
}
