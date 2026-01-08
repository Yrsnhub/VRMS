using System;
using System.Windows.Forms;
using VRMS.Forms.Payments; // Ensure this matches the namespace of your payment form

namespace VRMS.Forms
{
    public partial class NewRentalForm : Form
    {
        public NewRentalForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Logic to save the rental to your database would go here
            // bool isSaved = SaveRentalToDatabase();

            // 2. Prepare the data to pass to the Down Payment form
            // For this example, I'm assuming you have controls like txtCustomer, txtVehicle, etc.
            string customer = "John Doe"; // txtCustomer.Text
            string vehicle = "Toyota Vios (GAS-123)"; // txtVehicle.Text
            decimal totalAmount = 5000.00m; // The total calculated rental price

            // 3. Navigate to the Down Payment Form
            using (RentalDownPayment paymentForm = new RentalDownPayment())
            {
                // Note: You may need to add a public method or constructor to 
                // RentalDownPayment to receive these values.
                // paymentForm.LoadRentalData(customer, vehicle, totalAmount);

                if (paymentForm.ShowDialog() == DialogResult.OK)
                {
                    // If payment was successful
                    MessageBox.Show("Rental and Down Payment Processed Successfully!",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}