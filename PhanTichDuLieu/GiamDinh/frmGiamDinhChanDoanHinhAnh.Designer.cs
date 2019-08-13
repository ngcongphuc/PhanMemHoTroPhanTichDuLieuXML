namespace PhanTichDuLieu
{
    partial class frmGiamDinhChanDoanHinhAnh
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
            this.gridControlKetQua = new DevExpress.XtraGrid.GridControl();
            this.gridViewKetQua = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpEditCauTruyVan = new DevExpress.XtraEditors.LookUpEdit();
            this.btnXuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnTruyVan = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditCSKCB = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tbThoiGianKetThuc = new System.Windows.Forms.TextBox();
            this.tbThoiGianBatDau = new System.Windows.Forms.TextBox();
            this.lbThoiGian = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCauTruyVan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCSKCB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlKetQua
            // 
            this.gridControlKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlKetQua.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlKetQua.Location = new System.Drawing.Point(6, 105);
            this.gridControlKetQua.MainView = this.gridViewKetQua;
            this.gridControlKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlKetQua.Name = "gridControlKetQua";
            this.gridControlKetQua.Size = new System.Drawing.Size(1092, 499);
            this.gridControlKetQua.TabIndex = 32;
            this.gridControlKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKetQua});
            // 
            // gridViewKetQua
            // 
            this.gridViewKetQua.GridControl = this.gridControlKetQua;
            this.gridViewKetQua.Name = "gridViewKetQua";
            this.gridViewKetQua.OptionsFind.FindNullPrompt = "...";
            this.gridViewKetQua.OptionsFind.ShowClearButton = false;
            this.gridViewKetQua.OptionsFind.ShowCloseButton = false;
            this.gridViewKetQua.OptionsFind.ShowFindButton = false;
            this.gridViewKetQua.OptionsView.ColumnAutoWidth = false;
            this.gridViewKetQua.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewKetQua.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Câu Truy Vấn:";
            // 
            // lookUpEditCauTruyVan
            // 
            this.lookUpEditCauTruyVan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditCauTruyVan.Location = new System.Drawing.Point(110, 44);
            this.lookUpEditCauTruyVan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEditCauTruyVan.Name = "lookUpEditCauTruyVan";
            this.lookUpEditCauTruyVan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCauTruyVan.Size = new System.Drawing.Size(851, 22);
            this.lookUpEditCauTruyVan.TabIndex = 36;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.Location = new System.Drawing.Point(1000, 42);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(87, 28);
            this.btnXuatExcel.TabIndex = 35;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTruyVan.Location = new System.Drawing.Point(1000, 6);
            this.btnTruyVan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(87, 28);
            this.btnTruyVan.TabIndex = 34;
            this.btnTruyVan.Text = "Truy Vấn";
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // lookUpEditCSKCB
            // 
            this.lookUpEditCSKCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditCSKCB.Location = new System.Drawing.Point(110, 9);
            this.lookUpEditCSKCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEditCSKCB.Name = "lookUpEditCSKCB";
            this.lookUpEditCSKCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCSKCB.Size = new System.Drawing.Size(851, 22);
            this.lookUpEditCSKCB.TabIndex = 33;
            this.lookUpEditCSKCB.EditValueChanged += new System.EventHandler(this.lookUpEditCSKCB_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cơ Sở KCB:";
            // 
            // tbThoiGianKetThuc
            // 
            this.tbThoiGianKetThuc.Location = new System.Drawing.Point(268, 74);
            this.tbThoiGianKetThuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbThoiGianKetThuc.Name = "tbThoiGianKetThuc";
            this.tbThoiGianKetThuc.Size = new System.Drawing.Size(128, 23);
            this.tbThoiGianKetThuc.TabIndex = 40;
            // 
            // tbThoiGianBatDau
            // 
            this.tbThoiGianBatDau.Location = new System.Drawing.Point(110, 74);
            this.tbThoiGianBatDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbThoiGianBatDau.Name = "tbThoiGianBatDau";
            this.tbThoiGianBatDau.Size = new System.Drawing.Size(128, 23);
            this.tbThoiGianBatDau.TabIndex = 39;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.Location = new System.Drawing.Point(4, 78);
            this.lbThoiGian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(93, 17);
            this.lbThoiGian.TabIndex = 38;
            this.lbThoiGian.Text = "Kỳ quyết toán:";
            // 
            // frmGiamDinhChanDoanHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 609);
            this.Controls.Add(this.tbThoiGianKetThuc);
            this.Controls.Add(this.tbThoiGianBatDau);
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.gridControlKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookUpEditCauTruyVan);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnTruyVan);
            this.Controls.Add(this.lookUpEditCSKCB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGiamDinhChanDoanHinhAnh";
            this.Text = "frmGiamDinhChanDoanHinhAnh";
            this.Load += new System.EventHandler(this.FormDVKTCoDieuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCauTruyVan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCSKCB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlKetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKetQua;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCauTruyVan;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcel;
        private DevExpress.XtraEditors.SimpleButton btnTruyVan;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCSKCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbThoiGianKetThuc;
        private System.Windows.Forms.TextBox tbThoiGianBatDau;
        private DevExpress.XtraEditors.LabelControl lbThoiGian;
    }
}