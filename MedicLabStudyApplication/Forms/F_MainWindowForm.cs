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
    public partial class F_MainWindowForm : Form
    {
        public F_ContactUs contactUs = new F_ContactUs();
        public F_AboutUs aboutUs = new F_AboutUs();
        public F_Medicines medicines = new F_Medicines();
        public F_Services services = new F_Services();
        public F_Doctors doctors = new F_Doctors();

        public F_MainWindowForm()
        {
            InitializeComponent();
        }


    private void F_MainWindowForm_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mOREABOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutUs.ShowDialog();
        }

        private void cONTACTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contactUs.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            medicines.ShowDialog();
        }

        private void mEDICINESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicines.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            services.ShowDialog();
        }

        private void mEDICALSERVICESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            services.ShowDialog();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctors.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctors.ShowDialog();
        }

        private void F_MainWindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
