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
            this.richtbMain = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richtbMain
            // 
            this.richtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtbMain.Location = new System.Drawing.Point(0, 0);
            this.richtbMain.Name = "richtbMain";
            this.richtbMain.ReadOnly = true;
            this.richtbMain.ShowSelectionMargin = true;
            this.richtbMain.Size = new System.Drawing.Size(858, 402);
            this.richtbMain.TabIndex = 0;
            this.richtbMain.Text = "";
            // 
            // frmHuongDanSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 402);
            this.Controls.Add(this.richtbMain);
            this.Name = "frmHuongDanSuDung";
            this.Text = "frmHuongDanSuDung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtbMain;
    }
}