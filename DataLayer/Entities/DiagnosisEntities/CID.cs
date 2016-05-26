using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.DiagnosisEntities {
    public class CID {

        [Key] /// ?
        public int CID_id {
            get; set;
        }

        public CIDGenerator CID_generator {
            get; set;
        }
    }
}
