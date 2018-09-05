namespace PhanTichDuLieu
{
    partial class frmThuocCoDieuKien
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
            this.gridControlDieuKien = new DevExpress.XtraGrid.GridControl();
            this.gridViewDieuKien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlKetQua = new DevExpress.XtraGrid.GridControl();
            this.gridViewKetQua = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbThoiGianKetThuc = new System.Windows.Forms.TextBox();
            this.tbThoiGianBatDau = new System.Windows.Forms.TextBox();
            this.lbThoiGian = new DevExpress.XtraEditors.LabelControl();
            this.btnXuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnTruyVan = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditCSKCB = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDieuKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDieuKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCSKCB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDieuKien
            // 
            this.gridControlDieuKien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControlDieuKien.Location = new System.Drawing.Point(4, 43);
            this.gridControlDieuKien.MainView = this.gridViewDieuKien;
            this.gridControlDieuKien.Name = "gridControlDieuKien";
            this.gridControlDieuKien.Size = new System.Drawing.Size(325, 444);
            this.gridControlDieuKien.TabIndex = 24;
            this.gridControlDieuKien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDieuKien});
            // 
            // gridViewDieuKien
            // 
            this.gridViewDieuKien.GridControl = this.gridControlDieuKien;
            this.gridViewDieuKien.Name = "gridViewDieuKien";
            this.gridViewDieuKien.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewDieuKien.OptionsFind.AlwaysVisible = true;
            this.gridViewDieuKien.OptionsFind.FindNullPrompt = "...";
            this.gridViewDieuKien.OptionsFind.ShowClearButton = false;
            this.gridViewDieuKien.OptionsFind.ShowCloseButton = false;
            this.gridViewDieuKien.OptionsFind.ShowFindButton = false;
            this.gridViewDieuKien.OptionsSelection.MultiSelect = true;
            this.gridViewDieuKien.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewDieuKien.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlKetQua
            // 
            this.gridControlKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlKetQua.Location = new System.Drawing.Point(332, 89);
            this.gridControlKetQua.MainView = this.gridViewKetQua;
            this.gridControlKetQua.Name = "gridControlKetQua";
            this.gridControlKetQua.Size = new System.Drawing.Size(607, 398);
            this.gridControlKetQua.TabIndex = 25;
            this.gridControlKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKetQua});
            // 
            // gridViewKetQua
            // 
            this.gridViewKetQua.GridControl = this.gridControlKetQua;
            this.gridViewKetQua.Name = "gridViewKetQua";
            this.gridViewKetQua.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewKetQua.OptionsFind.FindNullPrompt = "...";
            this.gridViewKetQua.OptionsFind.ShowClearButton = false;
            this.gridViewKetQua.OptionsFind.ShowCloseButton = false;
            this.gridViewKetQua.OptionsFind.ShowFindButton = false;
            this.gridViewKetQua.OptionsView.ColumnAutoWidth = false;
            this.gridViewKetQua.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewKetQua.OptionsView.ShowGroupPanel = false;
            // 
            // tbThoiGianKetThuc
            // 
            this.tbThoiGianKetThuc.Location = new System.Drawing.Point(564, 9);
            this.tbThoiGianKetThuc.Name = "tbThoiGianKetThuc";
            this.tbThoiGianKetThuc.Size = new System.Drawing.Size(110, 21);
            this.tbThoiGianKetThuc.TabIndex = 31;
            // 
            // tbThoiGianBatDau
            // 
            this.tbThoiGianBatDau.Location = new System.Drawing.Point(429, 9);
            this.tbThoiGianBatDau.Name = "tbThoiGianBatDau";
            this.tbThoiGianBatDau.Size = new System.Drawing.Size(110, 21);
            this.tbThoiGianBatDau.TabIndex = 30;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.Location = new System.Drawing.Point(338, 12);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(72, 13);
            this.lbThoiGian.TabIndex = 29;
            this.lbThoiGian.Text = "Kỳ quyết toán:";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.Location = new System.Drawing.Point(855, 7);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(75, 23);
            this.btnXuatExcel.TabIndex = 28;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTruyVan.Location = new System.Drawing.Point(774, 7);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(75, 23);
            this.btnTruyVan.TabIndex = 27;
            this.btnTruyVan.Text = "Truy Vấn";
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // lookUpEditCSKCB
            // 
            this.lookUpEditCSKCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditCSKCB.Location = new System.Drawing.Point(429, 40);
            this.lookUpEditCSKCB.Name = "lookUpEditCSKCB";
            this.lookUpEditCSKCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCSKCB.Size = new System.Drawing.Size(510, 20);
            this.lookUpEditCSKCB.TabIndex = 26;
            this.lookUpEditCSKCB.EditValueChanged += new System.EventHandler(this.lookUpEditCSKCB_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cơ Sở KCB:";
            // 
            // frmThuocCoDieuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 495);
            this.Controls.Add(this.gridControlDieuKien);
            this.Controls.Add(this.gridControlKetQua);
            this.Controls.Add(this.tbThoiGianKetThuc);
            this.Controls.Add(this.tbThoiGianBatDau);
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnTruyVan);
            this.Controls.Add(this.lookUpEditCSKCB);
            this.Controls.Add(this.label1);
            this.Name = "frmThuocCoDieuKien";
            this.Text = "FormThuocCoDieuKien";
            this.Load += new System.EventHandler(this.FormDVKTCoDieuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDieuKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDieuKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCSKCB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDieuKien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDieuKien;
        private DevExpress.XtraGrid.GridControl gridControlKetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKetQua;
        private System.Windows.Forms.TextBox tbThoiGianKetThuc;
        private System.Windows.Forms.TextBox tbThoiGianBatDau;
        private DevExpress.XtraEditors.LabelControl lbThoiGian;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcel;
        private DevExpress.XtraEditors.SimpleButton btnTruyVan;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCSKCB;
        private System.Windows.Forms.Label label1;
    }
}