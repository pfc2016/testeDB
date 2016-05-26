﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.DiagnosisEntities {
    public class Disease {

        [Key]
        public int Disease_id {
            get; set;
        }

        public DateTime Disease_start_date {
            get; set;
        }

        public DateTime Disease_end_date {
            get; set;
        }

        public bool Disease_is_active {
            get; set;
        }


    }
}
