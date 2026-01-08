namespace VRMS.Controls
{
    partial class MainHeaderControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.panel1.Controls.Add(this.lblUserInfo);
            this.panel1.Controls.Add(this.lblPageSubtitle);
            this.panel1.Controls.Add(this.lblPageTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel1.Size = new System.Drawing.Size(630, 70);
            this.panel1.TabIndex = 0;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Location = new System.Drawing.Point(450, 25);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(160, 20);
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "User (Role)";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.AutoSize = true;
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.lblPageSubtitle.Location = new System.Drawing.Point(23, 42);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(114, 15);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Page description here";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(20, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(120, 30);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Page Title";
            // 
            // MainHeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MainHeaderControl";
            this.Size = new System.Drawing.Size(630, 70);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Label lblUserInfo;
    }
}