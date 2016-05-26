using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities {
    public class AllergiesManager {

        [Key]
        public int AllergiesManager_id {
            get; set;
        }

        public virtual List<Allergies> Allergies {
            get; set;
        }
    }
}
