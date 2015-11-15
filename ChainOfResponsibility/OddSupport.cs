using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class OddSupport : Support
    {
        public OddSupport(string name) : base(name)
        {
        }

        public override bool Resolve(Trouble trouble)
        {
            return trouble.Number % 2 == 1;
        }
    }
}
