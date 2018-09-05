namespace PhanTichDuLieu
{
    partial class frmGiamDinhThongKeMau7980a
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
            this.gridControlKetQua.Location = new System.Drawing.Point(5, 63);
            this.gridControlKetQua.MainView = this.gridViewKetQua;
            this.gridControlKetQua.Name = "gridControlKetQua";
            this.gridControlKetQua.Size = new System.Drawing.Size(936, 427);
            this.gridControlKetQua.TabIndex = 32;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Câu Truy Vấn:";
            // 
            // lookUpEditCauTruyVan
            // 
            this.lookUpEditCauTruyVan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditCauTruyVan.Location = new System.Drawing.Point(84, 36);
            this.lookUpEditCauTruyVan.Name = "lookUpEditCauTruyVan";
            this.lookUpEditCauTruyVan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCauTruyVan.Size = new System.Drawing.Size(740, 20);
            this.lookUpEditCauTruyVan.TabIndex = 36;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.Location = new System.Drawing.Point(857, 34);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(75, 23);
            this.btnXuatExcel.TabIndex = 35;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTruyVan.Location = new System.Drawing.Point(857, 5);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(75, 23);
            this.btnTruyVan.TabIndex = 34;
            this.btnTruyVan.Text = "Truy Vấn";
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // lookUpEditCSKCB
            // 
            this.lookUpEditCSKCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditCSKCB.Location = new System.Drawing.Point(84, 7);
            this.lookUpEditCSKCB.Name = "lookUpEditCSKCB";
            this.lookUpEditCSKCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCSKCB.Size = new System.Drawing.Size(740, 20);
            this.lookUpEditCSKCB.TabIndex = 33;
            this.lookUpEditCSKCB.EditValueChanged += new System.EventHandler(this.lookUpEditCSKCB_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cơ Sở KCB:";
            // 
            // frmDVKTCoDieuKienNangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 495);
            this.Controls.Add(this.gridControlKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookUpEditCauTruyVan);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnTruyVan);
            this.Controls.Add(this.lookUpEditCSKCB);
            this.Controls.Add(this.label1);
            this.Name = "frmDVKTCoDieuKienNangCao";
            this.Text = "FormDVKTCoDieuKien";
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
    }
}