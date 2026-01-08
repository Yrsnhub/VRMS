namespace VRMS.Forms.Payments
{
    public partial class RentalDownPayment : Form
    {
        public RentalDownPayment()
        {
            InitializeComponent();
        }

        // Add this method to receive data from the Rental Form
        public void LoadRentalData(string customer, string vehicle, decimal total)
        {
            lblCustomerName.Text = $"Customer: {customer}";
            lblVehicleDetails.Text = $"Vehicle: {vehicle}";
            lblFirstInstallment.Text = $"Initial Rental Fee: {total:C2}";

            // Assuming security deposit is a fixed amount or percentage
            decimal securityDeposit = 2000.00m;
            lblSecurityDeposit.Text = $"Security Deposit: {securityDeposit:C2}";

            lblTotalInitialPayment.Text = $"TOTAL DUE: {(total + securityDeposit):C2}";
        }

        // Example for the Confirm button in the Payment form
        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Logic to save payment...
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}