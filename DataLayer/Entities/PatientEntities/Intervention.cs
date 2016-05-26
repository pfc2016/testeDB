using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.PatientEntities {
    public class Intervention {

        public int Intervention_id {
            get; set;
        }

        public DateTime Intervention_start_day {
            get; set;
        }

        public DateTime Intervention_end_day {
            get; set;
        }

        public Staff Intervention_staff {
            get; set;
        }

        public Calendar Intervention_calendar {
            get; set;
        }

    }
}
