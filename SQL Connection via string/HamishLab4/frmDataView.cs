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
    public partial class frmDataView : Form
    {
        private Orders order;
        List<int> orderIDs = null;
        List<OrderDetails> orderDetailsList = new List<OrderDetails>();
        public frmDataView()
        {
            InitializeComponent();
        }
        //load the values (orderIDs) of the combobox
        private void LoadComboBox()
        {
            //access the OrdersDB
            orderIDs = OrdersDB.GetOrderIDs();
            if (orderIDs.Count > 0) // if there are members
            {
                cmbBoxOrderID.DataSource = orderIDs;
                cmbBoxOrderID.SelectedIndex = 0; // triggers SelectedIndexChanged
            }
            else // no members
            {
                MessageBox.Show("There are no members. " +
                    "Add some members in the database, and restart the application ", "Empty Load");
                Application.Exit();
            }
        }
        //Update list values when orderID is changed
        private void cmbBoxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
                int orderID = Convert.ToInt32(cmbBoxOrderID.Text);
                this.GetOrder(orderID);
                this.DisplayOrder();
                txtOrderTotal.Text = CalculateTotal().ToString("c");   
        }
        //calculate the total value of the orderID's order details
        private decimal CalculateTotal()
        {
            decimal total = 0; //total value
            foreach(OrderDetails o in orderDetailsList)
            {
                total += o.UnitPrice * (1 - o.Discount) * o.Quantity;
            }
            return total;
        }
        //Get a specific order ID from the dropdown list
        private void GetOrder(int orderID)
        {
            try
            {
                order = OrdersDB.GetOrder(orderID);
                orderDetailsList = OrderDetailsDB.GetOrderDetails(orderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        //display all values on the table
        private void DisplayOrder()
        {
            txtCustomerID.Text = order.CustomerID.ToString();
            txtOrderDate.Text = order.OrderDate.ToString();
            txtRequiredDate.Text = order.RequiredDate.ToString();
            txtShippedDate.Text = order.ShippedDate.ToString();
            //display values from order details to the data grid
            //change the column format
            dataGridViewOrderDetails.DataSource = orderDetailsList;
            dataGridViewOrderDetails.Columns["UnitPrice"].DefaultCellStyle.Format = "c";
            dataGridViewOrderDetails.Columns["Discount"].DefaultCellStyle.Format = "P";
        }
        //quit the application
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //load details on application start
        private void frmDataView_Load(object sender, EventArgs e)
        {
            this.LoadComboBox();
        }
        //open modify shipped date window and allow for changes
        private void btnModifyShip_Click(object sender, EventArgs e)
        {
            frmModifyShipped secondForm = new frmModifyShipped();
            secondForm.order = order; // set current member on the second form
            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK)
            {
                order = secondForm.order; // receive current member from the second form             
            }
            else if (result == DialogResult.Retry)
            {
                order = OrdersDB.GetOrder(order.OrderID);
            }
            this.GetOrder(order.OrderID);
            this.DisplayOrder();
            txtOrderTotal.Text = CalculateTotal().ToString("c");
        }
    }
}
