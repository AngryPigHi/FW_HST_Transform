using Microsoft.EntityFrameworkCore;
using SQLDBHelperServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLDBHelperServices.Models;
using FW_HST_Transform.Models;

namespace FW_HST_Transform
{
    public partial class CHBASearchFrm : Form
    {
        public CHBASearchFrm()
        {
            InitializeComponent();
        }

        private static readonly SQLDBContext context = new SQLDBContext();
        private long currentItemID;
        private List<TcchItemTmp> _itemsList = new List<TcchItemTmp>();
        private List<TcchShiTmp> _shisList = new List<TcchShiTmp>();


        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            string xmmc = txtXMMC.Text.Trim();
            string fczl = txtFCZL.Text.Trim();

            if (xmmc.Length>0||fczl.Length>0)
            {

                var items = context.TcchItems
                    .Where(p => EF.Functions.Like(p.Fczl, $"%{fczl}%") )
                    .Select(p=>new TcchItemTmp { ItemId=p.ItemId,Xmmc=p.Xmmc, Fczl=p.Fczl, Qmj=p.Qmj, Ydlb=p.Ydlb, Fcqsz=p.Fcqsz })
                    .ToList();
                dataGridView1.DataSource = items;
                lblZhuangTips.Text = $"共查出{items.Count}条记录。";

                _itemsList = new List<TcchItemTmp>();
                _itemsList = items;

                if (items.Count>0)
                {
                    //默认显示第一条项目
                    currentItemID = items[0].ItemId;

                    var shis = context.TcchShis.Where(p => p.ItemId == currentItemID)
                        .Select(p => new TcchShiTmp { RoomId = p.RoomId,Zbh=p.Zbh,Sgzh=p.Sgzh, Gazh=context.TcchZhuangs.Where(e=>e.Zbh==p.Zbh).Select(e=>e.Gazh).FirstOrDefault(),Szc = p.Szc, Mjfl = p.Mjfl, Sh = p.Sh, Sm = p.Sm, Cqmj = p.Cqmj, Zsmj = p.Zsmj, Ftmj = p.Ftmj, ItemId = p.ItemId, ImagePath = p.ImagePath, IsDelete = p.IsDelete })
                        .OrderBy(p => p.Sh)
                        .ToList();
                    dataGridView2.DataSource = shis;
                    lblShiTips.Text = $"共加载{shis.Count}条记录。";

                    if (shis.Count>0)
                    {
                        txtRoomId.Text = shis[0].RoomId.ToString();
                        txtFilePath.Text = shis[0].ImagePath;
                        txtZBH.Text = shis[0].Zbh.ToString() ;
                    }

                    _shisList = new List<TcchShiTmp>();
                    _shisList = shis;
                }
                else
                {
                    dataGridView2.DataSource = null;
                    txtRoomId.Text = "";
                    txtFilePath.Text = "";
                    txtZBH.Text = "";
                }


            }
            else
            {
                lblZhuangTips.Text = "请输入条件！";
            }

        }

        private void btnClearXMMC_Click(object sender, EventArgs e)
        {
            txtXMMC.Text = "";
        }

        private void btnClearFCZL_Click(object sender, EventArgs e)
        {
            txtFCZL.Text = "";

        }

        private void btnClearSH_Click(object sender, EventArgs e)
        {
            txtSH.Text = "";
        }

        private void btnClearSM_Click(object sender, EventArgs e)
        {
            txtSM.Text = "";
        }

