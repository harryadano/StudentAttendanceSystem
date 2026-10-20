using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            lblResult.Text = "Your password will appear here.";
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Please enter your registered email.",
                    "Missing Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            
            if (email.Equals(
                "admin@attendance.com",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Username: Administrator\n" +
                    "Email: admin@attendance.com\n" +
                    "Password: admin123\n" +
                    "Role: Admin",
                    "Account Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

         
            string accountFile = Path.Combine(
                Application.UserAppDataPath,
                "accounts.txt");

            if (!File.Exists(accountFile))
            {
                MessageBox.Show(
                    "No registered account file was found.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            try
            {
                string[] accounts = File.ReadAllLines(accountFile);

                foreach (string account in accounts)
                {
                    string[] details = account.Split('|');

                
                    if (details.Length >= 3 &&
                        details[1].Equals(
                            email,
                            StringComparison.OrdinalIgnoreCase))
                    {
                        string username = details[0];
                        string password = details[2];
                        string role = details.Length >= 4
                            ? details[3]
                            : "Not specified";

                        MessageBox.Show(
                            "Username: " + username + "\n" +
                            "Email: " + details[1] + "\n" +
                            "Password: " + password + "\n" +
                            "Role: " + role,
                            "Account Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return;
                    }
                }

                MessageBox.Show(
                    "No account found with that email.",
                    "Account Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "Unable to read the account file.",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "You do not have permission to access the account file.",
                    "Access Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }
    }
}
