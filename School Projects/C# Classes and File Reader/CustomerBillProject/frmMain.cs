using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Auth: Hamish Harrison December 9th - January 13th 2020
namespace CustomerBillProject
{
    public partial class frmMain : Form
    {
        //Create a list for new objects (clients)
        List<Client> clients = new List<Client>(); //empty list

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //variables
            decimal kwh; //user input for kwh
            decimal offkwh; //user input for off hours
            string name; //class constructor value for name
            int accountNumber; //class constructor value for account number
            string clientType;//class constructor value for client type (residential exc)

            //validate input Dec 11th
            if (Validator.IsNonNegativeInt32(txtUseage, "KWH") &&
                Validator.IsPresent(txtUseage, "KWH") &&
                Validator.IsNonNegativeInt32(txtAccountNo, "Account Number") &&
                Validator.IsPresent(txtAccountNo, "Account Number") &&
                Validator.IsPresent(txtClientName, "Client Name")
                )
            {
                //allocate values from text boxes
                kwh = Convert.ToDecimal(txtUseage.Text); //taking user input for kwh
                accountNumber = Convert.ToInt32(txtAccountNo.Text);
                name = txtClientName.Text;

                //calculate residential rate
                if (btnResidential.Checked == true)
                {
                    clientType = "r";
                    Residential r = new Residential(name, accountNumber, clientType);
                    lblBillTotal.Text = (r.CalculateBill(kwh)).ToString("c");

                    //add it to the list
                    r.ChargeAmount = (r.CalculateBill(kwh));
                    clients.Add(r);
                    DisplayClients();
                }
                //calculate commercial rate
                else if (btnCommercial.Checked == true)
                {
                    clientType = "c";
                    Commercial c = new Commercial(name, accountNumber, clientType);
                    lblBillTotal.Text = (c.CalculateBill(kwh)).ToString("c");

                    //add it to the list
                    c.ChargeAmount = (c.CalculateBill(kwh));
                    clients.Add(c);
                    DisplayClients();
                }
                else
                {
                    //calculate industrial peak rate
                    //validate off hours Dec 11th
                    if (Validator.IsNonNegativeInt32(txtOffHours, "Off hours") &&
                        Validator.IsPresent(txtOffHours, "Off hours"))
                    {
                        //calculate off hours, add peak hours and add client to list
                        clientType = "i";
                        offkwh = Convert.ToDecimal(txtOffHours.Text); //taking user input for off hours
                        Industrial i = new Industrial(name, accountNumber, clientType);
                        lblBillTotal.Text = (i.CalculateBill(kwh, offkwh)).ToString("c");

                        //add it to the list
                        i.ChargeAmount = (i.CalculateBill(kwh, offkwh));
                        clients.Add(i);
                        DisplayClients();
                    }
                }
            }
        }
            //Clear all fields Dec 9th, updated Dec 10th
            private void btnClear_Click(object sender, EventArgs e)
            {
                lblBillTotal.Text = "";
                txtOffHours.Text = "";
                txtUseage.Text = "";
                txtClientName.Text = "";
                txtAccountNo.Text = "";
                txtClientName.Focus();
            }

        //Close the window, Dec 9th
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Hiding the industry selects, Dec 10th
        private void btnIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            if (pnlIndistrialSelect.Visible == false &&
                pnlHoursDisplay.Visible == false)
            {
                pnlIndistrialSelect.Visible = true;
                pnlHoursDisplay.Visible = true;
            }
            else
            {
                pnlIndistrialSelect.Visible = false;
                pnlHoursDisplay.Visible = false;
            }
        }
        //display the list of clients and update totals
        private void DisplayClients()
        {
            lstClients.Items.Clear();
            foreach (Client c in clients)
                lstClients.Items.Add(c); // calling implicitly to string
            //update totals on form
            lblClientCount.Text = clients.Count.ToString();
            lblTotalCharges.Text = CalculateTotalCharges().ToString("c");
            lblTotResCharges.Text = CalculateClassCharges("r").ToString("c");
            lblTotComCharges.Text = CalculateClassCharges("c").ToString("c");
            lblTotIndCharges.Text = CalculateClassCharges("i").ToString("c");
        }
        //calculate totals
        private decimal CalculateTotalCharges()
        {
            decimal total = 0;
            foreach (Client c in clients)
                total += c.ChargeAmount;

            return total;
        }
        //calculate client type totals
        private decimal CalculateClassCharges(string t)
        {
            string type = t;
            decimal total = 0;
            foreach (Client c in clients)
                if (c.ClientType == t)
                {
                    total += c.ChargeAmount;
                }
            return total;
        }
        //read list on loading
        private void frmMain_Load(object sender, EventArgs e)
        {
            clients = ClientDB.ReadClients();
            DisplayClients();
        }
        //save list on closing
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClientDB.SaveClients(clients);
        }
        //get value from client list box
        private Client GetSelectedClient()
        {
            Client selectedClient = null; //no selection
            int selectedIndex = lstClients.SelectedIndex;
            if (selectedIndex < 0) //user did not select
            {
                MessageBox.Show("You need to select a client");
            }
            else //user selected an account
            {
                selectedClient = clients[selectedIndex];
            }
            return selectedClient;
        }
        //remove client
        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            Client client = GetSelectedClient();
            int selectedIndex = lstClients.SelectedIndex;
            if (selectedIndex < 0) //user did not select
            {
                MessageBox.Show("You need to select a client");
            }
            else //user selected an account
            {
                clients.Remove(client);
                DisplayClients();
            }
        }
    }
}
