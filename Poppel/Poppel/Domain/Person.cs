//Brian Mc George
//MCGBRI004
//03-10-2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poppel.Domain
{
    public abstract class Person
    {
        private string name;
        private string surname;
        private string id;
        private string phoneNumber;
        private string email;
        private string[] address;

        #region Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string[] Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        #endregion

        #region Utility
        /// <summary>
        /// Converts address array to a string.
        /// </summary>
        /// <returns>String representing the address.</returns>
        public string addressToString()
        {
            if (address == null)
            {
                return null;
            }
            string tempAddress = "";
            for (int i = 0; i < address.Length; i++)
            {
                tempAddress += address[i];
            }
            return tempAddress;
        }

        public static string phoneNumberFormatter(string number)
        {
            if (number == null || number.Length != 10)
            {
                return null;
            }
            return "("+number.Substring(0,3)+") "+number.Substring(3,3)+"-"+number.Substring(6);
        }
        public static string unFormatPhoneNumber(string number)
        {
            if(number==null || number.Length!=14)
            {
                return null;
            }
            return number.Substring(1, 3) + number.Substring(6, 3) + number.Substring(10, 4);
        }

        /// <summary>
        /// Converts name and surname to a single string.
        /// </summary>
        /// <returns>String representing the name and surname.</returns>
        public string nameSurnameToString()
        {
            return name + " " + surname; 
        }
        #endregion
    }
}
