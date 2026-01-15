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
            pnlHeader = new Panel();
            lblTitle = new Label();
            tcAdmin = new TabControl();
            tpPendingApprovals = new TabPage();
            splitContainer1 = new SplitContainer();
            dgvPendingUsers = new DataGridView();
            colUsername = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colRequestedDate = new DataGridViewTextBoxColumn();
            colApprove = new DataGridViewButtonColumn();
            colDecline = new DataGridViewButtonColumn();
            gbPendingListActions = new GroupBox();
            btnRefreshPending = new Button();
            btnExportPending = new Button();
            gbApprovalStats = new GroupBox();
            lblTotalPending = new Label();
            lblTotalLabel = new Label();
            lblApprovedToday = new Label();
            lblApprovedTodayLabel = new Label();
            lblDeclinedToday = new Label();
            lblDeclinedTodayLabel = new Label();
            tpUserManagement = new TabPage();
            splitContainer2 = new SplitContainer();
            dgvAllUsers = new DataGridView();
            gbUserListActions = new GroupBox();
            btnAddUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            btnRefreshAllUsers = new Button();
            tpSettings = new TabPage();
            btnSaveSettings = new Button();
            txtSystemName = new TextBox();
            lblSystemName = new Label();
            pnlHeader.SuspendLayout();
            tcAdmin.SuspendLayout();
            tpPendingApprovals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingUsers).BeginInit();
            gbPendingListActions.SuspendLayout();
            gbApprovalStats.SuspendLayout();
            tpUserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllUsers).BeginInit();
            gbUserListActions.SuspendLayout();
            tpSettings.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.WhiteSmoke;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1263, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(20, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(284, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Administration";
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpPendingApprovals);
            tcAdmin.Controls.Add(tpUserManagement);
            tcAdmin.Controls.Add(tpSettings);
            tcAdmin.Dock = DockStyle.Fill;
            tcAdmin.Font = new Font("Segoe UI", 10F);
            tcAdmin.ItemSize = new Size(180, 40);
            tcAdmin.Location = new Point(0, 100);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(1263, 775);
            tcAdmin.SizeMode = TabSizeMode.FillToRight;
            tcAdmin.TabIndex = 1;
            // 
            // tpPendingApprovals
            // 
            tpPendingApprovals.Controls.Add(splitContainer1);
            tpPendingApprovals.Location = new Point(4, 44);
            tpPendingApprovals.Name = "tpPendingApprovals";
            tpPendingApprovals.Padding = new Padding(10, 12, 10, 12);
            tpPendingApprovals.Size = new Size(1255, 727);
            tpPendingApprovals.TabIndex = 0;
            tpPendingApprovals.Text = "Pending Approvals";
            tpPendingApprovals.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(10, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvPendingUsers);
            splitContainer1.Panel1.Controls.Add(gbPendingListActions);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(gbApprovalStats);
            splitContainer1.Size = new Size(1235, 703);
            splitContainer1.SplitterDistance = 889;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 0;
            // 
            // dgvPendingUsers
            // 
            dgvPendingUsers.AllowUserToAddRows = false;
            dgvPendingUsers.AllowUserToDeleteRows = false;
            dgvPendingUsers.AllowUserToResizeRows = false;
            dgvPendingUsers.BackgroundColor = Color.White;
            dgvPendingUsers.BorderStyle = BorderStyle.None;
            dgvPendingUsers.ColumnHeadersHeight = 50;
            dgvPendingUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPendingUsers.Columns.AddRange(new DataGridViewColumn[] { colUsername, colFullName, colEmail, colRequestedDate, colApprove, colDecline });
            dgvPendingUsers.Dock = DockStyle.Fill;
            dgvPendingUsers.GridColor = Color.Gainsboro;
            dgvPendingUsers.Location = new Point(0, 112);
            dgvPendingUsers.MultiSelect = false;
            dgvPendingUsers.Name = "dgvPendingUsers";
            dgvPendingUsers.ReadOnly = true;
            dgvPendingUsers.RowHeadersVisible = false;
            dgvPendingUsers.RowHeadersWidth = 51;
            dgvPendingUsers.RowTemplate.Height = 45;
            dgvPendingUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPendingUsers.Size = new Size(889, 591);
            dgvPendingUsers.TabIndex = 2;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 120;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Width = 150;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 150;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            colFullName.Width = 200;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email Address";
            colEmail.MinimumWidth = 180;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 220;
            // 
            // colRequestedDate
            // 
            colRequestedDate.DataPropertyName = "RequestedDate";
            colRequestedDate.HeaderText = "Requested Date";
            colRequestedDate.MinimumWidth = 120;
            colRequestedDate.Name = "colRequestedDate";
            colRequestedDate.ReadOnly = true;
            colRequestedDate.Width = 150;
            // 
            // colApprove
            // 
            colApprove.HeaderText = "";
            colApprove.MinimumWidth = 80;
            colApprove.Name = "colApprove";
            colApprove.ReadOnly = true;
            colApprove.Text = "Approve";
            colApprove.UseColumnTextForButtonValue = true;
            colApprove.Width = 80;
            // 
            // colDecline
            // 
            colDecline.HeaderText = "";
            colDecline.MinimumWidth = 80;
            colDecline.Name = "colDecline";
            colDecline.ReadOnly = true;
            colDecline.Text = "Decline";
            colDecline.UseColumnTextForButtonValue = true;
            colDecline.Width = 80;
            // 
            // gbPendingListActions
            // 
            gbPendingListActions.Controls.Add(btnRefreshPending);
            gbPendingListActions.Controls.Add(btnExportPending);
            gbPendingListActions.Dock = DockStyle.Top;
            gbPendingListActions.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            gbPendingListActions.Location = new Point(0, 0);
            gbPendingListActions.Name = "gbPendingListActions";
            gbPendingListActions.Size = new Size(889, 112);
            gbPendingListActions.TabIndex = 1;
            gbPendingListActions.TabStop = false;
            gbPendingListActions.Text = "Pending User Approvals";
            // 
            // btnRefreshPending
            // 
            btnRefreshPending.BackColor = Color.FromArgb(52, 152, 219);
            btnRefreshPending.FlatStyle = FlatStyle.Flat;
            btnRefreshPending.ForeColor = Color.White;
            btnRefreshPending.Location = new Point(20, 44);
            btnRefreshPending.Name = "btnRefreshPending";
            btnRefreshPending.Size = new Size(140, 44);
            btnRefreshPending.TabIndex = 0;
            btnRefreshPending.Text = "Refresh List";
            btnRefreshPending.UseVisualStyleBackColor = false;
            // 
            // btnExportPending
            // 
            btnExportPending.BackColor = Color.FromArgb(155, 89, 182);
            btnExportPending.FlatStyle = FlatStyle.Flat;
            btnExportPending.ForeColor = Color.White;
            btnExportPending.Location = new Point(180, 44);
            btnExportPending.Name = "btnExportPending";
            btnExportPending.Size = new Size(140, 44);
            btnExportPending.TabIndex = 1;
            btnExportPending.Text = "Export to CSV";
            btnExportPending.UseVisualStyleBackColor = false;
            // 
            // gbApprovalStats
            // 
            gbApprovalStats.Controls.Add(lblTotalPending);
            gbApprovalStats.Controls.Add(lblTotalLabel);
            gbApprovalStats.Controls.Add(lblApprovedToday);
            gbApprovalStats.Controls.Add(lblApprovedTodayLabel);
            gbApprovalStats.Controls.Add(lblDeclinedToday);
            gbApprovalStats.Controls.Add(lblDeclinedTodayLabel);
            gbApprovalStats.Dock = DockStyle.Top;
            gbApprovalStats.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            gbApprovalStats.Location = new Point(0, 0);
            gbApprovalStats.Name = "gbApprovalStats";
            gbApprovalStats.Padding = new Padding(15);
            gbApprovalStats.Size = new Size(336, 703);
            gbApprovalStats.TabIndex = 0;
            gbApprovalStats.TabStop = false;
            gbApprovalStats.Text = "Approval Statistics";
            // 
            // lblTotalPending
            // 
            lblTotalPending.AutoSize = true;
            lblTotalPending.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalPending.ForeColor = Color.FromArgb(243, 156, 18);
            lblTotalPending.Location = new Point(18, 69);
            lblTotalPending.Name = "lblTotalPending";
            lblTotalPending.Size = new Size(81, 62);
            lblTotalPending.TabIndex = 5;
            lblTotalPending.Text = "12";
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalLabel.Location = new Point(18, 45);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(99, 20);
            lblTotalLabel.TabIndex = 4;
            lblTotalLabel.Text = "Total Pending";
            // 
            // lblApprovedToday
            // 
            lblApprovedToday.AutoSize = true;
            lblApprovedToday.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblApprovedToday.ForeColor = Color.FromArgb(46, 204, 113);
            lblApprovedToday.Location = new Point(18, 202);
            lblApprovedToday.Name = "lblApprovedToday";
            lblApprovedToday.Size = new Size(81, 62);
            lblApprovedToday.TabIndex = 3;
            lblApprovedToday.Text = "05";
            // 
            // lblApprovedTodayLabel
            // 
            lblApprovedTodayLabel.AutoSize = true;
            lblApprovedTodayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApprovedTodayLabel.Location = new Point(18, 178);
            lblApprovedTodayLabel.Name = "lblApprovedTodayLabel";
            lblApprovedTodayLabel.Size = new Size(119, 20);
            lblApprovedTodayLabel.TabIndex = 2;
            lblApprovedTodayLabel.Text = "Approved Today";
            // 
            // lblDeclinedToday
            // 
            lblDeclinedToday.AutoSize = true;
            lblDeclinedToday.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblDeclinedToday.ForeColor = Color.FromArgb(231, 76, 60);
            lblDeclinedToday.Location = new Point(18, 335);
            lblDeclinedToday.Name = "lblDeclinedToday";
            lblDeclinedToday.Size = new Size(81, 62);
            lblDeclinedToday.TabIndex = 1;
            lblDeclinedToday.Text = "02";
            // 
            // lblDeclinedTodayLabel
            // 
            lblDeclinedTodayLabel.AutoSize = true;
            lblDeclinedTodayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeclinedTodayLabel.Location = new Point(18, 311);
            lblDeclinedTodayLabel.Name = "lblDeclinedTodayLabel";
            lblDeclinedTodayLabel.Size = new Size(112, 20);
            lblDeclinedTodayLabel.TabIndex = 0;
            lblDeclinedTodayLabel.Text = "Declined Today";
            // 
            // tpUserManagement
            // 
            tpUserManagement.Controls.Add(splitContainer2);
            tpUserManagement.Location = new Point(4, 44);
            tpUserManagement.Name = "tpUserManagement";
            tpUserManagement.Padding = new Padding(10, 12, 10, 12);
            tpUserManagement.Size = new Size(1255, 727);
            tpUserManagement.TabIndex = 1;
            tpUserManagement.Text = "All Users";
            tpUserManagement.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(10, 12);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dgvAllUsers);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(gbUserListActions);
            splitContainer2.Size = new Size(1235, 703);
            splitContainer2.SplitterDistance = 573;
            splitContainer2.SplitterWidth = 10;
            splitContainer2.TabIndex = 0;
            // 
            // dgvAllUsers
            // 
            dgvAllUsers.AllowUserToAddRows = false;
            dgvAllUsers.AllowUserToDeleteRows = false;
            dgvAllUsers.BackgroundColor = Color.White;
            dgvAllUsers.BorderStyle = BorderStyle.None;
            dgvAllUsers.ColumnHeadersHeight = 40;
            dgvAllUsers.Dock = DockStyle.Fill;
            dgvAllUsers.Location = new Point(0, 0);
            dgvAllUsers.MultiSelect = false;
            dgvAllUsers.Name = "dgvAllUsers";
            dgvAllUsers.ReadOnly = true;
            dgvAllUsers.RowHeadersVisible = false;
            dgvAllUsers.RowHeadersWidth = 51;
            dgvAllUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllUsers.Size = new Size(1235, 573);
            dgvAllUsers.TabIndex = 0;
            // 
            // gbUserListActions
            // 
            gbUserListActions.Controls.Add(btnAddUser);
            gbUserListActions.Controls.Add(btnEditUser);
            gbUserListActions.Controls.Add(btnDeleteUser);
            gbUserListActions.Controls.Add(btnRefreshAllUsers);
            gbUserListActions.Dock = DockStyle.Fill;
            gbUserListActions.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            gbUserListActions.Location = new Point(0, 0);
            gbUserListActions.Name = "gbUserListActions";
            gbUserListActions.Size = new Size(1235, 120);
            gbUserListActions.TabIndex = 0;
            gbUserListActions.TabStop = false;
            gbUserListActions.Text = "User Management";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(46, 204, 113);
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(20, 44);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(140, 44);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "+ Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.FromArgb(243, 156, 18);
            btnEditUser.FlatStyle = FlatStyle.Flat;
            btnEditUser.ForeColor = Color.White;
            btnEditUser.Location = new Point(180, 44);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(140, 44);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(340, 44);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(140, 44);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnRefreshAllUsers
            // 
            btnRefreshAllUsers.BackColor = Color.FromArgb(52, 152, 219);
            btnRefreshAllUsers.FlatStyle = FlatStyle.Flat;
            btnRefreshAllUsers.ForeColor = Color.White;
            btnRefreshAllUsers.Location = new Point(812, 44);
            btnRefreshAllUsers.Name = "btnRefreshAllUsers";
            btnRefreshAllUsers.Size = new Size(140, 44);
            btnRefreshAllUsers.TabIndex = 3;
            btnRefreshAllUsers.Text = "Refresh";
            btnRefreshAllUsers.UseVisualStyleBackColor = false;
            // 
            // tpSettings
            // 
            tpSettings.Controls.Add(btnSaveSettings);
            tpSettings.Controls.Add(txtSystemName);
            tpSettings.Controls.Add(lblSystemName);
            tpSettings.Location = new Point(4, 44);
            tpSettings.Name = "tpSettings";
            tpSettings.Size = new Size(992, 727);
            tpSettings.TabIndex = 2;
            tpSettings.Text = "System Settings";
            tpSettings.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.BackColor = Color.FromArgb(52, 152, 219);
            btnSaveSettings.FlatStyle = FlatStyle.Flat;
            btnSaveSettings.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSaveSettings.ForeColor = Color.White;
            btnSaveSettings.Location = new Point(30, 138);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(200, 56);
            btnSaveSettings.TabIndex = 2;
            btnSaveSettings.Text = "Save System Config";
            btnSaveSettings.UseVisualStyleBackColor = false;
            // 
            // txtSystemName
            // 
            txtSystemName.Font = new Font("Segoe UI", 11F);
            txtSystemName.Location = new Point(30, 75);
            txtSystemName.Name = "txtSystemName";
            txtSystemName.Size = new Size(400, 32);
            txtSystemName.TabIndex = 1;
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSystemName.Location = new Point(26, 42);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(120, 23);
            lblSystemName.TabIndex = 0;
            lblSystemName.Text = "System Name:";
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tcAdmin);
            Controls.Add(pnlHeader);
            Name = "AdminView";
            Size = new Size(1263, 875);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tcAdmin.ResumeLayout(false);
            tpPendingApprovals.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPendingUsers).EndInit();
            gbPendingListActions.ResumeLayout(false);
            gbApprovalStats.ResumeLayout(false);
            gbApprovalStats.PerformLayout();
            tpUserManagement.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllUsers).EndInit();
            gbUserListActions.ResumeLayout(false);
            tpSettings.ResumeLayout(false);
            tpSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpPendingApprovals;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPendingUsers;
        private System.Windows.Forms.GroupBox gbPendingListActions;
        private System.Windows.Forms.Button btnRefreshPending;
        private System.Windows.Forms.Button btnExportPending;
        private System.Windows.Forms.GroupBox gbApprovalStats;
        private System.Windows.Forms.Label lblDeclinedToday;
        private System.Windows.Forms.Label lblDeclinedTodayLabel;
        private System.Windows.Forms.Label lblApprovedToday;
        private System.Windows.Forms.Label lblApprovedTodayLabel;
        private System.Windows.Forms.Label lblTotalPending;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.TabPage tpUserManagement;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.GroupBox gbUserListActions;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnRefreshAllUsers;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TextBox txtSystemName;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestedDate;
        private System.Windows.Forms.DataGridViewButtonColumn colApprove;
        private System.Windows.Forms.DataGridViewButtonColumn colDecline;
    }
}