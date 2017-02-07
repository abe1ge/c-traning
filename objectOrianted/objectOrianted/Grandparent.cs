using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrianted
{
    class child:parent
    {
        public child()
        {
            Console.WriteLine("Child in the building");
        }
        public child(int a)
        {
            Console.WriteLine("child is rocking " + a);
        }
    }

    class parent:Grandparent
    {
        public parent():base(12)
        {
            Console.WriteLine("Parent without perameters");
        }

        public parent(int a)
        {
            Console.WriteLine("Parent with number: " + a);
        }
    }

    class Grandparent
    {
        public Grandparent()
        {
            Console.WriteLine("GrandParent with no perameters");
        }

        public Grandparent(int a)
        {
            Console.WriteLine("Grandparent with number: " + a);
        }
    }
}
