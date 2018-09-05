using System;

namespace PhanTichDuLieu
{
    public partial class frmGioiThieu : DevExpress.XtraEditors.XtraForm
    {
        public frmGioiThieu()
        {
            InitializeComponent();
            this.Text = "Thông tin về phần mềm";
            this.groupBox1.Text = "";
            
        }

        public int i = 2;
        private void timerMain_Tick(object sender, EventArgs e)
        {
            this.lbFooter.Left += i;
            if (this.lbFooter.Left >= this.Width - this.lbFooter.Width || this.lbFooter.Left <= 0)
                i = -i;
        }
    }
}