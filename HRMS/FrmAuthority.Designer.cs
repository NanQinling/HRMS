namespace HRMS
{
    partial class FrmAuthority
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthority));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBeiZhu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tvDeptList = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbADD = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.ckbAttendance = new System.Windows.Forms.CheckBox();
            this.ckbOvertime = new System.Windows.Forms.CheckBox();
            this.ckbEvaluation = new System.Windows.Forms.CheckBox();
            this.ckbAssessment = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.tsbDisable = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox);
            this.panel1.Controls.Add(this.tvDeptList);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 400);
            this.panel1.TabIndex = 24;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtUserName);
            this.groupBox.Controls.Add(this.ckbAssessment);
            this.groupBox.Controls.Add(this.txtEndDate);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.ckbEvaluation);
            this.groupBox.Controls.Add(this.txtStartDate);
            this.groupBox.Controls.Add(this.ckbOvertime);
            this.groupBox.Controls.Add(this.label20);
            this.groupBox.Controls.Add(this.ckbAttendance);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.txtUserId);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.txtBeiZhu);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.txtDeptId);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txtDept);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Location = new System.Drawing.Point(243, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(550, 246);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 61;
            this.label7.Text = "人员姓名：";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(118, 96);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(101, 21);
            this.txtUserId.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 55;
            this.label1.Text = "人员编号：";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(342, 58);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(101, 21);
            this.txtEndDate.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(260, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 53;
            this.label20.Text = "结束日期：";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(118, 58);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(101, 21);
            this.txtStartDate.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "开始日期：";
            // 
            // txtBeiZhu
            // 
            this.txtBeiZhu.Location = new System.Drawing.Point(118, 197);
            this.txtBeiZhu.Multiline = true;
            this.txtBeiZhu.Name = "txtBeiZhu";
            this.txtBeiZhu.Size = new System.Drawing.Size(325, 21);
            this.txtBeiZhu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "备    注：";
            // 
            // txtDeptId
            // 
            this.txtDeptId.BackColor = System.Drawing.SystemColors.Info;
            this.txtDeptId.Location = new System.Drawing.Point(118, 20);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(101, 21);
            this.txtDeptId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "机构编号：";
            // 
            // txtDept
            // 
            this.txtDept.BackColor = System.Drawing.SystemColors.Info;
            this.txtDept.Location = new System.Drawing.Point(342, 20);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(101, 21);
            this.txtDept.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "机构名称：";
            // 
            // tvDeptList
            // 
            this.tvDeptList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvDeptList.Location = new System.Drawing.Point(3, 3);
            this.tvDeptList.Name = "tvDeptList";
            this.tvDeptList.Size = new System.Drawing.Size(234, 307);
            this.tvDeptList.TabIndex = 2;
            this.tvDeptList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDeptList_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbADD,
            this.tsbSave,
            this.tsbDisable,
            this.tsbDelete,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 30;
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
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 35);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
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
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(76, 35);
            this.tsbClose.Text = "关闭窗口";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // ckbAttendance
            // 
            this.ckbAttendance.AutoSize = true;
            this.ckbAttendance.Location = new System.Drawing.Point(23, 136);
            this.ckbAttendance.Name = "ckbAttendance";
            this.ckbAttendance.Size = new System.Drawing.Size(72, 16);
            this.ckbAttendance.TabIndex = 63;
            this.ckbAttendance.Text = "考勤管理";
            this.ckbAttendance.UseVisualStyleBackColor = true;
            // 
            // ckbOvertime
            // 
            this.ckbOvertime.AutoSize = true;
            this.ckbOvertime.Location = new System.Drawing.Point(123, 136);
            this.ckbOvertime.Name = "ckbOvertime";
            this.ckbOvertime.Size = new System.Drawing.Size(72, 16);
            this.ckbOvertime.TabIndex = 64;
            this.ckbOvertime.Text = "加班管理";
            this.ckbOvertime.UseVisualStyleBackColor = true;
            // 
            // ckbEvaluation
            // 
            this.ckbEvaluation.AutoSize = true;
            this.ckbEvaluation.Location = new System.Drawing.Point(223, 136);
            this.ckbEvaluation.Name = "ckbEvaluation";
            this.ckbEvaluation.Size = new System.Drawing.Size(96, 16);
            this.ckbEvaluation.TabIndex = 65;
            this.ckbEvaluation.Text = "员工考评管理";
            this.ckbEvaluation.UseVisualStyleBackColor = true;
            // 
            // ckbAssessment
            // 
            this.ckbAssessment.AutoSize = true;
            this.ckbAssessment.Location = new System.Drawing.Point(347, 136);
            this.ckbAssessment.Name = "ckbAssessment";
            this.ckbAssessment.Size = new System.Drawing.Size(96, 16);
            this.ckbAssessment.TabIndex = 66;
            this.ckbAssessment.Text = "绩效奖金管理";
            this.ckbAssessment.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(342, 97);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(101, 21);
            this.txtUserName.TabIndex = 67;
            // 
            // tsbDisable
            // 
            this.tsbDisable.Image = ((System.Drawing.Image)(resources.GetObject("tsbDisable.Image")));
            this.tsbDisable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDisable.Name = "tsbDisable";
            this.tsbDisable.Size = new System.Drawing.Size(52, 35);
            this.tsbDisable.Text = "定界";
            // 
            // FrmAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAuthority";
            this.Text = "权限管理";
            this.panel1.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbADD;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBeiZhu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvDeptList;
        private System.Windows.Forms.CheckBox ckbAssessment;
        private System.Windows.Forms.CheckBox ckbEvaluation;
        private System.Windows.Forms.CheckBox ckbOvertime;
        private System.Windows.Forms.CheckBox ckbAttendance;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ToolStripButton tsbDisable;
    }
}