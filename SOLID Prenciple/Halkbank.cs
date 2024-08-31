using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prenciple
{
    public class Halkbank : IBanka
    {
        public bool ParaTransferi(int tutar, string hesapNo)
        {
            //İstenilen logic işletilebilir. Farklılık bu logiclerde oluşturulur.
            throw new NotImplementedException();
        }
    }
}
