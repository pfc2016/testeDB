using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class MCDT {

        public Units MCDT_units {
            get; set;
        }

        public string Name {
            get; set;
        }

        public DateTime MCDT_date {
            get; set;
        }

        public MCDTManager MCDT_Manager {
            get; set;
        }
    }
}
