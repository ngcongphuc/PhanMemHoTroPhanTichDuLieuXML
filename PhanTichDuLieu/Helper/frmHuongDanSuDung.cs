using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Office.Interop.Word;
using System.IO;

namespace PhanTichDuLieu
{
    public partial class frmHuongDanSuDung : DevExpress.XtraEditors.XtraForm
    {
        public frmHuongDanSuDung()
        {
            InitializeComponent();

            using (frmWaitForm frm = new frmWaitForm(readWord))
            {
                frm.ShowDialog(this);
            }
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
    }
}