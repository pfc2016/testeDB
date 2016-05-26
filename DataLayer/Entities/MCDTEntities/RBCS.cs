﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class RBCS {

        [Key]
        public int RBCD_id {
            get; set;
        }

        public Units HB {
            get; set;
        }

        public Units HCT {
            get; set;
        }
    }
}
