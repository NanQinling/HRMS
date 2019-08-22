namespace HRMS
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageKaoQin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportPrintKaoQin = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据备份BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.组织机构管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.内设机构管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.岗位管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员变动管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入职管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.岗位变动管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借调管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.离职管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退休管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基本信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.薪酬管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工资管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维护员工工资数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入其他工资ExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工资运算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奖金管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维护员工奖金数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入其他工资ExcelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.奖金运算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelForm = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel12 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel13 = new System.Windows.Forms.ToolStripStatusLabel();
            this.权限管理AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 考勤管理ToolStripMenuItem
            // 
            this.考勤管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageKaoQin,
            this.tsmiImportAttendance,
            this.tsmiExportPrintKaoQin});
            this.考勤管理ToolStripMenuItem.Name = "考勤管理ToolStripMenuItem";
            this.考勤管理ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.考勤管理ToolStripMenuItem.Text = "考勤管理(&A)";
            // 
            // tsmiManageKaoQin
            // 
            this.tsmiManageKaoQin.Name = "tsmiManageKaoQin";
            this.tsmiManageKaoQin.Size = new System.Drawing.Size(184, 22);
            this.tsmiManageKaoQin.Text = "考勤管理(&M)";
            this.tsmiManageKaoQin.Click += new System.EventHandler(this.tsmiManageKaoQin_Click);
            // 
            // tsmiImportAttendance
            // 
            this.tsmiImportAttendance.Name = "tsmiImportAttendance";
            this.tsmiImportAttendance.Size = new System.Drawing.Size(184, 22);
            this.tsmiImportAttendance.Text = "批量导入考勤数据(&I)";
            this.tsmiImportAttendance.Click += new System.EventHandler(this.tsmiImportAttendance_Click);
            // 
            // tsmiExportPrintKaoQin
            // 
            this.tsmiExportPrintKaoQin.Name = "tsmiExportPrintKaoQin";
            this.tsmiExportPrintKaoQin.Size = new System.Drawing.Size(184, 22);
            this.tsmiExportPrintKaoQin.Text = "导出并打印(&P)";
            this.tsmiExportPrintKaoQin.Click += new System.EventHandler(this.tsmiExportPrintKaoQin_Click);
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.权限管理AToolStripMenuItem,
            this.toolStripSeparator2,
            this.数据备份BToolStripMenuItem,
            this.tmiModifyPwd,
            this.toolStripSeparator1,
            this.tmiClose});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.系统ToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // 数据备份BToolStripMenuItem
            // 
            this.数据备份BToolStripMenuItem.Name = "数据备份BToolStripMenuItem";
            this.数据备份BToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.数据备份BToolStripMenuItem.Text = "数据备份(&B)";
            // 
            // tmiModifyPwd
            // 
            this.tmiModifyPwd.Name = "tmiModifyPwd";
            this.tmiModifyPwd.Size = new System.Drawing.Size(180, 22);
            this.tmiModifyPwd.Text = "密码修改(&M)";
            this.tmiModifyPwd.Click += new System.EventHandler(this.tmiModifyPwd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tmiClose
            // 
            this.tmiClose.Name = "tmiClose";
            this.tmiClose.Size = new System.Drawing.Size(180, 22);
            this.tmiClose.Text = "退出系统(&X)";
            this.tmiClose.Click += new System.EventHandler(this.tmiClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.组织机构管理ToolStripMenuItem,
            this.人员变动管理ToolStripMenuItem,
            this.人员信息管理ToolStripMenuItem,
            this.考勤管理ToolStripMenuItem,
            this.薪酬管理ToolStripMenuItem,
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 组织机构管理ToolStripMenuItem
            // 
            this.组织机构管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.内设机构管理ToolStripMenuItem,
            this.岗位管理ToolStripMenuItem});
            this.组织机构管理ToolStripMenuItem.Name = "组织机构管理ToolStripMenuItem";
            this.组织机构管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.组织机构管理ToolStripMenuItem.Text = "组织机构管理";
            // 
            // 内设机构管理ToolStripMenuItem
            // 
            this.内设机构管理ToolStripMenuItem.Name = "内设机构管理ToolStripMenuItem";
            this.内设机构管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.内设机构管理ToolStripMenuItem.Text = "内设机构管理";
            this.内设机构管理ToolStripMenuItem.Click += new System.EventHandler(this.内设机构管理ToolStripMenuItem_Click);
            // 
            // 岗位管理ToolStripMenuItem
            // 
            this.岗位管理ToolStripMenuItem.Name = "岗位管理ToolStripMenuItem";
            this.岗位管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.岗位管理ToolStripMenuItem.Text = "岗位管理";
            this.岗位管理ToolStripMenuItem.Click += new System.EventHandler(this.岗位管理ToolStripMenuItem_Click);
            // 
            // 人员变动管理ToolStripMenuItem
            // 
            this.人员变动管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入职管理ToolStripMenuItem,
            this.岗位变动管理ToolStripMenuItem,
            this.借调管理ToolStripMenuItem,
            this.离职管理ToolStripMenuItem,
            this.退休管理ToolStripMenuItem});
            this.人员变动管理ToolStripMenuItem.Name = "人员变动管理ToolStripMenuItem";
            this.人员变动管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.人员变动管理ToolStripMenuItem.Text = "人员变动管理";
            // 
            // 入职管理ToolStripMenuItem
            // 
            this.入职管理ToolStripMenuItem.Name = "入职管理ToolStripMenuItem";
            this.入职管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.入职管理ToolStripMenuItem.Text = "入职管理";
            // 
            // 岗位变动管理ToolStripMenuItem
            // 
            this.岗位变动管理ToolStripMenuItem.Name = "岗位变动管理ToolStripMenuItem";
            this.岗位变动管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.岗位变动管理ToolStripMenuItem.Text = "岗位变动管理";
            // 
            // 借调管理ToolStripMenuItem
            // 
            this.借调管理ToolStripMenuItem.Name = "借调管理ToolStripMenuItem";
            this.借调管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.借调管理ToolStripMenuItem.Text = "借调管理";
            // 
            // 离职管理ToolStripMenuItem
            // 
            this.离职管理ToolStripMenuItem.Name = "离职管理ToolStripMenuItem";
            this.离职管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.离职管理ToolStripMenuItem.Text = "离职管理";
            // 
            // 退休管理ToolStripMenuItem
            // 
            this.退休管理ToolStripMenuItem.Name = "退休管理ToolStripMenuItem";
            this.退休管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退休管理ToolStripMenuItem.Text = "退休管理";
            // 
            // 人员信息管理ToolStripMenuItem
            // 
            this.人员信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本信息管理ToolStripMenuItem});
            this.人员信息管理ToolStripMenuItem.Name = "人员信息管理ToolStripMenuItem";
            this.人员信息管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.人员信息管理ToolStripMenuItem.Text = "人员信息管理";
            // 
            // 基本信息管理ToolStripMenuItem
            // 
            this.基本信息管理ToolStripMenuItem.Name = "基本信息管理ToolStripMenuItem";
            this.基本信息管理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.基本信息管理ToolStripMenuItem.Text = "基本信息管理";
            // 
            // 薪酬管理ToolStripMenuItem
            // 
            this.薪酬管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工资管理ToolStripMenuItem,
            this.奖金管理ToolStripMenuItem});
            this.薪酬管理ToolStripMenuItem.Name = "薪酬管理ToolStripMenuItem";
            this.薪酬管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.薪酬管理ToolStripMenuItem.Text = "薪酬管理";
            // 
            // 工资管理ToolStripMenuItem
            // 
            this.工资管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.维护员工工资数据ToolStripMenuItem,
            this.导入其他工资ExcelToolStripMenuItem,
            this.工资运算ToolStripMenuItem});
            this.工资管理ToolStripMenuItem.Name = "工资管理ToolStripMenuItem";
            this.工资管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.工资管理ToolStripMenuItem.Text = "工资管理";
            // 
            // 维护员工工资数据ToolStripMenuItem
            // 
            this.维护员工工资数据ToolStripMenuItem.Name = "维护员工工资数据ToolStripMenuItem";
            this.维护员工工资数据ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.维护员工工资数据ToolStripMenuItem.Text = "维护员工工资数据";
            // 
            // 导入其他工资ExcelToolStripMenuItem
            // 
            this.导入其他工资ExcelToolStripMenuItem.Name = "导入其他工资ExcelToolStripMenuItem";
            this.导入其他工资ExcelToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.导入其他工资ExcelToolStripMenuItem.Text = "导入其他工资（Excel）";
            // 
            // 工资运算ToolStripMenuItem
            // 
            this.工资运算ToolStripMenuItem.Name = "工资运算ToolStripMenuItem";
            this.工资运算ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.工资运算ToolStripMenuItem.Text = "工资运算";
            // 
            // 奖金管理ToolStripMenuItem
            // 
            this.奖金管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.维护员工奖金数据ToolStripMenuItem,
            this.导入其他工资ExcelToolStripMenuItem1,
            this.奖金运算ToolStripMenuItem});
            this.奖金管理ToolStripMenuItem.Name = "奖金管理ToolStripMenuItem";
            this.奖金管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.奖金管理ToolStripMenuItem.Text = "奖金管理";
            // 
            // 维护员工奖金数据ToolStripMenuItem
            // 
            this.维护员工奖金数据ToolStripMenuItem.Name = "维护员工奖金数据ToolStripMenuItem";
            this.维护员工奖金数据ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.维护员工奖金数据ToolStripMenuItem.Text = "维护员工奖金数据";
            // 
            // 导入其他工资ExcelToolStripMenuItem1
            // 
            this.导入其他工资ExcelToolStripMenuItem1.Name = "导入其他工资ExcelToolStripMenuItem1";
            this.导入其他工资ExcelToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.导入其他工资ExcelToolStripMenuItem1.Text = "导入其他工资（Excel）";
            // 
            // 奖金运算ToolStripMenuItem
            // 
            this.奖金运算ToolStripMenuItem.Name = "奖金运算ToolStripMenuItem";
            this.奖金运算ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.奖金运算ToolStripMenuItem.Text = "奖金运算";
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelForm.Location = new System.Drawing.Point(0, 28);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(992, 636);
            this.panelForm.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.bmp");
            this.imageList1.Images.SetKeyName(1, "1.bmp");
            this.imageList1.Images.SetKeyName(2, "2.bmp");
            this.imageList1.Images.SetKeyName(3, "3.bmp");
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel11,
            this.toolStripStatusLabel12,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel13});
            this.statusStrip1.Location = new System.Drawing.Point(0, 667);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 36);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 31);
            this.toolStripStatusLabel1.Text = "当前部门：";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 31);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(50, 31);
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(68, 31);
            this.toolStripStatusLabel4.Text = "当前用户：";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(131, 31);
            this.toolStripStatusLabel5.Text = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(50, 31);
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(92, 31);
            this.toolStripStatusLabel7.Text = "当前工作年月：";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.AutoSize = false;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(131, 31);
            this.toolStripStatusLabel8.Text = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.AutoSize = false;
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(50, 31);
            // 
            // toolStripStatusLabel11
            // 
            this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            this.toolStripStatusLabel11.Size = new System.Drawing.Size(56, 31);
            this.toolStripStatusLabel11.Text = "版本号：";
            // 
            // toolStripStatusLabel12
            // 
            this.toolStripStatusLabel12.AutoSize = false;
            this.toolStripStatusLabel12.Name = "toolStripStatusLabel12";
            this.toolStripStatusLabel12.Size = new System.Drawing.Size(137, 31);
            this.toolStripStatusLabel12.Text = "toolStripStatusLabel12";
            this.toolStripStatusLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.AutoSize = false;
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(50, 31);
            // 
            // toolStripStatusLabel13
            // 
            this.toolStripStatusLabel13.Font = new System.Drawing.Font("宋体", 9F);
            this.toolStripStatusLabel13.Name = "toolStripStatusLabel13";
            this.toolStripStatusLabel13.Size = new System.Drawing.Size(119, 12);
            this.toolStripStatusLabel13.Text = "Copyright(C) 南秦岭";
            // 
            // 权限管理AToolStripMenuItem
            // 
            this.权限管理AToolStripMenuItem.Name = "权限管理AToolStripMenuItem";
            this.权限管理AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.权限管理AToolStripMenuItem.Text = "权限管理(&A)";
            this.权限管理AToolStripMenuItem.Click += new System.EventHandler(this.权限管理AToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 703);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "渭南热电公司人力资源管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageKaoQin;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmiModifyPwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmiClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportAttendance;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel11;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel12;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel13;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportPrintKaoQin;
        private System.Windows.Forms.ToolStripMenuItem 组织机构管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 内设机构管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 岗位管理ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem 人员变动管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入职管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 岗位变动管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借调管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 离职管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退休管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 薪酬管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据备份BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工资管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护员工工资数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入其他工资ExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工资运算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奖金管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护员工奖金数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入其他工资ExcelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 奖金运算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限管理AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

