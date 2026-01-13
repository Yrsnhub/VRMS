using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Models.Accounts;
using VRMS.Repositories.Accounts;
using VRMS.Services.Account;

namespace VRMS.Controls
{
    public partial class AdminView : UserControl
    {
        private readonly UserService _userService;
        private CheckBox chkShowInactive;
        private ComboBox cmbRoleFilter;

        public AdminView()
            : this(new UserService(new UserRepository()))
        {
        }

        public AdminView(UserService userService)
        {
            InitializeComponent();
            SetupGrids();

            _userService = userService
                            ?? throw new ArgumentNullException(nameof(userService));

            AddUserFilters();
            WireEvents();
        }

        private void SetupGrids()
        {
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.Columns.Clear();

            // ID Column - Fixed Width
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = nameof(User.Id),
                Width = 60
            });

            // Username - Stretches to fill space
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Username",
                DataPropertyName = nameof(User.Username),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 40
            });

            // Full Name - Stretches to fill space
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Full Name",
                DataPropertyName = nameof(User.FullName),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 60
            });

            // Role - Fixed Width
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Role",
                DataPropertyName = nameof(User.Role),
                Width = 120
            });

            // Active - Fixed Width
            dgvUsers.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Active",
                DataPropertyName = nameof(User.IsActive),
                Width = 60
            });
        }

        private void AddUserFilters()
        {
            chkShowInactive = new CheckBox
            {
                Text = "Show inactive users",
                Location = new Point(520, 25),
                AutoSize = true
            };

            cmbRoleFilter = new ComboBox
            {
                Location = new Point(720, 22),
                Width = 180,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cmbRoleFilter.Items.Add("All");
            cmbRoleFilter.Items.AddRange(Enum.GetNames(typeof(UserRole)));
            cmbRoleFilter.SelectedIndex = 0;

            tpUsers.Controls.Add(chkShowInactive);
            tpUsers.Controls.Add(cmbRoleFilter);
        }

        private void WireEvents()
        {
            Load += (_, __) => ReloadUsers();
            chkShowInactive.CheckedChanged += (_, __) => ReloadUsers();
            cmbRoleFilter.SelectedIndexChanged += (_, __) => ReloadUsers();
            btnAddUser.Click += btnAddUser_Click;
            btnEditUser.Click += btnEditUser_Click;
            btnDeleteUser.Click += btnDeleteUser_Click;
            btnRefresh.Click += (_, __) => ReloadUsers();
        }

        private void ReloadUsers()
        {
            IEnumerable<User> users = chkShowInactive.Checked
                ? _userService.ListUsers()
                : _userService.ListActiveUsers();

            if (cmbRoleFilter.SelectedItem is string roleText && roleText != "All")
            {
                var role = Enum.Parse<UserRole>(roleText);
                users = users.Where(u => u.Role == role);
            }

            dgvUsers.DataSource = users.ToList();
        }

        private void btnAddUser_Click(object sender, EventArgs e) => MessageBox.Show("Add User wiring is next.");
        private void btnEditUser_Click(object sender, EventArgs e) => MessageBox.Show("Edit User wiring is next.");

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow?.DataBoundItem is not User user) return;
            if (MessageBox.Show($"Deactivate '{user.Username}'?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _userService.Deactivate(user.Id);
                ReloadUsers();
            }
        }

        // FIXED: Replaced invalid AutoResizeColumns(Fill) call
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                if (dgvUsers != null && !dgvUsers.IsDisposed)
                {
                    // Forcing a layout update allows 'Fill' columns to adjust automatically
                    dgvUsers.PerformLayout();
                    dgvUsers.Refresh();
                }
            });
        }
    }
}