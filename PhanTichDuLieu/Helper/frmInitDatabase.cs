using System;
using System.Windows.Forms;

namespace PhanTichDuLieu
{
    public partial class frmInitDatabase : Form
    {

        // dầu tiên khai báo những biến
        public string _nameForm;
        public string _messageShow;
        public string _result;
        public frmInitDatabase()
        {
            
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.tbInput.Focus();
            //this.tbInput.PasswordChar = '\u25CF';
        }

        public void set()
        {
            this.Text = _nameForm;
            this.lbMessage.Text = _messageShow;
        }
        private void btnClick_Click(object sender, EventArgs e)
        {
            _result = tbInput.Text;
            this.Close();
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Enter
            if (e.KeyChar == 13)
            {
                _result = tbInput.Text;
                this.Close();
            }
        }
    }
}
