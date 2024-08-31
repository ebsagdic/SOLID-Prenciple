using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    class AWS : Cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Machine");
        }

        public override void Translate()
        {
            Console.WriteLine("Translate");
        }
    }

    class Azure : Cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Machine");
        }

        public override void Translate()
        {
            throw new NotImplementedException();
        }
    }
    class Google : Cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Machine");
        }

        public override void Translate()
        {
            Console.WriteLine("Translate");
        }
    }
}
