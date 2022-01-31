
namespace _12_hastane_otomasyon
{
    partial class hastagiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_giris = new System.Windows.Forms.Button();
            this.msk_tc_no = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.lnk_kayit_ol = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(231, 208);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(175, 51);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "Giris yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // msk_tc_no
            // 
            this.msk_tc_no.Location = new System.Drawing.Point(213, 120);
            this.msk_tc_no.Mask = "00000000000";
            this.msk_tc_no.Name = "msk_tc_no";
            this.msk_tc_no.Size = new System.Drawing.Size(210, 38);
            this.msk_tc_no.TabIndex = 1;
            this.msk_tc_no.ValidatingType = typeof(int);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(213, 165);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = ' ';
            this.txtsifre.Size = new System.Drawing.Size(210, 38);
            this.txtsifre.TabIndex = 2;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // lnk_kayit_ol
            // 
            this.lnk_kayit_ol.AutoSize = true;
            this.lnk_kayit_ol.Location = new System.Drawing.Point(425, 219);
            this.lnk_kayit_ol.Name = "lnk_kayit_ol";
            this.lnk_kayit_ol.Size = new System.Drawing.Size(117, 32);
            this.lnk_kayit_ol.TabIndex = 3;
            this.lnk_kayit_ol.TabStop = true;
            this.lnk_kayit_ol.Text = "Kayıt ol";
            this.lnk_kayit_ol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_kayit_ol_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasta giriş paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC kimlik no:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sifre:";
            // 
            // hastagiris
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(554, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnk_kayit_ol);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msk_tc_no);
            this.Controls.Add(this.btn_giris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "hastagiris";
            this.Text = "hastagiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.MaskedTextBox msk_tc_no;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.LinkLabel lnk_kayit_ol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}