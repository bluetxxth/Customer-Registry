using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerRegistryV2B
{
    class Customer
    {
        //Instance variables

        Contact m_contact;
        string m_id;


        /// <summary>
        /// Constructor1 default
        /// </summary>
        public Customer()
            : this(null)
        {

            m_contact = new Contact();
        }

        /// <summary>
        /// Constructor2 overloaded
        /// </summary>
        /// <param name="contactIn"></param>
        public Customer(Contact contactIn)
            : this(contactIn, string.Empty)
        {


        }


        /// <summary>
        /// Constructor3 overloaded
        /// </summary>
        /// <param name="contactIn"></param>
        /// <param name="id"></param>
        public Customer(Contact contactIn, string id)
        {
            m_contact = contactIn;
            m_id = id;
        }


        /// <summary>
        /// Property provide get and set for m_contact
        /// </summary>
        public Contact ContactData
        {

            get { return m_contact; }

            set { m_contact = value; }

        }


        /// <summary>
        ///  Property provide get and set for m_id
        /// </summary>
        public string ID
        {

            get { return m_id; }

            set { m_id = value; }

        }


        /// <summary>
        /// Method to string
        /// </summary>
        /// <returns>a formated string</returns>
        public override string ToString()
        {

            string strOut = string.Format("{0, -10}{1, -5}", m_id, m_contact);

            return strOut;
        }

    }
}
