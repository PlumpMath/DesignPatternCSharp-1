using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class LimitSupport : Support
    {
        int limit;

        public LimitSupport(string name, int l) : base(name)
        {
            limit = l;
        }

        public override bool Resolve(Trouble trouble)
        {
            return trouble.Number < limit;
        }
    }
}
