using System;
using System.Windows.Forms;
using VRMS.Forms.Payments; // Ensure this points to the correct folder

namespace VRMS.Forms
{
    public partial class AddReservationForm : Form
    {
        public AddReservationForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. YOUR SAVE LOGIC HERE (SQL, Validation, etc.)

            // 2. Prepare data for the Payment Form
            string customer = "John Doe"; // Use your actual control values
            string vehicle = "Toyota Camry";
            decimal amount = 1500.00m;

            // 3. Open the ReservationDownPaymentForm
            using (ReservationDownPaymentForm payForm = new ReservationDownPaymentForm())
            {
                // Optional: Create a method in payForm to receive this data
                // payForm.SetData(customer, vehicle, amount);

                if (payForm.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}