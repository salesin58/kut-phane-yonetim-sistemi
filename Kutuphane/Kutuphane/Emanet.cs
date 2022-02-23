using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITYLAYER;
using BLL;

namespace Kutuphane
{
    public partial class Emanet : Form
    {
        public Emanet()
        {
            InitializeComponent();
        }


        string konum = " ";
        string tablo = "";

        BllEmanet islem_yap = new BllEmanet();
        void veri_cek()
        {
            
            List<EmanetVarlik> ktp = islem_yap.Emanet_iade();
            dataGridView1.DataSource = ktp;
        }

       

        BllEmanet alim_iade_ekle = new BllEmanet();
        private void Btn_Emanet_Click(object sender, EventArgs e)
        {
           
            try
            {
                int Sonuc = alim_iade_ekle.emanet_islemi(int.Parse(Txt_ektp_id.Text), int.Parse(Txt_eogr_id.Text), DateTime.Parse(Txt_etarih.Text), DateTime.Parse(Txt_etrh_son.Text), "alım");
                MessageBox.Show("Emanet verme işlemi başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Emanet işlemi için lütfen alanları doldurunuz!");
            }
        }

        BllOgrenci ogr_islem = new BllOgrenci();
        private void Btn_Emanet_ogr_ara_Click(object sender, EventArgs e)
        {
           
            try
            {
                List<OgrenciVarlik> ogr = ogr_islem.OgrenciGoster(Txt_Emanet_ogr_no.Text);
                dataGridView1.DataSource = ogr;
                tablo = "emanet_islemleri_ogrenci";
                MessageBox.Show("Arama başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz girdi!");
            }
        }

        BllKitap kitap_islemler = new BllKitap();
        private void Btn_ektp_ara_Click(object sender, EventArgs e)
        {
            
            try
            {
                List<KitapVarlik> ktp2 = kitap_islemler.KitapGoster(Txt_ektp_bilgi.Text, konum);
                dataGridView1.DataSource = ktp2;
                tablo = "emanet_islemleri_kitap";
                MessageBox.Show("Arama başrılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }

        private void Cmb_ektp_ktg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            konum = Cmb_ektp_ktg.SelectedItem.ToString();
        }

        private void Txt_ektp_bilgi_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_ektp_bilgi.Text = "";
        }

        private void Emanet_trh_secim_ValueChanged(object sender, EventArgs e)
        {
            
            Txt_etarih.Text = Emanet_trh_secim.Value.ToShortDateString();
            DateTime emanettarih = DateTime.Parse(Txt_etarih.Text);

           
            Txt_etrh_son.Text = emanettarih.AddDays(15).ToShortDateString();
        }

        private void Txt_Emanet_ogr_no_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_Emanet_ogr_no.Text = "";
        }
        

       
        private void Btn_iogr_ara_Click(object sender, EventArgs e)
        {
           
            try
            {
                List<EmanetVarlik> kayit_cek = islem_yap.kayit_listeleme1(int.Parse(Txt_iogr_no.Text));
                dataGridView1.DataSource = kayit_cek;
                MessageBox.Show("Arama başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }

        private void Btn_iktp_ara_Click(object sender, EventArgs e)
        {
           
            try
            {
                string konum = " ";
                konum = Cmb_iktp_ktg.SelectedItem.ToString();
                List<EmanetVarlik> kayit_cek_2 = islem_yap.kayit_listeleme2(Txt_iktp_bilgi.Text, konum);
                dataGridView1.DataSource = kayit_cek_2;
                MessageBox.Show("Arama başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }

        private void Btn_iade_Click(object sender, EventArgs e)
        {
            
            try
            {
                int Sonuc = alim_iade_ekle.tablo_iade_duzenleme(int.Parse(Txt_iktp_id.Text), int.Parse(Txt_iogr_id.Text), "iade");
                MessageBox.Show("İade başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("İade işlemi için lütfen alanları doldurunuz!");
            }
        }

        private void Txt_iogr_no_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_iogr_no.Text = "";
        }

        private void Txt_iktp_bilgi_MouseClick(object sender, MouseEventArgs e)
        {
            
            Txt_iktp_bilgi.Text = " ";
        }
       
        public void emanet_iade_renk()
        {
            double ceza ;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
               
                
                string islem_turu = dataGridView1.Rows[i].Cells[6].Value.ToString();

               
                if (islem_turu == "iade")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                
                if (islem_turu != "iade")
                {
                    string t1, t2; DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);

                  
                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                   
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        dataGridView1.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                }


            }
        }


        private void Btn_sirala_Click(object sender, EventArgs e)
        {
           
            veri_cek();
            emanet_iade_renk();
        }

        private void Btn_anasayfa_Click(object sender, EventArgs e)
        {
          
            Anasayfa anasyf = new Anasayfa();
            anasyf.Show();
            this.Hide();
        }

        private void Cmb_ektp_ktg_MouseClick(object sender, MouseEventArgs e)
        {
            Cmb_ektp_ktg.Text = "";
        }

        private void Txt_eogr_id_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_eogr_id.Text = "";
        }

        private void Txt_ektp_id_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_ektp_id.Text = "";
        }

        private void Txt_etarih_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_etarih.Text = "";
        }

        private void Txt_etrh_son_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_etrh_son.Text = "";
        }

        private void Cmb_iktp_ktg_MouseClick(object sender, MouseEventArgs e)
        {
            Cmb_iktp_ktg.Text = "";
        }

        private void Txt_iogr_id_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_iogr_id.Text = "";
        }

        private void Txt_iktp_id_MouseClick(object sender, MouseEventArgs e)
        {
            Txt_iktp_id.Text = "";
        }

        private void Emanet_Load(object sender, EventArgs e)
        {

        }
    }
}
