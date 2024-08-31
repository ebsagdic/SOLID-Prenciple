using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prenciple
{
    public interface IBanka
    {
        bool ParaTransferi(int tutar, string hesapNo);
    }
}
