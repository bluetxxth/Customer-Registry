using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerRegistryV2B
{
    class CustomerManager
    {

        //instance variables

        private List<Customer> m_customers;



        /// <summary>
        /// Constructor1 default
        /// </summary>
        public CustomerManager()
        {
            m_customers = new List<Customer>();
        }


        /// <summary>
        /// Property provides read only for m_customer
        /// </summary>
        public int Count
        {
            get { return m_customers.Count; }
        }


        /// <summary>
        /// Property provides get for ID
        /// </summary>
        public int GetNewID
        {
            get { return Count + 100; }
        }


        /// <summary>
        /// Method adds customer
        /// </summary>
        /// <param name="contactIn">the contact to be added</param>
        public void AddCustomer(Contact contactIn)
        {
            string newID = GetNewID.ToString();
            Customer newCustomer = new Customer(contactIn, newID);
            m_customers.Add(newCustomer);
        }


        /// <summary>
        /// Method Adds customer
        /// </summary>
        /// <param name="customerIn"></param>
        /// <returns>true if the customer added successfully</returns>
        public bool AddCustomer(Customer customerIn)
        {
            if (Count + 2 >= 0 && Convert.ToInt32(customerIn.ID) < m_customers.Count)
            {

                m_customers.Add(customerIn);

                customerIn.ID = GetNewID.ToString();

                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// Method change the contact data
        /// </summary>
        /// <param name="contactIn"></param>
        /// <param name="index"></param>
        public void ChangeCustomer(Contact contactIn, int index)
        {

            m_customers[index].ContactData = contactIn;

        }



        /// <summary>
        /// Method deletes customer
        /// </summary>
        /// <param name="index"></param>
        /// <returns>trueif the customer exists or false if the customer does not exist</returns>
        public bool DeleteCustomer(int index)
        {

            bool deleteCustomer = false;

            if (m_customers[index] == null)
            {

                deleteCustomer = false;

            }
            else
            {
                m_customers[index] = null;

                return deleteCustomer = true;
            }
            return deleteCustomer;
        }



        /// <summary>
        /// Method searchs a given customer
        /// </summary>
        /// <param name="str">the string entered in the search box</param>
        /// <returns>true if name is found, false if name is not found</returns>
        public Customer SearchCustomer(string str)
        {
            
            Customer customer = m_customers.Find(delegate(Customer c) 
                  {return c.ContactData.CompleteName.Equals(str);});
        
            return customer;
        }//end method


        /// <summary>
        /// Method gets the customer
        /// </summary>
        /// <returns>The customer</returns>
        public Customer GetCustomer(int index)
        {
                return this.m_customers[index];
        }



        /// <summary>
        ///Method gets the customer info
        /// </summary>
        /// <returns>the customer data</returns>
        public string[] GetCustomerInfo()
        {
            string[] getCustomer = new string[m_customers.Count];

            for (int index = 0; index < (m_customers.Count); index++)
            {
                getCustomer[index] = m_customers[index].ToString();

            }

            return getCustomer;
        }

    }
}
