namespace PhanTichDuLieu
{
    partial class frmDanhMucCoSoKCB
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
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.tbMaCSKCB = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbTenCSKCB = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.gridViewMain = new System.Windows.Forms.DataGridView();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(657, 64);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 29);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbMaCSKCB
            // 
            this.tbMaCSKCB.Location = new System.Drawing.Point(153, 17);
            this.tbMaCSKCB.Name = "tbMaCSKCB";
            this.tbMaCSKCB.Size = new System.Drawing.Size(145, 21);
            this.tbMaCSKCB.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(94, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Mã CSKCB:";
            // 
            // tbTenCSKCB
            // 
            this.tbTenCSKCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTenCSKCB.Location = new System.Drawing.Point(380, 17);
            this.tbTenCSKCB.Name = "tbTenCSKCB";
            this.tbTenCSKCB.Size = new System.Drawing.Size(356, 21);
            this.tbTenCSKCB.TabIndex = 24;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(317, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Tên CSKCB:";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.Location = new System.Drawing.Point(402, 64);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(79, 29);
            this.btnThemMoi.TabIndex = 25;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Location = new System.Drawing.Point(487, 64);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 29);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Controls.Add(this.tbID);
            this.gbMain.Controls.Add(this.labelControl3);
            this.gbMain.Controls.Add(this.tbTenCSKCB);
            this.gbMain.Controls.Add(this.btnCapNhat);
            this.gbMain.Controls.Add(this.labelControl1);
            this.gbMain.Controls.Add(this.btnLuu);
            this.gbMain.Controls.Add(this.tbMaCSKCB);
            this.gbMain.Controls.Add(this.btnThemMoi);
            this.gbMain.Controls.Add(this.btnXoa);
            this.gbMain.Controls.Add(this.labelControl2);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(742, 108);
            this.gbMain.TabIndex = 28;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "groupBox1";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(23, 17);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(48, 21);
            this.tbID.TabIndex = 29;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(15, 13);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "ID:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Location = new System.Drawing.Point(572, 64);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(79, 29);
            this.btnCapNhat.TabIndex = 27;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // gridViewMain
            // 
            this.gridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewMain.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMain.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridViewMain.Location = new System.Drawing.Point(3, 126);
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.Size = new System.Drawing.Size(751, 273);
            this.gridViewMain.TabIndex = 29;
            // 
            // frmDanhMucCoSoKCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 401);
            this.Controls.Add(this.gridViewMain);
            this.Controls.Add(this.gbMain);
            this.Name = "frmDanhMucCoSoKCB";
            this.Text = "FormDanhMucCoSoKCB";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.TextBox tbMaCSKCB;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox tbTenCSKCB;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.GroupBox gbMain;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private System.Windows.Forms.TextBox tbID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DataGridView gridViewMain;
    }
}