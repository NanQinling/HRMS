namespace HRMS
{
    partial class FrmKaoQinImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKaoQinImport));
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbPosition = new System.Windows.Forms.RadioButton();
            this.rdbEmp_Org = new System.Windows.Forms.RadioButton();
            this.rdbEmp_Bas = new System.Windows.Forms.RadioButton();
            this.rdbDD_YueDuHuiZong = new System.Windows.Forms.RadioButton();
            this.rdbKaoQin = new System.Windows.Forms.RadioButton();
            this.rdbDD_YuanShi = new System.Windows.Forms.RadioButton();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txterr = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(23, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "下载模板";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "导入文件文件名";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 21);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(788, 147);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(637, 48);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rdbPosition);
            this.panel1.Controls.Add(this.rdbEmp_Org);
            this.panel1.Controls.Add(this.rdbEmp_Bas);
            this.panel1.Controls.Add(this.rdbDD_YueDuHuiZong);
            this.panel1.Controls.Add(this.rdbKaoQin);
            this.panel1.Controls.Add(this.rdbDD_YuanShi);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 448);
            this.panel1.TabIndex = 8;
            // 
            // rdbPosition
            // 
            this.rdbPosition.AutoSize = true;
            this.rdbPosition.Location = new System.Drawing.Point(391, 120);
            this.rdbPosition.Name = "rdbPosition";
            this.rdbPosition.Size = new System.Drawing.Size(71, 16);
            this.rdbPosition.TabIndex = 32;
            this.rdbPosition.TabStop = true;
            this.rdbPosition.Text = "岗位设置";
            this.rdbPosition.UseVisualStyleBackColor = true;
            // 
            // rdbEmp_Org
            // 
            this.rdbEmp_Org.AutoSize = true;
            this.rdbEmp_Org.Location = new System.Drawing.Point(263, 120);
            this.rdbEmp_Org.Name = "rdbEmp_Org";
            this.rdbEmp_Org.Size = new System.Drawing.Size(95, 16);
            this.rdbEmp_Org.TabIndex = 31;
            this.rdbEmp_Org.TabStop = true;
            this.rdbEmp_Org.Text = "人员组织信息";
            this.rdbEmp_Org.UseVisualStyleBackColor = true;
            // 
            // rdbEmp_Bas
            // 
            this.rdbEmp_Bas.AutoSize = true;
            this.rdbEmp_Bas.Location = new System.Drawing.Point(142, 120);
            this.rdbEmp_Bas.Name = "rdbEmp_Bas";
            this.rdbEmp_Bas.Size = new System.Drawing.Size(95, 16);
            this.rdbEmp_Bas.TabIndex = 30;
            this.rdbEmp_Bas.TabStop = true;
            this.rdbEmp_Bas.Text = "人员基本信息";
            this.rdbEmp_Bas.UseVisualStyleBackColor = true;
            // 
            // rdbDD_YueDuHuiZong
            // 
            this.rdbDD_YueDuHuiZong.AutoSize = true;
            this.rdbDD_YueDuHuiZong.Location = new System.Drawing.Point(142, 89);
            this.rdbDD_YueDuHuiZong.Name = "rdbDD_YueDuHuiZong";
            this.rdbDD_YueDuHuiZong.Size = new System.Drawing.Size(95, 16);
            this.rdbDD_YueDuHuiZong.TabIndex = 29;
            this.rdbDD_YueDuHuiZong.TabStop = true;
            this.rdbDD_YueDuHuiZong.Text = "钉钉月度汇总";
            this.rdbDD_YueDuHuiZong.UseVisualStyleBackColor = true;
            // 
            // rdbKaoQin
            // 
            this.rdbKaoQin.AutoSize = true;
            this.rdbKaoQin.Location = new System.Drawing.Point(25, 120);
            this.rdbKaoQin.Name = "rdbKaoQin";
            this.rdbKaoQin.Size = new System.Drawing.Size(71, 16);
            this.rdbKaoQin.TabIndex = 28;
            this.rdbKaoQin.TabStop = true;
            this.rdbKaoQin.Text = "考勤数据";
            this.rdbKaoQin.UseVisualStyleBackColor = true;
            // 
            // rdbDD_YuanShi
            // 
            this.rdbDD_YuanShi.AutoSize = true;
            this.rdbDD_YuanShi.Location = new System.Drawing.Point(25, 89);
            this.rdbDD_YuanShi.Name = "rdbDD_YuanShi";
            this.rdbDD_YuanShi.Size = new System.Drawing.Size(95, 16);
            this.rdbDD_YuanShi.TabIndex = 27;
            this.rdbDD_YuanShi.TabStop = true;
            this.rdbDD_YuanShi.Text = "钉钉原始数据";
            this.rdbDD_YuanShi.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(541, 48);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 26;
            this.btnImport.Text = "上载数据";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txterr);
            this.groupBox1.Location = new System.Drawing.Point(3, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 129);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "错误信息";
            // 
            // txterr
            // 
            this.txterr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txterr.BackColor = System.Drawing.SystemColors.Info;
            this.txterr.Location = new System.Drawing.Point(6, 16);
            this.txterr.Multiline = true;
            this.txterr.Name = "txterr";
            this.txterr.Size = new System.Drawing.Size(776, 107);
            this.txterr.TabIndex = 21;
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.Location = new System.Drawing.Point(487, 48);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(23, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FrmKaoQinImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKaoQinImport";
            this.Text = "批量导入考勤";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbDD_YueDuHuiZong;
        private System.Windows.Forms.RadioButton rdbKaoQin;
        private System.Windows.Forms.RadioButton rdbDD_YuanShi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txterr;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.RadioButton rdbPosition;
        private System.Windows.Forms.RadioButton rdbEmp_Org;
        private System.Windows.Forms.RadioButton rdbEmp_Bas;
    }
}