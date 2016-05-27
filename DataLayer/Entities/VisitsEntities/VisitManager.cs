using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.Visitas {
    public class VisitManager {

        [Key]
        public int VisitManager_id {
            get; set;
        }
        /// <summary>
        /// navigation prop
        /// </summary>

        public ClinicRegistryManager ClinicRegistry_Manager
        {
            get; set;
        }
    }

}
