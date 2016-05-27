using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class MCDTStaffManager {

        [Key]
        public int MCDTStaffManager_id {
            get; set;
        }

        public virtual List<Staff> Staff {
            get; set;
        }
       /**
       *navigation prop
       */

        public virtual MCDTManager mcdtManager
        {
            get; set;
        }
    }
}
