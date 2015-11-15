using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class Support
    {
        string name;
        Support next;

        public Support(string name)
        {
            this.name = name;
        }
         
        public Support SetNext(Support n)
        {
            next = n;
            return next;
        }

        public void DoSupport(Trouble trouble)
        {
            if (Resolve(trouble))
            {
                Done(trouble);
            } else if (next != null)
            {
                next.DoSupport(trouble);
            } else
            {
                Fail(trouble);
            }
        }

        public override string ToString()
        {
            return "[" + name + "]";
        }

        abstract public bool Resolve(Trouble trouble);
        public void Done(Trouble trouble)
        {
            Console.WriteLine(trouble + " is resolved by " + this + ".");
        }

        public void Fail(Trouble trouble)
        {
            Console.WriteLine(trouble + " cannot be resolved.");
        }
    }
}
