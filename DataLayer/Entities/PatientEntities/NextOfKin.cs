using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DataLayer.Entities.PatientEntities {
    public class NextOfKin {
        [Key]
        public int NextOfKin_id {
            get; set;
        }

        /// <summary>
        /// Navigation prop
        /// </summary>
        public virtual NextOfKinManager Next_of_kin_manager {
            get; set;
        }

    }
}
