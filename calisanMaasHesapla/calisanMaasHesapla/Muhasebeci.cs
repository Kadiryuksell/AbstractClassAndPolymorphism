using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisanMaasHesapla
{
    public class Muhasebeci : Calisan
    {
        public int MesaiGunu { get; set; }

        public override void MaasHesapla()
        {
            base.MaasHesapla();
            maas = (maas / 21) * MesaiGunu + maas * 2;
        }

    }
}
