/*
 * Author      : Jackson Currie
 * Email       : 30005345@student.toiohomai.ac.nz
 * Last Edited : 18th October 2018
 * Description : Event methods from the GUI components
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDB
{
    public partial class CustomerDetails : Form
    {
        // Global list variables
        private List<Customer> CustomerDB = new List<Customer>();
        private List<string> data;
        
        // When the form loads
        public CustomerDetails()
        {
            InitializeComponent();
            LoadDB();
            ClearBoxes();
            DisplayCustomers();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        // Add data to database
        private void LoadDB()
        {
            CustomerDB.Add(new Customer("Jaarna", "Kereopa", "123-2514"));
            CustomerDB.Add(new Customer("Sue", "Stook", "123-1263"));
            CustomerDB.Add(new Customer("Jamie", "Allom", "123-3658"));
            CustomerDB.Add(new Customer("Brian", "Janes", "123-9898"));
        }

        // Clears data in text boxes
        private void ClearBoxes()
        {
            tbxFirstname.Clear();
            tbxLastname.Clear();
            tbxPhone.Clear();
        }

        // Loops through database to add customers
        private void DisplayCustomers()
        {
            foreach(Customer customer in CustomerDB)
            {
                lbxCustomers.Items.Add(customer.GetCustomer());
            }
        }

        // Search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbxCustomerName.Text;

            // Check if search empty
            if (search == "")
            {
                MessageBox.Show("You must enter a customer name.", "Search");
                tbxCustomerName.Focus();
            }
            // If data in text box
            else
            {
                // Clear search and list
                tbxCustomerName.Clear();
                lbxCustomers.Items.Clear();

                // Number of search results
                int results = 0;
               
                // Loop through data to find results
                foreach (Customer customer in CustomerDB)
                {
                    // Found result
                    if (customer.FName.ToUpper() == search.ToUpper() || customer.LName.ToUpper() == search.ToUpper() || customer.Phone == search)
                    {
                        results++;
                        lbxCustomers.Items.Add(customer.GetCustomer());
                        lbxCustomers.SetSelected(0, true);
                    }
                }

                // No reuslts
                if (results == 0)
                {
                    MessageBox.Show("Customer not found, please try again.", "Search");
                    DisplayCustomers();
                    ClearBoxes();
                    tbxCustomerName.Focus();
                }
            }
        }

        // List customers button
        private void btnListCustomers_Click(object sender, EventArgs e)
        {
            // Re-list all customers
            lbxCustomers.Items.Clear();
            ClearBoxes();
            DisplayCustomers();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        // Clear list button
        private void btnClearList_Click(object sender, EventArgs e)
        {
            // Clear the list
            lbxCustomers.Items.Clear();
            ClearBoxes();
            tbxCustomerName.Focus();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        // Update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if fields are empty
            if(tbxFirstname.Text != "" && tbxLastname.Text != "" && tbxPhone.Text != "")
            {
                // Use phone number as identity
                string phone = data[2];

                // Search database
                foreach (Customer customer in CustomerDB)
                {
                    // Found identity
                    if(customer.Phone == tbxPhone.Text && customer.Phone != phone)
                    {
                        MessageBox.Show("Someone with that phone number already exists.", "Update");
                        return;
                    }
                }

                // Search database
                foreach (Customer customer in CustomerDB)
                {
                    // Update data
                    if(customer.Phone == phone)
                    {
                        customer.FName = tbxFirstname.Text;
                        customer.LName = tbxLastname.Text;
                        customer.Phone = tbxPhone.Text;
                    }
                }

                // Re-list customers
                ClearBoxes();
                tbxCustomerName.Focus();
                lbxCustomers.Items.Clear();
                DisplayCustomers();
                MessageBox.Show("Customer details updated.", "Update");
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            // Empty fields
            else
            {
                MessageBox.Show("All text fields must be filled to update.", "Update");
            }
        }

        // Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if fields are empty
            if (tbxFirstname.Text != "" && tbxLastname.Text != "" && tbxPhone.Text != "")
            {
                // Search database
                foreach(Customer customer in CustomerDB)
                {
                    // Check if identity exists
                    if(customer.Phone == tbxPhone.Text)
                    {
                        MessageBox.Show("Someone with that phone number already exists.", "Add");
                        return;
                    }
                }

                // Add new customer
                CustomerDB.Add(new Customer(tbxFirstname.Text, tbxLastname.Text, tbxPhone.Text));

                // Re-list customers
                ClearBoxes();
                lbxCustomers.Items.Clear();
                DisplayCustomers();
                MessageBox.Show("New customer has been added", "Add");
            }

            // Empty fields
            else
            {
                MessageBox.Show("All text fields must be filled to add.", "Add");
            }
        }

        // Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Make sure of delete
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + data[0] + ".", "Delete", MessageBoxButtons.YesNo);

            // If sure
            if (result == DialogResult.Yes)
            {

                // Search database
                foreach (Customer customer in CustomerDB)
                {
                    // Delete customer
                    if (customer.Phone == data[2])
                    {
                        CustomerDB.Remove(customer);
                        break;
                    }
                }

                // Re-list customers
                ClearBoxes();
                lbxCustomers.Items.Clear();
                DisplayCustomers();
                MessageBox.Show("Customer has been deleted", "Delete");
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        // Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input fields
            ClearBoxes();
            lbxCustomers.SetSelected(0, false);
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            tbxFirstname.Focus();
        }

        // When customer selected
        private void lbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if valid selection
            if(lbxCustomers.SelectedIndex >= 0)
            {
                // Set selection data
                data = lbxCustomers.SelectedItem.ToString().Split(new[] { "\t\t" }, StringSplitOptions.None).ToList();

                foreach (Customer customer in CustomerDB)
                {
                    if (customer.Phone == data[2])
                    {
                        tbxFirstname.Text = customer.FName;
                        tbxLastname.Text = customer.LName;
                        tbxPhone.Text = customer.Phone;
                    }
                }

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        // Bind enter to search
        private void tbxCustomerName_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnSearch;
        }

        // Bind enter to add or update
        private void tbxPhone_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnAdd.Enabled ? btnAdd : btnUpdate;
        }

        // Bind enter to add or update
        private void tbxFirstname_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnAdd.Enabled ? btnAdd : btnUpdate;
        }

        // Bind enter to add or update
        private void tbxLastname_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnAdd.Enabled ? btnAdd : btnUpdate;
        }

        // Unbind enter
        private void tbxCustomerName_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        // Unbind enter
        private void tbxFirstname_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        // Unbind enter
        private void tbxLastname_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        // Unbind enter
        private void tbxPhone_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }
    }
}
