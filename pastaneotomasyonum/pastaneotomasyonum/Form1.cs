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

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        PastanestokEntities db = new PastanestokEntities();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {
            
            var kontrol = db.adminler.ToList();
            if(kontrol!= null)
            {
                foreach(var admin in kontrol)
                {
                    if(txtadminad.Text==admin.adminad && txtadminsifre.Text==admin.adminsifre)
                    {

                        Form2 f2 = new Form2();
                        f2.Show();
                        txtadminsifre.Text=admin.adminid.ToString();
                        this.Hide();

                    }
                    

                }
            }


        }
        
    }
    
}
