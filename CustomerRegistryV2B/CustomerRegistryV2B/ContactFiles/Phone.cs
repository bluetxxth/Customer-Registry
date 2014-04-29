
//
//Class Phone takes care of the Phone features such as Cell phone and home phone
//Gabriel Nieva M12K2712
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerRegistryV2B
{
    public class Phone
    {
        //instance fields
        private string m_home;
        private string m_other;
        private string m_work;




        /// <summary>
        /// Constrductor default
        /// </summary>
        public Phone()
        {

        }

        /// <summary>
        /// Constructor overloaded
        /// </summary>
        /// <param name="homePhone"></param>
        /// <param name="workPhone"></param>
        public Phone(string homePhone, string workPhone)
        {

            DefaultValues();

        }



        /// <summary>
        /// Method initializes the three instance variables 
        /// by assigning them to string empty
        /// </summary>
        public void DefaultValues()
        {

            this.m_home = String.Empty;
            this.m_other = String.Empty;
            this.m_work = String.Empty;

        }


        /// <summary>
        /// Property provides get and set for m_home
        /// </summary>
        public string Home
        {
            get { return m_home; }

            set { m_home = value; }
        }


        /// <summary>
        /// Property provides get and set for m_other
        /// </summary>
        public string Other
        {
            get { return m_other; }
            set { m_other = value; }
        }


        /// <summary>
        /// Property provides get and set for m_work
        /// </summary>
        public string Work
        {
            get { return m_work; }
            set { m_work = value; }

        }



        /// <summary>
        /// Method checks the data
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {

            if (m_home == null)
            {
                return false;

            }
            else if (m_work == null)
            {
                return false;

            }
            else if (m_other == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        /// <summary>
        /// Method returns a formated string with the output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            string strOut = string.Format("{0, 23} {1, 0} {2, 1}", m_home.Trim(), m_other, m_work.Trim());
            return strOut;

        }





    }
}
