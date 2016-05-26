using DataLayer.Entities.Visitas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Visits {
    public class HomeVisit : Visit {

        [Key]
        public int HomeVisit_id {
            get; set;
        }

    }
}
