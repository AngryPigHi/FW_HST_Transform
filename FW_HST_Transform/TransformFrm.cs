using OracleDBHelperServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
using OracleDBHelperServices.Models;
using SQLDBHelperServices;

namespace FW_HST_Transform
{
    public partial class TransformFrm : Form
    {
        public TransformFrm()
        {
            InitializeComponent();
        }

        private readonly string sqlConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.9.134)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));Persist Security Info=True;User ID=bdcdj_tc;Password=gtis;";

        private DataTable dt_QJ_LJZ = new DataTable();
        private int row_QJ_LJZ_Index = 0;



        //加载权籍幢信息
        private  void btnLoadQJZ_Click(object sender, EventArgs e)
        {
            dgvQJZ.DataSource = null;
            //dt_QJ_LJZ = LoadQJZFromDB();
            dgvQJZ.DataSource = dt_QJ_LJZ;
            row_QJ_LJZ_Index = 0;
            //lblSearchQJZTips.Text = $"共{dt_QJ_LJZ.Rows.Count}条记录";

            for (int i = 0; i < this.dgvQJZ.Columns.Count; i++)
            {
                this.dgvQJZ.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                this.dgvQJZ.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            //ModelContext oracleDbContext = new ModelContext();
            //var r = oracleDbContext.FwHsts.Where(t=>t.Hstmc.Length>0).ToList();
            //r.ForEach(t => MessageBox.Show(t.Hstmc));
            //ShowQJLJZRowDetails(dt_QJ_LJZ.Rows[0]);Specified cast is not valid
            SQLDBContext context = new SQLDBContext();
            var res = context.TcchShis.Take(2).ToList();
            res.ForEach(t => MessageBox.Show(t.ImagePath));
        }

        //异步加载数据
        private  DataTable LoadQJZFromDB()
        {
            string sqlnum = txtSQLNum.Text.Trim();

            //string sql = await Task.Run(() =>
            //{
            //    return ToolsHelper.ReadFrmDBSQL("ChainCheckLJZFrm_GetLJZ_Active", sqlnum);
            //});
            string sql= ToolsHelper.ReadFrmDBSQL("ChainCheckLJZFrm_GetLJZ_Active", sqlnum);

           
                return OracleHelper.Query(sqlConnStr, sql).Tables[0];
           
        }

        //
        private void ShowQJLJZRowDetails(DataRow row)
        {
            //select ZLDZ,LJZH,ZRZH,FWCS,SCJZMJ,BDCDYH,FW_DCB_INDEX,FW_XMXX_INDEX,FWMC,XMMC,FWYT,BDCZT,LSZD,LSZDXG,BDCDYFWLX from qj_tc.fw_ljz where qyhf like '%园区%' and (xgbz not like '%注销%' or xgbz is null) and xgzt is not null
            if (row!=null)
            {
                txtQJZID.Text = row["FW_DCB_INDEX"].ToString();
                txtQJZYT.Text = row["FWYT"].ToString();
                txtQJZZMC.Text = row["FWMC"].ToString();
                txtQJZZRZH.Text = row["ZRZH"].ToString();
                txtQJZLJZH.Text = row["LJZH"].ToString();
                txtQJZLSZD.Text = row["LSZDXG"].ToString().Length==0? row["LSZD"].ToString(): row["LSZDXG"].ToString();

                //加载其关联的户室信息


            }
            else
            {

            }

        }

        private void TransformFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
