using PDFServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FW_HST_Transform
{
    public partial class PDFToPNGFrm : Form
    {
        public PDFToPNGFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择目录";
            if (dilog.ShowDialog() == System.Windows.Forms.DialogResult.OK || dilog.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                textBox1.Text = dilog.SelectedPath;

                DirectoryInfo TheFolder = new DirectoryInfo(dilog.SelectedPath);
                foreach (FileInfo NextFile in TheFolder.GetFiles())
                {
                    if (NextFile.Extension == ".pdf")
                    {
                        //PDFHelper.GenerationPng(NextFile.FullName);

                    }
                }

                MessageBox.Show("Done!");
            }

           


        }
    }
}
