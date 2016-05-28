using DataLayer.Entities.Visitas;
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
        /*
        public MCDT mcdt {
            get; set;
        }
        /*
        public Patient Patient {
            get; set;
        }*/
        /// <summary>
        /// UM MCDT pode ser realizado pelo mais de um staff
        /// </summary>


        public virtual List< MCDTStaffManager> MCDTStaffManager
        {
            get; set;
        }
        /// <summary>
        /// nav prop
        /// </summary>
        public virtual ClinicRegistryManager clinicRegistryManager
        {
            get; set;
        }


    }
}
