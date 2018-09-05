namespace PhanTichDuLieu
{
    partial class frmInitDatabase
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
            this.lbMessage = new DevExpress.XtraEditors.LabelControl();
            this.btnClick = new DevExpress.XtraEditors.SimpleButton();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.Location = new System.Drawing.Point(13, 12);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(63, 13);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "labelControl1";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(275, 30);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(40, 23);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Xong";
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(13, 32);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(256, 20);
            this.tbInput.TabIndex = 2;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // frmInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 64);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lbMessage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInputBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbMessage;
        private DevExpress.XtraEditors.SimpleButton btnClick;
        private System.Windows.Forms.TextBox tbInput;
    }
}