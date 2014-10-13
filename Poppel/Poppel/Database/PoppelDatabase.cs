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
using Poppel.Order;
using Poppel.Report;
using System.Windows.Forms;


namespace Poppel.Database
{
    public class PoppelDatabase : Database
    {
        private Collection<Category> categories;
        private Collection<StockItem> items;
        public bool doesKeyExist(string id)
        {
            SqlDataReader reader;
            SqlCommand command;
            bool exists = false;
            try
            {
                command = new SqlCommand("SELECT TOP 1 customer_id FROM Customer WHERE customer_id = '" + id + "'", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    exists = true;
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return exists;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return true;
            }

        }

        public void addCustomer(Customer customer)
        {
            string sqlString = "";
            sqlString = "INSERT INTO Customer(customer_id,customer_name,customer_surname,customer_telephoneNumber,customer_email,customer_credit,customer_creditLimit,customer_street,customer_suburb,customer_town,customer_city,customer_zipCode) VALUES ('" + customer.Id.Trim() + "','" + customer.Name.Trim() + "','" + customer.Surname.Trim() + "','" + customer.PhoneNumber.Trim() + "','" + customer.Email.Trim() + "'," + customer.Credit.ToString() + "," + customer.CreditLimit.ToString() + ",'" + customer.Address[0].Trim() + "','" + customer.Address[1] + "','" + customer.Address[2] + "','" + customer.Address[3] + "','" + customer.Address[4] + "')";

            UpdateDataSource(new SqlCommand(sqlString, cnMain));
        }


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
                command = new SqlCommand("SELECT * FROM Customer WHERE customer_telephoneNumber = '" + telephoneNumber + "'", cnMain);
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



        public Collection<OrderItem> readProducts()
        {
            Collection<OrderItem> products = new Collection<OrderItem>();
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                command = new SqlCommand("SELECT * FROM Product", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrderItem orderItem = new OrderItem();
                        orderItem.Product = createProduct(reader);
                        products.Add(orderItem);

                    }


                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                readAlternatives(products);
                readCategories(products);
                foreach (OrderItem product in products)
                {
                    setStockCount(product.Product);
                }

                return products;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return null;
            }



        }

        public Collection<ReportItem> readOrderItem()
        {
            Collection<ReportItem> products = new Collection<ReportItem>();
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                command = new SqlCommand("SELECT * FROM OrderItem", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ReportItem orderItem = new ReportItem();
                        orderItem.productID = reader.GetInt32(1);
                        products.Add(orderItem);
                    }


                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connectio

                return products;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return null;
            }



        }
        
        private void readAlternatives(Collection<OrderItem> products)
        {
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                foreach (OrderItem product in products)
                {
                    command = new SqlCommand("SELECT alternative_product_id FROM Alternatives WHERE product_id=" + product.Product.Id, cnMain);
                    cnMain.Open();             //open the connection
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    //Read from table
                    if (reader.HasRows)
                    {
                        product.Product.Alternatives = new Collection<Product>();
                        while (reader.Read())
                        {
                            OrderItem alternative = OrderController.getProduct(reader.GetInt32(0), products);
                            Product alternativeProduct = alternative.Product;
                            product.Product.Alternatives.Add(alternativeProduct);
                        }
                    }
                    reader.Close();   //close the reader 
                    cnMain.Close();  //close the connection

                }
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
        }

        private void readCategories(Collection<OrderItem> products)
        {
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                if (categories == null)
                {
                    readCategories();
                }
                foreach (OrderItem product in products)
                {
                    command = new SqlCommand("SELECT category_id FROM ProductCategory WHERE product_id=" + product.Product.Id, cnMain);
                    cnMain.Open();             //open the connection
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    //Read from table
                    if (reader.HasRows)
                    {
                        product.Product.Categories = new Collection<Category>();
                        while (reader.Read())
                        {
                            int category_id = reader.GetInt32(0);
                            Boolean added = false;
                            int index = 0;
                            while (!added && index < categories.Count)
                            {
                                if (categories[index].Category_id == category_id)
                                {
                                    product.Product.Categories.Add(categories[index]);
                                    added = true;
                                }
                                index++;
                            }
                        }
                    }
                    reader.Close();   //close the reader 
                    cnMain.Close();  //close the connection

                }
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
        }

        private Product createProduct(SqlDataReader reader)
        {
            Product product = new Product();
            product.Id = reader.GetInt32(0);
            product.Description = reader.GetString(1).Trim();
            product.Price = reader.GetDecimal(2);
            product.ProductCode = reader.GetString(3).Trim();
            return product;
        }


