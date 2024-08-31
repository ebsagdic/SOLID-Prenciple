
namespace SOLID_Prenciple
{
    public class OpenClosedPrinciple
    {
        public void  ParaTransferi(IBanka banka ,int tutar, string hesapNo)
        {
            banka.ParaTransferi(tutar, hesapNo);
        }

    }
}
