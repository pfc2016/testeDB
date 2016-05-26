﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities {
    public abstract class User {

        public int User_id {
            get; set;
        }

        public string Password {
            get; set;
        }

        public string Name {
            get; set;
        }

        public string Address {
            get; set;
        }

        public string Telephone {
            get; set;
        }

        public int MyProperty {
            get; set;
        }

        public string Email {
            get; set;
        }

    }
}