        private void btnSearchShi_Click(object sender, EventArgs e)
        {
            string sh = txtSH.Text.Trim();
            string sm = txtSM.Text.Trim();

            if (sh.Length>0||sm.Length>0)
            {

                if (ckbIsUnique.Checked)
                {
                    var shis = _shisList.Where(p => p.Sh == sh)
                        .ToList();
                    dataGridView2.DataSource = shis;
                    lblShiTips.Text = $"共加载{shis.Count}条记录。";
                    if (shis.Count>0)
                    {
                        txtRoomId.Text = shis[0].RoomId.ToString();
                        txtFilePath.Text = shis[0].ImagePath;
                        txtZBH.Text = shis[0].Zbh.ToString();
                    }
                    else
                    {
                        txtRoomId.Text = "";
                        txtFilePath.Text = "";
                        txtZBH.Text = "";
                    }
                    
                }
                else
                {
                    //var shis = _shisList.Where(p => EF.Functions.Like(p.Sh, sh) || EF.Functions.Like(p.Sm, sm))
                        //.ToList();
                    var shis = _shisList.Where(p => p.Sh.Contains(sh))
                         .ToList();
                    dataGridView2.DataSource = shis;
                    lblShiTips.Text = $"共加载{shis.Count}条记录。";
                    if (shis.Count > 0)
                    {
                        txtRoomId.Text = shis[0].RoomId.ToString();
                        txtFilePath.Text = shis[0].ImagePath;
                        txtZBH.Text = shis[0].Zbh.ToString();

                    }
                    else
                    {
                        txtRoomId.Text = "";
                        txtZBH.Text = "";
                        txtFilePath.Text = "";
                    }
                }
               

            }
            else
            {
                //lblShiTips.Text = "";
                dataGridView2.DataSource = _shisList;
                lblShiTips.Text = $"共加载{_shisList.Count}条记录。";

                if (_shisList.Count > 0)
                {
                    txtRoomId.Text = _shisList[0].RoomId.ToString();
                    txtFilePath.Text = _shisList[0].ImagePath;
                    txtZBH.Text = _shisList[0].Zbh.ToString();

                }
            }
            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var itemId = this.dataGridView1.Rows[e.RowIndex].Cells["ItemId"].Value.ToString();

            if (itemId.Length>0)
            {
                currentItemID = Convert.ToInt32(itemId);
                var shis = context.TcchShis.Where(p => p.ItemId == Convert.ToInt32(itemId))
                       .Select(p => new TcchShiTmp { RoomId = p.RoomId, Zbh = p.Zbh, Sgzh = p.Sgzh, Gazh = context.TcchZhuangs.Where(e => e.Zbh == p.Zbh).Select(e => e.Gazh).FirstOrDefault(), Szc = p.Szc, Mjfl = p.Mjfl, Sh = p.Sh, Sm = p.Sm, Cqmj = p.Cqmj, Zsmj = p.Zsmj, Ftmj = p.Ftmj, ItemId = p.ItemId, ImagePath = p.ImagePath, IsDelete = p.IsDelete })
                       .OrderBy(p => p.Sh)
                       .ToList();
                dataGridView2.DataSource = shis;
                lblShiTips.Text = $"共加载{shis.Count}条记录。";

                if (shis.Count > 0)
                {
                    txtRoomId.Text = shis[0].RoomId.ToString();
                    txtFilePath.Text = shis[0].ImagePath;
                    txtZBH.Text = shis[0].Zbh.ToString();
                }

                _shisList = new List<TcchShiTmp>();
                _shisList = shis;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string roomId= this.dataGridView2.Rows[e.RowIndex].Cells["RoomId"].Value.ToString();
            string imagePath= this.dataGridView2.Rows[e.RowIndex].Cells["ImagePath"].Value.ToString();
            string zbh= this.dataGridView2.Rows[e.RowIndex].Cells["ZBH"].Value.ToString();

            txtRoomId.Text = roomId;
            txtFilePath.Text = imagePath;
            txtZBH.Text = zbh;

        }

        private void btnCopyRoomId_Click(object sender, EventArgs e)
        {
            
            Clipboard.SetDataObject(txtRoomId.Text+","+ txtFilePath.Text);
        }

        private void btnCopyFilePath_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtZBH.Text);
        }

        private void CHBASearchFrm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSearchItem_MouseDown(object sender, MouseEventArgs e)
        {
            lblZhuangTips.Text = "正在查询中。。。";
        }

        private void btnSearchShi_MouseDown(object sender, MouseEventArgs e)
        {
            lblShiTips.Text = "正在查询中。。。";
        }
    }
}
