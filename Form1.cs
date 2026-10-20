using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '●';
            chkShowPassword.Checked = false;

            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        }

   
        private void chkShowPassword_CheckedChanged(
            object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your email and password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string displayName = "";
            if (email.Equals(
                    "admin@attendance.com",
                    StringComparison.OrdinalIgnoreCase)
                && password == "admin12345")
            {
                displayName = "Administrator";
            }
            else
            {
           
                string accountFile = System.IO.Path.Combine(
                    Application.UserAppDataPath,
                    "accounts.txt");

                if (System.IO.File.Exists(accountFile))
                {
                    string[] accounts =
                        System.IO.File.ReadAllLines(accountFile);

                    foreach (string account in accounts)
                    {
                        string[] details = account.Split('|');

                        if (details.Length >= 3 &&
                            details[1].Trim().Equals(
                                email,
                                StringComparison.OrdinalIgnoreCase) &&
                            details[2] == password)
                        {
                            displayName = details[0];
                            break;
                        }
                    }
                }
            }

            if (displayName != "")
            {
                MessageBox.Show(
                    "Welcome, " + displayName + "!",
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Form3 dashboard = new Form3();
                dashboard.SetAdminName(displayName);
                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid email or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void lnkSwitchLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 createAccount = new Form2();
            createAccount.Show();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 forgotPassword = new Form4();
            forgotPassword.ShowDialog();
        }
    }
}
