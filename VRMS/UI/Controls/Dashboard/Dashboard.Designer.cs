namespace VRMS.Controls
{
    partial class DashboardView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblDashboardTitle = new Label();
            btnRefresh = new Button();
            dateRangePicker = new DateTimePicker();
            mainContainer = new Panel();
            leftPanel = new Panel();
            pnlCards = new FlowLayoutPanel();
            pnlCardTotal = new Panel();
            lblTotalTitle = new Label();
            lblTotalValue = new Label();
            pnlCardAvailable = new Panel();
            lblAvailableTitle = new Label();
            lblAvailableValue = new Label();
            pnlCardRented = new Panel();
            lblRentedTitle = new Label();
            lblRentedValue = new Label();
            pnlCardRevenue = new Panel();
            lblRevenueTitle = new Label();
            lblRevenueValue = new Label();
            pnlCardOverdue = new Panel();
            lblOverdueTitle = new Label();
            lblOverdueValue = new Label();
            pnlCardMaintenance = new Panel();
            lblMaintenanceTitle = new Label();
            lblMaintenanceValue = new Label();
            pnlChartArea = new Panel();
            lblChartTitle = new Label();
            rightPanel = new Panel();
            splitRight = new SplitContainer();
            pnlTodaySchedule = new Panel();
            lblTodayScheduleTitle = new Label();
            dgvTodaySchedule = new DataGridView();
            pnlAlerts = new Panel();
            lblAlertsTitle = new Label();
            dgvAlerts = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlHeader.SuspendLayout();
            mainContainer.SuspendLayout();
            leftPanel.SuspendLayout();
            pnlCards.SuspendLayout();
            pnlCardTotal.SuspendLayout();
            pnlCardAvailable.SuspendLayout();
            pnlCardRented.SuspendLayout();
            pnlCardRevenue.SuspendLayout();
            pnlCardOverdue.SuspendLayout();
            pnlCardMaintenance.SuspendLayout();
            pnlChartArea.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitRight).BeginInit();
            splitRight.Panel1.SuspendLayout();
            splitRight.Panel2.SuspendLayout();
            splitRight.SuspendLayout();
            pnlTodaySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodaySchedule).BeginInit();
            pnlAlerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlerts).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(dateRangePicker);
            pnlHeader.Controls.Add(btnRefresh);
            pnlHeader.Controls.Add(lblDashboardTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(12);
            pnlHeader.Size = new Size(1050, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDashboardTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblDashboardTitle.Location = new Point(12, 12);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(188, 32);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "VRMS Dashboard";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(820, 12);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 32);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dateRangePicker
            // 
            dateRangePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateRangePicker.Font = new Font("Segoe UI", 9F);
            dateRangePicker.Format = DateTimePickerFormat.Short;
            dateRangePicker.Location = new Point(690, 16);
            dateRangePicker.Margin = new Padding(3, 2, 3, 2);
            dateRangePicker.Name = "dateRangePicker";
            dateRangePicker.Size = new Size(124, 23);
            dateRangePicker.TabIndex = 2;
            // 
            // mainContainer
            // 
            mainContainer.Controls.Add(rightPanel);
            mainContainer.Controls.Add(leftPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 60);
            mainContainer.Margin = new Padding(3, 2, 3, 2);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(10);
            mainContainer.Size = new Size(1050, 620);
            mainContainer.TabIndex = 1;
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            leftPanel.Controls.Add(pnlChartArea);
            leftPanel.Controls.Add(pnlCards);
            leftPanel.Location = new Point(10, 10);
            leftPanel.Margin = new Padding(3, 2, 3, 2);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(680, 600);
            leftPanel.TabIndex = 0;
            // 
            // pnlCards
            // 
            pnlCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCards.BackColor = Color.Transparent;
            pnlCards.Controls.Add(pnlCardTotal);
            pnlCards.Controls.Add(pnlCardAvailable);
            pnlCards.Controls.Add(pnlCardRented);
            pnlCards.Controls.Add(pnlCardRevenue);
            pnlCards.Controls.Add(pnlCardOverdue);
            pnlCards.Controls.Add(pnlCardMaintenance);
            pnlCards.Location = new Point(0, 0);
            pnlCards.Margin = new Padding(3, 2, 3, 2);
            pnlCards.Name = "pnlCards";
            pnlCards.Padding = new Padding(8, 10, 8, 10);
            pnlCards.Size = new Size(680, 160);
            pnlCards.TabIndex = 0;
            // 
            // pnlCardTotal
            // 
            pnlCardTotal.BackColor = Color.FromArgb(52, 73, 94);
            pnlCardTotal.Controls.Add(lblTotalTitle);
            pnlCardTotal.Controls.Add(lblTotalValue);
            pnlCardTotal.Cursor = Cursors.Hand;
            pnlCardTotal.ForeColor = Color.White;
            pnlCardTotal.Location = new Point(11, 12);
            pnlCardTotal.Margin = new Padding(7);
            pnlCardTotal.Name = "pnlCardTotal";
            pnlCardTotal.Padding = new Padding(10);
            pnlCardTotal.Size = new Size(130, 136);
            pnlCardTotal.TabIndex = 0;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTotalTitle.ForeColor = Color.Gainsboro;
            lblTotalTitle.Location = new Point(10, 10);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(74, 19);
            lblTotalTitle.TabIndex = 1;
            lblTotalTitle.Text = "Total Fleet";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalValue.Location = new Point(10, 50);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(44, 51);
            lblTotalValue.TabIndex = 0;
            lblTotalValue.Text = "0";
            lblTotalValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCardAvailable
            // 
            pnlCardAvailable.BackColor = Color.FromArgb(39, 174, 96);
            pnlCardAvailable.Controls.Add(lblAvailableTitle);
            pnlCardAvailable.Controls.Add(lblAvailableValue);
            pnlCardAvailable.Cursor = Cursors.Hand;
            pnlCardAvailable.ForeColor = Color.White;
            pnlCardAvailable.Location = new Point(155, 12);
            pnlCardAvailable.Margin = new Padding(7);
            pnlCardAvailable.Name = "pnlCardAvailable";
            pnlCardAvailable.Padding = new Padding(10);
            pnlCardAvailable.Size = new Size(130, 136);
            pnlCardAvailable.TabIndex = 1;
            // 
            // lblAvailableTitle
            // 
            lblAvailableTitle.AutoSize = true;
            lblAvailableTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAvailableTitle.ForeColor = Color.Gainsboro;
            lblAvailableTitle.Location = new Point(10, 10);
            lblAvailableTitle.Name = "lblAvailableTitle";
            lblAvailableTitle.Size = new Size(115, 19);
            lblAvailableTitle.TabIndex = 1;
            lblAvailableTitle.Text = "Vehicle Available";
            // 
            // lblAvailableValue
            // 
            lblAvailableValue.AutoSize = true;
            lblAvailableValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblAvailableValue.Location = new Point(10, 50);
            lblAvailableValue.Name = "lblAvailableValue";
            lblAvailableValue.Size = new Size(44, 51);
            lblAvailableValue.TabIndex = 0;
            lblAvailableValue.Text = "0";
            lblAvailableValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCardRented
            // 
            pnlCardRented.BackColor = Color.FromArgb(41, 128, 185);
            pnlCardRented.Controls.Add(lblRentedTitle);
            pnlCardRented.Controls.Add(lblRentedValue);
            pnlCardRented.Cursor = Cursors.Hand;
            pnlCardRented.ForeColor = Color.White;
            pnlCardRented.Location = new Point(299, 12);
            pnlCardRented.Margin = new Padding(7);
            pnlCardRented.Name = "pnlCardRented";
            pnlCardRented.Padding = new Padding(10);
            pnlCardRented.Size = new Size(130, 136);
            pnlCardRented.TabIndex = 2;
            // 
            // lblRentedTitle
            // 
            lblRentedTitle.AutoSize = true;
            lblRentedTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblRentedTitle.ForeColor = Color.Gainsboro;
            lblRentedTitle.Location = new Point(10, 10);
            lblRentedTitle.Name = "lblRentedTitle";
            lblRentedTitle.Size = new Size(87, 19);
            lblRentedTitle.TabIndex = 1;
            lblRentedTitle.Text = "Active Rents";
            // 
            // lblRentedValue
            // 
            lblRentedValue.AutoSize = true;
            lblRentedValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblRentedValue.Location = new Point(10, 50);
            lblRentedValue.Name = "lblRentedValue";
            lblRentedValue.Size = new Size(44, 51);
            lblRentedValue.TabIndex = 0;
            lblRentedValue.Text = "0";
            lblRentedValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCardRevenue
            // 
            pnlCardRevenue.BackColor = Color.FromArgb(142, 68, 173);
            pnlCardRevenue.Controls.Add(lblRevenueTitle);
            pnlCardRevenue.Controls.Add(lblRevenueValue);
            pnlCardRevenue.Cursor = Cursors.Hand;
            pnlCardRevenue.ForeColor = Color.White;
            pnlCardRevenue.Location = new Point(443, 12);
            pnlCardRevenue.Margin = new Padding(7);
            pnlCardRevenue.Name = "pnlCardRevenue";
            pnlCardRevenue.Padding = new Padding(10);
            pnlCardRevenue.Size = new Size(140, 136);
            pnlCardRevenue.TabIndex = 3;
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblRevenueTitle.ForeColor = Color.Gainsboro;
            lblRevenueTitle.Location = new Point(10, 10);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(118, 19);
            lblRevenueTitle.TabIndex = 1;
            lblRevenueTitle.Text = "Revenue (Month)";
            // 
            // lblRevenueValue
            // 
            lblRevenueValue.AutoSize = true;
            lblRevenueValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblRevenueValue.Location = new Point(10, 58);
            lblRevenueValue.Name = "lblRevenueValue";
            lblRevenueValue.Size = new Size(53, 41);
            lblRevenueValue.TabIndex = 0;
            lblRevenueValue.Text = "₱0";
            lblRevenueValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCardOverdue
            // 
            pnlCardOverdue.BackColor = Color.FromArgb(192, 57, 43);
            pnlCardOverdue.Controls.Add(lblOverdueTitle);
            pnlCardOverdue.Controls.Add(lblOverdueValue);
            pnlCardOverdue.Cursor = Cursors.Hand;
            pnlCardOverdue.ForeColor = Color.White;
            pnlCardOverdue.Location = new Point(597, 12);
            pnlCardOverdue.Margin = new Padding(7);
            pnlCardOverdue.Name = "pnlCardOverdue";
            pnlCardOverdue.Padding = new Padding(10);
            pnlCardOverdue.Size = new Size(130, 136);
            pnlCardOverdue.TabIndex = 4;
            // 
            // lblOverdueTitle
            // 
            lblOverdueTitle.AutoSize = true;
            lblOverdueTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblOverdueTitle.ForeColor = Color.Gainsboro;
            lblOverdueTitle.Location = new Point(10, 10);
            lblOverdueTitle.Name = "lblOverdueTitle";
            lblOverdueTitle.Size = new Size(62, 19);
            lblOverdueTitle.TabIndex = 1;
            lblOverdueTitle.Text = "Overdue";
            // 
            // lblOverdueValue
            // 
            lblOverdueValue.AutoSize = true;
            lblOverdueValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblOverdueValue.Location = new Point(10, 50);
            lblOverdueValue.Name = "lblOverdueValue";
            lblOverdueValue.Size = new Size(68, 51);
            lblOverdueValue.TabIndex = 0;
            lblOverdueValue.Text = "₱0";
            lblOverdueValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCardMaintenance
            // 
            pnlCardMaintenance.BackColor = Color.FromArgb(230, 126, 34);
            pnlCardMaintenance.Controls.Add(lblMaintenanceTitle);
            pnlCardMaintenance.Controls.Add(lblMaintenanceValue);
            pnlCardMaintenance.Cursor = Cursors.Hand;
            pnlCardMaintenance.ForeColor = Color.White;
            pnlCardMaintenance.Location = new Point(11, 158);
            pnlCardMaintenance.Margin = new Padding(7);
            pnlCardMaintenance.Name = "pnlCardMaintenance";
            pnlCardMaintenance.Padding = new Padding(10);
            pnlCardMaintenance.Size = new Size(130, 136);
            pnlCardMaintenance.TabIndex = 5;
            // 
            // lblMaintenanceTitle
            // 
            lblMaintenanceTitle.AutoSize = true;
            lblMaintenanceTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMaintenanceTitle.ForeColor = Color.Gainsboro;
            lblMaintenanceTitle.Location = new Point(10, 10);
            lblMaintenanceTitle.Name = "lblMaintenanceTitle";
            lblMaintenanceTitle.Size = new Size(128, 19);
            lblMaintenanceTitle.TabIndex = 1;
            lblMaintenanceTitle.Text = "Under Maintenance";
            // 
            // lblMaintenanceValue
            // 
            lblMaintenanceValue.AutoSize = true;
            lblMaintenanceValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblMaintenanceValue.Location = new Point(10, 50);
            lblMaintenanceValue.Name = "lblMaintenanceValue";
            lblMaintenanceValue.Size = new Size(44, 51);
            lblMaintenanceValue.TabIndex = 0;
            lblMaintenanceValue.Text = "0";
            lblMaintenanceValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlChartArea
            // 
            pnlChartArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChartArea.BackColor = Color.White;
            pnlChartArea.Controls.Add(lblChartTitle);
            pnlChartArea.Location = new Point(0, 160);
            pnlChartArea.Margin = new Padding(3, 2, 3, 2);
            pnlChartArea.Name = "pnlChartArea";
            pnlChartArea.Padding = new Padding(10);
            pnlChartArea.Size = new Size(680, 440);
            pnlChartArea.TabIndex = 1;
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.Dock = DockStyle.Top;
            lblChartTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblChartTitle.Location = new Point(10, 10);
            lblChartTitle.Margin = new Padding(3, 0, 3, 9);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Padding = new Padding(0, 0, 0, 7);
            lblChartTitle.Size = new Size(234, 28);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "📊 Fleet Performance Trends";
            // 
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rightPanel.Controls.Add(splitRight);
            rightPanel.Location = new Point(695, 10);
            rightPanel.Margin = new Padding(3, 2, 3, 2);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(345, 600);
            rightPanel.TabIndex = 1;
            // 
            // splitRight
            // 
            splitRight.Dock = DockStyle.Fill;
            splitRight.Location = new Point(0, 0);
            splitRight.Margin = new Padding(3, 2, 3, 2);
            splitRight.Name = "splitRight";
            splitRight.Orientation = Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            splitRight.Panel1.Controls.Add(pnlTodaySchedule);
            // 
            // splitRight.Panel2
            // 
            splitRight.Panel2.Controls.Add(pnlAlerts);
            splitRight.Size = new Size(345, 600);
            splitRight.SplitterDistance = 300;
            splitRight.SplitterWidth = 10;
            splitRight.TabIndex = 0;
            // 
            // pnlTodaySchedule
            // 
            pnlTodaySchedule.BackColor = Color.White;
            pnlTodaySchedule.Controls.Add(lblTodayScheduleTitle);
            pnlTodaySchedule.Controls.Add(dgvTodaySchedule);
            pnlTodaySchedule.Dock = DockStyle.Fill;
            pnlTodaySchedule.Location = new Point(0, 0);
            pnlTodaySchedule.Margin = new Padding(3, 2, 3, 2);
            pnlTodaySchedule.Name = "pnlTodaySchedule";
            pnlTodaySchedule.Padding = new Padding(10);
            pnlTodaySchedule.Size = new Size(345, 300);
            pnlTodaySchedule.TabIndex = 0;
            // 
            // lblTodayScheduleTitle
            // 
            lblTodayScheduleTitle.AutoSize = true;
            lblTodayScheduleTitle.Dock = DockStyle.Top;
            lblTodayScheduleTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTodayScheduleTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblTodayScheduleTitle.Location = new Point(10, 10);
            lblTodayScheduleTitle.Margin = new Padding(3, 0, 3, 9);
            lblTodayScheduleTitle.Name = "lblTodayScheduleTitle";
            lblTodayScheduleTitle.Padding = new Padding(0, 0, 0, 5);
            lblTodayScheduleTitle.Size = new Size(198, 25);
            lblTodayScheduleTitle.TabIndex = 1;
            lblTodayScheduleTitle.Text = "📅 Today's Pickups/Returns";
            // 
            // dgvTodaySchedule
            // 
            dgvTodaySchedule.AllowUserToAddRows = false;
            dgvTodaySchedule.AllowUserToResizeRows = false;
            dgvTodaySchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodaySchedule.BackgroundColor = Color.White;
            dgvTodaySchedule.BorderStyle = BorderStyle.None;
            dgvTodaySchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTodaySchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTodaySchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTodaySchedule.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTodaySchedule.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTodaySchedule.Dock = DockStyle.Fill;
            dgvTodaySchedule.EnableHeadersVisualStyles = false;
            dgvTodaySchedule.GridColor = Color.WhiteSmoke;
            dgvTodaySchedule.Location = new Point(10, 35);
            dgvTodaySchedule.Margin = new Padding(3, 2, 3, 2);
            dgvTodaySchedule.Name = "dgvTodaySchedule";
            dgvTodaySchedule.ReadOnly = true;
            dgvTodaySchedule.RowHeadersVisible = false;
            dgvTodaySchedule.RowHeadersWidth = 51;
            dgvTodaySchedule.RowTemplate.Height = 28;
            dgvTodaySchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTodaySchedule.Size = new Size(325, 255);
            dgvTodaySchedule.TabIndex = 0;
            // 
            // pnlAlerts
            // 
            pnlAlerts.BackColor = Color.White;
            pnlAlerts.Controls.Add(lblAlertsTitle);
            pnlAlerts.Controls.Add(dgvAlerts);
            pnlAlerts.Dock = DockStyle.Fill;
            pnlAlerts.Location = new Point(0, 0);
            pnlAlerts.Margin = new Padding(3, 2, 3, 2);
            pnlAlerts.Name = "pnlAlerts";
            pnlAlerts.Padding = new Padding(10);
            pnlAlerts.Size = new Size(345, 290);
            pnlAlerts.TabIndex = 0;
            // 
            // lblAlertsTitle
            // 
            lblAlertsTitle.AutoSize = true;
            lblAlertsTitle.Dock = DockStyle.Top;
            lblAlertsTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAlertsTitle.ForeColor = Color.FromArgb(192, 57, 43);
            lblAlertsTitle.Location = new Point(10, 10);
            lblAlertsTitle.Margin = new Padding(3, 0, 3, 9);
            lblAlertsTitle.Name = "lblAlertsTitle";
            lblAlertsTitle.Padding = new Padding(0, 0, 0, 5);
            lblAlertsTitle.Size = new Size(79, 25);
            lblAlertsTitle.TabIndex = 2;
            lblAlertsTitle.Text = "⚠️ Alerts";
            // 
            // dgvAlerts
            // 
            dgvAlerts.AllowUserToAddRows = false;
            dgvAlerts.AllowUserToResizeRows = false;
            dgvAlerts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlerts.BackgroundColor = Color.White;
            dgvAlerts.BorderStyle = BorderStyle.None;
            dgvAlerts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAlerts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(231, 76, 60);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 76, 60);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAlerts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAlerts.ColumnHeadersHeight = 32;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAlerts.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAlerts.Dock = DockStyle.Fill;
            dgvAlerts.EnableHeadersVisualStyles = false;
            dgvAlerts.GridColor = Color.WhiteSmoke;
            dgvAlerts.Location = new Point(10, 35);
            dgvAlerts.Margin = new Padding(3, 2, 3, 2);
            dgvAlerts.Name = "dgvAlerts";
            dgvAlerts.ReadOnly = true;
            dgvAlerts.RowHeadersVisible = false;
            dgvAlerts.RowHeadersWidth = 51;
            dgvAlerts.RowTemplate.Height = 28;
            dgvAlerts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlerts.Size = new Size(325, 245);
            dgvAlerts.TabIndex = 0;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 244);
            Controls.Add(mainContainer);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1050, 680);
            Name = "DashboardView";
            Size = new Size(1050, 680);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            mainContainer.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            pnlCards.ResumeLayout(false);
            pnlCardTotal.ResumeLayout(false);
            pnlCardTotal.PerformLayout();
            pnlCardAvailable.ResumeLayout(false);
            pnlCardAvailable.PerformLayout();
            pnlCardRented.ResumeLayout(false);
            pnlCardRented.PerformLayout();
            pnlCardRevenue.ResumeLayout(false);
            pnlCardRevenue.PerformLayout();
            pnlCardOverdue.ResumeLayout(false);
            pnlCardOverdue.PerformLayout();
            pnlCardMaintenance.ResumeLayout(false);
            pnlCardMaintenance.PerformLayout();
            pnlChartArea.ResumeLayout(false);
            pnlChartArea.PerformLayout();
            rightPanel.ResumeLayout(false);
            splitRight.Panel1.ResumeLayout(false);
            splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitRight).EndInit();
            splitRight.ResumeLayout(false);
            pnlTodaySchedule.ResumeLayout(false);
            pnlTodaySchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodaySchedule).EndInit();
            pnlAlerts.ResumeLayout(false);
            pnlAlerts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlerts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dateRangePicker;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.FlowLayoutPanel pnlCards;
        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel pnlCardAvailable;
        private System.Windows.Forms.Label lblAvailableTitle;
        private System.Windows.Forms.Label lblAvailableValue;
        private System.Windows.Forms.Panel pnlCardRented;
        private System.Windows.Forms.Label lblRentedTitle;
        private System.Windows.Forms.Label lblRentedValue;
        private System.Windows.Forms.Panel pnlCardRevenue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Panel pnlCardOverdue;
        private System.Windows.Forms.Label lblOverdueTitle;
        private System.Windows.Forms.Label lblOverdueValue;
        private System.Windows.Forms.Panel pnlCardMaintenance;
        private System.Windows.Forms.Label lblMaintenanceTitle;
        private System.Windows.Forms.Label lblMaintenanceValue;
        private System.Windows.Forms.Panel pnlChartArea;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.Panel pnlTodaySchedule;
        private System.Windows.Forms.Label lblTodayScheduleTitle;
        private System.Windows.Forms.DataGridView dgvTodaySchedule;
        private System.Windows.Forms.Panel pnlAlerts;
        private System.Windows.Forms.Label lblAlertsTitle;
        private System.Windows.Forms.DataGridView dgvAlerts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}