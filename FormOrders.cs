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

            // Connect to db:
            Orders.ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.None, true);
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
                var viewCustomerForm = new FormViewCustomer(customer);

                viewCustomerForm.ShowDialog();

                // When form is closed, reload grid if changes made:
                if (viewCustomerForm.DialogResult == DialogResult.OK)
                {
                    xpViewOrders.Reload();
                }
            }
        }
    }
}
