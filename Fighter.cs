﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Sheet_Generator
{
    class Fighter
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Fighter(string n) { name = n; }
    }
}
