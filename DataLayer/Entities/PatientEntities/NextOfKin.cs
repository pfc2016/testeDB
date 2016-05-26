using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.PatientEntities {
    public class NextOfKin {

        public int NextOfKin_id {
            get; set;
        }

        /// <summary>
        /// Navigation prop
        /// </summary>
        public NextOfKinManager Next_of_kin_manager {
            get; set;
        }

    }
}
