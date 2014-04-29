//
//Class Contact takes care of the contact features which englobe all other classes Email, Phone, Address, Countries, etc...
//Gabriel Nieva M12K2712
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerRegistryV2B
{
    public class Contact
    {

        private string m_firstName = string.Empty;
        private string m_LastName = string.Empty;
        private Address m_address;
        private Email m_email;
        private Phone m_phone;


        /// <summary>
        /// Constructor default
        /// </summary>
        public Contact()
            : this(string.Empty, string.Empty, new Address(), new Phone(), new Email())
        {

        }


        /// <summary>
        /// Constructor overloaded
        /// </summary>
        public Contact(string firstName, string lastName, Address adr, Phone tel, Email mail)
        {

            this.m_address = adr;
            this.m_email = mail;
            this.m_phone = tel;
            this.m_firstName = firstName;
            this.m_LastName = lastName;

        }


        /// <summary>
        /// Property provides get and set for m_address
        /// </summary>
        public Address AddressData
        {
            get { return this.m_address; }

            set { this.m_address = value; }

        }


        /// <summary>
        /// Property provides get and set for m_Email
        /// </summary>
        public Email EmailData
        {


            get { return m_email; }

            set { m_email = value; }

        }


        /// <summary>
        /// Property provides get and set for m_FirstName
        /// </summary>
        public string FirstName
        {

            get { return m_firstName; }

            set { m_firstName = value; }

        }



        /// <summary>
        /// Property provides get and set for m_LastName
        /// </summary>
        public string LastName
        {

            get { return m_LastName; }

            set { m_firstName = value; }


        }


        /// <summary>
        /// Property provides get and set for m_phone
        /// </summary>
        public Phone PhoneData
        {

            get { return m_phone; }

            set { m_phone = value; }

        }



        /// <summary>
        /// Property provides get for a string containing m_first and m_last name
        /// </summary>
        public string CompleteName
        {

            get { return m_firstName + " " + m_LastName; }

        }

        /// <summary>
        /// Method Checks the data
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            //first name
            if (String.IsNullOrEmpty(m_firstName))
            {
                return false;
                //last name
            }
            else if (String.IsNullOrEmpty(m_LastName))
            {
                return false;
                //country
            }
            //check to see if country is selected. If -1 it means it is not selected
            else if (m_address.Country == (Countries)(-1))
            {
                return false;
            }

            //check is done by the Address class checkData method
            else if (m_address.CheckData() != true)
            {
                return false;

            }
            else
            {
                return true; // if all is okay then it is true
            }

        }


        /// <summary>
        /// Method returns formated string with full name, address and telephone number
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Format("\t{0,-20}{1, -20}{2, -3}{3, -5}", CompleteName.Trim(), m_address.ToString().Trim(), m_phone.ToString(), m_email.ToString());

            return strOut;
        }

    }

}
