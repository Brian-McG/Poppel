//Brian Mc George
//MCGBRI004
//04-10-2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poppel.CustomerMangement;
using Poppel.Domain;

namespace Poppel.PresentationLayer
{
    public partial class CustomerManagement : Form
    {
        private CustomerManangementController customerManagementController;
        private editCustomer editButtonState;

        public enum radioButtonSelected
        {
            customerNumber = 0,
            phoneNumber = 1
        }
        public enum editCustomer
        {
            editCustomer = 0,
            saveCustomer = 1
        }

        #region Constructors
        public CustomerManagement()
        {
            InitializeComponent();
            customerManagementController = new CustomerManangementController();
            inputTextBox.Select();
            editButtonState = editCustomer.editCustomer;

        }
        #endregion

        #region ButtonClickEvents
        private void searchButton_Click(object sender, EventArgs e)
        {
            userNotFoundErrorLabel.Visible = false;
            setLabelVisibility(false);
            setButtonState(editCustomer.editCustomer);
            if (customerNumberRadioButton.Checked)
            {
                Customer searchCustomer = customerManagementController.searchCustomerByCustomerNumber(inputTextBox.Text.ToLower());
                if (searchCustomer == null)
                {
                    userNotFoundErrorLabel.Text = "The customer entered does not exist.";
                    userNotFoundErrorLabel.Visible = true;
                    editCustomerButton.Enabled = false;

                    creditGroupBox.Visible = false;
                    personalDetailsGroupBox.Visible = false;
                    addressGroupBox.Visible = false;
                }
                else
                {
                    firstNameTestBox.Text = searchCustomer.Name;
                    lastNameTextBox.Text = searchCustomer.Surname;
                    phoneNumberMaskBox.Text = searchCustomer.PhoneNumber;
                    emailAddressTextBox.Text = searchCustomer.Email;
                    streetAddressTextBox.Text = searchCustomer.Address[0];
                    suburbTextBox.Text = searchCustomer.Address[1];
                    townTextBox.Text = searchCustomer.Address[2];
                    cityTextBox.Text = searchCustomer.Address[3];
                    zipCodeTextBox.Text = searchCustomer.Address[4];
                    currentCreditTextBox.Text = string.Format("{0:0.00}", searchCustomer.Credit);
                    creditLimitTextBox.Text = string.Format("{0:0.00}", searchCustomer.CreditLimit);

                    creditGroupBox.Visible = true;
                    personalDetailsGroupBox.Visible = true;
                    addressGroupBox.Visible = true;
                    editCustomerButton.Enabled = true;
                }
            }
            else
            {
                customerManagementController.searchCustomerByPhoneNumber(inputTextBox.Text);
            }
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            editErrorLabel.Visible = false;
            if (editButtonState == editCustomer.editCustomer)
            {

                setReadOnly(false);
                setButtonState(editCustomer.saveCustomer);
                firstNameTestBox.Select();
                editCustomerButton.Text = "Save Customer";

            }
            else
            {
                if (isCustomerDetailsValid())
                {
                    editButtonState = editCustomer.editCustomer;
                    editCustomerButton.Text = "Edit Customer";
                    setReadOnly(true);
                    Customer customer = new Customer();
                    if (createCustomer(customer))
                    {
                        customerManagementController.editCustomer(customer);
                    }
                }
                else
                {
                    editErrorLabel.Text = "Customer Details count not be saved.\nFormat errors in customer details found.";
                    editErrorLabel.Visible = true;
                }


            }

        }
        #endregion

