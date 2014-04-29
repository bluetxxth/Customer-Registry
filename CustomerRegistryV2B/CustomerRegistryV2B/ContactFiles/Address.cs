
//
//Class Address takes care of the address features such as zipcode, street and country
//Gabriel Nieva M12K2712
//
//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerRegistryV2B
{
    public class Address
    {

        //instance fields
        private string m_city;
        private Countries m_country; // countries is an enumeration
        private string m_street;
        private string m_strErrMessage;
        private string m_zipCode;


        /// <summary>
        ///Constructor1 default (call constructor3 with more parameters)
        /// </summary>
        public Address():this(string.Empty, string.Empty, string.Empty)
        {       
            this.m_strErrMessage = string.Empty;

        }


        /// <summary>
        /// Constructor2 Overloaded
        /// </summary>
        /// <param name="theOther"></param>
        public Address(Address theOther)
        {

            m_city = theOther.m_city;
            m_street = theOther.m_street;
            m_zipCode = theOther.m_zipCode;
            m_country = theOther.m_country;
        }


        /// <summary>
        /// Constructor3 Overloaded  (calls constructor4 with more parameters)
        /// </summary>
        /// <param name="m_street"></param>
        /// <param name="zip"></param>
        /// <param name="city"></param>
        public Address(string m_street, string zip, string city):this(string.Empty, string.Empty, string.Empty, new Countries())
        {
            this.m_city = string.Empty;
            this.m_street = string.Empty;
            this.m_zipCode = string.Empty;
            this.m_country = new Countries();
           

        }


        /// <summary>
        /// Constructor4 Overloaded
        /// </summary>
        /// <param name="m_street"></param>
        /// <param name="zip"></param>
        /// <param name="city"></param>
        public Address(string m_street,
                        string zip,
                        string city,
                        Countries country)
        {
            //this.m_city = null;
            //this.m_street = null;
            //this.m_zipCode = null;
            //this.m_country = new Countries();

        }





        /// <summary>
        /// Property provides get and set for m_city
        /// </summary>
        public string City
        {

            get { return m_city; }
            set { m_city = value; }

        }


        /// <summary>
        /// Property provides get and set for m_country
        /// </summary>
        public Countries Country
        {

            get { return m_country; }

            set { m_country = value; }
        }



        /// <summary>
        /// Property provides get and set for m_strErrMessage
        /// </summary>
        public string ErrorMessage
        {

            get { return m_strErrMessage; }

            set { m_strErrMessage = value; }

        }


        /// <summary>
        /// Property provides get and set for m_street
        /// </summary>
        public string Street
        {

            get { return m_street; }

            set { m_street = value; }

        }


        /// <summary>
        /// Property provides get and set for m_zipCode
        /// </summary>
        public string ZipCode
        {

            get { return m_zipCode; }

            set { m_zipCode = value; }

        }


        /// <summary>
        /// Method control for the validity of the information entered by the user
        /// Can require to enter street and zip code by uncommenting the corrsponding 
        /// section below.
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {

            //checks to see if city is empty
            if (String.IsNullOrEmpty(m_city))
            {

                return false;
            }

     /////// uncomment below to get functionality/////


            // //checks to see if street is empty
            // else if(String.IsNullOrEmpty(m_street))
            // {

            //     return false;
            // }


            // //checks to see if zip code is empty
            //else if(String.IsNullOrEmpty(m_zipCode))
            //{
            //    return false;
            //}

            else

                return true;
        }


        ///// <summary>
        ///// Method gets the country
        ///// </summary>
        ///// <returns></returns>
        //public void GetCountryString()
        //{

        //}






        /// <summary>
        /// Method overloaded string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //remove underscore
            string m_countryNoUnderscore = m_country.ToString().Replace("_", " ");

            string strOut = String.Format("{0, 20}{1, 7}{2, 6}{3, 8}", m_street.Trim(), m_zipCode.Trim(), m_city.Trim(), m_countryNoUnderscore.Trim());

            return strOut;
        }

    }//end class
}//end namespaces
