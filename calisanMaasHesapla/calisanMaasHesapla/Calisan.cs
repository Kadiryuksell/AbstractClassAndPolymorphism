using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisanMaasHesapla
{
    public abstract class Calisan
    {
        private const int asgeriMaas = 4250;
        public string Isim { get; set; }
        public string Unvan { get; set; }

        protected int maas;

        public int Maas
        {
            get 
            {
                return maas;
            }
            
        }
       

        public virtual void MaasHesapla()
        {
            maas = asgeriMaas;
        }



    }
}