        #region Utility
        private bool createCustomer(Customer customer)
        {
            Boolean correct = true;
            customer.Id = inputTextBox.Text.Trim();
            customer.Name = firstNameTestBox.Text.Trim();
            customer.Surname = lastNameTextBox.Text.Trim();
            customer.PhoneNumber = Person.unFormatPhoneNumber(phoneNumberMaskBox.Text);
            customer.Email = emailAddressTextBox.Text;
            decimal temp = -1;
            Decimal.TryParse(currentCreditTextBox.Text.Trim(), out temp);
            if (temp == -1)
            {
                editErrorLabel.Text = "An error occured converting credit.";
                editErrorLabel.Visible = true;
                correct = false;
                
            }
            else
            {
                customer.Credit = temp;
            }
            temp = -1;
            Decimal.TryParse(creditLimitTextBox.Text.Trim(), out temp);
            if (temp == -1)
            {
                editErrorLabel.Text = "An error occured converting credit limit.\nCheck credit limit format is correct.";
                editErrorLabel.Visible = true;
                correct = false;
            }
            else
            {
                customer.CreditLimit = temp;
            }

            string[] address = new string[Person.ADDRESS_LENGTH];
            address[0] = streetAddressTextBox.Text.Trim();
            address[1] = suburbTextBox.Text.Trim();
            address[2] = townTextBox.Text.Trim();
            address[3] = cityTextBox.Text.Trim();
            address[4] = zipCodeTextBox.Text.Trim();

            customer.Address = address;
            return correct;
        }

        private void setButtonState(editCustomer state)
        {
            if (state == editCustomer.editCustomer)
            {
                editCustomerButton.Text = "Edit Customer";
                editButtonState = editCustomer.editCustomer;
            }
            else if (state == editCustomer.saveCustomer)
            {
                editCustomerButton.Text = "Save Customer";
                editButtonState = editCustomer.saveCustomer;
            }

        }


        private bool isCustomerDetailsValid()
        {
            if (firstNameErrorMessageLabel.Visible || lastNameErrorMessageLabel.Visible || phoneErrorLabel.Visible || emailErrorMessageLabel.Visible || creditLimitErrorLabel.Visible || zipCodeErrorMessageLabel.Visible || streetErrorMessageLabel.Visible || suburbErrorMessageLabel.Visible || townErrorMessageLabel.Visible)
            {
                return false;
            }
            return true;

        }

        private void setLabelVisibility(bool visible)
        {
            firstNameErrorMessageLabel.Visible = visible;
            lastNameErrorMessageLabel.Visible = visible;
            phoneErrorLabel.Visible = visible;
            emailErrorMessageLabel.Visible = visible;
            creditLimitErrorLabel.Visible = visible;
            zipCodeErrorMessageLabel.Visible = visible;
            streetErrorMessageLabel.Visible = visible;
            suburbErrorMessageLabel.Visible = visible;
            townErrorMessageLabel.Visible = visible;
            cityErrorMessageLabel.Visible = visible;
        }

        private void setReadOnly(bool set)
        {
            firstNameTestBox.ReadOnly = set;
            lastNameTextBox.ReadOnly = set;
            phoneNumberMaskBox.ReadOnly = set;
            emailAddressTextBox.ReadOnly = set;
            streetAddressTextBox.ReadOnly = set;
            suburbTextBox.ReadOnly = set;
            townTextBox.ReadOnly = set;
            cityTextBox.ReadOnly = set;
            zipCodeTextBox.ReadOnly = set;
            creditLimitTextBox.ReadOnly = set;
        }
        #endregion

        #region RadioButtonClick
        private void customerNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (customerNumberRadioButton.Checked)
            {
                inputTextBox.Text = null;
                formatLabel.Text = "Example Customer Code: XYZRTZ001";
                inputTextBox.Mask = "LLLLLL000";
            }
        }

