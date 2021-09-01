
namespace FW_HST_Transform
{
    partial class ConfigFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSqlServerTitle = new System.Windows.Forms.Label();
            this.lblOracleTitle = new System.Windows.Forms.Label();
            this.txtSqlServer = new System.Windows.Forms.TextBox();
            this.btnSetSqlServer = new System.Windows.Forms.Button();
            this.btnSetOracle = new System.Windows.Forms.Button();
            this.txtOracle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartTransform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSqlServerTitle
            // 
            this.lblSqlServerTitle.AutoSize = true;
            this.lblSqlServerTitle.Location = new System.Drawing.Point(25, 59);
            this.lblSqlServerTitle.Name = "lblSqlServerTitle";
            this.lblSqlServerTitle.Size = new System.Drawing.Size(111, 17);
            this.lblSqlServerTitle.TabIndex = 0;
            this.lblSqlServerTitle.Text = "SqlServer数据库：";
            // 
            // lblOracleTitle
            // 
            this.lblOracleTitle.AutoSize = true;
            this.lblOracleTitle.Location = new System.Drawing.Point(25, 141);
            this.lblOracleTitle.Name = "lblOracleTitle";
            this.lblOracleTitle.Size = new System.Drawing.Size(94, 17);
            this.lblOracleTitle.TabIndex = 1;
            this.lblOracleTitle.Text = "Oracle数据库：";
            // 
            // txtSqlServer
            // 
            this.txtSqlServer.Location = new System.Drawing.Point(25, 87);
            this.txtSqlServer.Name = "txtSqlServer";
            this.txtSqlServer.Size = new System.Drawing.Size(271, 23);
            this.txtSqlServer.TabIndex = 2;
            // 
            // btnSetSqlServer
            // 
            this.btnSetSqlServer.Location = new System.Drawing.Point(302, 87);
            this.btnSetSqlServer.Name = "btnSetSqlServer";
            this.btnSetSqlServer.Size = new System.Drawing.Size(56, 23);
            this.btnSetSqlServer.TabIndex = 3;
            this.btnSetSqlServer.Text = "配置";
            this.btnSetSqlServer.UseVisualStyleBackColor = true;
            // 
            // btnSetOracle
            // 
            this.btnSetOracle.Location = new System.Drawing.Point(302, 168);
            this.btnSetOracle.Name = "btnSetOracle";
            this.btnSetOracle.Size = new System.Drawing.Size(56, 23);
            this.btnSetOracle.TabIndex = 5;
            this.btnSetOracle.Text = "配置";
            this.btnSetOracle.UseVisualStyleBackColor = true;
            // 
            // txtOracle
            // 
            this.txtOracle.Location = new System.Drawing.Point(25, 168);
            this.txtOracle.Name = "txtOracle";
            this.txtOracle.Size = new System.Drawing.Size(271, 23);
            this.txtOracle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(122, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "房屋户室图关联迁移";
            // 
            // btnStartTransform
            // 
            this.btnStartTransform.Location = new System.Drawing.Point(268, 221);
            this.btnStartTransform.Name = "btnStartTransform";
            this.btnStartTransform.Size = new System.Drawing.Size(90, 23);
            this.btnStartTransform.TabIndex = 7;
            this.btnStartTransform.Text = "开始迁移";
            this.btnStartTransform.UseVisualStyleBackColor = true;
            // 
            // ConfigFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 276);
            this.Controls.Add(this.btnStartTransform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetOracle);
            this.Controls.Add(this.txtOracle);
            this.Controls.Add(this.btnSetSqlServer);
            this.Controls.Add(this.txtSqlServer);
            this.Controls.Add(this.lblOracleTitle);
            this.Controls.Add(this.lblSqlServerTitle);
            this.Name = "ConfigFrm";
            this.Text = "配置数据库连接";
            this.Load += new System.EventHandler(this.ConfigFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSqlServerTitle;
        private System.Windows.Forms.Label lblOracleTitle;
        private System.Windows.Forms.TextBox txtSqlServer;
        private System.Windows.Forms.Button btnSetSqlServer;
        private System.Windows.Forms.Button btnSetOracle;
        private System.Windows.Forms.TextBox txtOracle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartTransform;
    }
}

