using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form

    {
        public Form3()
        {
            InitializeComponent();

        }
        public void SetAdminName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                AdminName.Text = "Welcome!";
                return;
            }

            string formattedName =
                char.ToUpper(name[0]) + name.Substring(1);

            AdminName.Text = "Welcome, " + formattedName + "!";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }


    }
}
