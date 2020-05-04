using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Sheet_Generator
{
    class Wizard
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Wizard(string n) { name = n; }
    }
}
