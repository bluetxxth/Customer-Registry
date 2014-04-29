
//
//Class Email takes care of the email features such as work mail and home mail.
//Gabriel Nieva M12K2712
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerRegistryV2B
{
    public class Email
    {

        //instance fields
        private string m_personal;
        private string m_work;



        /// <summary>
        /// Constructor1 default
        /// </summary>
        public Email()
        {


        }

        /// <summary>
        ///Constructor2 overloaded the constructor with one parameter 
        ///calls the constructor with two parameter trough an initialization with a default 
        ///value on the second parameter.
        ///list 
        /// </summary>
        /// <param name="workMail"></param>
        public Email(string workMail)
            : this(workMail, string.Empty)
        {


        }

        /// <summary>
        /// Constructor3 overloaded. This is the construcor with the largest
        /// number of parameters (2 parameters). All coding should be done here.
        /// </summary>
        /// <param name="workMail"></param>
        /// <param name="personalMail"></param>
        public Email(string workMail, string personalMail)
        {
            this.m_work = workMail;
            this.m_personal = personalMail;
        }



        /// <summary>
        /// Property related to the field m_Personal
        /// Providesboth read and write access
        /// </summary>
        public string Personal
        {

            get { return m_personal; }

            set { m_personal = value; }

        }


        /// <summary>
        /// Property related to the field m_work
        /// provides both read and write access
        /// </summary>
        public string Work
        {

            get { return m_work; }

            set { m_work = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns>A formated string as a heading for the values formatted
        /// in the ToString method below</returns>
        public string GetToStringItemsHeadings
        {

            get
            {
                return string.Format("{0, -20} {1, -20}",
                    "Office Email", "Private Email");
            }

        }


        /// <summary>
        /// Method checks the data
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {

            if (String.IsNullOrEmpty(m_personal))
            {

                return false;

            }
            else if (String.IsNullOrEmpty(m_work))
            {

                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Method ToString overloaded
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Format("{0, 22} {1,12:f2}", m_work.Trim(), m_personal.Trim());

            return strOut;

        }



    }//end class
}//end namespace
