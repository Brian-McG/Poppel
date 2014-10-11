using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poppel.Database;
using Poppel.Domain;

namespace Poppel.Login
{
    public class LoginController
    {
        PoppelDatabase database = new PoppelDatabase();

        public Employee login(string username, string password)
        {
            return database.login(username, password);
        }
    }
}
