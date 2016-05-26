﻿using DataLayer.Entities.MCDT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities {
    public class Staff : User {

        /*public string Designation {
            get; set;
        }*/

        [Key]
        public int Staff_id {
            get; set;
        }

        public ProfessionalsType ProfessionalType {
            get; set;
        }
        /// <summary>
        /// Navigation prop
        /// </summary>
        public MCDTStaffManager MCDTStaffManager {
            get; set;
        }


    }
}