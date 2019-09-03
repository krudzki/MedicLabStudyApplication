using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicLabStudyApplication.Libs;

namespace MedicLabStudyApplication
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void mainWindowLoad(object sender, EventArgs e)
        {

        }

        private void calendarDateChange(object sender, DateRangeEventArgs e)
        {
            // nothing
        }

        private void mainWindowRefresh(object sender, EventArgs e)
        {
            // nothing
        }

        private void openAboutUsForm(object sender, EventArgs e)
        {
            FormInicjalizator.openAboutUsForm();
        }

        private void openContactUsForm(object sender, EventArgs e)
        {
            FormInicjalizator.openContactUsForm();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openMedicinesForm(object sender, EventArgs e)
        {
            FormInicjalizator.openMedicinesForm();
        }

        private void openServicesForm(object sender, EventArgs e)
        {
            FormInicjalizator.openServicesForm();
        }

        private void openDoctorsForm(object sender, EventArgs e)
        {
            FormInicjalizator.openDoctorsForm();
        }

        private void MainWindowClouseClick(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = new DialogResult();

            //dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
