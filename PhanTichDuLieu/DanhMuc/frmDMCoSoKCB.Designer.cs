namespace PhanTichDuLieu
{
    partial class frmDMCoSoKCB
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
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaCSKCB = new System.Windows.Forms.TextBox();
            this.tbSTT = new System.Windows.Forms.TextBox();
            this.tbTenCSKCB = new System.Windows.Forms.TextBox();
            this.btnImportCSKCB = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.Location = new System.Drawing.Point(4, 126);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(989, 355);
            this.gridControlMain.TabIndex = 13;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            this.gridControlMain.Click += new System.EventHandler(this.gridControlMain_Click);
            this.gridControlMain.DoubleClick += new System.EventHandler(this.gridControlMain_DoubleClick);
            // 
            // gridViewMain
            // 
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(728, 7);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(633, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(537, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(441, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên CSKCB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã CSKCB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "STT:";
            // 
            // tbMaCSKCB
            // 
            this.tbMaCSKCB.Location = new System.Drawing.Point(94, 46);
            this.tbMaCSKCB.Name = "tbMaCSKCB";
            this.tbMaCSKCB.Size = new System.Drawing.Size(325, 21);
            this.tbMaCSKCB.TabIndex = 15;
            // 
            // tbSTT
            // 
            this.tbSTT.Location = new System.Drawing.Point(94, 7);
            this.tbSTT.Name = "tbSTT";
            this.tbSTT.Size = new System.Drawing.Size(325, 21);
            this.tbSTT.TabIndex = 14;
            // 
            // tbTenCSKCB
            // 
            this.tbTenCSKCB.Location = new System.Drawing.Point(94, 86);
            this.tbTenCSKCB.Name = "tbTenCSKCB";
            this.tbTenCSKCB.Size = new System.Drawing.Size(325, 21);
            this.tbTenCSKCB.TabIndex = 16;
            // 
            // btnImportCSKCB
            // 
            this.btnImportCSKCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportCSKCB.Location = new System.Drawing.Point(878, 7);
            this.btnImportCSKCB.Name = "btnImportCSKCB";
            this.btnImportCSKCB.Size = new System.Drawing.Size(115, 37);
            this.btnImportCSKCB.TabIndex = 26;
            this.btnImportCSKCB.Text = "Import Cơ Sở KCB";
            this.btnImportCSKCB.Click += new System.EventHandler(this.btnImportCSKCB_Click);
            // 
            // frmDMCoSoKCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 488);
            this.Controls.Add(this.btnImportCSKCB);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenCSKCB);
            this.Controls.Add(this.tbMaCSKCB);
            this.Controls.Add(this.tbSTT);
            this.Name = "frmDMCoSoKCB";
            this.Text = "frmDMCoSoKCB";
            this.Load += new System.EventHandler(this.frmDMCoSoKCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaCSKCB;
        private System.Windows.Forms.TextBox tbSTT;
        private System.Windows.Forms.TextBox tbTenCSKCB;
        private DevExpress.XtraEditors.SimpleButton btnImportCSKCB;
    }
}