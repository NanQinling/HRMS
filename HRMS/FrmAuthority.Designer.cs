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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuMen = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHnbh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ckbAttendance = new System.Windows.Forms.CheckBox();
            this.ckbOvertime = new System.Windows.Forms.CheckBox();
            this.ckbEvaluation = new System.Windows.Forms.CheckBox();
            this.ckbAssessment = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(0, -30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 510);
            this.panel1.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(17, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(763, 113);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "dept";
            this.Column1.HeaderText = "部门";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "userid";
            this.Column2.HeaderText = "人员编号";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "username";
            this.Column3.HeaderText = "姓名";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Attendance";
            this.Column4.HeaderText = "考勤管理";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Overtime";
            this.Column5.HeaderText = "加班管理";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Evaluation";
            this.Column6.HeaderText = "员工考评管理";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "assessment";
            this.Column7.HeaderText = "月度绩效管理";
            this.Column7.Name = "Column7";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(705, 63);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbAssessment);
            this.groupBox2.Controls.Add(this.ckbEvaluation);
            this.groupBox2.Controls.Add(this.ckbOvertime);
            this.groupBox2.Controls.Add(this.ckbAttendance);
            this.groupBox2.Controls.Add(this.txtBuMen);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHnbh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(17, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 133);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[考勤数据]";
            // 
            // txtBuMen
            // 
            this.txtBuMen.BackColor = System.Drawing.SystemColors.Info;
            this.txtBuMen.Location = new System.Drawing.Point(96, 20);
            this.txtBuMen.Name = "txtBuMen";
            this.txtBuMen.ReadOnly = true;
            this.txtBuMen.Size = new System.Drawing.Size(72, 21);
            this.txtBuMen.TabIndex = 60;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 61;
            this.label29.Text = "部门：";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Location = new System.Drawing.Point(688, 20);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(72, 21);
            this.txtName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "姓名：";
            // 
            // txtHnbh
            // 
            this.txtHnbh.BackColor = System.Drawing.SystemColors.Info;
            this.txtHnbh.Location = new System.Drawing.Point(469, 20);
            this.txtHnbh.Name = "txtHnbh";
            this.txtHnbh.ReadOnly = true;
            this.txtHnbh.Size = new System.Drawing.Size(72, 21);
            this.txtHnbh.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "人员编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "权限管理";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(598, 63);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // ckbAttendance
            // 
            this.ckbAttendance.AutoSize = true;
            this.ckbAttendance.Location = new System.Drawing.Point(13, 57);
            this.ckbAttendance.Name = "ckbAttendance";
            this.ckbAttendance.Size = new System.Drawing.Size(72, 16);
            this.ckbAttendance.TabIndex = 62;
            this.ckbAttendance.Text = "考勤管理";
            this.ckbAttendance.UseVisualStyleBackColor = true;
            // 
            // ckbOvertime
            // 
            this.ckbOvertime.AutoSize = true;
            this.ckbOvertime.Location = new System.Drawing.Point(129, 57);
            this.ckbOvertime.Name = "ckbOvertime";
            this.ckbOvertime.Size = new System.Drawing.Size(72, 16);
            this.ckbOvertime.TabIndex = 63;
            this.ckbOvertime.Text = "加班管理";
            this.ckbOvertime.UseVisualStyleBackColor = true;
            // 
            // ckbEvaluation
            // 
            this.ckbEvaluation.AutoSize = true;
            this.ckbEvaluation.Location = new System.Drawing.Point(267, 57);
            this.ckbEvaluation.Name = "ckbEvaluation";
            this.ckbEvaluation.Size = new System.Drawing.Size(96, 16);
            this.ckbEvaluation.TabIndex = 64;
            this.ckbEvaluation.Text = "员工考评管理";
            this.ckbEvaluation.UseVisualStyleBackColor = true;
            // 
            // ckbAssessment
            // 
            this.ckbAssessment.AutoSize = true;
            this.ckbAssessment.Location = new System.Drawing.Point(401, 57);
            this.ckbAssessment.Name = "ckbAssessment";
            this.ckbAssessment.Size = new System.Drawing.Size(96, 16);
            this.ckbAssessment.TabIndex = 65;
            this.ckbAssessment.Text = "月度绩效管理";
            this.ckbAssessment.UseVisualStyleBackColor = true;
            // 
            // FrmAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAuthority";
            this.Text = "权限管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuMen;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHnbh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.CheckBox ckbAssessment;
        private System.Windows.Forms.CheckBox ckbEvaluation;
        private System.Windows.Forms.CheckBox ckbOvertime;
        private System.Windows.Forms.CheckBox ckbAttendance;
    }
}