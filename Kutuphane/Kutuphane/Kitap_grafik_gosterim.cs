using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using BLL;


namespace Kutuphane
{
    public partial class Kitap_grafik_gosterim : Form
    {
        public Kitap_grafik_gosterim()
        {
            InitializeComponent();
        }

        Surec zedgraph = new Surec();
        private void Kitap_grafik_gosterim_Load(object sender, EventArgs e)
        {
           
            int ktp = zedgraph.Listele();
            int verilen_ktp = zedgraph.alma();

            GraphPane myPane = zedGraphControl1.GraphPane;

          
            string[] satir = { "Verilen Kitaplar", "Verilmeye Hazır Kitaplar", "Tüm Kitaplar" };
            double[] kitap_sayi = { verilen_ktp, ktp - verilen_ktp, ktp };

            
            myPane.AddPieSlices(kitap_sayi, new[] { "Verilen Kitaplar", "Verilmeye Hazır Kitaplar", null });
            myPane.Legend.IsVisible = true;
            LineItem myLine = myPane.AddCurve(null, null, kitap_sayi, Color.Red);
          
            myLine.Line.Fill = new Fill(Color.Red, Color.White, Color.Blue);

            myPane.XAxis.Scale.TextLabels = satir;
            myPane.XAxis.Type = AxisType.Text;

           
            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));
            zedGraphControl1.AxisChange();
        }

        private void Btn_anasayfa_Click(object sender, EventArgs e)
        {
            
            Anasayfa anasyf = new Anasayfa();
            anasyf.Show();
            this.Hide();
        }
    }
}
