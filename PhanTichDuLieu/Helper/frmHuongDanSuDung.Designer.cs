namespace PhanTichDuLieu
{
    partial class frmHuongDanSuDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHuongDanSuDung));
            this.richtbMain = new System.Windows.Forms.RichTextBox();
            this.btnHuongDanSuDung = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // richtbMain
            // 
            this.richtbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtbMain.Location = new System.Drawing.Point(0, 93);
            this.richtbMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richtbMain.Name = "richtbMain";
            this.richtbMain.ReadOnly = true;
            this.richtbMain.ShowSelectionMargin = true;
            this.richtbMain.Size = new System.Drawing.Size(1000, 402);
            this.richtbMain.TabIndex = 0;
            this.richtbMain.Text = "";
            // 
            // btnHuongDanSuDung
            // 
            this.btnHuongDanSuDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuongDanSuDung.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuongDanSuDung.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuongDanSuDung.Appearance.Options.UseFont = true;
            this.btnHuongDanSuDung.Appearance.Options.UseForeColor = true;
            this.btnHuongDanSuDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongDanSuDung.ImageOptions.Image")));
            this.btnHuongDanSuDung.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnHuongDanSuDung.Location = new System.Drawing.Point(0, 0);
            this.btnHuongDanSuDung.Name = "btnHuongDanSuDung";
            this.btnHuongDanSuDung.Size = new System.Drawing.Size(1001, 86);
            this.btnHuongDanSuDung.TabIndex = 1;
            this.btnHuongDanSuDung.Text = "Hướng Dẫn Sử Dụng";
            this.btnHuongDanSuDung.Click += new System.EventHandler(this.btnHuongDanSuDung_Click);
            this.btnHuongDanSuDung.DoubleClick += new System.EventHandler(this.btnHuongDanSuDung_DoubleClick);
            // 
            // frmHuongDanSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 495);
            this.Controls.Add(this.btnHuongDanSuDung);
            this.Controls.Add(this.richtbMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHuongDanSuDung";
            this.Text = "frmHuongDanSuDung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtbMain;
        private DevExpress.XtraEditors.SimpleButton btnHuongDanSuDung;
    }
}