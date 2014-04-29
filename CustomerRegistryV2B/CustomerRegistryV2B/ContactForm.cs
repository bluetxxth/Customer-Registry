//
//Contact form 
//
//Gabriel Nieva M12K2712
//
//


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
    public partial class ContactForm : Form
    {
        //contact object receiving input and / or sending output
        private Contact m_contact = new Contact();


        //flag to handle the closing of the form
        private bool m_closeForm;


        /// <summary>
        /// Constructor1 default
        /// </summary>
        /// <param name="title">title for the form</param>
        public ContactForm(string title)
        {
            //Windows initialization
            InitializeComponent();

            this.Text = title;

            m_closeForm = true;

            //My initialization
            //InitializeGUI();

            FillCountryComboBox();

        }


        /// <summary>
        /// Method initializes GUI
        /// </summary>
        private void InitializeGUI()
        {
            //////cmbCountry.DataSource = Enum.GetNames(typeof(Countries));

            //// Fill comboBox with countries 
            //string[] countryNames = Enum.GetNames(typeof(Countries));

            //foreach (string str in countryNames)
            //{
            //    cmbCountry.Items.Add(str.Replace("_", " "));
            //}

            FillCountryComboBox();
        }


        /// <summary>
        /// Property provide get and set for m_contact
        /// </summary>
        public Contact ContactData
        {

            get { return m_contact; }

            set
            {
                if (value != null)
                {
                    m_contact = value;
                }

                //update input controls
                UpdateGUI();

            }//end set

        }//end property


        /// <summary>
        /// Method OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {


            if (ReadInput() == true && m_contact.CheckData() == true)
            {
                m_closeForm = true;
                //  MessageBox.Show(m_contact.ToString());


                this.Close();
            }
            else
            {
                MessageBox.Show("incomplete information; enter name, last name, city and country", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                m_closeForm = false;
            }



        }



        /// <summary>
        /// Method Cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {

            DialogResult output = MessageBox.Show(String.Format("Cancel registration process? "), "continue?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            //dont close the form just remove the popup
            if (output == DialogResult.No)
            {
                m_closeForm = false;
                
            }
            if (output == DialogResult.Yes)
            {

                //close the form
                m_closeForm = true;

                // this.Close();
                //Application.Exit();
            }




        }



        /// <summary>
        /// Method provides closing contact form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (m_closeForm)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }



        /// <summary>
        /// Method reads the address data
        /// </summary>
        /// <returns></returns>
        public Address ReadAddress()
        {

            Address addr = new Address();

            addr.City = txtCity.Text;
            addr.Street = txtStreet.Text;
            addr.ZipCode = txtZipCode.Text;
            addr.Country = (Countries)Enum.Parse(typeof(Countries), cmbCountry.SelectedIndex.ToString());
            addr.CheckData();


            return addr;
        }


        /// <summary>
        /// Method reads Email data
        /// </summary>
        /// <returns></returns>
        public Email ReadEmails()
        {
            Email email = new Email();

            email.Work = txtMailBusiness.Text;
            email.Personal = txtMailPrivate.Text;

            return email;
        }


        /// <summary>
        /// Method reads Phone data
        /// </summary>
        /// <returns></returns>
        public Phone ReadPhones()
        {
            Phone phone = new Phone();

            phone.Work = txtHomePhone.Text;
            phone.Home = txtCellPhone.Text;

            return phone;
        }



        /// <summary>
        /// Method Reads all
        /// </summary>
        /// <returns></returns>
        public bool ReadInput()
        {


            Address address = ReadAddress();

            if ((!object.ReferenceEquals(address.ErrorMessage, string.Empty)))
            {
                MessageBox.Show(address.ErrorMessage);
                return false;
            }

            Phone phone = ReadPhones();
            Email email = ReadEmails();

            m_contact = new Contact(txtFirstName.Text, txtLastName.Text, address, phone, email);

            //if ((ReadAddress() != null) && (ReadPhones() != null) && (ReadEmails() != null))
            //{
            //    return true;

            //}
            //else
            //    return false;

            return true;
        }



        /// <summary>
        /// 
        /// </summary>
        private void FillCountryComboBox()
        {
            //cmbCountry.DataSource = Enum.GetNames(typeof(Countries));

            // Fill comboBox with countries 
            string[] countries = Enum.GetNames(typeof(Countries));
            for (int i = 0; i < countries.Length; i++)
            {
                cmbCountry.Items.Add(countries[i].Replace("_", " "));
            }

        }


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public string ToString()
        //{


        //}


        /// <summary>
        /// 
        /// </summary>
        private void UpdateGUI()
        {

            //cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            //cmbCountry.SelectedIndex = (int)m_contact.AddressData.Country;

            FillCountryComboBox();

            txtFirstName.Text = m_contact.FirstName;
            txtLastName.Text = m_contact.LastName;
            txtCellPhone.Text = m_contact.PhoneData.Work;
            txtHomePhone.Text = m_contact.PhoneData.Home;
            txtMailBusiness.Text = m_contact.EmailData.Work;
            txtMailPrivate.Text = m_contact.EmailData.Personal;
            txtStreet.Text = m_contact.AddressData.Street;
            txtCity.Text = m_contact.AddressData.City;
            txtZipCode.Text = m_contact.AddressData.ZipCode;
            cmbCountry.SelectedIndex = (int)m_contact.AddressData.Country;    // this is to display the last selected country // TODO
       


        }


    }
}
