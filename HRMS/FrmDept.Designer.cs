namespace HRMS
{
    partial class FrmDept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDept));
            this.tvDeptList = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.对象编码 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.对象名称 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.对象简称 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.排序 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.开始日期 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.结束日期 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.备注 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMoveSave = new System.Windows.Forms.Button();
            this.btnMoveBott = new System.Windows.Forms.Button();
            this.btnMoveTop = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.gbDept = new System.Windows.Forms.GroupBox();
            this.ckbIsGuaKaoZuZhi = new System.Windows.Forms.CheckBox();
            this.ckbIsXuNiZuZhi = new System.Windows.Forms.CheckBox();
            this.txtChengLiWenHao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChengLiRiQi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbJiGouLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBeiZhu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJiGouShortName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJiGouFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbADDParent = new System.Windows.Forms.ToolStripButton();
            this.tsbADDChild = new System.Windows.Forms.ToolStripButton();
            this.tsbModify = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tspDingJie = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.gbDept.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDeptList
            // 
            this.tvDeptList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvDeptList.Location = new System.Drawing.Point(3, 3);
            this.tvDeptList.Name = "tvDeptList";
            this.tvDeptList.Size = new System.Drawing.Size(234, 390);
            this.tvDeptList.TabIndex = 0;
            this.tvDeptList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvDeptList_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gbSort);
            this.panel1.Controls.Add(this.gbDept);
            this.panel1.Controls.Add(this.tvDeptList);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 400);
            this.panel1.TabIndex = 28;
            // 
            // gbSort
            // 
            this.gbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSort.Controls.Add(this.listView1);
            this.gbSort.Controls.Add(this.btnMoveSave);
            this.gbSort.Controls.Add(this.btnMoveBott);
            this.gbSort.Controls.Add(this.btnMoveTop);
            this.gbSort.Controls.Add(this.btnMoveDown);
            this.gbSort.Controls.Add(this.btnMoveUp);
            this.gbSort.Location = new System.Drawing.Point(243, 184);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(550, 209);
            this.gbSort.TabIndex = 8;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "排序";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.对象编码,
            this.对象名称,
            this.对象简称,
            this.排序,
            this.开始日期,
            this.结束日期,
            this.备注});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(536, 152);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 对象编码
            // 
            this.对象编码.Text = "对象编码";
            this.对象编码.Width = 100;
            // 
            // 对象名称
            // 
            this.对象名称.Text = "对象名称";
            this.对象名称.Width = 150;
            // 
            // 对象简称
            // 
            this.对象简称.Text = "对象简称";
            this.对象简称.Width = 120;
            // 
            // 排序
            // 
            this.排序.Text = "排序";
            // 
            // 开始日期
            // 
            this.开始日期.Text = "开始日期";
            this.开始日期.Width = 100;
            // 
            // 结束日期
            // 
            this.结束日期.Text = "结束日期";
            this.结束日期.Width = 100;
            // 
            // 备注
            // 
            this.备注.Text = "备注";
            this.备注.Width = 120;
            // 
            // btnMoveSave
            // 
            this.btnMoveSave.Location = new System.Drawing.Point(346, 20);
            this.btnMoveSave.Name = "btnMoveSave";
            this.btnMoveSave.Size = new System.Drawing.Size(75, 23);
            this.btnMoveSave.TabIndex = 7;
            this.btnMoveSave.Text = "保存";
            this.btnMoveSave.UseVisualStyleBackColor = true;
            this.btnMoveSave.Click += new System.EventHandler(this.BtnMoveSave_Click);
            // 
            // btnMoveBott
            // 
            this.btnMoveBott.Location = new System.Drawing.Point(261, 20);
            this.btnMoveBott.Name = "btnMoveBott";
            this.btnMoveBott.Size = new System.Drawing.Size(75, 23);
            this.btnMoveBott.TabIndex = 6;
            this.btnMoveBott.Text = "置尾";
            this.btnMoveBott.UseVisualStyleBackColor = true;
            this.btnMoveBott.Click += new System.EventHandler(this.BtnMoveBott_Click);
            // 
            // btnMoveTop
            // 
            this.btnMoveTop.Location = new System.Drawing.Point(6, 20);
            this.btnMoveTop.Name = "btnMoveTop";
            this.btnMoveTop.Size = new System.Drawing.Size(75, 23);
            this.btnMoveTop.TabIndex = 3;
            this.btnMoveTop.Text = "置顶";
            this.btnMoveTop.UseVisualStyleBackColor = true;
            this.btnMoveTop.Click += new System.EventHandler(this.BtnMoveTop_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(176, 20);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.Text = "下移";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.BtnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(91, 20);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 4;
            this.btnMoveUp.Text = "上移";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.BtnMoveUp_Click);
            // 
            // gbDept
            // 
            this.gbDept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDept.Controls.Add(this.ckbIsGuaKaoZuZhi);
            this.gbDept.Controls.Add(this.ckbIsXuNiZuZhi);
            this.gbDept.Controls.Add(this.txtChengLiWenHao);
            this.gbDept.Controls.Add(this.label8);
            this.gbDept.Controls.Add(this.txtChengLiRiQi);
            this.gbDept.Controls.Add(this.label9);
            this.gbDept.Controls.Add(this.cmbJiGouLevel);
            this.gbDept.Controls.Add(this.label7);
            this.gbDept.Controls.Add(this.txtEndDate);
            this.gbDept.Controls.Add(this.label20);
            this.gbDept.Controls.Add(this.txtStartDate);
            this.gbDept.Controls.Add(this.label11);
            this.gbDept.Controls.Add(this.txtBeiZhu);
            this.gbDept.Controls.Add(this.label5);
            this.gbDept.Controls.Add(this.txtJiGouShortName);
            this.gbDept.Controls.Add(this.label3);
            this.gbDept.Controls.Add(this.txtJiGouFullName);
            this.gbDept.Controls.Add(this.label2);
            this.gbDept.Location = new System.Drawing.Point(243, 3);
            this.gbDept.Name = "gbDept";
            this.gbDept.Size = new System.Drawing.Size(550, 175);
            this.gbDept.TabIndex = 0;
            this.gbDept.TabStop = false;
            this.gbDept.Text = "机构信息";
            // 
            // ckbIsGuaKaoZuZhi
            // 
            this.ckbIsGuaKaoZuZhi.AutoSize = true;
            this.ckbIsGuaKaoZuZhi.Location = new System.Drawing.Point(161, 112);
            this.ckbIsGuaKaoZuZhi.Name = "ckbIsGuaKaoZuZhi";
            this.ckbIsGuaKaoZuZhi.Size = new System.Drawing.Size(96, 16);
            this.ckbIsGuaKaoZuZhi.TabIndex = 68;
            this.ckbIsGuaKaoZuZhi.Text = "是否挂靠组织";
            this.ckbIsGuaKaoZuZhi.UseVisualStyleBackColor = true;
            // 
            // ckbIsXuNiZuZhi
            // 
            this.ckbIsXuNiZuZhi.AutoSize = true;
            this.ckbIsXuNiZuZhi.Location = new System.Drawing.Point(13, 112);
            this.ckbIsXuNiZuZhi.Name = "ckbIsXuNiZuZhi";
            this.ckbIsXuNiZuZhi.Size = new System.Drawing.Size(96, 16);
            this.ckbIsXuNiZuZhi.TabIndex = 67;
            this.ckbIsXuNiZuZhi.Text = "是否虚拟组织";
            this.ckbIsXuNiZuZhi.UseVisualStyleBackColor = true;
            // 
            // txtChengLiWenHao
            // 
            this.txtChengLiWenHao.Location = new System.Drawing.Point(373, 80);
            this.txtChengLiWenHao.Name = "txtChengLiWenHao";
            this.txtChengLiWenHao.Size = new System.Drawing.Size(101, 21);
            this.txtChengLiWenHao.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 66;
            this.label8.Text = "成立文号：";
            // 
            // txtChengLiRiQi
            // 
            this.txtChengLiRiQi.Location = new System.Drawing.Point(105, 80);
            this.txtChengLiRiQi.Name = "txtChengLiRiQi";
            this.txtChengLiRiQi.Size = new System.Drawing.Size(101, 21);
            this.txtChengLiRiQi.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 64;
            this.label9.Text = "成立日期：";
            // 
            // cmbJiGouLevel
            // 
            this.cmbJiGouLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJiGouLevel.FormattingEnabled = true;
            this.cmbJiGouLevel.Location = new System.Drawing.Point(373, 110);
            this.cmbJiGouLevel.Name = "cmbJiGouLevel";
            this.cmbJiGouLevel.Size = new System.Drawing.Size(101, 20);
            this.cmbJiGouLevel.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 61;
            this.label7.Text = "机构层级：";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(373, 21);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(101, 21);
            this.txtEndDate.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(290, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 53;
            this.label20.Text = "结束日期：";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(105, 21);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(101, 21);
            this.txtStartDate.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "开始日期：";
            // 
            // txtBeiZhu
            // 
            this.txtBeiZhu.Location = new System.Drawing.Point(105, 141);
            this.txtBeiZhu.Multiline = true;
            this.txtBeiZhu.Name = "txtBeiZhu";
            this.txtBeiZhu.Size = new System.Drawing.Size(369, 21);
            this.txtBeiZhu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "备    注：";
            // 
            // txtJiGouShortName
            // 
            this.txtJiGouShortName.Location = new System.Drawing.Point(373, 51);
            this.txtJiGouShortName.Name = "txtJiGouShortName";
            this.txtJiGouShortName.Size = new System.Drawing.Size(101, 21);
            this.txtJiGouShortName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "机构简称：";
            // 
            // txtJiGouFullName
            // 
            this.txtJiGouFullName.Location = new System.Drawing.Point(105, 51);
            this.txtJiGouFullName.Name = "txtJiGouFullName";
            this.txtJiGouFullName.Size = new System.Drawing.Size(101, 21);
            this.txtJiGouFullName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "机构名称：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbADDParent,
            this.tsbADDChild,
            this.tsbModify,
            this.tsbSave,
            this.tspDingJie,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbADDParent
            // 
            this.tsbADDParent.Image = ((System.Drawing.Image)(resources.GetObject("tsbADDParent.Image")));
            this.tsbADDParent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbADDParent.Name = "tsbADDParent";
            this.tsbADDParent.Size = new System.Drawing.Size(76, 35);
            this.tsbADDParent.Text = "添加同级";
            this.tsbADDParent.Click += new System.EventHandler(this.tsbADDParent_Click);
            // 
            // tsbADDChild
            // 
            this.tsbADDChild.Image = ((System.Drawing.Image)(resources.GetObject("tsbADDChild.Image")));
            this.tsbADDChild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbADDChild.Name = "tsbADDChild";
            this.tsbADDChild.Size = new System.Drawing.Size(76, 35);
            this.tsbADDChild.Text = "添加下级";
            this.tsbADDChild.Click += new System.EventHandler(this.tsbADDChild_Click);
            // 
            // tsbModify
            // 
            this.tsbModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbModify.Image")));
            this.tsbModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModify.Name = "tsbModify";
            this.tsbModify.Size = new System.Drawing.Size(52, 35);
            this.tsbModify.Text = "修改";
            this.tsbModify.Click += new System.EventHandler(this.TsbModify_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 35);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tspDingJie
            // 
            this.tspDingJie.Image = ((System.Drawing.Image)(resources.GetObject("tspDingJie.Image")));
            this.tspDingJie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspDingJie.Name = "tspDingJie";
            this.tspDingJie.Size = new System.Drawing.Size(52, 35);
            this.tspDingJie.Text = "定界";
            this.tspDingJie.Click += new System.EventHandler(this.tspDingJie_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 35);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(644, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDept";
            this.Text = "机构管理";
            this.panel1.ResumeLayout(false);
            this.gbSort.ResumeLayout(false);
            this.gbDept.ResumeLayout(false);
            this.gbDept.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDeptList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDept;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBeiZhu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJiGouShortName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJiGouFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbADDParent;
        private System.Windows.Forms.ToolStripButton tsbADDChild;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbJiGouLevel;
        private System.Windows.Forms.CheckBox ckbIsGuaKaoZuZhi;
        private System.Windows.Forms.CheckBox ckbIsXuNiZuZhi;
        private System.Windows.Forms.TextBox txtChengLiWenHao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChengLiRiQi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMoveSave;
        private System.Windows.Forms.Button btnMoveBott;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveTop;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 对象编码;
        private System.Windows.Forms.ColumnHeader 对象名称;
        private System.Windows.Forms.ColumnHeader 对象简称;
        private System.Windows.Forms.ColumnHeader 排序;
        private System.Windows.Forms.ColumnHeader 开始日期;
        private System.Windows.Forms.ColumnHeader 结束日期;
        private System.Windows.Forms.ColumnHeader 备注;
        private System.Windows.Forms.ToolStripButton tspDingJie;
        private System.Windows.Forms.ToolStripButton tsbModify;
    }
}