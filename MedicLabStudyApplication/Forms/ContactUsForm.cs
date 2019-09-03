using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;
using MedicLabStudyApplication.Libs.Email;

namespace MedicLabStudyApplication
{
    public partial class ContactUsForm : Form
    {
        public ContactUsForm()
        {
            InitializeComponent();
        }

        private void buttonSendClick(object sender, EventArgs e)
        {
            try
            {
                Email.send(inputName.Text, inputEmail.Text, inputSubject.Text, inputQuestion.Text);
                MessageBox.Show("The message was send to MedicLab!");
                inputName.Clear();
                inputEmail.Clear();
                inputSubject.Clear();
                inputQuestion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
