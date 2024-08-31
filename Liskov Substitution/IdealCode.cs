using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    abstract class Cloudly
    {
        public abstract void MachineLearning();
    }

    class AWSService : Cloudly, ITranslateable
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Machine");
        }

        public void Translate()
        {
            Console.WriteLine("Translate");
        }
    }
    class AzureService : Cloudly
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Machine");
        }
    }

    class GoogleService : Cloudly, ITranslateable
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Machine");
        }

        public void Translate()
        {
            Console.WriteLine("Translate");
        }
    }
}
