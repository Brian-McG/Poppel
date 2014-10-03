using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poppel.Domain
{
    abstract class Person
    {
        private string name;
        private string surname;
        private string id;
        private string cellNumber;
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
        public string CellNumber
        {
            get
            {
                return cellNumber;
            }
            set
            {
                cellNumber = value;
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
