﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.TreatmentEntities {
    public class NonARV : Medication {

        [Key]
        public int NonARV_id {
            get; set;
        }

    }
}
