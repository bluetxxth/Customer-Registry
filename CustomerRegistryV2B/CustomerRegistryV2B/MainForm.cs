using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerRegistryV2B
{
    public partial class MainForm : Form
    {

        CustomerManager customerMngr = new CustomerManager();

        /// <summary>
        /// Constructor1
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Method adds contacts upon clicking the add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContactForm frmContact = new ContactForm("Add New Customer");

            
            //Display  the form and wait until the user clicks a button. If the button presseed was okay
            // the okay button, get the data and save it into the registry (customerMngr)

            if (frmContact.ShowDialog() == DialogResult.OK)
            {
                customerMngr.AddCustomer(frmContact.ContactData);
                updateCustomerList(); // update results

            }
        }


        /// <summary>
        /// Mthod updates the listbox 
        /// </summary>
        public void updateCustomerList()
        {

            //clear list box
            listBox1.Items.Clear();

            //print out the info
            listBox1.Items.AddRange(customerMngr.GetCustomerInfo());


        }


        /// <summary>
        /// Method deletes customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //remove rows
            listBox1.Items.Remove(listBox1.SelectedItem);
          


        }


        /// <summary>
        /// Method Changes customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            ContactForm frmContact = new ContactForm("Change Customer");
            //Customer customer = new Customer();

            int index = listBox1.SelectedIndex;

            //verify that contact is selected
            if (listBox1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please Select an item!");
                return;

            }

            //Change or edit customer data
            if (listBox1.SelectedIndex >= 0)
            {

                frmContact.ContactData = customerMngr.GetCustomer(index).ContactData;
                frmContact.ShowDialog();
                //customerMngr.AddCustomer(frmContact.ContactData);
                customerMngr.ChangeCustomer(frmContact.ContactData, index);
                updateCustomerList(); // update results

            }

        }


        /// <summary>
        /// Method search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchContact.Text;
            ContactForm frmContact = new ContactForm("Change Customer");

            //customer object 
            Customer customer = new Customer();

            //index for the listbox
            int index = listBox1.SelectedIndex;

            //message if the search box is empty
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("enter a name", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //verify that there is a contact on the listbox
                if (listBox1.Items.Count > 0)
                {

                    //verify that there is a customer and that the customer has the right full name
                    if (customerMngr.SearchCustomer(name) != null && name.Equals(customerMngr.SearchCustomer(name).ContactData.CompleteName))
                    {
                    //MessageBox.Show("customer found " + customerMngr.SearchCustomer(name));
                    frmContact.ContactData = customerMngr.SearchCustomer(name).ContactData;
                    frmContact.ShowDialog();
                    }

                    else
                    {
                        MessageBox.Show("customer not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
            
                }//Output message if no contacts have been entered yet i.e listbox empty
                else if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("no contacts entered yet");
                }

            }

        }//end method

    }//end class
}//end namespace



