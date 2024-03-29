﻿using MedicLabStudyApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicLabStudyApplication
{
    public partial class LoginForm : Form
    {
        UserInDatabaseChecker loginValidator = new UserInDatabaseChecker();
        UserCreatorForm userCreator = new UserCreatorForm();

        MainWindowForm mainWindow = new MainWindowForm();
        public LoginForm()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            // define local variables from the user inputs
            string user = userNameTxtBox.Text;
            string password = passwordTxtBox.Text;

            // check if eligible to be logged in

            if (loginValidator.check(user,password))
            {

                MessageBox.Show("You are logged in successfully");
                this.Hide();
                var mainForm = new MainWindowForm();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();

            }
            else
            {
                // show default login error code
                MessageBox.Show("Login Error!");
            }
        }

        private void forgotPasswordLiLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // enter your code for forget password casee
            MessageBox.Show("Under development");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // enter your code for registration form of yout choice
            MessageBox.Show("Under development");
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            userCreator.ShowDialog();
        }
    }
}
