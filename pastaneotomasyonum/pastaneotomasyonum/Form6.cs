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
    public partial class Form6 : Form
    {
        public Form6()
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

        private void butongoster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.musteriler.ToList();
        }

        private void butonekle_Click(object sender, EventArgs e)
        {
            musteriler mus = new musteriler();
            mus.musteriad = txtmusteriad.Text;
            mus.musterisoyad = txtmusterisoyad.Text;
            mus.musteritel = txtmusteritelefon.Text;
            db.musteriler.Add(mus);
            db.SaveChanges();
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE MÜŞTERİ EKLENDİ");
        }

        private void butonsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtmusteriid.Text);
            var a = db.musteriler.Find(id);
            db.musteriler.Remove(a);
            db.SaveChanges();
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE MÜŞTERİ SİLİNDİ");
        }

        private void butonguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtmusteriid.Text);
            var x = db.musteriler.Find(id);
            x.musteriad = txtmusteriad.Text;
            x.musterisoyad = txtmusterisoyad.Text;
            x.musteritel = txtmusteritelefon.Text;
            db.SaveChanges();
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtmusteriid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtmusteriad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtmusterisoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtmusteritelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                List<musteriler> liste1 = db.musteriler.OrderBy(p => p.musteriad).ToList();
                dataGridView1.DataSource = liste1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
