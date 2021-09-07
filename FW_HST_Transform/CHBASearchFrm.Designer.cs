
namespace FW_HST_Transform
{
    partial class CHBASearchFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtXMMC = new System.Windows.Forms.TextBox();
            this.txtFCZL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSH = new System.Windows.Forms.TextBox();
            this.txtSGZH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.btnSearchShi = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCopyRoomId = new System.Windows.Forms.Button();
            this.btnCopyZBH = new System.Windows.Forms.Button();
            this.lblZhuangTips = new System.Windows.Forms.Label();
            this.lblShiTips = new System.Windows.Forms.Label();
            this.btnClearSM = new System.Windows.Forms.Button();
            this.btnClearFCZL = new System.Windows.Forms.Button();
            this.btnClearSH = new System.Windows.Forms.Button();
            this.btnClearXMMC = new System.Windows.Forms.Button();
            this.ckbIsUnique = new System.Windows.Forms.CheckBox();
            this.txtZBH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称：";
            // 
            // txtXMMC
            // 
            this.txtXMMC.Location = new System.Drawing.Point(89, 18);
            this.txtXMMC.Name = "txtXMMC";
            this.txtXMMC.Size = new System.Drawing.Size(204, 23);
            this.txtXMMC.TabIndex = 1;
            // 
            // txtFCZL
            // 
            this.txtFCZL.Location = new System.Drawing.Point(406, 18);
            this.txtFCZL.Name = "txtFCZL";
            this.txtFCZL.Size = new System.Drawing.Size(208, 23);
            this.txtFCZL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "房产坐落：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(826, 129);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "室号：";
            // 
            // txtSH
            // 
            this.txtSH.Location = new System.Drawing.Point(344, 199);
            this.txtSH.Name = "txtSH";
            this.txtSH.Size = new System.Drawing.Size(186, 23);
            this.txtSH.TabIndex = 6;
            // 
            // txtSGZH
            // 
            this.txtSGZH.Location = new System.Drawing.Point(89, 199);
            this.txtSGZH.Name = "txtSGZH";
            this.txtSGZH.Size = new System.Drawing.Size(171, 23);
            this.txtSGZH.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "施工幢号：";
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Location = new System.Drawing.Point(789, 18);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(55, 23);
            this.btnSearchItem.TabIndex = 9;
            this.btnSearchItem.Text = "搜索";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            this.btnSearchItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSearchItem_MouseDown);
            // 
            // btnSearchShi
            // 
            this.btnSearchShi.Location = new System.Drawing.Point(789, 198);
            this.btnSearchShi.Name = "btnSearchShi";
            this.btnSearchShi.Size = new System.Drawing.Size(55, 23);
            this.btnSearchShi.TabIndex = 10;
            this.btnSearchShi.Text = "搜索";
            this.btnSearchShi.UseVisualStyleBackColor = true;
            this.btnSearchShi.Click += new System.EventHandler(this.btnSearchShi_Click);
            this.btnSearchShi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSearchShi_MouseDown);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 232);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(826, 266);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "RoomId:";
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(74, 514);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.ReadOnly = true;
            this.txtRoomId.Size = new System.Drawing.Size(99, 23);
            this.txtRoomId.TabIndex = 13;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(248, 514);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(280, 23);
            this.txtFilePath.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "文件地址：";
            // 
            // btnCopyRoomId
            // 
            this.btnCopyRoomId.Location = new System.Drawing.Point(535, 514);
            this.btnCopyRoomId.Name = "btnCopyRoomId";
            this.btnCopyRoomId.Size = new System.Drawing.Size(50, 23);
            this.btnCopyRoomId.TabIndex = 16;
            this.btnCopyRoomId.Text = "复制";
            this.btnCopyRoomId.UseVisualStyleBackColor = true;
            this.btnCopyRoomId.Click += new System.EventHandler(this.btnCopyRoomId_Click);
            // 
            // btnCopyZBH
            // 
            this.btnCopyZBH.Location = new System.Drawing.Point(798, 513);
            this.btnCopyZBH.Name = "btnCopyZBH";
            this.btnCopyZBH.Size = new System.Drawing.Size(45, 23);
            this.btnCopyZBH.TabIndex = 17;
            this.btnCopyZBH.Text = "复制";
            this.btnCopyZBH.UseVisualStyleBackColor = true;
            this.btnCopyZBH.Click += new System.EventHandler(this.btnCopyFilePath_Click);
            // 
            // lblZhuangTips
            // 
            this.lblZhuangTips.AutoSize = true;
            this.lblZhuangTips.Location = new System.Drawing.Point(647, 21);
            this.lblZhuangTips.Name = "lblZhuangTips";
            this.lblZhuangTips.Size = new System.Drawing.Size(89, 17);
            this.lblZhuangTips.TabIndex = 18;
            this.lblZhuangTips.Text = "lblZhuangTips";
            // 
            // lblShiTips
            // 
            this.lblShiTips.AutoSize = true;
            this.lblShiTips.Location = new System.Drawing.Point(647, 201);
            this.lblShiTips.Name = "lblShiTips";
            this.lblShiTips.Size = new System.Drawing.Size(63, 17);
            this.lblShiTips.TabIndex = 19;
            this.lblShiTips.Text = "lblShiTips";
            // 
            // btnClearSM
            // 
            this.btnClearSM.Location = new System.Drawing.Point(261, 199);
            this.btnClearSM.Name = "btnClearSM";
            this.btnClearSM.Size = new System.Drawing.Size(26, 23);
            this.btnClearSM.TabIndex = 20;
            this.btnClearSM.Text = "X";
            this.btnClearSM.UseVisualStyleBackColor = true;
            this.btnClearSM.Click += new System.EventHandler(this.btnClearSM_Click);
            // 
            // btnClearFCZL
            // 
            this.btnClearFCZL.Location = new System.Drawing.Point(615, 18);
            this.btnClearFCZL.Name = "btnClearFCZL";
            this.btnClearFCZL.Size = new System.Drawing.Size(26, 23);
            this.btnClearFCZL.TabIndex = 21;
            this.btnClearFCZL.Text = "X";
            this.btnClearFCZL.UseVisualStyleBackColor = true;
            this.btnClearFCZL.Click += new System.EventHandler(this.btnClearFCZL_Click);
            // 
            // btnClearSH
            // 
            this.btnClearSH.Location = new System.Drawing.Point(536, 199);
            this.btnClearSH.Name = "btnClearSH";
            this.btnClearSH.Size = new System.Drawing.Size(26, 23);
            this.btnClearSH.TabIndex = 22;
            this.btnClearSH.Text = "X";
            this.btnClearSH.UseVisualStyleBackColor = true;
            this.btnClearSH.Click += new System.EventHandler(this.btnClearSH_Click);
            // 
            // btnClearXMMC
            // 
            this.btnClearXMMC.Location = new System.Drawing.Point(299, 18);
            this.btnClearXMMC.Name = "btnClearXMMC";
            this.btnClearXMMC.Size = new System.Drawing.Size(26, 23);
            this.btnClearXMMC.TabIndex = 23;
            this.btnClearXMMC.Text = "X";
            this.btnClearXMMC.UseVisualStyleBackColor = true;
            this.btnClearXMMC.Click += new System.EventHandler(this.btnClearXMMC_Click);
            // 
            // ckbIsUnique
            // 
            this.ckbIsUnique.AutoSize = true;
            this.ckbIsUnique.Location = new System.Drawing.Point(569, 200);
            this.ckbIsUnique.Name = "ckbIsUnique";
            this.ckbIsUnique.Size = new System.Drawing.Size(75, 21);
            this.ckbIsUnique.TabIndex = 24;
            this.ckbIsUnique.Text = "精确查找";
            this.ckbIsUnique.UseVisualStyleBackColor = true;
            // 
            // txtZBH
            // 
            this.txtZBH.Location = new System.Drawing.Point(659, 513);
            this.txtZBH.Name = "txtZBH";
            this.txtZBH.ReadOnly = true;
            this.txtZBH.Size = new System.Drawing.Size(130, 23);
            this.txtZBH.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(600, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "幢编号：";
            // 
            // CHBASearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 555);
            this.Controls.Add(this.txtZBH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ckbIsUnique);
            this.Controls.Add(this.btnClearXMMC);
            this.Controls.Add(this.btnClearSH);
            this.Controls.Add(this.btnClearFCZL);
            this.Controls.Add(this.btnClearSM);
            this.Controls.Add(this.lblShiTips);
            this.Controls.Add(this.lblZhuangTips);
            this.Controls.Add(this.btnCopyZBH);
            this.Controls.Add(this.btnCopyRoomId);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSearchShi);
            this.Controls.Add(this.btnSearchItem);
            this.Controls.Add(this.txtSGZH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFCZL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXMMC);
            this.Controls.Add(this.label1);
            this.Name = "CHBASearchFrm";
            this.Text = "CHBASearchFrm";
            this.Load += new System.EventHandler(this.CHBASearchFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXMMC;
        private System.Windows.Forms.TextBox txtFCZL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSH;
        private System.Windows.Forms.TextBox txtSGZH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.Button btnSearchShi;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCopyRoomId;
        private System.Windows.Forms.Button btnCopyZBH;
        private System.Windows.Forms.Label lblZhuangTips;
        private System.Windows.Forms.Label lblShiTips;
        private System.Windows.Forms.Button btnClearSM;
        private System.Windows.Forms.Button btnClearFCZL;
        private System.Windows.Forms.Button btnClearSH;
        private System.Windows.Forms.Button btnClearXMMC;
        private System.Windows.Forms.CheckBox ckbIsUnique;
        private System.Windows.Forms.TextBox txtZBH;
        private System.Windows.Forms.Label label7;
    }
}