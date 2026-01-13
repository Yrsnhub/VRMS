namespace VRMS.Controls
{
    partial class AdminView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            tcAdmin = new System.Windows.Forms.TabControl();
            tpUsers = new System.Windows.Forms.TabPage();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            dgvUsers = new System.Windows.Forms.DataGridView();
            gbUserListActions = new System.Windows.Forms.GroupBox();
            btnAddUser = new System.Windows.Forms.Button();
            btnEditUser = new System.Windows.Forms.Button();
            btnDeleteUser = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            pnlUserManagement = new System.Windows.Forms.Panel();
            gbUserDetails = new System.Windows.Forms.GroupBox();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblUsername = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            lblFullName = new System.Windows.Forms.Label();
            cbRole = new System.Windows.Forms.ComboBox();
            lblRole = new System.Windows.Forms.Label();
            gbActions = new System.Windows.Forms.GroupBox();
            btnApprove = new System.Windows.Forms.Button();
            btnReject = new System.Windows.Forms.Button();
            btnDeactivate = new System.Windows.Forms.Button();
            btnResetPassword = new System.Windows.Forms.Button();
            btnSaveUser = new System.Windows.Forms.Button();
            tpLogs = new System.Windows.Forms.TabPage();
            btnClearLogs = new System.Windows.Forms.Button();
            dgvLogs = new System.Windows.Forms.DataGridView();
            tpSettings = new System.Windows.Forms.TabPage();
            btnSaveSettings = new System.Windows.Forms.Button();
            txtSystemName = new System.Windows.Forms.TextBox();
            lblSystemName = new System.Windows.Forms.Label();
            pnlHeader.SuspendLayout();
            tcAdmin.SuspendLayout();
            tpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            gbUserListActions.SuspendLayout();
            pnlUserManagement.SuspendLayout();
            gbUserDetails.SuspendLayout();
            gbActions.SuspendLayout();
            tpLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            tpSettings.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1000, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblTitle.Location = new System.Drawing.Point(20, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(284, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Administration";
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpUsers);
            tcAdmin.Controls.Add(tpLogs);
            tcAdmin.Controls.Add(tpSettings);
            tcAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            tcAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            tcAdmin.ItemSize = new System.Drawing.Size(180, 40);
            tcAdmin.Location = new System.Drawing.Point(0, 100);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new System.Drawing.Size(1000, 775);
            tcAdmin.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            tcAdmin.TabIndex = 1;
            // 
            // tpUsers
            // 
            tpUsers.Controls.Add(splitContainer1);
            tpUsers.Location = new System.Drawing.Point(4, 44);
            tpUsers.Name = "tpUsers";
            tpUsers.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            tpUsers.Size = new System.Drawing.Size(992, 727);
            tpUsers.TabIndex = 0;
            tpUsers.Text = "User Management";
            tpUsers.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(10, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvUsers);
            splitContainer1.Panel1.Controls.Add(gbUserListActions);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlUserManagement);
            splitContainer1.Size = new System.Drawing.Size(972, 703);
            splitContainer1.SplitterDistance = 650;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.BackgroundColor = System.Drawing.Color.White;
            dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill; // Set to Fill to avoid cut-off
            dgvUsers.Location = new System.Drawing.Point(0, 112);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new System.Drawing.Size(650, 591);
            dgvUsers.TabIndex = 1;
            // 
            // gbUserListActions
            // 
            gbUserListActions.Controls.Add(btnAddUser);
            gbUserListActions.Controls.Add(btnEditUser);
            gbUserListActions.Controls.Add(btnDeleteUser);
            gbUserListActions.Controls.Add(btnRefresh);
            gbUserListActions.Dock = System.Windows.Forms.DockStyle.Top;
            gbUserListActions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            gbUserListActions.Location = new System.Drawing.Point(0, 0);
            gbUserListActions.Name = "gbUserListActions";
            gbUserListActions.Size = new System.Drawing.Size(650, 112);
            gbUserListActions.TabIndex = 0;
            gbUserListActions.TabStop = false;
            gbUserListActions.Text = "User List";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddUser.ForeColor = System.Drawing.Color.White;
            btnAddUser.Location = new System.Drawing.Point(20, 44);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new System.Drawing.Size(120, 44);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "+ Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditUser.ForeColor = System.Drawing.Color.White;
            btnEditUser.Location = new System.Drawing.Point(160, 44);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new System.Drawing.Size(120, 44);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteUser.ForeColor = System.Drawing.Color.White;
            btnDeleteUser.Location = new System.Drawing.Point(300, 44);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new System.Drawing.Size(120, 44);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(508, 44);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(120, 44);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // pnlUserManagement
            // 
            pnlUserManagement.Controls.Add(gbUserDetails);
            pnlUserManagement.Controls.Add(gbActions);
            pnlUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlUserManagement.Location = new System.Drawing.Point(0, 0);
            pnlUserManagement.Name = "pnlUserManagement";
            pnlUserManagement.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            pnlUserManagement.Size = new System.Drawing.Size(312, 703);
            pnlUserManagement.TabIndex = 0;
            // 
            // gbUserDetails
            // 
            gbUserDetails.Controls.Add(txtEmail);
            gbUserDetails.Controls.Add(lblEmail);
            gbUserDetails.Controls.Add(txtUsername);
            gbUserDetails.Controls.Add(lblUsername);
            gbUserDetails.Controls.Add(txtFullName);
            gbUserDetails.Controls.Add(lblFullName);
            gbUserDetails.Controls.Add(cbRole);
            gbUserDetails.Controls.Add(lblRole);
            gbUserDetails.Dock = System.Windows.Forms.DockStyle.Top;
            gbUserDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            gbUserDetails.Location = new System.Drawing.Point(10, 12);
            gbUserDetails.Name = "gbUserDetails";
            gbUserDetails.Size = new System.Drawing.Size(292, 335);
            gbUserDetails.TabIndex = 0;
            gbUserDetails.TabStop = false;
            gbUserDetails.Text = "User Details";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(20, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(250, 29);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(17, 196);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(48, 21);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(20, 88);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(250, 29);
            txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(17, 59);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(83, 21);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(20, 156);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(250, 29);
            txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new System.Drawing.Point(17, 128);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(82, 21);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Administrator", "Manager", "User", "Viewer" });
            cbRole.Location = new System.Drawing.Point(20, 294);
            cbRole.Name = "cbRole";
            cbRole.Size = new System.Drawing.Size(250, 29);
            cbRole.TabIndex = 1;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new System.Drawing.Point(17, 265);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(43, 21);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role";
            // 
            // gbActions
            // 
            gbActions.Controls.Add(btnApprove);
            gbActions.Controls.Add(btnReject);
            gbActions.Controls.Add(btnDeactivate);
            gbActions.Controls.Add(btnResetPassword);
            gbActions.Controls.Add(btnSaveUser);
            gbActions.Dock = System.Windows.Forms.DockStyle.Fill;
            gbActions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            gbActions.Location = new System.Drawing.Point(10, 347);
            gbActions.Name = "gbActions";
            gbActions.Size = new System.Drawing.Size(292, 344);
            gbActions.TabIndex = 1;
            gbActions.TabStop = false;
            gbActions.Text = "Actions";
            // 
            // btnApprove
            // 
            btnApprove.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApprove.ForeColor = System.Drawing.Color.White;
            btnApprove.Location = new System.Drawing.Point(20, 50);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new System.Drawing.Size(250, 44);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Approve User";
            btnApprove.UseVisualStyleBackColor = false;
            // 
            // btnReject
            // 
            btnReject.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReject.ForeColor = System.Drawing.Color.White;
            btnReject.Location = new System.Drawing.Point(20, 106);
            btnReject.Name = "btnReject";
            btnReject.Size = new System.Drawing.Size(250, 44);
            btnReject.TabIndex = 1;
            btnReject.Text = "Reject User";
            btnReject.UseVisualStyleBackColor = false;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeactivate.ForeColor = System.Drawing.Color.White;
            btnDeactivate.Location = new System.Drawing.Point(20, 219);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new System.Drawing.Size(250, 44);
            btnDeactivate.TabIndex = 3;
            btnDeactivate.Text = "Deactivate User";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetPassword.ForeColor = System.Drawing.Color.White;
            btnResetPassword.Location = new System.Drawing.Point(20, 162);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new System.Drawing.Size(250, 44);
            btnResetPassword.TabIndex = 2;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = false;
            // 
            // btnSaveUser
            // 
            btnSaveUser.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveUser.ForeColor = System.Drawing.Color.White;
            btnSaveUser.Location = new System.Drawing.Point(20, 275);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new System.Drawing.Size(250, 44);
            btnSaveUser.TabIndex = 4;
            btnSaveUser.Text = "Save Changes";
            btnSaveUser.UseVisualStyleBackColor = false;
            // 
            // tpLogs
            // 
            tpLogs.Controls.Add(btnClearLogs);
            tpLogs.Controls.Add(dgvLogs);
            tpLogs.Location = new System.Drawing.Point(4, 44);
            tpLogs.Name = "tpLogs";
            tpLogs.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            tpLogs.Size = new System.Drawing.Size(992, 727);
            tpLogs.TabIndex = 1;
            tpLogs.Text = "System Activity Logs";
            tpLogs.UseVisualStyleBackColor = true;
            // 
            // btnClearLogs
            // 
            btnClearLogs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClearLogs.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            btnClearLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClearLogs.ForeColor = System.Drawing.Color.White;
            btnClearLogs.Location = new System.Drawing.Point(829, 16);
            btnClearLogs.Name = "btnClearLogs";
            btnClearLogs.Size = new System.Drawing.Size(150, 44);
            btnClearLogs.TabIndex = 1;
            btnClearLogs.Text = "Clear History";
            btnClearLogs.UseVisualStyleBackColor = false;
            // 
            // dgvLogs
            // 
            dgvLogs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvLogs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new System.Drawing.Point(13, 68);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersVisible = false;
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.Size = new System.Drawing.Size(966, 631);
            dgvLogs.TabIndex = 0;
            // 
            // tpSettings
            // 
            tpSettings.Controls.Add(btnSaveSettings);
            tpSettings.Controls.Add(txtSystemName);
            tpSettings.Controls.Add(lblSystemName);
            tpSettings.Location = new System.Drawing.Point(4, 44);
            tpSettings.Name = "tpSettings";
            tpSettings.Size = new System.Drawing.Size(992, 727);
            tpSettings.TabIndex = 2;
            tpSettings.Text = "System Settings";
            tpSettings.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSaveSettings.ForeColor = System.Drawing.Color.White;
            btnSaveSettings.Location = new System.Drawing.Point(30, 138);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new System.Drawing.Size(200, 56);
            btnSaveSettings.TabIndex = 2;
            btnSaveSettings.Text = "Save System Config";
            btnSaveSettings.UseVisualStyleBackColor = false;
            // 
            // txtSystemName
            // 
            txtSystemName.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtSystemName.Location = new System.Drawing.Point(30, 75);
            txtSystemName.Name = "txtSystemName";
            txtSystemName.Size = new System.Drawing.Size(400, 32);
            txtSystemName.TabIndex = 1;
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            lblSystemName.Location = new System.Drawing.Point(26, 42);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new System.Drawing.Size(120, 23);
            lblSystemName.TabIndex = 0;
            lblSystemName.Text = "System Name:";
            // 
            // AdminView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(tcAdmin);
            Controls.Add(pnlHeader);
            Name = "AdminView";
            Size = new System.Drawing.Size(1000, 875);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tcAdmin.ResumeLayout(false);
            tpUsers.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            gbUserListActions.ResumeLayout(false);
            pnlUserManagement.ResumeLayout(false);
            gbUserDetails.ResumeLayout(false);
            gbUserDetails.PerformLayout();
            gbActions.ResumeLayout(false);
            tpLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            tpSettings.ResumeLayout(false);
            tpSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox gbUserListActions;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.GroupBox gbUserDetails;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.TabPage tpLogs;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TextBox txtSystemName;
        private System.Windows.Forms.Label lblSystemName;
    }
}