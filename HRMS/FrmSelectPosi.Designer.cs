namespace HRMS
{
    partial class FrmSelectPosi
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
            this.tvPosiList = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvPosiList
            // 
            this.tvPosiList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvPosiList.Location = new System.Drawing.Point(12, 12);
            this.tvPosiList.Name = "tvPosiList";
            this.tvPosiList.Size = new System.Drawing.Size(478, 283);
            this.tvPosiList.TabIndex = 1;
            this.tvPosiList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPosiList_AfterSelect);
            this.tvPosiList.DoubleClick += new System.EventHandler(this.tvPosiList_DoubleClick);
            // 
            // FrmSelectPosi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 307);
            this.Controls.Add(this.tvPosiList);
            this.Name = "FrmSelectPosi";
            this.Text = "FrmSelectPosi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvPosiList;
    }
}