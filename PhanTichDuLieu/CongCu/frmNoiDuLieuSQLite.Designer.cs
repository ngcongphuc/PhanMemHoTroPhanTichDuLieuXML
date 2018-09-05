namespace PhanTichDuLieu
{
    partial class frmNoiDuLieuSQLite
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
            this.lbFileMain = new System.Windows.Forms.Label();
            this.gridViewMain = new System.Windows.Forms.DataGridView();
            this.tbFileMain = new System.Windows.Forms.TextBox();
            this.btlLoadFileMain = new System.Windows.Forms.Button();
            this.btnMerger = new System.Windows.Forms.Button();
            this.lbDanhSachTapTinDB = new System.Windows.Forms.ListBox();
            this.btnClickTest = new System.Windows.Forms.Button();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFileMain
            // 
            this.lbFileMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFileMain.AutoSize = true;
            this.lbFileMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFileMain.Location = new System.Drawing.Point(671, 18);
            this.lbFileMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFileMain.Name = "lbFileMain";
            this.lbFileMain.Size = new System.Drawing.Size(50, 16);
            this.lbFileMain.TabIndex = 18;
            this.lbFileMain.Text = "Total: 0";
            // 
            // gridViewMain
            // 
            this.gridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewMain.BackgroundColor = System.Drawing.Color.White;
            this.gridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMain.Location = new System.Drawing.Point(187, 103);
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.Size = new System.Drawing.Size(609, 275);
            this.gridViewMain.TabIndex = 17;
            // 
            // tbFileMain
            // 
            this.tbFileMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileMain.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbFileMain.Location = new System.Drawing.Point(187, 12);
            this.tbFileMain.Name = "tbFileMain";
            this.tbFileMain.Size = new System.Drawing.Size(479, 26);
            this.tbFileMain.TabIndex = 16;
            // 
            // btlLoadFileMain
            // 
            this.btlLoadFileMain.BackColor = System.Drawing.SystemColors.Info;
            this.btlLoadFileMain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlLoadFileMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btlLoadFileMain.Location = new System.Drawing.Point(1, 3);
            this.btlLoadFileMain.Name = "btlLoadFileMain";
            this.btlLoadFileMain.Size = new System.Drawing.Size(180, 47);
            this.btlLoadFileMain.TabIndex = 15;
            this.btlLoadFileMain.Text = "Choose Root File";
            this.btlLoadFileMain.UseVisualStyleBackColor = false;
            this.btlLoadFileMain.Click += new System.EventHandler(this.btlLoadFileMain_Click);
            // 
            // btnMerger
            // 
            this.btnMerger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMerger.BackColor = System.Drawing.SystemColors.Info;
            this.btnMerger.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMerger.Location = new System.Drawing.Point(187, 52);
            this.btnMerger.Name = "btnMerger";
            this.btnMerger.Size = new System.Drawing.Size(531, 47);
            this.btnMerger.TabIndex = 14;
            this.btnMerger.Text = "Merger Files";
            this.btnMerger.UseVisualStyleBackColor = false;
            this.btnMerger.Click += new System.EventHandler(this.btnMerger_Click);
            // 
            // lbDanhSachTapTinDB
            // 
            this.lbDanhSachTapTinDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDanhSachTapTinDB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachTapTinDB.ForeColor = System.Drawing.Color.Navy;
            this.lbDanhSachTapTinDB.FormattingEnabled = true;
            this.lbDanhSachTapTinDB.ItemHeight = 20;
            this.lbDanhSachTapTinDB.Location = new System.Drawing.Point(1, 104);
            this.lbDanhSachTapTinDB.Name = "lbDanhSachTapTinDB";
            this.lbDanhSachTapTinDB.Size = new System.Drawing.Size(180, 224);
            this.lbDanhSachTapTinDB.TabIndex = 13;
            // 
            // btnClickTest
            // 
            this.btnClickTest.BackColor = System.Drawing.SystemColors.Info;
            this.btnClickTest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClickTest.Location = new System.Drawing.Point(1, 52);
            this.btnClickTest.Name = "btnClickTest";
            this.btnClickTest.Size = new System.Drawing.Size(180, 47);
            this.btnClickTest.TabIndex = 12;
            this.btnClickTest.Text = "Choose List File Merger";
            this.btnClickTest.UseVisualStyleBackColor = false;
            this.btnClickTest.Click += new System.EventHandler(this.btnClickTest_Click);
            // 
            // btnShowHide
            // 
            this.btnShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHide.BackColor = System.Drawing.SystemColors.Info;
            this.btnShowHide.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowHide.Location = new System.Drawing.Point(724, 52);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(72, 47);
            this.btnShowHide.TabIndex = 21;
            this.btnShowHide.Text = "Show";
            this.btnShowHide.UseVisualStyleBackColor = false;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.SystemColors.Info;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Location = new System.Drawing.Point(1, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 47);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNoiDuLieuSQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 379);
            this.Controls.Add(this.lbFileMain);
            this.Controls.Add(this.gridViewMain);
            this.Controls.Add(this.tbFileMain);
            this.Controls.Add(this.btlLoadFileMain);
            this.Controls.Add(this.btnMerger);
            this.Controls.Add(this.lbDanhSachTapTinDB);
            this.Controls.Add(this.btnClickTest);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.btnClose);
            this.Name = "frmNoiDuLieuSQLite";
            this.Text = "NoiDuLieuSQLite";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFileMain;
        private System.Windows.Forms.DataGridView gridViewMain;
        private System.Windows.Forms.TextBox tbFileMain;
        private System.Windows.Forms.Button btlLoadFileMain;
        private System.Windows.Forms.Button btnMerger;
        private System.Windows.Forms.ListBox lbDanhSachTapTinDB;
        private System.Windows.Forms.Button btnClickTest;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Button btnClose;
    }
}