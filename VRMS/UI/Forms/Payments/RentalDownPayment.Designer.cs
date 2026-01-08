namespace VRMS.Forms.Payments
{
    partial class RentalDownPayment
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpRentalSummary = new System.Windows.Forms.GroupBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.lblVehicleDetails = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.grpInitialCosts = new System.Windows.Forms.GroupBox();
            this.lblTotalInitialPayment = new System.Windows.Forms.Label();
            this.lblSecurityDeposit = new System.Windows.Forms.Label();
            this.lblFirstInstallment = new System.Windows.Forms.Label();
            this.grpPaymentProcessing = new System.Windows.Forms.GroupBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblLabelAmount = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblLabelMethod = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpRentalSummary.SuspendLayout();
            this.grpInitialCosts.SuspendLayout();
            this.grpPaymentProcessing.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(480, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(15, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(240, 30);
            this.lblHeader.Text = "Rental Down Payment";
            // 
            // grpRentalSummary
            // 
            this.grpRentalSummary.Controls.Add(this.lblReturnDate);
            this.grpRentalSummary.Controls.Add(this.lblRentalID);
            this.grpRentalSummary.Controls.Add(this.lblVehicleDetails);
            this.grpRentalSummary.Controls.Add(this.lblCustomerName);
            this.grpRentalSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpRentalSummary.Location = new System.Drawing.Point(20, 75);
            this.grpRentalSummary.Name = "grpRentalSummary";
            this.grpRentalSummary.Size = new System.Drawing.Size(440, 115);
            this.grpRentalSummary.TabIndex = 1;
            this.grpRentalSummary.TabStop = false;
            this.grpRentalSummary.Text = "Rental Details";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReturnDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblReturnDate.Location = new System.Drawing.Point(15, 88);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Text = "Return Date: --";
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRentalID.ForeColor = System.Drawing.Color.DimGray;
            this.lblRentalID.Location = new System.Drawing.Point(250, 25);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Text = "Rental ID: --";
            // 
            // lblVehicleDetails
            // 
            this.lblVehicleDetails.AutoSize = true;
            this.lblVehicleDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVehicleDetails.Location = new System.Drawing.Point(15, 60);
            this.lblVehicleDetails.Name = "lblVehicleDetails";
            this.lblVehicleDetails.Text = "Vehicle: --";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.Location = new System.Drawing.Point(15, 25);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Text = "Customer: --";
            // 
            // grpInitialCosts
            // 
            this.grpInitialCosts.Controls.Add(this.lblTotalInitialPayment);
            this.grpInitialCosts.Controls.Add(this.lblSecurityDeposit);
            this.grpInitialCosts.Controls.Add(this.lblFirstInstallment);
            this.grpInitialCosts.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpInitialCosts.Location = new System.Drawing.Point(20, 200);
            this.grpInitialCosts.Name = "grpInitialCosts";
            this.grpInitialCosts.Size = new System.Drawing.Size(440, 140);
            this.grpInitialCosts.TabIndex = 2;
            this.grpInitialCosts.TabStop = false;
            this.grpInitialCosts.Text = "Initial Payment Breakdown";
            // 
            // lblTotalInitialPayment
            // 
            this.lblTotalInitialPayment.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalInitialPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTotalInitialPayment.Location = new System.Drawing.Point(6, 90);
            this.lblTotalInitialPayment.Name = "lblTotalInitialPayment";
            this.lblTotalInitialPayment.Size = new System.Drawing.Size(428, 40);
            this.lblTotalInitialPayment.Text = "TOTAL DUE: ₱0.00";
            this.lblTotalInitialPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSecurityDeposit
            // 
            this.lblSecurityDeposit.AutoSize = true;
            this.lblSecurityDeposit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSecurityDeposit.Location = new System.Drawing.Point(15, 60);
            this.lblSecurityDeposit.Name = "lblSecurityDeposit";
            this.lblSecurityDeposit.Text = "Security Deposit: ₱0.00";
            // 
            // lblFirstInstallment
            // 
            this.lblFirstInstallment.AutoSize = true;
            this.lblFirstInstallment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFirstInstallment.Location = new System.Drawing.Point(15, 30);
            this.lblFirstInstallment.Name = "lblFirstInstallment";
            this.lblFirstInstallment.Text = "Initial Rental Fee: ₱0.00";
            // 
            // grpPaymentProcessing
            // 
            this.grpPaymentProcessing.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpPaymentProcessing.Controls.Add(this.txtAmountPaid);
            this.grpPaymentProcessing.Controls.Add(this.lblLabelAmount);
            this.grpPaymentProcessing.Controls.Add(this.cbPaymentMethod);
            this.grpPaymentProcessing.Controls.Add(this.lblLabelMethod);
            this.grpPaymentProcessing.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpPaymentProcessing.Location = new System.Drawing.Point(20, 355);
            this.grpPaymentProcessing.Name = "grpPaymentProcessing";
            this.grpPaymentProcessing.Size = new System.Drawing.Size(440, 115);
            this.grpPaymentProcessing.TabIndex = 3;
            this.grpPaymentProcessing.TabStop = false;
            this.grpPaymentProcessing.Text = "Payment Processing";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmountPaid.Location = new System.Drawing.Point(225, 60);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(185, 27);
            // 
            // lblLabelAmount
            // 
            this.lblLabelAmount.AutoSize = true;
            this.lblLabelAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLabelAmount.Location = new System.Drawing.Point(221, 40);
            this.lblLabelAmount.Name = "lblLabelAmount";
            this.lblLabelAmount.Text = "Amount Paid:";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Bank Transfer", "E-Wallet" });
            this.cbPaymentMethod.Location = new System.Drawing.Point(19, 60);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(185, 25);
            // 
            // lblLabelMethod
            // 
            this.lblLabelMethod.AutoSize = true;
            this.lblLabelMethod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLabelMethod.Location = new System.Drawing.Point(15, 40);
            this.lblLabelMethod.Name = "lblLabelMethod";
            this.lblLabelMethod.Text = "Payment Method:";
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(240, 485);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(220, 50);
            this.btnProcess.Text = "Confirm Payment";
            this.btnProcess.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCancel.Location = new System.Drawing.Point(20, 485);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 50);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // RentalDownPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 555);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.grpPaymentProcessing);
            this.Controls.Add(this.grpInitialCosts);
            this.Controls.Add(this.grpRentalSummary);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentalDownPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Upfront Rental Payment";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpRentalSummary.ResumeLayout(false);
            this.grpRentalSummary.PerformLayout();
            this.grpInitialCosts.ResumeLayout(false);
            this.grpInitialCosts.PerformLayout();
            this.grpPaymentProcessing.ResumeLayout(false);
            this.grpPaymentProcessing.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpRentalSummary;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.Label lblVehicleDetails;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.GroupBox grpInitialCosts;
        private System.Windows.Forms.Label lblTotalInitialPayment;
        private System.Windows.Forms.Label lblSecurityDeposit;
        private System.Windows.Forms.Label lblFirstInstallment;
        private System.Windows.Forms.GroupBox grpPaymentProcessing;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblLabelAmount;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label lblLabelMethod;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnCancel;
    }
}