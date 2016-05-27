using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DataLayer.Entities.PatientEntities {
    public class Calendar {
        [Key]
        public int Calendar_id {
            get; set;
        }

        public virtual List<Intervention> Calendar_interventions {
            get; set;
        }

    }
}
