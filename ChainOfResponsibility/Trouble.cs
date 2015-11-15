using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Trouble
    {
        int number;
        public int Number
        {
            get { return number; }
        }

        public Trouble(int number)
        {
            this.number = number;
        }

        public override string ToString()
        {
            return "[Trouble " + number + "]";
        }
    }
}
