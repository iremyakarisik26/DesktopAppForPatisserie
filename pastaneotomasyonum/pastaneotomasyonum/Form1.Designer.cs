
namespace otomasyon2yedek
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtadminsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.giris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadminad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtadminsifre
            // 
            this.txtadminsifre.BackColor = System.Drawing.Color.Thistle;
            this.txtadminsifre.Location = new System.Drawing.Point(416, 312);
            this.txtadminsifre.Multiline = true;
            this.txtadminsifre.Name = "txtadminsifre";
            this.txtadminsifre.PasswordChar = '*';
            this.txtadminsifre.Size = new System.Drawing.Size(169, 29);
            this.txtadminsifre.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(266, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 121;
            this.label3.Text = "ŞİFRENİZ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(288, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 120;
            this.label1.Text = "ADINIZ :";
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.MediumOrchid;
            this.giris.FlatAppearance.BorderSize = 0;
            this.giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.ForeColor = System.Drawing.Color.Linen;
            this.giris.Location = new System.Drawing.Point(470, 357);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(130, 42);
            this.giris.TabIndex = 119;
            this.giris.Text = "GİRİŞ";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(284, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 49);
            this.label2.TabIndex = 118;
            this.label2.Text = "HOŞGELDİNİZ...";
            // 
            // txtadminad
            // 
            this.txtadminad.BackColor = System.Drawing.Color.Thistle;
            this.txtadminad.Location = new System.Drawing.Point(416, 257);
            this.txtadminad.Multiline = true;
            this.txtadminad.Name = "txtadminad";
            this.txtadminad.Size = new System.Drawing.Size(169, 29);
            this.txtadminad.TabIndex = 124;
            this.txtadminad.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 702);
            this.Controls.Add(this.txtadminad);
            this.Controls.Add(this.txtadminsifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadminsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadminad;
    }
}

