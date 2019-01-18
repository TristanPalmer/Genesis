using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Genesis.Orders;

namespace Genesis
{
    public partial class FormViewCustomer : Form
    {
        public Customer Customer { get; private set; }

        public FormViewCustomer(Customer customer)
        {
            InitializeComponent();

            LoadCustomer(customer);
        }

        private void LoadCustomer(Customer customer)
        {
            // Store to property:
            Customer = customer;

            // Set ui:
            txtFirstName.Text = Customer.FirstName;
            txtLastName.Text = Customer.LastName;
        }

        private ValidationMessage ValidateCustomer()
        {
            var regex = new Regex("^[a-zA-Z-']*$"); // Alpha chars, dash(-) and apostrophe(')

            // Validate names:

            if (String.IsNullOrWhiteSpace(txtFirstName.Text) || !regex.IsMatch(txtFirstName.Text))
                { return new ValidationMessage(false, "Invalid first name"); }

            if (String.IsNullOrWhiteSpace(txtLastName.Text) || !regex.IsMatch(txtLastName.Text))
                { return new ValidationMessage(false, "Invalid last name"); }

            // Return success:
            return new ValidationMessage(true, "Valid");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var validation = ValidateCustomer();

            if (!validation.IsValid)
            {
                MessageBox.Show(validation.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Persist property values:
                Customer.FirstName = txtFirstName.Text;
                Customer.LastName = txtLastName.Text;

                // Record valid result and close form:
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    internal class ValidationMessage
    {
        internal bool IsValid { get; private set; }
        internal String Message { get; private set; }

        internal ValidationMessage(bool isValid, String message) { IsValid = isValid; Message = message; }
    }
}
