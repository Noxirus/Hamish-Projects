using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamishLab4
{
    public partial class frmModifyShipped : Form
    {
        public Orders order; //current order object
        public frmModifyShipped()
        {
            InitializeComponent();
        }
        //update values on the table
        private void DisplayCurrentOrderDates()
        {
            txtOrderDate.Text = order.OrderDate.ToString();
            txtShippedDate.Text = order.ShippedDate.ToString();
            txtRequiredDate.Text = order.RequiredDate.ToString();
            txtShippedDate.Focus();
        }
        //input order dates from the order object on load
        private void frmModifyShipped_Load(object sender, EventArgs e)
        {
            DisplayCurrentOrderDates();
        }
        //check validity of changed shipped date
        private bool IsValidDateShipped()
        {
            bool valid = true; // empty is valid
            DateTime endDate;
            if (txtOrderDate.Text != "")// if not empty
            {
                if (DateTime.TryParse(txtShippedDate.Text, out endDate))//valid date
                {
                    DateTime startDate = Convert.ToDateTime(txtOrderDate.Text);
                    DateTime requireDate = Convert.ToDateTime(txtRequiredDate.Text);
                    //check to see if date is earlier than date ordered
                    if (startDate >= endDate)
                    {
                        valid = false;
                        MessageBox.Show("Date Shipped must be later than Date Ordered", "Data Error");
                        txtShippedDate.SelectAll();
                        txtShippedDate.Focus();
                    }
                    //check to see if date is later than required date
                    else if (requireDate <= endDate)
                    {
                            valid = false;
                            MessageBox.Show("Date Shipped must be before Date Required", "Data Error");
                            txtShippedDate.SelectAll();
                            txtShippedDate.Focus();
                        }
                    }
                //check if shipped date should be null
                else if(chkBoxNullShip.Checked == true)
                {
                    txtShippedDate.Text = "";
                    valid = true;
                }
                //inform the user that the date format is incorrect
                else
                {
                    valid = false;
                    MessageBox.Show("Please enter Date Ended in format YYYY-MM-DD", "Data Error");
                    txtShippedDate.SelectAll();
                    txtShippedDate.Focus();
                }
            }
            return valid;
        }
        //accept new shipped date and update the value on the database
        private void btnAcceptShipping_Click(object sender, EventArgs e)
        {
            if (IsValidDateShipped())
            { 
                // build Member object with the new data
                Orders newOrder = new Orders();
                newOrder.ShippedDate = order.ShippedDate;
                DateTime? dateTime = null;
                //check to see if value of shippedDate is null
                if(txtShippedDate.Text != "")
                { 
                dateTime = Convert.ToDateTime(txtShippedDate.Text);
                }
                else
                {
                    dateTime = null;
                }
                try // try to update
                {
                    if (!OrdersDB.UpdateOrder(order.OrderID, dateTime))//failed
                    {
                        MessageBox.Show("Another user has updated or " +
                                "deleted current member", "Concurrency Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        //order = newOrder;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating: " + ex.Message, ex.GetType().ToString());
                }
            }
        }
        //datetime box value tansferred to textbox
        private void dtpShip_ValueChanged(object sender, EventArgs e)
        {
            txtShippedDate.Text = dtpShip.Value.ToString();
        }
        //clear textbox if checked, allows for null
        private void chkBoxNullShip_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxNullShip.Checked == true)
            {
                txtShippedDate.Text = "";
            }
        }
        //close the modify window
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
