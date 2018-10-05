namespace PhanTichDuLieu
{
    partial class frmChiaDuLieuSQLite_7980a
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
            this.components = new System.ComponentModel.Container();
            this.gridControlMain = new System.Windows.Forms.DataGridView();
            this.lbFileMain = new System.Windows.Forms.Label();
            this.tbFileMain = new System.Windows.Forms.TextBox();
            this.btlLoadFileMain = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.timerlbFooter = new System.Windows.Forms.Timer(this.components);
            this.btnShowHide = new System.Windows.Forms.Button();
            this.lbFooter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbThoiGianBatDau = new System.Windows.Forms.TextBox();
            this.tbThoiGianKetThuc = new System.Windows.Forms.TextBox();
            this.lbLuuY = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridControlMain.ColumnHeadersHeight = 20;
            this.gridControlMain.Location = new System.Drawing.Point(3, 105);
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.ReadOnly = true;
            this.gridControlMain.RowHeadersWidth = 37;
            this.gridControlMain.Size = new System.Drawing.Size(941, 293);
            this.gridControlMain.TabIndex = 27;
            // 
            // lbFileMain
            // 
            this.lbFileMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFileMain.AutoSize = true;
            this.lbFileMain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFileMain.Location = new System.Drawing.Point(770, 77);
            this.lbFileMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFileMain.Name = "lbFileMain";
            this.lbFileMain.Size = new System.Drawing.Size(115, 18);
            this.lbFileMain.TabIndex = 22;
            this.lbFileMain.Text = "Dòng dữ liệu: 0";
            // 
            // tbFileMain
            // 
            this.tbFileMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileMain.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbFileMain.Location = new System.Drawing.Point(3, 73);
            this.tbFileMain.Name = "tbFileMain";
            this.tbFileMain.Size = new System.Drawing.Size(762, 26);
            this.tbFileMain.TabIndex = 21;
            // 
            // btlLoadFileMain
            // 
            this.btlLoadFileMain.BackColor = System.Drawing.SystemColors.Info;
            this.btlLoadFileMain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlLoadFileMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btlLoadFileMain.Location = new System.Drawing.Point(3, 10);
            this.btlLoadFileMain.Name = "btlLoadFileMain";
            this.btlLoadFileMain.Size = new System.Drawing.Size(138, 47);
            this.btlLoadFileMain.TabIndex = 20;
            this.btlLoadFileMain.Text = "Chọn Dữ Liệu";
            this.btlLoadFileMain.UseVisualStyleBackColor = false;
            this.btlLoadFileMain.Click += new System.EventHandler(this.btlLoadFileMain_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSplit.BackColor = System.Drawing.SystemColors.Info;
            this.btnSplit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSplit.Location = new System.Drawing.Point(656, 10);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(138, 47);
            this.btnSplit.TabIndex = 19;
            this.btnSplit.Text = "Tách Dữ Liệu";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // timerlbFooter
            // 
            this.timerlbFooter.Enabled = true;
            this.timerlbFooter.Tick += new System.EventHandler(this.timerlbFooter_Tick);
            // 
            // btnShowHide
            // 
            this.btnShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHide.BackColor = System.Drawing.SystemColors.Info;
            this.btnShowHide.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowHide.Location = new System.Drawing.Point(806, 10);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(138, 47);
            this.btnShowHide.TabIndex = 24;
            this.btnShowHide.Text = "Hiển Thị Dữ Liệu";
            this.btnShowHide.UseVisualStyleBackColor = false;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // lbFooter
            // 
            this.lbFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFooter.AutoSize = true;
            this.lbFooter.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFooter.ForeColor = System.Drawing.Color.Navy;
            this.lbFooter.Location = new System.Drawing.Point(7, 419);
            this.lbFooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFooter.Name = "lbFooter";
            this.lbFooter.Size = new System.Drawing.Size(25, 14);
            this.lbFooter.TabIndex = 23;
            this.lbFooter.Text = "Text";
            this.lbFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kỳ QT Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(208, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Đến";
            // 
            // tbThoiGianBatDau
            // 
            this.tbThoiGianBatDau.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThoiGianBatDau.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbThoiGianBatDau.Location = new System.Drawing.Point(92, 15);
            this.tbThoiGianBatDau.Name = "tbThoiGianBatDau";
            this.tbThoiGianBatDau.Size = new System.Drawing.Size(102, 26);
            this.tbThoiGianBatDau.TabIndex = 12;
            // 
            // tbThoiGianKetThuc
            // 
            this.tbThoiGianKetThuc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThoiGianKetThuc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbThoiGianKetThuc.Location = new System.Drawing.Point(250, 15);
            this.tbThoiGianKetThuc.Name = "tbThoiGianKetThuc";
            this.tbThoiGianKetThuc.Size = new System.Drawing.Size(102, 26);
            this.tbThoiGianKetThuc.TabIndex = 13;
            // 
            // lbLuuY
            // 
            this.lbLuuY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLuuY.AutoSize = true;
            this.lbLuuY.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuuY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLuuY.Location = new System.Drawing.Point(7, 401);
            this.lbLuuY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLuuY.Name = "lbLuuY";
            this.lbLuuY.Size = new System.Drawing.Size(41, 14);
            this.lbLuuY.TabIndex = 25;
            this.lbLuuY.Text = "Lưu ý:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbThoiGianBatDau);
            this.panel1.Controls.Add(this.tbThoiGianKetThuc);
            this.panel1.Location = new System.Drawing.Point(154, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 55);
            this.panel1.TabIndex = 26;
            // 
            // frmChiaDuLieuSQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 439);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.lbFileMain);
            this.Controls.Add(this.tbFileMain);
            this.Controls.Add(this.btlLoadFileMain);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.lbFooter);
            this.Controls.Add(this.lbLuuY);
            this.Controls.Add(this.panel1);
            this.Name = "frmChiaDuLieuSQLite";
            this.Text = "frmChiaDuLieuSQLite";
            this.Load += new System.EventHandler(this.frmChiaDuLieuSQLite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridControlMain;
        private System.Windows.Forms.Label lbFileMain;
        private System.Windows.Forms.TextBox tbFileMain;
        private System.Windows.Forms.Button btlLoadFileMain;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Timer timerlbFooter;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Label lbFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbThoiGianBatDau;
        private System.Windows.Forms.TextBox tbThoiGianKetThuc;
        private System.Windows.Forms.Label lbLuuY;
        private System.Windows.Forms.Panel panel1;
    }
}