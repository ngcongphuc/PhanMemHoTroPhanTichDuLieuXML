namespace PhanTichDuLieu
{
    partial class frmGiamDinhThongKeThuocVuotTuyen
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCauTruyVan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlKetQua
            // 
            this.gridControlKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlKetQua.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlKetQua.Location = new System.Drawing.Point(6, 38);
            this.gridControlKetQua.MainView = this.gridViewKetQua;
            this.gridControlKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlKetQua.Name = "gridControlKetQua";
            this.gridControlKetQua.Size = new System.Drawing.Size(1092, 565);
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
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Câu Truy Vấn:";
            // 
            // lookUpEditCauTruyVan
            // 
            this.lookUpEditCauTruyVan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditCauTruyVan.Location = new System.Drawing.Point(98, 5);
            this.lookUpEditCauTruyVan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEditCauTruyVan.Name = "lookUpEditCauTruyVan";
            this.lookUpEditCauTruyVan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCauTruyVan.Size = new System.Drawing.Size(783, 22);
            this.lookUpEditCauTruyVan.TabIndex = 36;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.Location = new System.Drawing.Point(1003, 2);
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
            this.btnTruyVan.Location = new System.Drawing.Point(904, 2);
            this.btnTruyVan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(87, 28);
            this.btnTruyVan.TabIndex = 34;
            this.btnTruyVan.Text = "Truy Vấn";
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // frmGiamDinhThongKeThuocVuotTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 609);
            this.Controls.Add(this.gridControlKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookUpEditCauTruyVan);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnTruyVan);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGiamDinhThongKeThuocVuotTuyen";
            this.Text = "frmGiamDinhThongKeThuocVuotTuyen";
            this.Load += new System.EventHandler(this.FormDVKTCoDieuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCauTruyVan.Properties)).EndInit();
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
    }
}