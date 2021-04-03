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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        PastanestokEntities db = new PastanestokEntities();
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.satislar.ToList();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            satislar sat = new satislar();
            sat.satisid = int.Parse(txtsatisid.Text);
            sat.urun = int.Parse(txturunid.Text);
            sat.musteri = int.Parse(txtmusteriid.Text);
            sat.tarih = DateTime.Parse(dtmtarih.Text);
            sat.fiyat = decimal.Parse(txtfiyat.Text);           
            db.satislar.Add(sat);
            db.SaveChanges();
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE SATIŞ YAPILDI");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                var toplam = db.satislar.Sum(p => p.fiyat);
                txttoplamsatis.Text = toplam.ToString();


        }

        private void txttoplamsatis_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtsatisid.Text);
            var satis = db.satislar.Find(a);
            db.satislar.Remove(satis);
            db.SaveChanges();
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE SATIŞ SİLİNDİ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtsatisid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txturunid.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtmusteriid.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dtmtarih.Value = DateTime.Parse(dataGridView1.Rows[secilen].Cells[3].Value.ToString());
            txtfiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
       
        }
    }
}