        private void setStockCount(Product product)
        {
            SqlDataReader reader;
            SqlCommand command;
            try
            {
                DateTime check = DateTime.Now.AddMonths(1);
                command = new SqlCommand("SELECT SUM(stockItem_numberInStock) AS number_in_stock FROM StockItem WHERE product_ref = " + product.Id + " AND DATEDIFF(day, '" + check.ToString() + "',stockItem_expityDate) >= 0", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        if (reader.IsDBNull(0))
                        {
                            product.NumberInStock = 0;
                        }
                        else
                        {
                            product.NumberInStock = reader.GetInt32(0);
                        }

                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
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
            if (!reader.IsDBNull(3))
            {
                customer.PhoneNumber = reader.GetString(3).Trim();
            }
            if (!reader.IsDBNull(4))
            {
                customer.Email = reader.GetString(4).Trim();
            }
            customer.Credit = reader.GetDecimal(5);
            customer.CreditLimit = reader.GetDecimal(6);
            string[] address = new string[5];

            if (!reader.IsDBNull(7))
            {
                address[0] = reader.GetString(7).Trim();
            }
            if (!reader.IsDBNull(8))
            {
                address[1] = reader.GetString(8).Trim();
            }
            if (!reader.IsDBNull(9))
            {
                address[2] = reader.GetString(9).Trim();
            }
            if (!reader.IsDBNull(10))
            {
                address[3] = reader.GetString(10).Trim();
            }
            if (!reader.IsDBNull(11))
            {
                address[4] = reader.GetString(11).Trim();
            }
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == null)
                {
                    address[i] = "";
                }
            }
            customer.Address = address;
            return customer;
        }

