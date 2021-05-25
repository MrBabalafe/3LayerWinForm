using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4 {
    public partial class Form1 : Form {

        //Necessary for displaying info on the form. These store the current order / order details
        public Order order;
        public List<OrderDetail> orderDetails;

        public Form1() {
            InitializeComponent();
        }

        //When Search button is clicked
        private void btnSearch_Click(object sender, EventArgs e) {
            try {
                
                //Execute database queries to retrieve order and order details info for the specified order id
                int idToSearch = Convert.ToInt32(txtOrderID.Text);
                order = OrderDB.GetOrder(idToSearch);
                orderDetails = OrderDetailDB.GetOrderDetails(idToSearch);

                //Update the form info to display info about the current order and order details
                txtCustomerID.Text = order.CustomerID;
                UpdateDateBoxes(order);
                orderDetailDataGridView.DataSource = orderDetails;

                //Calculate the Order total from order detail info
                decimal orderTotal = CalculateOrderTotal(orderDetails);
                
                //Formatting for the form, and allow the Shipped Date box to be modified by user after an order is searched
                lblOrderTotal.Visible = true;
                lblOrderTotalCalc.Visible = true;
                lblOrderTotalCalc.Text = orderTotal.ToString("c");
                dtShipped.Enabled = true;
                btnUpdate.Enabled = true;
                checkBoxNull.Enabled = true;

            //If the user entered a badly formatted OrderID to search, display an error box
            } catch(FormatException ex) {
                MessageBox.Show("Incorrect Format for Order ID.");
            }
            
        }

        //Calculate the order total for the current order details.
        private decimal CalculateOrderTotal(List<OrderDetail> orderDetails) {
            decimal orderTotal = 0;
            foreach (OrderDetail od in orderDetails) {
                orderTotal += (od.UnitPrice * (1 - (decimal)od.Discount) * od.Quantity);
            }
            return orderTotal;
        }

        //This method just updates the date boxes with current order info.
        private void UpdateDateBoxes(Order order) {
            DateTime mindate = new DateTime(1900, 1, 1);

            //If any of the dates are stored as the default value that means that they were NULL in the database (OrderDB.cs line 37)
            //If the date is supposed to be null, make the datebox display nothing and if its the shipped date, check off the null check box
            if (order.OrderDate == default) {
                dtOrder.Value = mindate;
                dtOrder.CustomFormat = " ";
                dtOrder.Format = DateTimePickerFormat.Custom;
            } else {
                dtOrder.Value = order.OrderDate;
                dtOrder.Format = DateTimePickerFormat.Long;
            }

            if (order.RequiredDate == default) {
                dtRequired.Value = mindate;
                dtRequired.CustomFormat = " ";
                dtRequired.Format = DateTimePickerFormat.Custom;
            } else {
                dtRequired.Value = order.RequiredDate;
                dtRequired.Format = DateTimePickerFormat.Long;
            }

            if (order.ShippedDate == default) {
                dtShipped.Value = mindate;
                dtShipped.CustomFormat = " ";
                dtShipped.Format = DateTimePickerFormat.Custom;
                checkBoxNull.Checked = true;
            } else {
                checkBoxNull.Checked = false;
                dtShipped.Value = order.ShippedDate;
                dtShipped.Format = DateTimePickerFormat.Long;

            }
        }

        //When update button is clicked
        private void btnUpdate_Click(object sender, EventArgs e) {
            //Change current order's shipped date to what user inputs
            order.ShippedDate = dtShipped.Value;
            //Run SQL command to update Database and show a message that tells user it worked.
            OrderDB.UpdateOrder(order, checkBoxNull.Checked);
            MessageBox.Show("Order " + order.OrderID + " successfuly updated!", "Update Successful");
        }

        //Makes sure that when the Shipped Date value is changed it is valid (Between Order Date and Required Date.
        //If not disable the update button so the user can't accidentally add bad data.
        private void dtShipped_ValueChanged(object sender, EventArgs e) {
            if (dtShipped.Value < order.OrderDate || dtShipped.Value > order.RequiredDate) {
                btnUpdate.Enabled = false;
            } else {
                btnUpdate.Enabled = true;
            }
        }

        //If the null check box is checked then make the ShippedDate datebox display nothing.
        //If it gets unchecked then just set the new value to Today, but it can be changed by user.
        private void checkBoxNull_CheckedChanged(object sender, EventArgs e) {
            if(checkBoxNull.Checked) {
                DateTime mindate = new DateTime(1900, 1, 1);
                dtShipped.Value = mindate;
                dtShipped.CustomFormat = " ";
                dtShipped.Format = DateTimePickerFormat.Custom;
                btnUpdate.Enabled = true;
            } else {
                dtShipped.Value = DateTime.Today;
                dtShipped.Format = DateTimePickerFormat.Long;
            }
        }
    }
}
