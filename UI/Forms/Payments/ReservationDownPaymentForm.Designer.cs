namespace VRMS.Forms.Payments
{
    partial class ReservationDownPaymentForm
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
            this.grpReservation = new System.Windows.Forms.GroupBox();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.lblVehicleInfo = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.grpDownPayment = new System.Windows.Forms.GroupBox();
            this.lblRequiredDownpayment = new System.Windows.Forms.Label();
            this.lblTotalContractPrice = new System.Windows.Forms.Label();
            this.grpPaymentInput = new System.Windows.Forms.GroupBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpReservation.SuspendLayout();
            this.grpDownPayment.SuspendLayout();
            this.grpPaymentInput.SuspendLayout();
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
            this.lblHeader.Size = new System.Drawing.Size(210, 37);
            this.lblHeader.Text = "Down Payment";
            // 
            // grpReservation
            // 
            this.grpReservation.Controls.Add(this.lblReservationID);
            this.grpReservation.Controls.Add(this.lblVehicleInfo);
            this.grpReservation.Controls.Add(this.lblCustomerInfo);
            this.grpReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpReservation.Location = new System.Drawing.Point(20, 75);
            this.grpReservation.Name = "grpReservation";
            this.grpReservation.Size = new System.Drawing.Size(440, 110);
            this.grpReservation.TabIndex = 1;
            this.grpReservation.TabStop = false;
            this.grpReservation.Text = "Reservation Details";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReservationID.ForeColor = System.Drawing.Color.DimGray;
            this.lblReservationID.Location = new System.Drawing.Point(15, 80);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Text = "Reservation ID: --";
            // 
            // lblVehicleInfo
            // 
            this.lblVehicleInfo.AutoSize = true;
            this.lblVehicleInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVehicleInfo.Location = new System.Drawing.Point(15, 55);
            this.lblVehicleInfo.Name = "lblVehicleInfo";
            this.lblVehicleInfo.Text = "Vehicle: --";
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblCustomerInfo.Location = new System.Drawing.Point(15, 25);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Text = "Customer: --";
            // 
            // grpDownPayment
            // 
            this.grpDownPayment.Controls.Add(this.lblRequiredDownpayment);
            this.grpDownPayment.Controls.Add(this.lblTotalContractPrice);
            this.grpDownPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpDownPayment.Location = new System.Drawing.Point(20, 195);
            this.grpDownPayment.Name = "grpDownPayment";
            this.grpDownPayment.Size = new System.Drawing.Size(440, 120);
            this.grpDownPayment.TabIndex = 2;
            this.grpDownPayment.TabStop = false;
            this.grpDownPayment.Text = "Payment Summary";
            // 
            // lblRequiredDownpayment
            // 
            this.lblRequiredDownpayment.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRequiredDownpayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblRequiredDownpayment.Location = new System.Drawing.Point(6, 65);
            this.lblRequiredDownpayment.Name = "lblRequiredDownpayment";
            this.lblRequiredDownpayment.Size = new System.Drawing.Size(428, 40);
            this.lblRequiredDownpayment.Text = "DOWN PAYMENT: ₱0.00";
            this.lblRequiredDownpayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalContractPrice
            // 
            this.lblTotalContractPrice.AutoSize = true;
            this.lblTotalContractPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalContractPrice.Location = new System.Drawing.Point(15, 35);
            this.lblTotalContractPrice.Name = "lblTotalContractPrice";
            this.lblTotalContractPrice.Text = "Total Rental Amount: ₱0.00";
            // 
            // grpPaymentInput
            // 
            this.grpPaymentInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpPaymentInput.Controls.Add(this.txtAmountPaid);
            this.grpPaymentInput.Controls.Add(this.label9);
            this.grpPaymentInput.Controls.Add(this.cbPaymentMethod);
            this.grpPaymentInput.Controls.Add(this.label8);
            this.grpPaymentInput.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpPaymentInput.Location = new System.Drawing.Point(20, 330);
            this.grpDownPayment.TabIndex = 3;
            this.grpPaymentInput.Name = "grpPaymentInput";
            this.grpPaymentInput.Size = new System.Drawing.Size(440, 110);
            this.grpPaymentInput.TabStop = false;
            this.grpPaymentInput.Text = "Payment Processing";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmountPaid.Location = new System.Drawing.Point(225, 55);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(185, 32);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(221, 35);
            this.label9.Text = "Amount Tendered:";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Debit Card", "E-Wallet" });
            this.cbPaymentMethod.Location = new System.Drawing.Point(19, 55);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(185, 31);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(15, 35);
            this.label8.Text = "Method:";
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(240, 460);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(220, 50);
            this.btnProcess.Text = "Post Down Payment";
            this.btnProcess.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCancel.Location = new System.Drawing.Point(20, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 50);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // DownPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 530);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.grpPaymentInput);
            this.Controls.Add(this.grpDownPayment);
            this.Controls.Add(this.grpReservation);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservation Down Payment";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpReservation.ResumeLayout(false);
            this.grpReservation.PerformLayout();
            this.grpDownPayment.ResumeLayout(false);
            this.grpDownPayment.PerformLayout();
            this.grpPaymentInput.ResumeLayout(false);
            this.grpPaymentInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpReservation;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.GroupBox grpDownPayment;
        private System.Windows.Forms.Label lblRequiredDownpayment;
        private System.Windows.Forms.Label lblTotalContractPrice;
        private System.Windows.Forms.GroupBox grpPaymentInput;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnCancel;
    }
}