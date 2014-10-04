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

        }
    }
}
