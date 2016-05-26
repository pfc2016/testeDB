using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.MCDT {
    public class PsychiatricExam : MCDT{

        [Key]
        public int PsychiatricExam_id {
            get; set;
        }

    }
}
