using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DataLayer.Entities.MCDT {
    public abstract class MCDT {
        [Key]
        public int MCDT_ID { get; set; }
        public Units MCDT_units {
            get; set;
        }

        public string Name {
            get; set;
        }

        public DateTime MCDT_date {
            get; set;
        }

       /* public MCDTManager MCDT_Manager {
            get; set;
        }*/
    }
}
