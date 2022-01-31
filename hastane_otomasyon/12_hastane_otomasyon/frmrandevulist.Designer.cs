
namespace _12_hastane_otomasyon
{
    partial class frmrandevulist
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
            this.randevular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.randevular)).BeginInit();
            this.SuspendLayout();
            // 
            // randevular
            // 
            this.randevular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.randevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randevular.Location = new System.Drawing.Point(0, 0);
            this.randevular.Name = "randevular";
            this.randevular.RowHeadersWidth = 51;
            this.randevular.RowTemplate.Height = 24;
            this.randevular.Size = new System.Drawing.Size(800, 450);
            this.randevular.TabIndex = 0;
        //    this.randevular.DoubleClick += new System.EventHandler(this.//dataGridView1_DoubleClick);
            // 
            // frmrandevulist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.randevular);
            this.MaximizeBox = false;
            this.Name = "frmrandevulist";
            this.Text = "Randevu listesi";
            this.Load += new System.EventHandler(this.frmrandevulist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.randevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView randevular;
    }
}