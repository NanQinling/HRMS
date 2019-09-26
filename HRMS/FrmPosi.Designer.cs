namespace HRMS
{
    partial class FrmPosi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPosi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbADD = new System.Windows.Forms.ToolStripButton();
            this.tsbModify = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDingJie = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
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
            this.gbPosi = new System.Windows.Forms.GroupBox();
            this.cmbPosiQuality = new System.Windows.Forms.ComboBox();
            this.txtParentDept = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbIsXuni = new System.Windows.Forms.CheckBox();
            this.ckbIsYunXing = new System.Windows.Forms.CheckBox();
            this.ckbIsGuanJian = new System.Windows.Forms.CheckBox();
            this.ckbIsTeShu = new System.Windows.Forms.CheckBox();
            this.txtXuLie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGangJi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBeiZhu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tvPosiList = new System.Windows.Forms.TreeView();
            this.btnClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.gbPosi.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbADD,
            this.tsbModify,
            this.tsbSave,
            this.tsbDingJie,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbADD
            // 
            this.tsbADD.Image = ((System.Drawing.Image)(resources.GetObject("tsbADD.Image")));
            this.tsbADD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbADD.Name = "tsbADD";
            this.tsbADD.Size = new System.Drawing.Size(52, 35);
            this.tsbADD.Text = "添加";
            this.tsbADD.Click += new System.EventHandler(this.tsbADD_Click);
            // 
            // tsbModify
            // 
            this.tsbModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbModify.Image")));
            this.tsbModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModify.Name = "tsbModify";
            this.tsbModify.Size = new System.Drawing.Size(52, 35);
            this.tsbModify.Text = "修改";
            this.tsbModify.Click += new System.EventHandler(this.tsbModify_Click);
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
            // tsbDingJie
            // 
            this.tsbDingJie.Image = ((System.Drawing.Image)(resources.GetObject("tsbDingJie.Image")));
            this.tsbDingJie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDingJie.Name = "tsbDingJie";
            this.tsbDingJie.Size = new System.Drawing.Size(52, 35);
            this.tsbDingJie.Text = "定界";
            this.tsbDingJie.Click += new System.EventHandler(this.tsbDingJie_Click);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gbSort);
            this.panel1.Controls.Add(this.gbPosi);
            this.panel1.Controls.Add(this.tvPosiList);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 400);
            this.panel1.TabIndex = 33;
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
            this.gbSort.Location = new System.Drawing.Point(243, 199);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(550, 194);
            this.gbSort.TabIndex = 71;
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
            this.listView1.Size = new System.Drawing.Size(536, 137);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.btnMoveSave.Click += new System.EventHandler(this.btnMoveSave_Click);
            // 
            // btnMoveBott
            // 
            this.btnMoveBott.Location = new System.Drawing.Point(261, 20);
            this.btnMoveBott.Name = "btnMoveBott";
            this.btnMoveBott.Size = new System.Drawing.Size(75, 23);
            this.btnMoveBott.TabIndex = 6;
            this.btnMoveBott.Text = "置尾";
            this.btnMoveBott.UseVisualStyleBackColor = true;
            this.btnMoveBott.Click += new System.EventHandler(this.btnMoveBott_Click);
            // 
            // btnMoveTop
            // 
            this.btnMoveTop.Location = new System.Drawing.Point(6, 20);
            this.btnMoveTop.Name = "btnMoveTop";
            this.btnMoveTop.Size = new System.Drawing.Size(75, 23);
            this.btnMoveTop.TabIndex = 3;
            this.btnMoveTop.Text = "置顶";
            this.btnMoveTop.UseVisualStyleBackColor = true;
            this.btnMoveTop.Click += new System.EventHandler(this.btnMoveTop_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(176, 20);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.Text = "下移";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(91, 20);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 4;
            this.btnMoveUp.Text = "上移";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // gbPosi
            // 
            this.gbPosi.Controls.Add(this.cmbPosiQuality);
            this.gbPosi.Controls.Add(this.txtParentDept);
            this.gbPosi.Controls.Add(this.label4);
            this.gbPosi.Controls.Add(this.ckbIsXuni);
            this.gbPosi.Controls.Add(this.ckbIsYunXing);
            this.gbPosi.Controls.Add(this.ckbIsGuanJian);
            this.gbPosi.Controls.Add(this.ckbIsTeShu);
            this.gbPosi.Controls.Add(this.txtXuLie);
            this.gbPosi.Controls.Add(this.label8);
            this.gbPosi.Controls.Add(this.cmbGangJi);
            this.gbPosi.Controls.Add(this.label7);
            this.gbPosi.Controls.Add(this.label1);
            this.gbPosi.Controls.Add(this.txtEndDate);
            this.gbPosi.Controls.Add(this.label20);
            this.gbPosi.Controls.Add(this.txtStartDate);
            this.gbPosi.Controls.Add(this.label11);
            this.gbPosi.Controls.Add(this.txtBeiZhu);
            this.gbPosi.Controls.Add(this.label5);
            this.gbPosi.Controls.Add(this.txtShortName);
            this.gbPosi.Controls.Add(this.label3);
            this.gbPosi.Controls.Add(this.txtFullName);
            this.gbPosi.Controls.Add(this.label2);
            this.gbPosi.Location = new System.Drawing.Point(243, 3);
            this.gbPosi.Name = "gbPosi";
            this.gbPosi.Size = new System.Drawing.Size(550, 190);
            this.gbPosi.TabIndex = 0;
            this.gbPosi.TabStop = false;
            this.gbPosi.Text = "岗位信息";
            // 
            // cmbPosiQuality
            // 
            this.cmbPosiQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosiQuality.FormattingEnabled = true;
            this.cmbPosiQuality.Items.AddRange(new object[] {
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cmbPosiQuality.Location = new System.Drawing.Point(118, 76);
            this.cmbPosiQuality.Name = "cmbPosiQuality";
            this.cmbPosiQuality.Size = new System.Drawing.Size(101, 20);
            this.cmbPosiQuality.TabIndex = 71;
            // 
            // txtParentDept
            // 
            this.txtParentDept.Location = new System.Drawing.Point(361, 132);
            this.txtParentDept.Name = "txtParentDept";
            this.txtParentDept.Size = new System.Drawing.Size(101, 21);
            this.txtParentDept.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 69;
            this.label4.Text = "上级机构：";
            // 
            // ckbIsXuni
            // 
            this.ckbIsXuni.AutoSize = true;
            this.ckbIsXuni.Location = new System.Drawing.Point(123, 134);
            this.ckbIsXuni.Name = "ckbIsXuni";
            this.ckbIsXuni.Size = new System.Drawing.Size(96, 16);
            this.ckbIsXuni.TabIndex = 68;
            this.ckbIsXuni.Text = "是否虚拟岗位";
            this.ckbIsXuni.UseVisualStyleBackColor = true;
            // 
            // ckbIsYunXing
            // 
            this.ckbIsYunXing.AutoSize = true;
            this.ckbIsYunXing.Location = new System.Drawing.Point(20, 134);
            this.ckbIsYunXing.Name = "ckbIsYunXing";
            this.ckbIsYunXing.Size = new System.Drawing.Size(96, 16);
            this.ckbIsYunXing.TabIndex = 67;
            this.ckbIsYunXing.Text = "是否运行岗位";
            this.ckbIsYunXing.UseVisualStyleBackColor = true;
            // 
            // ckbIsGuanJian
            // 
            this.ckbIsGuanJian.AutoSize = true;
            this.ckbIsGuanJian.Location = new System.Drawing.Point(366, 107);
            this.ckbIsGuanJian.Name = "ckbIsGuanJian";
            this.ckbIsGuanJian.Size = new System.Drawing.Size(96, 16);
            this.ckbIsGuanJian.TabIndex = 66;
            this.ckbIsGuanJian.Text = "是否关键岗位";
            this.ckbIsGuanJian.UseVisualStyleBackColor = true;
            // 
            // ckbIsTeShu
            // 
            this.ckbIsTeShu.AutoSize = true;
            this.ckbIsTeShu.Location = new System.Drawing.Point(262, 106);
            this.ckbIsTeShu.Name = "ckbIsTeShu";
            this.ckbIsTeShu.Size = new System.Drawing.Size(96, 16);
            this.ckbIsTeShu.TabIndex = 65;
            this.ckbIsTeShu.Text = "是否特殊岗位";
            this.ckbIsTeShu.UseVisualStyleBackColor = true;
            // 
            // txtXuLie
            // 
            this.txtXuLie.Location = new System.Drawing.Point(361, 76);
            this.txtXuLie.Name = "txtXuLie";
            this.txtXuLie.Size = new System.Drawing.Size(101, 21);
            this.txtXuLie.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 64;
            this.label8.Text = "岗级：";
            // 
            // cmbGangJi
            // 
            this.cmbGangJi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGangJi.FormattingEnabled = true;
            this.cmbGangJi.Items.AddRange(new object[] {
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cmbGangJi.Location = new System.Drawing.Point(118, 104);
            this.cmbGangJi.Name = "cmbGangJi";
            this.cmbGangJi.Size = new System.Drawing.Size(101, 20);
            this.cmbGangJi.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 61;
            this.label7.Text = "岗位序列：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 55;
            this.label1.Text = "岗位性质：";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(361, 19);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(101, 21);
            this.txtEndDate.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(260, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 53;
            this.label20.Text = "结束日期：";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(118, 19);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(101, 21);
            this.txtStartDate.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "开始日期：";
            // 
            // txtBeiZhu
            // 
            this.txtBeiZhu.Location = new System.Drawing.Point(118, 156);
            this.txtBeiZhu.Multiline = true;
            this.txtBeiZhu.Name = "txtBeiZhu";
            this.txtBeiZhu.Size = new System.Drawing.Size(344, 21);
            this.txtBeiZhu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "备    注：";
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(361, 46);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(101, 21);
            this.txtShortName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "职位名称：";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(118, 46);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(101, 21);
            this.txtFullName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "职位简称：";
            // 
            // tvPosiList
            // 
            this.tvPosiList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvPosiList.ImageIndex = 0;
            this.tvPosiList.ImageList = this.imageList1;
            this.tvPosiList.Location = new System.Drawing.Point(3, 3);
            this.tvPosiList.Name = "tvPosiList";
            this.tvPosiList.SelectedImageIndex = 0;
            this.tvPosiList.Size = new System.Drawing.Size(234, 390);
            this.tvPosiList.TabIndex = 0;
            this.tvPosiList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPosiList_AfterSelect);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(632, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "机构.bmp");
            this.imageList1.Images.SetKeyName(1, "人员.png");
            // 
            // FrmPosi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPosi";
            this.Text = "FrmPosi";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbSort.ResumeLayout(false);
            this.gbPosi.ResumeLayout(false);
            this.gbPosi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbADD;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbDingJie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPosi;
        private System.Windows.Forms.ComboBox cmbGangJi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBeiZhu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvPosiList;
        private System.Windows.Forms.CheckBox ckbIsXuni;
        private System.Windows.Forms.CheckBox ckbIsYunXing;
        private System.Windows.Forms.CheckBox ckbIsGuanJian;
        private System.Windows.Forms.CheckBox ckbIsTeShu;
        private System.Windows.Forms.TextBox txtXuLie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 对象编码;
        private System.Windows.Forms.ColumnHeader 对象名称;
        private System.Windows.Forms.ColumnHeader 对象简称;
        private System.Windows.Forms.ColumnHeader 排序;
        private System.Windows.Forms.ColumnHeader 开始日期;
        private System.Windows.Forms.ColumnHeader 结束日期;
        private System.Windows.Forms.ColumnHeader 备注;
        private System.Windows.Forms.Button btnMoveSave;
        private System.Windows.Forms.Button btnMoveBott;
        private System.Windows.Forms.Button btnMoveTop;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripButton tsbModify;
        private System.Windows.Forms.TextBox txtParentDept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPosiQuality;
        private System.Windows.Forms.ImageList imageList1;
    }
}