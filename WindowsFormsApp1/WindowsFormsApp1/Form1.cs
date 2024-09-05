using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private User _userManager;

        public Form1()
        {
            InitializeComponent();
            _userManager = new User();
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\Andre Victoria\\Documents\\OOP_AS2\\OOP_AS2_Andre_Victoria\\WindowsFormsApp1\\WindowsFormsApp1\\users.json");
            _userManager.LoadUsersFromJson(jsonFilePath);
            button1.Click += new EventHandler(btnLogin_Click);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = textUsername.Text;
            var password = textPassword.Text;

            if (_userManager.IsValid(username, password))
            {
                labelMessage.Text = "Login successful!";
                labelMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelMessage.Text = "Invalid username or password.";
                labelMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}