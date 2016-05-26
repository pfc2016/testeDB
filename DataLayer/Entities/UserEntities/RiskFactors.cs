using DataLayer.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities {
    public class RiskFactors {

        [Key]
        public int RiskFActors_id {
            get; set;
        }

        public RiskFactorsType RiskFactorType {
            get; set;
        }

        public RiskFactorsManager RiskFactorManager {
            get; set;
        }

    }
}
