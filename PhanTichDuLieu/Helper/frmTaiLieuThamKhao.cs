using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Diagnostics;

namespace PhanTichDuLieu
{
    public partial class frmTaiLieuThamKhao : DevExpress.XtraEditors.XtraForm
    {
        public frmTaiLieuThamKhao()
        {
            InitializeComponent();
            Load();
            popu();
        }

        private void Load()
        {
            this.lvMain.View = View.Details;
            this.lvMain.Columns.Add("");
            this.lvMain.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void popu()
        {
            string[] filePaths = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Tai Lieu Tham Khao\");
            int num = filePaths.Length;

            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(32, 32);

            String[] paths = { };

            imgs.Images.Add(PhanTichDuLieu.Properties.Resources.exporttodoc_32x32);
            imgs.Images.Add(PhanTichDuLieu.Properties.Resources.exporttodocx_32x32);
            imgs.Images.Add(PhanTichDuLieu.Properties.Resources.exporttoxls_32x32);
            imgs.Images.Add(PhanTichDuLieu.Properties.Resources.exporttoxlsx_32x32);
            imgs.Images.Add(PhanTichDuLieu.Properties.Resources.exporttopdf_32x32);

            this.lvMain.SmallImageList = imgs;

            for (int i = 0; i < num; i++)
            {
                string namefile = Path.GetFileName(filePaths[i]).Trim();
                switch (Path.GetExtension(filePaths[i]).Trim())
                {
                    case ".doc":
                        lvMain.Items.Add(namefile, 0);
                        break;
                    case ".docx":
                        lvMain.Items.Add(namefile, 1);
                        break;
                    case ".xls":
                        lvMain.Items.Add(namefile, 2);
                        break;
                    case ".xlsx":
                        lvMain.Items.Add(namefile, 3);
                        break;
                    case ".pdf":
                        lvMain.Items.Add(namefile, 4);
                        break;
                    default:
                        lvMain.Items.Add(namefile, 4);
                        break;
                }
            }
        }

        private void lvMain_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void lvMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selected = this.lvMain.SelectedItems[0].SubItems[0].Text;
            Process.Start(Directory.GetCurrentDirectory() + @"\Tai Lieu Tham Khao\" + selected);
        }
    }
}