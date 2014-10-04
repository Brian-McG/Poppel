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
        CustomerManangementController customerManagementController = new CustomerManangementController();
        public editCustomer editButtonState;
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


        public CustomerManagement()
        {
            InitializeComponent();
            inputTextBox.Select();
            editButtonState = editCustomer.editCustomer;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            userNotFoundErrorLabel.Visible=false;
           if(customerNumberRadioButton.Checked)
           {
             Customer searchCustomer =  customerManagementController.searchCustomerByCustomerNumber(inputTextBox.Text.ToLower());     
               if(searchCustomer==null)
               {
                   userNotFoundErrorLabel.Text = "The customer entered does not exist.";
                       userNotFoundErrorLabel.Visible=true;
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
                   cityTextBox.Text = searchCustomer.Address[2];
                   zipCodeTextBox.Text = searchCustomer.Address[3];
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


        /// <summary>
        /// Checks if the customer number in inputTextBox is in correct format.
        /// </summary>
        /// <returns>True if format is correct. Else, returns false.</returns>
        private bool isCustomerNumberValid()
        {
            if(inputTextBox.Text.Length!=9)
            {
                return false;
            }
            else
            {
                string textPart = inputTextBox.Text.Substring(0, 6);
                string numericPart = inputTextBox.Text.Substring(6, 3);

                for(int i=0;i<textPart.Length;i++)
                {
                    if(!char.IsLetter(textPart[i]))
                    {
                        return false;
                    }
                }
                for (int i = 0; i < numericPart.Length; i++)
                {
                    if (!char.IsNumber(numericPart[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        private void customerNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(customerNumberRadioButton.Checked)
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

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            if(editButtonState == editCustomer.editCustomer)
            {
                setReadOnly(false);
                firstNameTestBox.Select();
                editCustomerButton.Text = "Save Customer";
            }
            else
            {
                setReadOnly(true);
                editCustomerButton.Text = "Edit Customer";

            }

        }

        private void setReadOnly(bool set)
        {
            firstNameTestBox.ReadOnly = set;
            lastNameTextBox.ReadOnly = set;
            phoneNumberMaskBox.ReadOnly = set;
            emailAddressTextBox.ReadOnly = set;
            streetAddressTextBox.ReadOnly = set;
            suburbTextBox.ReadOnly = set;
            cityTextBox.ReadOnly = set;
            zipCodeTextBox.ReadOnly = set;
            creditLimitTextBox.ReadOnly = set;
        }
    }
}
