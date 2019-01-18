using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Genesis.Orders;

namespace Genesis
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();

            try
            {
                Orders.ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.None, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to database", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        /// <summary>
        /// FormOrders main grid 'View Customer' click event, opens 'FormViewCustomer' to allow editing of customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repositoryItemButtonEdit1_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // Get customer id from grid:
            object customerId = gridView1.GetFocusedRowCellValue("CustomerId");
            int row = gridView1.GetFocusedDataSourceRowIndex();

            // Retrieve customer object:
            Customer customer = null;
            try
            {
                customer = (Customer)unitOfWorkOrders.GetObjectByKey(typeof(Customer), customerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load customer.");
            }

            // If customer has been found...
            if (customer != null)
            {
                // ... open FormViewCustomer:
                var customerForm = new FormViewCustomer(customer);

                customerForm.ShowDialog();

                // When form is closed, reload grid if changes made:
                if (customerForm.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        // "loading..." screen:
                        splashScreenManager1.ShowWaitForm();

                        // Persist changes to database:
                        customerForm.Customer.Save();
                        customerForm.Customer.Session.CommitTransaction();

                        // Close loading screen:
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                        // Reload grid ui:
                        xpViewOrders.Reload();
                    }
                    catch
                    {
                        // Close loading screen:
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                        // Any other error handling etc...

                        MessageBox.Show("Error saving customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                    }
                }
            }
        }
    }
}
