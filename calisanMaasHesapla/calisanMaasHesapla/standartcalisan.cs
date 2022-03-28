using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisanMaasHesapla
{
    public class Standartcalisan:Calisan
    {
        public override void MaasHesapla()
        {
            
            base.MaasHesapla();
            maas *= 2;
        }


    }
}
