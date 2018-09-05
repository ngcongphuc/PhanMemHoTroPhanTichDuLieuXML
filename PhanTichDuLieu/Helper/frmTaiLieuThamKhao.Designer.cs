namespace PhanTichDuLieu
{
    partial class frmTaiLieuThamKhao
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
            this.lvMain = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvMain
            // 
            this.lvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lvMain.Location = new System.Drawing.Point(0, 2);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(749, 388);
            this.lvMain.TabIndex = 2;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMain_MouseClick);
            this.lvMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvMain_MouseDoubleClick);
            // 
            // frmTaiLieuThamKhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 387);
            this.Controls.Add(this.lvMain);
            this.Name = "frmTaiLieuThamKhao";
            this.Text = "frmTaiLieuThamKhao";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvMain;
    }
}