        private void telephoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (telephoneRadioButton.Checked)
            {
                inputTextBox.Text = null;
                formatLabel.Text = "Example Telephone number: (021) 555-5555";
                inputTextBox.Mask = "(999) 000-0000";
            }
        }
        #endregion

        #region Validation
        private void firstNameTestBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                firstNameErrorMessageLabel.Text = "Numbers are not allowed in a name.";
                firstNameErrorMessageLabel.Visible = true;
            }
            else if (firstNameTestBox.Text.Length >= 60 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                firstNameErrorMessageLabel.Text = "Name length has been exceeded.\nNames can only be up to 60 characters.";
                firstNameErrorMessageLabel.Visible = true;
            }
            else
            {
                firstNameErrorMessageLabel.Visible = false;
            }
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                lastNameErrorMessageLabel.Text = "Numbers are not allowed in a name.";
                lastNameErrorMessageLabel.Visible = true;
            }
            else if (lastNameTextBox.Text.Length >= 60 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lastNameErrorMessageLabel.Text = "Name length has been exceeded.\nNames can only be up to 60 characters.";
                lastNameErrorMessageLabel.Visible = true;
            }
            else
            {
                lastNameErrorMessageLabel.Visible = false;
            }
        }


        private void phoneNumberMaskBox_Leave(object sender, EventArgs e)
        {

            if (phoneNumberMaskBox.Text != "(   )    -" && Person.unFormatPhoneNumber(phoneNumberMaskBox.Text) == null)
            {
                Console.WriteLine(phoneNumberMaskBox.Text);
                phoneErrorLabel.Text = "Phone number must contain 10 digits.";
                phoneErrorLabel.Visible = true;
            }
            else
            {
                phoneErrorLabel.Visible = false;
            }
        }

        private void emailAddressTextBox_Leave(object sender, EventArgs e)
        {
            //http://www.codeproject.com/Questions/447172/Email-Mask-for-csharp-masktextbox
            //Checks if email address is in correct format.
            if (!System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                emailErrorMessageLabel.Text = "Email address should be in the format:\nxyz@abc.com";
                emailErrorMessageLabel.Visible = true;
            }
            else
            {
                emailErrorMessageLabel.Visible = false;
            }
        }

        private void firstNameTestBox_Leave(object sender, EventArgs e)
        {
            int i = 0;
            bool stop = false;

            if (firstNameTestBox.Text.Length >= 60)
            {
                firstNameErrorMessageLabel.Text = "Name length has been exceeded.\nNames can only be up to 60 characters.";
                firstNameErrorMessageLabel.Visible = true;
                stop = true;
            }
            while (i < firstNameTestBox.Text.Length && !stop)
            {
                if (char.IsNumber(firstNameTestBox.Text[i]))
                {
                    firstNameErrorMessageLabel.Text = "Numbers are not allowed in a name.";
                    firstNameErrorMessageLabel.Visible = true;
                    stop = true;
                }
                i++;
            }
            if (!stop)
            {
                firstNameErrorMessageLabel.Visible = false;
            }
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            int i = 0;
            bool stop = false;

            if (lastNameTextBox.Text.Length >= 60)
            {
                lastNameErrorMessageLabel.Text = "Name length has been exceeded.\nNames can only be up to 60 characters.";
                lastNameErrorMessageLabel.Visible = true;
                stop = true;
            }
            while (i < lastNameTextBox.Text.Length && !stop)
            {
                if (char.IsNumber(lastNameTextBox.Text[i]))
                {
                    lastNameErrorMessageLabel.Text = "Numbers are not allowed in a name.";
                    lastNameErrorMessageLabel.Visible = true;
                    stop = true;
                }
                i++;
            }
            if (!stop)
            {
                lastNameErrorMessageLabel.Visible = false;
            }
        }

        private void creditLimitTextBox_Leave(object sender, EventArgs e)
        {
            int i = 0;
            bool stop = false;
            int dotIndex = creditLimitTextBox.Text.IndexOf(".");
            if (dotIndex == -1 && creditLimitTextBox.Text.Length > 8)
            {
                creditLimitErrorLabel.Text = "Credit limit can only be up to 8 digits.";
                creditLimitErrorLabel.Visible = true;
                stop = true;
            }
            else if (dotIndex != -1 && creditLimitTextBox.Text.Length > 10)
            {
                creditLimitErrorLabel.Text = "Credit limit can only be up to 8 digits.";
                creditLimitErrorLabel.Visible = true;
                stop = true;
            }
            while (i < creditLimitTextBox.Text.Length && !stop)
            {
                if (!char.IsControl(creditLimitTextBox.Text[i]) && !char.IsDigit(creditLimitTextBox.Text[i]) && creditLimitTextBox.Text[i] != '.')
                {
                    creditLimitErrorLabel.Text = "Only numbers and a '.' allowed.";
                    creditLimitErrorLabel.Visible = true;
                    stop = true;
                }


                i++;
            }

            if (creditLimitTextBox.Text.IndexOf(".") != creditLimitTextBox.Text.LastIndexOf(".") && !stop)
            {
                creditLimitErrorLabel.Text = "Only one '.' allowed.";
                creditLimitErrorLabel.Visible = true;
                stop = true;
            }
            else if (dotIndex != -1 && creditLimitTextBox.Text.Substring(dotIndex).Length > 3 && !stop)
            {
                creditLimitErrorLabel.Text = "Only two decimal places allowed.";
                creditLimitErrorLabel.Visible = true;
                stop = true;
            }

            if (!stop)
            {
                creditLimitErrorLabel.Visible = false;
            }
        }

        private void creditLimitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            int index = (sender as TextBox).Text.IndexOf('.');
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                creditLimitErrorLabel.Text = "Only numbers and a '.' allowed.";
                creditLimitErrorLabel.Visible = true;
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && index > -1)
            {
                creditLimitErrorLabel.Text = "Only one '.' allowed.";
                creditLimitErrorLabel.Visible = true;
                e.Handled = true;
            }
            else if (index != -1 && creditLimitTextBox.SelectionStart > index && creditLimitTextBox.Text.Substring(index).Length >= 3 && !char.IsControl(e.KeyChar))
            {

                int test = creditLimitTextBox.Text.Substring(index).Length;
                string test2 = creditLimitTextBox.Text.Substring(index);
                creditLimitErrorLabel.Text = "Only two decimal places allowed.";
                creditLimitErrorLabel.Visible = true;
                e.Handled = true;
            }
            else if (index == -1 && creditLimitTextBox.Text.Length > 8 && !char.IsControl(e.KeyChar))
            {
                creditLimitErrorLabel.Text = "Name length has been exceeded.\nCredit limit can only be up to 8 digits.";
                creditLimitErrorLabel.Visible = true;
                e.Handled = true;
            }
            else if (index != -1 && creditLimitTextBox.Text.Length > 10 && !char.IsControl(e.KeyChar))
            {
                creditLimitErrorLabel.Text = "Name length has been exceeded.\nCredit limit can only be up to 8 digits.";
                creditLimitErrorLabel.Visible = true;
                e.Handled = true;
            }
            else
            {
                creditLimitErrorLabel.Visible = false;
            }

        }
        private void zipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (zipCodeTextBox.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                zipCodeErrorMessageLabel.Text = "Zip code can only be up to 5 digits.";
                zipCodeErrorMessageLabel.Visible = true;
                e.Handled = true;
            }

            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                zipCodeErrorMessageLabel.Text = "Only numbers allowed.";
                zipCodeErrorMessageLabel.Visible = true;
                e.Handled = true;
            }
            else
            {
                zipCodeErrorMessageLabel.Visible = false;
            }

        }

        private void zipCodeTextBox_Leave(object sender, EventArgs e)
        {
            bool stop = false;
            int i = 0;
            if (zipCodeTextBox.Text.Length > 5)
            {
                zipCodeErrorMessageLabel.Text = "Zip code can only be up to 5 digits.";
                zipCodeErrorMessageLabel.Visible = true;
                stop = true;
            }
            while (i < zipCodeTextBox.Text.Length && !stop)
            {
                if (!char.IsDigit(zipCodeTextBox.Text[i]))
                {

                    zipCodeErrorMessageLabel.Text = "Only numbers allowed.";
                    zipCodeErrorMessageLabel.Visible = true;
                    stop = true;
                }
                i++;
            }

            if (!stop)
            {
                zipCodeErrorMessageLabel.Visible = false;
            }


        }


        #endregion




    }
}
