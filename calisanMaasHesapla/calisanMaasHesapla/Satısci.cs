using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisanMaasHesapla
{
    public class Satısci : Calisan
    {
        public int Satismiktari { get; set; }

        public override void MaasHesapla()
        {
            base.MaasHesapla();
            maas = (Satismiktari / 10) + (maas * 2);
        }

    }
}
