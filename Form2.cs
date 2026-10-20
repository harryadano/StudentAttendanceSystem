using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();  
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Teacher");

            
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.SelectedIndex = -1;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please fill in all fields, including Role.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        
            try
            {
                MailAddress emailAddress = new MailAddress(email);

                if (emailAddress.Address != email)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter a valid email, e.g. admin04@gmail.com.",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            
            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            
            if (password.Length < 6)
            {
                MessageBox.Show(
                    "Weak password. Password must be at least 6 characters.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string role = cmbRole.SelectedItem.ToString();

            
            string accountFile = Path.Combine(
                Application.UserAppDataPath,
                "accounts.txt");

            try
            {
                Directory.CreateDirectory(Application.UserAppDataPath);

                string[] accounts = File.Exists(accountFile)
                    ? File.ReadAllLines(accountFile)
                    : new string[0];

         
                foreach (string account in accounts)
                {
                    string[] details = account.Split('|');

                    if (details.Length >= 3 &&
                        (details[0].Equals(
                            username,
                            StringComparison.OrdinalIgnoreCase) ||
                         details[1].Equals(
                            email,
                            StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show(
                            "Username or email already exists.",
                            "Duplicate Account",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }

            
                File.AppendAllText(
                    accountFile,
                    username + "|" + email + "|" +
                    password + "|" + role +
                    Environment.NewLine);

                MessageBox.Show(
                    "Account created successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

     
                txtUsername.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                cmbRole.SelectedIndex = -1;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "You do not have permission to save the account.",
                    "Access Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "Unable to save the account. Please try again.",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        

        private void lnkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
