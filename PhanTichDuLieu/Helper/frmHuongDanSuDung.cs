using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PhanTichDuLieu
{
    public partial class frmHuongDanSuDung : DevExpress.XtraEditors.XtraForm
    {
        public frmHuongDanSuDung()
        {
            InitializeComponent();

            this.richtbMain.Visible = false;
            
            /*using (frmWaitForm frm = new frmWaitForm(readWord))
            {
                frm.ShowDialog(this);
            }*/
        }

        public void readWord()
        {
            string _strFileName = Directory.GetCurrentDirectory() + @"\Help.docx";
            var word = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document document = word.Documents.Open(_strFileName);
            document.ActiveWindow.Selection.WholeStory();
            document.ActiveWindow.Selection.Copy();
            document.Close();
            IDataObject data = Clipboard.GetDataObject();
            this.richtbMain.Rtf= data.GetData(DataFormats.Rtf).ToString();
        }

        private void btnHuongDanSuDung_DoubleClick(object sender, System.EventArgs e)
        {
            string _strFileName = Directory.GetCurrentDirectory() + @"\Help.docx";
            Process.Start(_strFileName);
        }

        private void btnHuongDanSuDung_Click(object sender, System.EventArgs e)
        {
            string _strFileName = Directory.GetCurrentDirectory() + @"\Help.docx";
            Process.Start(_strFileName);
        }
    }
}