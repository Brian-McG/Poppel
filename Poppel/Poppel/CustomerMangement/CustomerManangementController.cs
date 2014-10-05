using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poppel.PresentationLayer;
using Poppel.Domain;
using Poppel.Database;

namespace Poppel.CustomerMangement
{
    public class CustomerManangementController
    {
        PoppelDatabase database = new PoppelDatabase();
        public Customer searchCustomerByCustomerNumber(string id)
        {
            return database.readCustomersByCustomerNumber(id);
        }

        public Collection<Customer> searchCustomerByPhoneNumber(string telephoneNumber)
        {
            return database.readCustomersByTelephoneNumber(Person.unFormatPhoneNumber(telephoneNumber));
        }

        public void editCustomer(Customer customer)
        {
            database.editCustomer(customer);
        }
        public void addCustomer(Customer customer)
        {
            database.addCustomer(customer);
        }

        public string generateId(string name, string surname)
        {
            bool generated = false;
            string customerCode = name.Substring(0, 3) + "" + surname.Substring(0, 3);
            int number = 0;
            while(!generated)
            {
                number++;
                if(number==1000)
                {
                    return null;
                }
                string testCode = "" + number;
                for (int i = 0; i <= 3 - testCode.Length; i++)
                {
                    testCode = "0" + testCode;
                }
                testCode = customerCode +""+ testCode;
               testCode = testCode.ToLower();
                if(!database.doesKeyExist(testCode))
                {
                    generated = true;
                    customerCode = testCode;
                }
            }
            return customerCode;



        }


    }
}
