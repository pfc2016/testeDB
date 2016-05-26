using DataLayer.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities {
    public class FamilyHistory {

        [Key]
        public int FamilyHistory_id {
            get; set;
        }

        public FamilyHistoryType FamilyHistoryType {
            get; set;
        }

        public string Carrier {
            get; set;
        }

        public FamilyHistoryManager FamilyHistoryManager {
            get; set;
        }
    }
}
