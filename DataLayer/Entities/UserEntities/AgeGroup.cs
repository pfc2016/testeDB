using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Entities {
    public class AgeGroup {

        [Key]
        public int AgeGroup_id {
            get; set;
        }

        public string Description {
            get; set;
        }

        public int Age {
            get; set;
        }

        public Patient Patient {
            get; set;
        }

    }
}
