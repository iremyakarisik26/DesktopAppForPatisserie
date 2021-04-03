using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon2yedek
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        PastanestokEntities db = new PastanestokEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var kategori = (from a in db.kategoriler
                            select new
                            {
                                a.kategoriid,
                                a.kategoriad

                            }).ToList();
            cmburunkat.ValueMember = "kategoriid";
            cmburunkat.DisplayMember = "kategoriad";
            cmburunkat.DataSource = kategori;
        }

        private void butongoster_Click(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = (from a in db.urunler
                                        select new
                                        {
                                            a.urunid,
                                            a.urunad,
                                            a.urunstok,
                                            a.urunfiyat,
                                            a.kategoriler.kategoriad
                                        }).ToList();

        }

        private void butonekle_Click(object sender, EventArgs e)
        {
            urunler urun = new urunler();
            urun.urunad = txturunad.Text;
            urun.urunkategori = int.Parse(cmburunkat.SelectedValue.ToString());
            urun.urunstok = short.Parse(txtstok.Text);
            urun.urunfiyat = decimal.Parse(txtfiyat.Text);
            db.urunler.Add(urun);
            db.SaveChanges();
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE EKLENDİ");
        }

        private void butonsil_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txturunid.Text);
            var urun = db.urunler.Find(a);
            db.urunler.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE SİLİNDİ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txturunid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txturunad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtstok.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtfiyat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmburunkat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void butonguncelle_Click(object sender, EventArgs e)
        {
            int b = int.Parse(txturunid.Text);
            var urun = db.urunler.Find(b);
            urun.urunad = txturunad.Text;
            urun.urunkategori = int.Parse(cmburunkat.SelectedValue.ToString());
            urun.urunstok = short.Parse(txtstok.Text);
            urun.urunfiyat =decimal.Parse( txtfiyat.Text);
            db.SaveChanges();
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butontemizle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                List<urunler> liste1 = db.urunler.OrderBy(p => p.urunad).ToList();
                dataGridView1.DataSource = liste1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                List<urunler> liste2 = db.urunler.OrderBy(p => p.urunid).Take(10).ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                var toplam = db.urunler.Sum(p => p.urunstok);
                txttoplamstok.Text = toplam.ToString();

            }
        }

        private void txttoplamstok_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmburunkat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
