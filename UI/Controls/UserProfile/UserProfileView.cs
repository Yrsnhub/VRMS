using System;
using System.Drawing;
using System.Windows.Forms;

namespace VRMS.Controls.UserProfile
{
    public partial class UserProfileView : UserControl
    {
        // For rounded corners - you can remove if not needed
        private const int BorderRadius = 10;

        public UserProfileView()
        {
            InitializeComponent();
            SetupView();
            LoadUserData();
        }

        private void SetupView()
        {
            // Set initial values and styling
            txtUsername.BackColor = Color.FromArgb(245, 245, 245);
            txtUsername.ForeColor = Color.FromArgb(100, 100, 100);

            // Add placeholder text hints
            AddPlaceholder(txtFullName, "Enter your full name");
            AddPlaceholder(txtEmail, "example@email.com");
            AddPlaceholder(txtPhone, "+1234567890");

            // Subscribe to events
            btnSave.Click += BtnSave_Click;
            btnChangePassword.Click += BtnChangePassword_Click;

            // Text change validation
            txtFullName.TextChanged += ValidateFields;
            txtEmail.TextChanged += ValidateFields;
            txtPhone.TextChanged += ValidateFields;
        }

        private void LoadUserData()
        {
            // TODO: Replace with actual database/user service calls
            // For now, use dummy data
            var currentUser = GetCurrentUser(); // Replace with your user retrieval logic

            lblProfileName.Text = currentUser.FullName;
            lblProfileRole.Text = currentUser.Role;
            txtUsername.Text = currentUser.Username;
            txtFullName.Text = currentUser.FullName;
            txtEmail.Text = currentUser.Email;
            txtPhone.Text = currentUser.Phone;

            // Load profile picture if available
            if (!string.IsNullOrEmpty(currentUser.ProfileImagePath))
            {
                // Load image from path
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    // Update user profile
                    var userData = new
                    {
                        FullName = txtFullName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Phone = txtPhone.Text.Trim()
                    };

                    // TODO: Save to database
                    // await UserService.UpdateProfileAsync(userData);

                    MessageBox.Show("Profile updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update display name
                    lblProfileName.Text = userData.FullName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving profile: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (ValidatePasswordFields())
            {
                try
                {
                    var passwordData = new
                    {
                        CurrentPassword = txtCurrentPassword.Text,
                        NewPassword = txtNewPassword.Text
                    };

                    // TODO: Call password change service
                    // await UserService.ChangePasswordAsync(passwordData);

                    MessageBox.Show("Password changed successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear password fields
                    ClearPasswordFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error changing password: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full name is required", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool ValidatePasswordFields()
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                MessageBox.Show("Current password is required", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("New password is required", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return false;
            }

            if (txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return false;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("New password and confirmation do not match", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void ValidateFields(object sender, EventArgs e)
        {
            bool hasChanges = HasProfileChanges();
            btnSave.Enabled = hasChanges;
            btnSave.BackColor = hasChanges ? Color.FromArgb(46, 204, 113) : Color.FromArgb(189, 195, 199);
        }

        private bool HasProfileChanges()
        {
            // TODO: Compare with original values
            return !string.IsNullOrWhiteSpace(txtFullName.Text) ||
                   !string.IsNullOrWhiteSpace(txtEmail.Text) ||
                   !string.IsNullOrWhiteSpace(txtPhone.Text);
        }

        private void ClearPasswordFields()
        {
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };

            // Set initial
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        // Dummy user class for development - replace with your actual User class
        private class DummyUser
        {
            public string Username { get; set; } = "john.doe";
            public string FullName { get; set; } = "John Doe";
            public string Email { get; set; } = "john.doe@example.com";
            public string Phone { get; set; } = "+1234567890";
            public string Role { get; set; } = "Administrator";
            public string ProfileImagePath { get; set; } = "";
        }

        private DummyUser GetCurrentUser()
        {
            // TODO: Replace with actual user retrieval
            return new DummyUser();
        }
    }
}