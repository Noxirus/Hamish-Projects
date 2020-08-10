using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamishLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //validate the input
            this.Validate();
            try
            {
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.northwindDataSet);
            }
            //catch any errors and inform the user
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Another user updated or deleted data in the meantime" + "\nTry again",
                    "Concurrency Exception");
                //refresh the dataset
                this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while saving:" + ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading data" + ex.Message, ex.GetType().ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            // TODO: This line of code loads data into the 'northwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);
            // TODO: This line of code loads data into the 'northwindDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        private void productsBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show("Bad data input, please enter correct values");
        }
        //Validate that name is not null
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            productNameTextBox.Focus();
        }

        private void productNameTextBox_Leave(object sender, EventArgs e)
        {
            if (productNameTextBox.Text == "")
            {
                MessageBox.Show("Name must have a value");
                productNameTextBox.Focus();
            }
        }
    }
}
