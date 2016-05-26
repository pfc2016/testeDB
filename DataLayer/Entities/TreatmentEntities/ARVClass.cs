using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.TreatmentEntities {
    public enum ARVClass {

        MultiClassCombinationDrugs,
        NRTIS,
        NNRTIS,
        ProteaseInhibitors, 
        EntryInhibitors, 
        IntegraseInhibitors

    }
}