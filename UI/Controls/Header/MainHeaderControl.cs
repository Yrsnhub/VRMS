using System;
using System.Drawing;
using System.Windows.Forms;

namespace VRMS.Controls
{
    public partial class MainHeaderControl : UserControl
    {
        public event EventHandler UserInfoClicked;
        private Color originalUserInfoColor;
        private Font originalUserInfoFont;

        public MainHeaderControl()
        {
            InitializeComponent();

            // Save original styling
            originalUserInfoColor = lblUserInfo.ForeColor;
            originalUserInfoFont = lblUserInfo.Font;

            // Initialize
            SetTitle("Dashboard", "Overview and Key Metrics");
            lblUserInfo.Text = "Loading...";

            // Make user info clickable
            lblUserInfo.Click += (s, e) => OnUserInfoClicked();

            // Add hover effects
            lblUserInfo.MouseEnter += (s, e) =>
            {
                lblUserInfo.ForeColor = Color.FromArgb(46, 204, 113); // Green hover color
                lblUserInfo.Font = new Font(lblUserInfo.Font, FontStyle.Underline | FontStyle.Bold);
            };

            lblUserInfo.MouseLeave += (s, e) =>
            {
                lblUserInfo.ForeColor = originalUserInfoColor;
                lblUserInfo.Font = originalUserInfoFont;
            };
        }

        /// <summary>
        /// Raises the UserInfoClicked event
        /// </summary>
        protected virtual void OnUserInfoClicked()
        {
            UserInfoClicked?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Sets the main page title and optional subtitle
        /// </summary>
        /// <param name="title">Main page title</param>
        /// <param name="subtitle">Optional descriptive subtitle</param>
        public void SetTitle(string title, string subtitle = "")
        {
            // Validate and set title
            if (lblPageTitle != null)
            {
                lblPageTitle.Text = string.IsNullOrEmpty(title) ? "Untitled" : title;
            }

            // Validate and set subtitle
            if (lblPageSubtitle != null)
            {
                if (string.IsNullOrEmpty(subtitle))
                {
                    // Hide subtitle if empty
                    lblPageSubtitle.Visible = false;
                }
                else
                {
                    lblPageSubtitle.Text = subtitle;
                    lblPageSubtitle.Visible = true;
                }
            }
        }

        /// <summary>
        /// Sets the user information displayed in the header
        /// </summary>
        /// <param name="username">Current user's name</param>
        /// <param name="role">Current user's role</param>
        public void SetUser(string username, string role)
        {
            if (lblUserInfo != null)
            {
                if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(role))
                {
                    lblUserInfo.Text = "Not logged in";
                }
                else if (string.IsNullOrEmpty(role))
                {
                    lblUserInfo.Text = username;
                }
                else if (string.IsNullOrEmpty(username))
                {
                    lblUserInfo.Text = $"({role})";
                }
                else
                {
                    lblUserInfo.Text = $"{username} ({role})";
                }

                // Save the current text to restore after hover
                originalUserInfoColor = lblUserInfo.ForeColor;
            }
        }

        /// <summary>
        /// Gets the current page title
        /// </summary>
        public string GetCurrentTitle()
        {
            return lblPageTitle?.Text ?? string.Empty;
        }

        /// <summary>
        /// Gets the current page subtitle
        /// </summary>
        public string GetCurrentSubtitle()
        {
            return lblPageSubtitle?.Text ?? string.Empty;
        }

        /// <summary>
        /// Gets the current user info
        /// </summary>
        public string GetCurrentUserInfo()
        {
            return lblUserInfo?.Text ?? string.Empty;
        }

        /// <summary>
        /// Clears all header information
        /// </summary>
        public void Clear()
        {
            SetTitle("", "");
            SetUser("", "");
        }

        /// <summary>
        /// Updates header with error state styling
        /// </summary>
        public void SetErrorState(string errorMessage)
        {
            if (lblPageTitle != null)
            {
                lblPageTitle.Text = "Error";
                lblPageTitle.ForeColor = Color.FromArgb(231, 76, 60); // Red color
            }

            if (lblPageSubtitle != null)
            {
                lblPageSubtitle.Text = errorMessage;
                lblPageSubtitle.ForeColor = Color.FromArgb(231, 76, 60);
                lblPageSubtitle.Visible = true;
            }
        }

        /// <summary>
        /// Resets header to normal state
        /// </summary>
        public void ResetState()
        {
            if (lblPageTitle != null)
            {
                lblPageTitle.ForeColor = Color.White;
            }

            if (lblPageSubtitle != null)
            {
                lblPageSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            }
        }
    }
}