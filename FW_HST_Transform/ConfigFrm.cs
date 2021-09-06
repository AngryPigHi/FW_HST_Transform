using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FW_HST_Transform
{
    public partial class ConfigFrm : Form
    {
        public ConfigFrm()
        {
            InitializeComponent();
        }

        private void ConfigFrm_Load(object sender, EventArgs e)
        {
            //1.从文件中读取已有的数据库连接配置（展示在文本框中）


        }

        private void btnStartTransform_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransformFrm frm = new TransformFrm();
            frm.Show();
        }
    }
}
