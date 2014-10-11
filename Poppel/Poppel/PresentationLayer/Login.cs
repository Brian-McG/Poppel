using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poppel.Login;
using Poppel.Domain;

namespace Poppel.PresentationLayer
{
    public partial class Login : Form
    {
        private LoginController loginController;
        private bool loginClosed;
        public Login()
        {
            InitializeComponent();
            loginController = new LoginController();
            loginClosed = false;
           
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginErrorLabel.Visible = false;
            Employee employee = loginController.login(usernameTexBox.Text, passwordTextBox.Text);
            if(employee!=null)
            {
                MainForm mainForm = new MainForm(employee);
                
                mainForm.Show();
                loginClosed = true;
                this.Close();
             //  Application.Run();
                
              
               

            }
            else
            {
                loginErrorLabel.Text = "Username or password was incorrect.";
                loginErrorLabel.Visible = true;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!loginClosed)
            {
                Application.Exit();
            }
        }
    }
}
