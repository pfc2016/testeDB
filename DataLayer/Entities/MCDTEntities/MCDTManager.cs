using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class MCDTManager {

        [Key]
        public int MCDTManager_id {
            get; set;
        }

        public List<MCDT> MCDT_Manager {
            get; set;
        }

        public Patient Patient {
            get; set;
        }

    }
}
