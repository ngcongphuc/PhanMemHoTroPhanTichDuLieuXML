namespace PhanTichDuLieu
{
    partial class frmDMxml123
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
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaCSKCB = new System.Windows.Forms.Label();
            this.lbTenCSKCB = new System.Windows.Forms.Label();
            this.lbSTT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.Location = new System.Drawing.Point(1, 39);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(788, 313);
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
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(701, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 27);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên CSKCB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã CSKCB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "STT:";
            // 
            // lbMaCSKCB
            // 
            this.lbMaCSKCB.AutoSize = true;
            this.lbMaCSKCB.Location = new System.Drawing.Point(137, 15);
            this.lbMaCSKCB.Name = "lbMaCSKCB";
            this.lbMaCSKCB.Size = new System.Drawing.Size(61, 13);
            this.lbMaCSKCB.TabIndex = 26;
            this.lbMaCSKCB.Text = "lbMaCSKCB";
            // 
            // lbTenCSKCB
            // 
            this.lbTenCSKCB.AutoSize = true;
            this.lbTenCSKCB.Location = new System.Drawing.Point(308, 15);
            this.lbTenCSKCB.Name = "lbTenCSKCB";
            this.lbTenCSKCB.Size = new System.Drawing.Size(65, 13);
            this.lbTenCSKCB.TabIndex = 27;
            this.lbTenCSKCB.Text = "lbTenCSKCB";
            // 
            // lbSTT
            // 
            this.lbSTT.AutoSize = true;
            this.lbSTT.Location = new System.Drawing.Point(32, 15);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(33, 13);
            this.lbSTT.TabIndex = 28;
            this.lbSTT.Text = "lbSTT";
            // 
            // frmDMxml123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 353);
            this.Controls.Add(this.lbSTT);
            this.Controls.Add(this.lbTenCSKCB);
            this.Controls.Add(this.lbMaCSKCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmDMxml123";
            this.Text = "frmDMxml123";
            this.Load += new System.EventHandler(this.frmDMxml123_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaCSKCB;
        private System.Windows.Forms.Label lbTenCSKCB;
        private System.Windows.Forms.Label lbSTT;
    }
}