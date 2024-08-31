using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    interface IPrint
    {
        void Print();
    }
    interface IScan
    {
        void Scan();
    }
    interface IFax
    {
        void Fax();
    }
    interface IPrintDuplex
    {
        void PrintDuplex();
    }

    class HPPrinters : IPrint, IScan, IFax, IPrintDuplex
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
            //LOGİC
        }

        public void Scan()
        {
            //LOGİC
        }
    }
    class SamsungPrinters : IPrintDuplex,IScan
    {
        public void PrintDuplex()
        {
            //LOGİC
        }

        public void Scan()
        {
            //LOGİC
        }
    }
    class LexmarkPrinters : IFax, IPrintDuplex,IPrint
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
            //LOGİC
        }
    }
}
