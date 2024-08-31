using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    interface IPrinter
    {
        void Print();
        void Scan();
        void Fax();
        void PrintDuplex();
    }

    public class HPPrinter : IPrinter
    {
        public void Fax()
        {
            //LOGİC
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void PrintDuplex()
        {
            //LOGİC
        }

        public void Scan()
        {
            //LOGİC
        }
    }
    class SamsungPrinter : IPrinter
    {
        public void Fax()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            //LOGİC
        }

        public void PrintDuplex()
        {
            //LOGİC
        }

        public void Scan()
        {
            //LOGİC
        }
    }
    class LexmarkPrinter : IPrinter
    {
        public void Fax()
        {
            //LOGİC
        }

        public void Print()
        {
            //LOGİC
        }

        public void PrintDuplex()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            //LOGİC
        }
    }
}
