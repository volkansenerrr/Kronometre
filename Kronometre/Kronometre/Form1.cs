using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        int saniye = 0; // Saniye sayacı
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            timer1.Start(); // Timer'ı başlat
        }

        private void btn_durdur_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Timer'ı durdur
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Timer'ı durdur
            saniye = 0; // Sayaç sıfırla
            lbl_zaman.Text = "00:00:00"; // Ekrandaki zamanı sıfırla
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++; // Saniyeyi bir artır
            TimeSpan ts = TimeSpan.FromSeconds(saniye); // Saniyeyi bir TimeSpan'e çevir
            lbl_zaman.Text = ts.ToString(@"hh\:mm\:ss"); // Saat, dakika ve saniye formatında göster
        }
    }
}
