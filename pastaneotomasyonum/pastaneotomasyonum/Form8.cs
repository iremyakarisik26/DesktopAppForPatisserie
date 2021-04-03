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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        PastanestokEntities db = new PastanestokEntities();
        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void butongoster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.kategoriler.ToList();
        }

        private void butonekle_Click(object sender, EventArgs e)
        {
            kategoriler kat = new kategoriler();
            kat.kategoriad = txtkategoriad.Text;
            db.kategoriler.Add(kat);
            db.SaveChanges();
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE EKLENDİ");

        }

        private void butonsil_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtkategoriid.Text);
            var kategori = db.kategoriler.Find(a);
            db.kategoriler.Remove(kategori);
            db.SaveChanges();
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE SİLİNDİ");

        }

        private void butonguncelle_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtkategoriid.Text);
            var kategori = db.kategoriler.Find(a);
            kategori.kategoriad = txtkategoriad.Text;
            db.SaveChanges();
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ ");

            // İYİKİ LİNQ VAR BE :))
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtkategoriid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtkategoriad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
           
        }
    }
}
