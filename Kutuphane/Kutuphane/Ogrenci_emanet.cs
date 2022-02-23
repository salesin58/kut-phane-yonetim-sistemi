using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITYLAYER;

namespace Kutuphane
{
    public partial class Ogrenci_emanet : Form
    {
        public Ogrenci_emanet()
        {
            InitializeComponent();
        }

        public void emanet_iade_renk()
        {
            double ceza;
            for (int i = 0; i < data_liste.Rows.Count; i++)
            {
               

                string islem_turu = data_liste.Rows[i].Cells[6].Value.ToString();

                
                if (islem_turu == "iade")
                {
                    data_liste.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    data_liste.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                
                if (islem_turu != "iade")
                {
                    string t1, t2; DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(data_liste.Rows[i].Cells[3].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);

                   
                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        data_liste.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        data_liste.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                   
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        data_liste.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        data_liste.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        data_liste.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                }


            }
        }
        BllEmanet iade_ve_alimlar = new BllEmanet();
        private void Btn_tum_Click(object sender, EventArgs e)
        {
            
            List<EmanetVarlik> ktp1 = iade_ve_alimlar.Emanet_iade();
            data_liste.DataSource = ktp1;
            emanet_iade_renk();
            MessageBox.Show("Kayıt gösterme başarılı!");
        }

        private void Btn_ara_Click(object sender, EventArgs e)
        {
           
            List<EmanetVarlik> arama = iade_ve_alimlar.ogrenci_emanet_iade_listele(Txt_ogrno.Text);
            data_liste.DataSource = arama;
            MessageBox.Show("Arama Başarılı!");
        }

        private void Btn_anasayfa_Click(object sender, EventArgs e)
        {
          
            Anasayfa anasyf = new Anasayfa();
            anasyf.Show();
            this.Hide();
        }

        private void Txt_ogrno_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_ogrno.Text = "";
        }

        private void Ogrenci_emanet_Load(object sender, EventArgs e)
        {

        }
    }
}
