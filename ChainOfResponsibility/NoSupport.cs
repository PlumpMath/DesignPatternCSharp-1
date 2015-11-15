using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class NoSupport : Support
    {
        public NoSupport(string name) : base(name)
        {
        }

        override public bool Resolve(Trouble trouble)
        {
            return false;
        }
    }
}
