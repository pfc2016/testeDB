using DataLayer.Entities.Visitas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Visits {
    public class SubsequentVisit : Visit{

        [Key]
        public int SubsequentVisit_id {
            get; set;
        }

    }
}
