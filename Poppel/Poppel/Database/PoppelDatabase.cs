//Brian Mc George
//MCGBRI004
//04-10-2014

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

//namespaces
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using Poppel.Domain;


namespace Poppel.Database
{
    public class PoppelDatabase : Database
    {
        /// <summary>
        /// Reads customers from database with argument telephone number.
        /// </summary>
        /// <param name="telephoneNumber">telephone number to check against</param>
        /// <returns>collection of customers with specified telephone number</returns>
        public Collection<Customer> readCustomersByTelephoneNumber(string telephoneNumber)
        {
            Collection<Customer> customers = new Collection<Customer>();
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                command = new SqlCommand("SELECT * FROM Customer WHERE customer_telephoneNumber = " + telephoneNumber, cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        customers.Add(createCustomer(reader));             //add to the collection
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return customers;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Reads customers from database with argument customer number.
        /// </summary>
        /// <param name="id">customer number to check against.</param>
        /// <returns>Customer with specified customer number.</returns>
        public Customer readCustomersByCustomerNumber(string id)
        {
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                Customer customer = null;
                command = new SqlCommand("SELECT * FROM Customer WHERE customer_id = '" + id + "'", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        customer = createCustomer(reader);
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return customer;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return null;
            }
        }
        public void editCustomer(Customer customer)
        {
            string sqlString = "";
            sqlString = "Update Customer Set customer_name = '" + customer.Name.Trim() + "',customer_surname = '" + customer.Surname.Trim() + "',customer_telephoneNumber = '" + customer.PhoneNumber.Trim() + "',customer_email = '" + customer.Email.Trim() + "',customer_credit = " + customer.Credit.ToString() + ",customer_creditLimit = " + customer.CreditLimit.ToString() + ",customer_street = '" + customer.Address[0].Trim() + "',customer_suburb = '" + customer.Address[1] + "',customer_town = '" + customer.Address[2] + "',customer_city = '" + customer.Address[3] + "',customer_zipCode = '" + customer.Address[4] + "' WHERE (customer_id = '" + customer.Id.Trim() + "')";

            UpdateDataSource(new SqlCommand(sqlString, cnMain));
        }

        /// <summary>
        /// Create customer from argument reader.
        /// </summary>
        /// <param name="reader">reads data from database</param>
        private Customer createCustomer(SqlDataReader reader)
        {

            Customer customer = new Customer();
            customer.Id = reader.GetString(0).Trim();
            customer.Name = reader.GetString(1).Trim();
            customer.Surname = reader.GetString(2).Trim();
            customer.PhoneNumber = reader.GetString(3).Trim();
            customer.Email = reader.GetString(4).Trim();
            customer.Credit = reader.GetDecimal(5);
            customer.CreditLimit = reader.GetDecimal(6);
            string[] address = new string[5];
            address[0] = reader.GetString(7).Trim();
            address[1] = reader.GetString(8).Trim();
            address[2] = reader.GetString(9).Trim();
            address[3] = reader.GetString(10).Trim();
            address[4] = reader.GetString(11).Trim();
            for (int i = 0; i < address.Length;i++ )
            {
                if(address[i]==null)
                {
                    address[i] = "";
                }
            }
                customer.Address = address;
            return customer;


        }


        /*
        //Constructors
        public EmployeeDB()
            : base()
        {
            ReadDataFromTable(sql_SELECT1, table1);   //Get the data from ALL 3 tables
            //same for other two Tables 
            ReadDataFromTable(sql_SELECT2, table2);
            ReadDataFromTable(sql_SELECT3, table3);
        }

        public Collection<Employee> AllEmployees
        {
            get
            {
                return employees;
            }
        }

        #region Data reader

        private string ReadDataFromTable(string selectString, string table)
        {
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                command = new SqlCommand(selectString, cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    // Call the FillEmployeeByRole method see step 2.4
                    FillEmployeesByRole(reader, table, employees);       //Fill the collection – 
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return "success";
            }
            catch (Exception ex)
            {
                cnMain.Close();
                return (ex.ToString());

            }
        }

        private Role GetRoleInfo(SqlDataReader reader, Employee anEmp)
        {
            //to "see" specialised   functionality of a Role – refer VIA correct class
            Waitron waitron;
            Runner runner;
            HeadWaitron headWaitron;
            switch (anEmp.Role.roleDescription)
            {
                case Role.RoleType.HeadWaitron:
                    headWaitron = (HeadWaitron)(anEmp.Role);
                    headWaitron.Salary = reader.GetDecimal(4);  //See Retrieving Data 
                    return headWaitron;
                //Do the same for the other roles
                case Role.RoleType.Waitron:
                    waitron = (Waitron)(anEmp.Role);
                    waitron.Rate = reader.GetDecimal(4);
                    waitron.NumberOfShifts = reader.GetInt32(5);
                    return waitron;
                case Role.RoleType.Runner:
                    runner = (Runner)(anEmp.Role);
                    runner.Rate = reader.GetDecimal(4);
                    runner.NumberOfShifts = reader.GetInt32(5);
                    return runner;
                default:
                    return null;
            }
        }

        private void FillEmployeesByRole(SqlDataReader reader, string dataTable,
                                                                      Collection<Employee> employees)
        {
            Employee employee;
            Role.RoleType employeeRole = Role.RoleType.NoRole;

            switch (dataTable)                                //Determine the role from table name
            {
                case "HeadWaitron":
                    employeeRole = Role.RoleType.HeadWaitron;
                    break;
                //same for other two roles & the default Role
                case "Waitron":
                    employeeRole = Role.RoleType.Waitron;
                    break;
                case "Runner":
                    employeeRole = Role.RoleType.Runner;
                    break;
                default:
                    employeeRole = Role.RoleType.NoRole;
                    break;
            }
            while (reader.Read())                          //While you still have stuff to read
            {
                employee = new Employee((byte)employeeRole);
                //Same for EmpID, Name  & Phone, all strings with indices 1, 2, & 3 respectively
                employee.ID = reader.GetString(0).Trim();
                employee.EmpID = reader.GetString(1).Trim();
                employee.Name = reader.GetString(2).Trim();
                employee.Phone = reader.GetString(3).Trim();
                //call the GetRoleInfo method to obtain role specific data from the database
                employee.Role = GetRoleInfo(reader, employee);
                employees.Add(employee);             //add to the collection
            }
        }

        #endregion

        #region Database Operations --- Add, Edit & Delete
        public void DatabaseAdd(Employee TempEmp)
        {
            string strSQL = "";

            //Build SQL string for the command

            switch (TempEmp.Role.roleDescription)
            {
                case Role.RoleType.HeadWaitron:
                    strSQL = "INSERT into HeadWaitron(ID, EmpID, Name, Phone, Salary)" +
                         "VALUES ('" + GetValueString(TempEmp) + ")";
                    break;
                case Role.RoleType.Waitron:
                    strSQL = "INSERT into Waitron(ID, EmpID, Name, Phone, Rate, Shifts)" +
                                          "VALUES ('" + GetValueString(TempEmp) + ")";
                    break;
                case Role.RoleType.Runner:
                    strSQL = "INSERT into Runner(ID, EmpID, Name, Phone, Rate, Shifts)" +
                                                         "VALUES ('" + GetValueString(TempEmp) + ")";
                    break;
            }

            //Create & execute the insert command 
            UpdateDataSource(new SqlCommand(strSQL, cnMain));
        }


        public void DatabaseEdit(Employee tempEmp)
        {
            string sqlString = "";
            HeadWaitron headWaitron;
            Waitron waitron;
            Runner runner;
            //Build SQL string for the Update command

            switch (tempEmp.Role.roleDescription)
            {
                case Role.RoleType.HeadWaitron:
                    headWaitron = (HeadWaitron)tempEmp.Role;
                    sqlString = "Update HeadWaitron Set Name = '" + tempEmp.Name.Trim() + "'," +
                              "Phone = '" + tempEmp.Phone.Trim() + "'," +
                              "Salary =" + headWaitron.Salary.ToString() + " " +
                              "WHERE (ID = '" + tempEmp.ID.Trim() + "')";
                    break;
                case Role.RoleType.Waitron:
                    waitron = (Waitron)tempEmp.Role;
                    sqlString = "Update Waitron Set Name = '" + tempEmp.Name.Trim() + "'," +
                             "Phone = '" + tempEmp.Phone.Trim() + "'," +
                             "Rate =" + waitron.Rate.ToString() + ", " +
                             "Shifts =" + waitron.NumberOfShifts.ToString() + " " +
                             "WHERE (ID = '" + tempEmp.ID.Trim() + "')";
                    break;
                case Role.RoleType.Runner:
                    runner = (Runner)tempEmp.Role;
                    sqlString = "Update Waitron Set Name = '" + tempEmp.Name.Trim() + "'," +
                             "Phone = '" + tempEmp.Phone.Trim() + "'," +
                             "Rate =" + runner.Rate.ToString() + " ," +
                             "Shifts =" + runner.NumberOfShifts.ToString() + " " +
                             "WHERE (ID = '" + tempEmp.ID.Trim() + "')";
                    break;
            }
            //Create & execute the update command 
            UpdateDataSource(new SqlCommand(sqlString, cnMain));
        }
        public bool DatabaseDelete(Employee employee)
        {
            string SQLstring = "";
            bool success = false;
            //Build SQL string for the DELETE command
            switch (employee.Role.roleDescription)
            {
                case Role.RoleType.HeadWaitron:
                    SQLstring = "DELETE FROM  HeadWaitron WHERE ID = '" + employee.ID + "'";
                    break;
                case Role.RoleType.Waitron:
                    SQLstring = "DELETE FROM  Waitron WHERE ID = '" + employee.ID + "'";
                    break;
                case Role.RoleType.Runner:
                    SQLstring = "DELETE FROM  Runner WHERE ID = '" + employee.ID + "'";
                    break;
            }
            //Update database by executing new SQL statement--customer table
            success = UpdateDataSource(new SqlCommand(SQLstring, cnMain));
            return true;
        }

        private string GetValueString(Employee TempEmp)
        {
            string aStr;
            decimal pay = 0;
            string additional = "";

            HeadWaitron headW;
            Waitron waitron;
            Runner runner;

            switch (TempEmp.Role.roleDescription)
            {
                case Role.RoleType.HeadWaitron:
                    headW = (HeadWaitron)(TempEmp.Role);
                    pay = headW.Salary;
                    break;
                case Role.RoleType.Waitron:
                    waitron = (Waitron)(TempEmp.Role);
                    pay = waitron.Rate;
                    additional = "," + waitron.NumberOfShifts.ToString();
                    break;
                case Role.RoleType.Runner:
                    runner = (Runner)(TempEmp.Role);
                    pay = runner.Rate;
                    additional = "," + runner.NumberOfShifts.ToString();
                    break;
            }

            aStr = TempEmp.ID + "' , '" + TempEmp.EmpID + "' ," +
                  "'" + TempEmp.Name + "' ," +
                  " '" + (TempEmp.Phone).Trim() + "' , " +
                                   Convert.ToString(pay) + additional;

            return aStr;
        }

        #endregion
           */
    }

}
