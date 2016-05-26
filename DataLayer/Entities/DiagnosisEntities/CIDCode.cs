using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.DiagnosisEntities {
    public class CIDCode {

        [Key]
        public int CIDCode_id {
            get; set;
        }

        public string CID_code {
            get; set;
        }

        public CIDVersion CID_version {
            get; set;
        }
    }
}
