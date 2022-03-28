using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calisanMaasHesapla
{
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
        }
        private void calisanGoster(Calisan calisan)
        {
            calisan.MaasHesapla();
            
            MessageBox.Show("Ünvan: " +calisan.Unvan+ "\nİsim: " + calisan.Isim + "\nMaas: " + calisan.Maas.ToString());
        }

        private void btncalistir_Click(object sender, EventArgs e)
        {
            Standartcalisan standartcalisan = new Standartcalisan()
            {
                Unvan = "Standart Çalışan",
                Isim = "Veli Gümüş"
            };
            calisanGoster(standartcalisan);

            Muhasebeci muhasebeci = new Muhasebeci()
            {
                Unvan = "Muhasebeci",
                Isim = "Ahmet Demir",
                MesaiGunu = 3
            };
            calisanGoster(muhasebeci);

            Satısci satısci = new Satısci()
            {
                Unvan = "satışcı",
                Isim = "Mehmet Çelik",
                Satismiktari = 1000
            };
            calisanGoster(satısci);
            




        }
    }
}
