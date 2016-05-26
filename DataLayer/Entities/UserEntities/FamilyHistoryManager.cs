using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities {
    public class FamilyHistoryManager {

        [Key]
        public int FamilyHistoryManager_id {
            get; set;
        }

        public List<FamilyHistory> FamilyHistory {
            get; set;
        }
    }
}
