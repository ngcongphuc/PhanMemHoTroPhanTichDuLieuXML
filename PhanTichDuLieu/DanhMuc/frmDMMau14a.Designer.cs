namespace PhanTichDuLieu
{
    partial class frmDMMau14a
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
            this.tbSTT = new System.Windows.Forms.TextBox();
            this.tbMaDieuKien = new System.Windows.Forms.TextBox();
            this.tbTenDieuKien = new System.Windows.Forms.TextBox();
            this.tbDieuKien = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.Location = new System.Drawing.Point(4, 184);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(989, 299);
            this.gridControlMain.TabIndex = 0;
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
            // tbSTT
            // 
            this.tbSTT.Location = new System.Drawing.Point(94, 9);
            this.tbSTT.Name = "tbSTT";
            this.tbSTT.Size = new System.Drawing.Size(325, 21);
            this.tbSTT.TabIndex = 1;
            // 
            // tbMaDieuKien
            // 
            this.tbMaDieuKien.Location = new System.Drawing.Point(94, 48);
            this.tbMaDieuKien.Name = "tbMaDieuKien";
            this.tbMaDieuKien.Size = new System.Drawing.Size(325, 21);
            this.tbMaDieuKien.TabIndex = 2;
            // 
            // tbTenDieuKien
            // 
            this.tbTenDieuKien.Location = new System.Drawing.Point(94, 88);
            this.tbTenDieuKien.Name = "tbTenDieuKien";
            this.tbTenDieuKien.Size = new System.Drawing.Size(325, 21);
            this.tbTenDieuKien.TabIndex = 3;
            // 
            // tbDieuKien
            // 
            this.tbDieuKien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDieuKien.Location = new System.Drawing.Point(483, 9);
            this.tbDieuKien.Name = "tbDieuKien";
            this.tbDieuKien.Size = new System.Drawing.Size(510, 156);
            this.tbDieuKien.TabIndex = 4;
            this.tbDieuKien.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "STT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Điều Kiện:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên Điều Kiện:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Điều Kiện:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 142);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(119, 142);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(232, 142);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(341, 142);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FormDMDieuKienDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 488);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDieuKien);
            this.Controls.Add(this.tbTenDieuKien);
            this.Controls.Add(this.tbMaDieuKien);
            this.Controls.Add(this.tbSTT);
            this.Controls.Add(this.gridControlMain);
            this.Name = "FormDMDieuKienDichVu";
            this.Text = "FormDMDieuKienDichVu";
            this.Load += new System.EventHandler(this.FormDMDieuKienDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private System.Windows.Forms.TextBox tbSTT;
        private System.Windows.Forms.TextBox tbMaDieuKien;
        private System.Windows.Forms.TextBox tbTenDieuKien;
        private System.Windows.Forms.RichTextBox tbDieuKien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}