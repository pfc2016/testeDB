using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.DiagnosisEntities {
    public class CIDGenerator {

        [Key] // ??
        public int CIDGenerator_id {
            get; set;
        }

        public CIDCode CID_code {
            get; set;
        }

        public CIDVersion CID_version {
            get; set;
        }

    }
}