        public Collection<Category> readCategories()
        {
            SqlDataReader reader;
            SqlCommand command;
            Collection<Category> categories;
            try
            {
                command = new SqlCommand("SELECT * FROM Category", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                categories = new Collection<Category>();
                //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category category = new Category();
                        category.Category_id = reader.GetInt32(0);
                        category.Category_description = reader.GetString(1);
                        categories.Add(category);
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                this.categories = categories;
                return categories;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
            return null;
        }

        public String getOrderNumber(int ID)
        {
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                command = new SqlCommand("SELECT order_id FROM OrderItem WHERE product_id = " + ID + ";", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                int number = 0;
                //Read from table
                if (reader.HasRows)
                {
                    number = reader.GetInt32(0);
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return number + "";
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
            return null;

        }

        public DateTime getOrderDate(String ID)
        {
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                command = new SqlCommand("SELECT order_datePlaced FROM Order WHERE order_id = '" + ID + "';", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                DateTime date = DateTime.Today;
                //Read from table
                if (reader.HasRows)
                {
                    date = reader.GetDateTime(1);
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return date;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
            return DateTime.Today;

        }

        public void removeOrder(String ID)
        {
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                command = new SqlCommand("DELETE FROM Order WHERE order_id = '" + ID + "';", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();

                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }


        }

        public String getRackNumber(int ID)
        {
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                command = new SqlCommand("SELECT stockItem_rackNumber FROM StockItem WHERE product_ref = " + ID + ";", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                int number = 0;
                //Read from table
                if (reader.HasRows)
                {
                    number = reader.GetInt32(4);
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return number + "";
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
            return null;

        }

        public Collection<StockItem> readStock(String Date)
        {
            SqlDataReader reader;
            SqlCommand command;
            Collection<StockItem> items;
            try
            {
                DateTime input;
                DateTime.TryParse(Date, out input);
                command = new SqlCommand("SELECT * FROM StockItem WHERE DATEDIFF(day, stockItem_expityDate,'" + input.ToString() + "') >= 0;", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                items = new Collection<StockItem>();
                //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        StockItem item = new StockItem();
                        item.expiryDate = reader.GetString(1);
                        item.rackNumber = reader.GetString(2);
                        item.numberInStock = reader.GetInt32(3) + "";
                        item.productRef = reader.GetInt32(4) + "";
                        items.Add(item);
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                this.items = items;
                return items;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
            return null;
        }



        public Employee login(string username, string password)
        {

            SqlDataReader reader;
            SqlCommand command;

            try
            {
                Employee employee = null;
                command = new SqlCommand("SELECT * FROM Employee WHERE employee_id = '" + username + "' AND employee_password ='" + password + "'", cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();                        //Read from table
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employee = createEmployee(reader);
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();  //close the connection
                return employee;
            }
            catch (Exception ex)
            {
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
                return null;
            }


        }

        private Employee createEmployee(SqlDataReader reader)
        {

            Employee employee = new Employee();
            employee.Id = reader.GetString(0).Trim();
            employee.Name = reader.GetString(1).Trim();
            employee.Surname = reader.GetString(2).Trim();
            if (!reader.IsDBNull(3))
            {
                employee.PhoneNumber = reader.GetString(3).Trim();
            }
            if (!reader.IsDBNull(4))
            {
                employee.Email = reader.GetString(4).Trim();
            }
            string[] address = new string[5];

            if (!reader.IsDBNull(5))
            {
                address[0] = reader.GetString(5).Trim();
            }
            if (!reader.IsDBNull(6))
            {
                address[1] = reader.GetString(6).Trim();
            }
            if (!reader.IsDBNull(7))
            {
                address[2] = reader.GetString(7).Trim();
            }
            if (!reader.IsDBNull(8))
            {
                address[3] = reader.GetString(8).Trim();
            }
            if (!reader.IsDBNull(9))
            {
                address[4] = reader.GetString(9).Trim();
            }
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == null)
                {
                    address[i] = "";
                }
            }
            employee.Address = address;
            employee.Salary = reader.GetDecimal(11);
            employee.Position = reader.GetString(12);
            return employee;
        }


        public void writeOrder(Poppel.Order.Order order)
        {
            string sqlString = "";
            sqlString = "INSERT INTO [Order](order_datePlaced,customer_id,employee_id) OUTPUT INSERTED.order_id VALUES ('" + order.DateOrderPlaced.ToString() + "','" + order.Customer.Id.Trim() + "','" + order.Employee.Id + "')";
            //'" + order.DateOrderPlaced.ToString() + "',

            SqlDataReader reader;
            SqlCommand command;
            try
            {
                command = new SqlCommand(sqlString, cnMain);
                cnMain.Open();             //open the connection
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                //Read from table
                int id = -1;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }
                reader.Close();   //close the reader 
                cnMain.Close();

                if (id != -1)
                    for (int i = 0; i < order.Products.Count; i++)
                    {
                        sqlString = "INSERT INTO [OrderItem](order_id,product_quantity) OUTPUT INSERTED.orderItem_id VALUES (" + id + "," + order.Products[i].Quantity + ")";
                        cnMain.Open();
                        command = new SqlCommand(sqlString, cnMain);
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                        //Read from table
                        int orderItemId = -1;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                orderItemId = reader.GetInt32(0);
                            }
                        }
                        cnMain.Close();
                        reader.Close();   //close the reader 

                        DateTime check = DateTime.Now;
                        check = check.AddMonths(1);
                        sqlString = "SELECT stockItem_id,stockItem_numberInStock FROM StockItem WHERE DATEDIFF(day, '" + check.ToString() + "',stockItem_expityDate) >= 0 order by convert(datetime, stockItem_expityDate, 103) ASC";
                        command = new SqlCommand(sqlString, cnMain);
                        cnMain.Open();             //open the connection
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                        //Read from table
                        int stockItemID = -1;
                        bool done = false;
                        if (reader.HasRows)
                        {
                            while (reader.Read() && !done)
                            {

                                stockItemID = reader.GetInt32(0);
                                int numInStock = reader.GetInt32(1);
                                int reductionAmount;
                                if (numInStock >= order.Products[i].Quantity)
                                {
                                    done = true;
                                    reductionAmount = order.Products[i].Quantity;
                                }
                                else
                                {
                                    reductionAmount = numInStock;
                                }
                                SqlConnection connection = newConnection();

                                SqlCommand currentCommand = new SqlCommand("INSERT INTO OrderStockItem(orderItem_id,stockItem_id, item_quantity) VALUES(" + orderItemId + "," + stockItemID + "," + reductionAmount + ")", connection);
                                currentCommand.CommandType = CommandType.Text;
                                connection.Open();
                                currentCommand.ExecuteNonQuery();
                                connection.Close();

                                currentCommand = new SqlCommand("Update StockItem Set stockItem_numberInStock = stockItem_numberInStock - " + reductionAmount + "WHERE stockItem_id = " + stockItemID, connection);
                                currentCommand.CommandType = CommandType.Text;
                                connection.Open();
                                currentCommand.ExecuteNonQuery();

                                connection.Close();


                            }
                        }
                        reader.Close();   //close the reader 
                        cnMain.Close();
                    }
                sqlString = "INSERT INTO [Delivery](delivery_startTime,delivery_endTime,order_id) OUTPUT INSERTED.delivery_id VALUES ('" + order.DeliveryDetails.StartDeliveryTime.ToString() + "','" + order.DeliveryDetails.EndDeliveryTime.ToString() + "'," + id + ")";
                cnMain.Open();
                command = new SqlCommand(sqlString, cnMain);
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                //Read from table
                int deliveryId = -1;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        deliveryId = reader.GetInt32(0);
                    }
                }
                cnMain.Close();
                reader.Close();   //close the reader 
                for (int i = 0; i < order.DeliveryDetails.AllowedDeliveryDates.Count; i++)
                {
                    sqlString = "INSERT INTO [DeliveryDate](delivery_id,delivery_date) VALUES (" + deliveryId + ",'" + order.DeliveryDetails.AllowedDeliveryDates[i].ToString() + "')";
                    UpdateDataSource(new SqlCommand(sqlString, cnMain));
                }






                cnMain.Close();  //close the connection

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                //ADD EVENT IF EXCEPTION OCCURS?
                cnMain.Close();
                Console.Write(ex.ToString());
            }
        }

        public void deleteOrder(string orderId)
        {

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
