using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntityFrameworkProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

        private void OgrenciListele()
        {
            dgwGoster.DataSource = db.TBLOGRENCİ.ToList();
            dgwGoster.Columns[3].Visible = false;
            dgwGoster.Columns[4].Visible = false;
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            OgrenciListele();
        }

        private void btnDersListele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-B83TJ29;Initial Catalog=DbSinavOgrenci;Integrated Security=True;");
            SqlCommand komut = new SqlCommand("Select * from TBLDERSLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwGoster.DataSource = dt;
        }

        private void BtnNotListesi_Click(object sender, EventArgs e)
        {
            var result = from item in db.TBLNOTLAR
                         select new
                         {
                             item.NOTLAR,
                             item.TBLOGRENCİ.AD,
                             item.TBLOGRENCİ.SOYAD,
                             item.TBLDERSLER.DERSADI,
                             item.SINAV1,
                             item.SINAV2,
                             item.SINAV3,
                             item.ORTALAMA,
                             item.DURUM
                         };

            dgwGoster.DataSource = result.ToList();
        }
        private void btnNotListesiJoın_Click(object sender, EventArgs e)
        {
            var sorgu = from n in db.TBLNOTLAR
                        join o in db.TBLOGRENCİ
                        on n.OGRID equals o.ID
                        join d in db.TBLDERSLER
                        on n.DERSID equals d.DERSID
                        select new
                        {
                            ÖğrenciID=o.ID,
                            Öğrenci =o.AD + " " + o.SOYAD,
                            Ders = d.DERSADI,
                            SINAV1=n.SINAV1,
                            SINAV2=n.SINAV2,
                            SINAV3=n.SINAV3,
                            ORTALAMA=n.ORTALAMA
                        };
            
            dgwGoster.DataSource = sorgu.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCİ t = new TBLOGRENCİ();
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            db.TBLOGRENCİ.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Öğrenci Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var result = db.TBLOGRENCİ.Find(id);
            db.TBLOGRENCİ.Remove(result);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            OgrenciListele();

        }


        private void dgwGoster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgwGoster.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgwGoster.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgwGoster.CurrentRow.Cells[2].Value.ToString();


        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var result = db.TBLOGRENCİ.Find(id);
            result.AD = txtAd.Text;
            result.SOYAD = txtSoyad.Text;
            result.FOTOGRAF = txtFoto.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Güncelledi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OgrenciListele();
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            dgwGoster.DataSource = db.NOTLİSTESİ();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dgwGoster.DataSource = db.TBLOGRENCİ.Where(p => p.AD == txtAd.Text | p.SOYAD == txtSoyad.Text).ToList();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAd.Text;
            var result = from item in db.TBLOGRENCİ
                         where item.AD.Contains(aranan)
                         select item;
            dgwGoster.DataSource = result.ToList();

        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if (rbtn1.Checked)
            {
                List<TBLOGRENCİ> liste1 = db.TBLOGRENCİ.OrderBy(p => p.AD).ToList();
                dgwGoster.DataSource = liste1;

            }
            if (rbtn2.Checked)
            {
                List<TBLOGRENCİ> liste2 = db.TBLOGRENCİ.OrderByDescending(p => p.AD).ToList();
                dgwGoster.DataSource = liste2;
            }
            if (rbtn3.Checked)
            {
                List<TBLOGRENCİ> liste3 = db.TBLOGRENCİ.OrderBy(p => p.AD).Take(3).ToList();
                dgwGoster.DataSource = liste3;
            }
            if (rbtn4.Checked)
            {
                int id = Convert.ToInt32(txtIdGiriniz.Text);
                var result = db.TBLOGRENCİ.Find(id);
                dgwGoster.DataSource = db.TBLOGRENCİ.Where(p => p.ID == result.ID).ToList();
            }
            if (rbtn5.Checked)
            {
                List<TBLOGRENCİ> liste4 = db.TBLOGRENCİ.Where(p => p.AD.StartsWith("a")).ToList();
                dgwGoster.DataSource = liste4;
            }
            if (rbtn6.Checked)
            {
                List<TBLOGRENCİ> liste4 = db.TBLOGRENCİ.Where(p => p.AD.EndsWith("a")).ToList();
                dgwGoster.DataSource = liste4;
            }
            if (rbtn7.Checked)
            {
                int Toplam = db.TBLOGRENCİ.Count();
                MessageBox.Show(Toplam.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (rbtn8.Checked)
            {
                var Toplam = db.TBLNOTLAR.Sum(p => p.SINAV1);
                MessageBox.Show(Toplam.ToString(), "Toplam Sınav1 Puanı: ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (rbtn9.Checked)
            {
                var Ort = db.TBLNOTLAR.Average(p => p.SINAV1);
                MessageBox.Show(Ort.ToString(), "Sınav1 Ortalaması: ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (rbtn10.Checked)
            {
                var Ort = db.TBLNOTLAR.Average(p => p.SINAV1);
                dgwGoster.DataSource = db.NOTLİSTESİ().Where(p => p.SINAV1 > Ort).ToList();
            }
            if (rbtn11.Checked)
            {
                var Max = db.TBLNOTLAR.Max(p => p.SINAV1);
                MessageBox.Show(Max.ToString(), "Sınav1 Max Not: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rbtn12.Checked)
            {
                var Min = db.TBLNOTLAR.Min(p => p.SINAV1);
                MessageBox.Show(Min.ToString(), "Sınav1 Min Not: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rbtn13.Checked)
            {
                var MaxPuan = db.TBLNOTLAR.Max(p => p.SINAV1);
                dgwGoster.DataSource = db.NOTLİSTESİ().Where(p => p.SINAV1 == MaxPuan).ToList();

            }
            if (rbtn14.Checked)
            {
                var MinPuan = db.TBLNOTLAR.Min(p => p.SINAV1);
                dgwGoster.DataSource = db.NOTLİSTESİ().Where(p => p.SINAV1 == MinPuan).ToList();

            }

        }


    }
}
