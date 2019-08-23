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
            this.gbDept = new System.Windows.Forms.GroupBox();
            this.cmbJiGouLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtParentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtJiGouID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBeiZhu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJiGouShortName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJiGouFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tvDeptList = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbADDParent = new System.Windows.Forms.ToolStripButton();
            this.tsbADDChild = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveDown = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.gbDept.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gbDept);
            this.panel1.Controls.Add(this.tvDeptList);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 400);
            this.panel1.TabIndex = 24;
            // 
            // gbDept
            // 
            this.gbDept.Controls.Add(this.cmbJiGouLevel);
            this.gbDept.Controls.Add(this.label7);
            this.gbDept.Controls.Add(this.txtSort);
            this.gbDept.Controls.Add(this.label6);
            this.gbDept.Controls.Add(this.txtParentID);
            this.gbDept.Controls.Add(this.label1);
            this.gbDept.Controls.Add(this.txtEndDate);
            this.gbDept.Controls.Add(this.label20);
            this.gbDept.Controls.Add(this.txtStartDate);
            this.gbDept.Controls.Add(this.label11);
            this.gbDept.Controls.Add(this.txtJiGouID);
            this.gbDept.Controls.Add(this.label4);
            this.gbDept.Controls.Add(this.txtBeiZhu);
            this.gbDept.Controls.Add(this.label5);
            this.gbDept.Controls.Add(this.txtJiGouShortName);
            this.gbDept.Controls.Add(this.label3);
            this.gbDept.Controls.Add(this.txtJiGouFullName);
            this.gbDept.Controls.Add(this.label2);
            this.gbDept.Location = new System.Drawing.Point(243, 3);
            this.gbDept.Name = "gbDept";
            this.gbDept.Size = new System.Drawing.Size(550, 246);
            this.gbDept.TabIndex = 1;
            this.gbDept.TabStop = false;
            // 
            // cmbJiGouLevel
            // 
            this.cmbJiGouLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJiGouLevel.FormattingEnabled = true;
            this.cmbJiGouLevel.Location = new System.Drawing.Point(342, 97);
            this.cmbJiGouLevel.Name = "cmbJiGouLevel";
            this.cmbJiGouLevel.Size = new System.Drawing.Size(101, 20);
            this.cmbJiGouLevel.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 61;
            this.label7.Text = "机构层级：";
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(342, 133);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(101, 21);
            this.txtSort.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 57;
            this.label6.Text = "排    序：";
            // 
            // txtParentID
            // 
            this.txtParentID.Location = new System.Drawing.Point(118, 96);
            this.txtParentID.Name = "txtParentID";
            this.txtParentID.Size = new System.Drawing.Size(101, 21);
            this.txtParentID.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 55;
            this.label1.Text = "上级机构：";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(342, 20);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(101, 21);
            this.txtEndDate.TabIndex = 52;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(260, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 53;
            this.label20.Text = "结束日期：";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(118, 20);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(101, 21);
            this.txtStartDate.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "开始日期：";
            // 
            // txtJiGouID
            // 
            this.txtJiGouID.Location = new System.Drawing.Point(118, 133);
            this.txtJiGouID.Name = "txtJiGouID";
            this.txtJiGouID.Size = new System.Drawing.Size(101, 21);
            this.txtJiGouID.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "机构编码：";
            // 
            // txtBeiZhu
            // 
            this.txtBeiZhu.Location = new System.Drawing.Point(118, 172);
            this.txtBeiZhu.Multiline = true;
            this.txtBeiZhu.Name = "txtBeiZhu";
            this.txtBeiZhu.Size = new System.Drawing.Size(325, 21);
            this.txtBeiZhu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "备    注：";
            // 
            // txtJiGouShortName
            // 
            this.txtJiGouShortName.Location = new System.Drawing.Point(118, 54);
            this.txtJiGouShortName.Name = "txtJiGouShortName";
            this.txtJiGouShortName.Size = new System.Drawing.Size(101, 21);
            this.txtJiGouShortName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "对象缩写：";
            // 
            // txtJiGouFullName
            // 
            this.txtJiGouFullName.Location = new System.Drawing.Point(342, 54);
            this.txtJiGouFullName.Name = "txtJiGouFullName";
            this.txtJiGouFullName.Size = new System.Drawing.Size(101, 21);
            this.txtJiGouFullName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "对象名称：";
            // 
            // tvDeptList
            // 
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
            this.tsbADDParent,
            this.tsbADDChild,
            this.tsbSave,
            this.tsbDelete,
            this.tsbClose,
            this.tsbMoveUp,
            this.tsbMoveDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbADDParent
            // 
            this.tsbADDParent.Image = ((System.Drawing.Image)(resources.GetObject("tsbADDParent.Image")));
            this.tsbADDParent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbADDParent.Name = "tsbADDParent";
            this.tsbADDParent.Size = new System.Drawing.Size(76, 35);
            this.tsbADDParent.Text = "添加同级";
            // 
            // tsbADDChild
            // 
            this.tsbADDChild.Image = ((System.Drawing.Image)(resources.GetObject("tsbADDChild.Image")));
            this.tsbADDChild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbADDChild.Name = "tsbADDChild";
            this.tsbADDChild.Size = new System.Drawing.Size(76, 35);
            this.tsbADDChild.Text = "添加下级";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 35);
            this.tsbSave.Text = "保存";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 35);
            this.tsbDelete.Text = "删除";
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
            // tsbMoveUp
            // 
            this.tsbMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoveUp.Image")));
            this.tsbMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveUp.Name = "tsbMoveUp";
            this.tsbMoveUp.Size = new System.Drawing.Size(52, 35);
            this.tsbMoveUp.Text = "上移";
            // 
            // tsbMoveDown
            // 
            this.tsbMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoveDown.Image")));
            this.tsbMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveDown.Name = "tsbMoveDown";
            this.tsbMoveDown.Size = new System.Drawing.Size(52, 35);
            this.tsbMoveDown.Text = "下移";
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
            this.gbDept.ResumeLayout(false);
            this.gbDept.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbADDParent;
        private System.Windows.Forms.ToolStripButton tsbADDChild;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbMoveUp;
        private System.Windows.Forms.ToolStripButton tsbMoveDown;
        private System.Windows.Forms.GroupBox gbDept;
        private System.Windows.Forms.ComboBox cmbJiGouLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtParentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtJiGouID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBeiZhu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJiGouShortName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJiGouFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvDeptList;
    }
}