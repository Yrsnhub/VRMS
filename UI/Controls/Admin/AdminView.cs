using System;
using System.Drawing;
using System.Windows.Forms;
using VRMS.Services.Account;
using VRMS.UI.ApplicationService;

namespace VRMS.Controls
{
    public partial class AdminView : UserControl
    {
        private readonly UserService _userService;
        private CheckBox chkShowInactive;
        private ComboBox cmbRoleFilter;

        // DEFAULT ctor — production usage
        public AdminView()
            : this(ApplicationServices.UserService)
        {
        }

        // OPTIONAL ctor — unit testing / isolation
        internal AdminView(UserService userService)
        {
            _userService = userService
                ?? throw new ArgumentNullException(nameof(userService));

            InitializeComponent();
            SetupGrids();
            AddUserFilters();
            WireEvents();
            LoadStats();
        }

        private void SetupGrids()
        {
            // Setup Pending Users Grid
            dgvPendingUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvPendingUsers.AutoGenerateColumns = false;

            // Clear existing columns if any
            dgvPendingUsers.Columns.Clear();

            // Setup All Users Grid
            dgvAllUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvAllUsers.AutoGenerateColumns = false;

            // Configure All Users grid columns
            dgvAllUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 60
            });

            dgvAllUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Username",
                DataPropertyName = "Username",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 40
            });

            dgvAllUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Full Name",
                DataPropertyName = "FullName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 60
            });

            dgvAllUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 50
            });

            dgvAllUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Role",
                DataPropertyName = "Role",
                Width = 120
            });

            dgvAllUsers.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Active",
                DataPropertyName = "IsActive",
                Width = 60
            });
        }

        private void AddUserFilters()
        {
            // Add filters for All Users tab
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

            cmbRoleFilter.Items.Add("All Roles");
            cmbRoleFilter.Items.Add("Administrator");
            cmbRoleFilter.Items.Add("Manager");
            cmbRoleFilter.Items.Add("User");
            cmbRoleFilter.Items.Add("Viewer");
            cmbRoleFilter.SelectedIndex = 0;

            tpUserManagement.Controls.Add(chkShowInactive);
            tpUserManagement.Controls.Add(cmbRoleFilter);
        }

        private void WireEvents()
        {
            Load += (_, __) =>
            {
                // Sample data for UI testing
                LoadSampleData();
            };

            // Pending Users events
            btnRefreshPending.Click += (_, __) => LoadSamplePendingData();
            btnExportPending.Click += (_, __) => MessageBox.Show("Export functionality will be implemented later.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // All Users events
            chkShowInactive.CheckedChanged += (_, __) => LoadSampleAllUsersData();
            cmbRoleFilter.SelectedIndexChanged += (_, __) => LoadSampleAllUsersData();
            btnAddUser.Click += (_, __) => MessageBox.Show("Add User functionality will be implemented later.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnEditUser.Click += (_, __) => MessageBox.Show("Edit User functionality will be implemented later.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDeleteUser.Click += (_, __) => MessageBox.Show("Delete User functionality will be implemented later.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefreshAllUsers.Click += (_, __) => LoadSampleAllUsersData();

            // Grid events - for approve/decline buttons
            dgvPendingUsers.CellContentClick += dgvPendingUsers_CellContentClick;
        }

        private void LoadStats()
        {
            // Sample statistics for UI testing
            lblTotalPending.Text = "12";
            lblApprovedToday.Text = "5";
            lblDeclinedToday.Text = "2";
        }

        private void LoadSampleData()
        {
            LoadSamplePendingData();
            LoadSampleAllUsersData();
            LoadStats();
        }

        private void LoadSamplePendingData()
        {
            // Create sample data for pending users grid
            var sampleData = new[]
            {
                new { Username = "john.doe", FullName = "John Doe", Email = "john.doe@example.com", RequestedDate = "2024-01-15 09:30:00" },
                new { Username = "jane.smith", FullName = "Jane Smith", Email = "jane.smith@example.com", RequestedDate = "2024-01-15 10:15:00" },
                new { Username = "bob.johnson", FullName = "Bob Johnson", Email = "bob.j@example.com", RequestedDate = "2024-01-14 14:20:00" },
                new { Username = "alice.williams", FullName = "Alice Williams", Email = "alice.w@example.com", RequestedDate = "2024-01-14 16:45:00" },
                new { Username = "charlie.brown", FullName = "Charlie Brown", Email = "charlie.b@example.com", RequestedDate = "2024-01-13 11:10:00" }
            };

            dgvPendingUsers.DataSource = sampleData;
        }

        private void LoadSampleAllUsersData()
        {
            // Create sample data for all users grid
            var sampleData = new[]
            {
                new { Id = 1, Username = "admin", FullName = "System Administrator", Email = "admin@system.com", Role = "Administrator", IsActive = true },
                new { Id = 2, Username = "manager1", FullName = "Project Manager", Email = "manager@company.com", Role = "Manager", IsActive = true },
                new { Id = 3, Username = "user1", FullName = "Regular User", Email = "user@company.com", Role = "User", IsActive = true },
                new { Id = 4, Username = "inactive1", FullName = "Inactive User", Email = "inactive@company.com", Role = "Viewer", IsActive = false },
                new { Id = 5, Username = "viewer1", FullName = "Data Viewer", Email = "viewer@company.com", Role = "Viewer", IsActive = true }
            };

            dgvAllUsers.DataSource = sampleData;
        }

        private void dgvPendingUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if click is on a button column
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var grid = sender as DataGridView;
            var column = grid?.Columns[e.ColumnIndex];

            if (column is DataGridViewButtonColumn && grid?.Rows[e.RowIndex].DataBoundItem is object user)
            {
                // Get username from the row data
                var username = grid.Rows[e.RowIndex].Cells["colUsername"].Value?.ToString() ?? "Unknown";

                if (column.Name == "colApprove")
                {
                    if (MessageBox.Show(
                        $"Approve user '{username}'?",
                        "Confirm Approval",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show($"User '{username}' approved (UI only - no backend).",
                            "UI Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // In real implementation, remove from grid or update status
                    }
                }
                else if (column.Name == "colDecline")
                {
                    if (MessageBox.Show(
                        $"Decline user '{username}'?",
                        "Confirm Decline",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        MessageBox.Show($"User '{username}' declined (UI only - no backend).",
                            "UI Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // In real implementation, remove from grid or update status
                    }
                }
            }
        }

        private void btnRefreshPending_Click(object sender, EventArgs e)
        {
            // This is already wired in WireEvents(), but keep as separate method if needed
            LoadSamplePendingData();
        }

        private void btnRefreshAllUsers_Click(object sender, EventArgs e)
        {
            // This is already wired in WireEvents(), but keep as separate method if needed
            LoadSampleAllUsersData();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Already wired in WireEvents()
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            // Already wired in WireEvents()
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Already wired in WireEvents()
        }
    }
}