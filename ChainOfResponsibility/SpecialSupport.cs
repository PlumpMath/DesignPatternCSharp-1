using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class SpecialSupport : Support
    {
        int number;

        public SpecialSupport(string name, int n) : base(name)
        {
            number = n;
        }

        public override bool Resolve(Trouble trouble)
        {
            return trouble.Number == number;
        }
    }
}
