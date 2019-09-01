using MySql.Data.MySqlClient;
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

namespace MedicLabStudyApplication
{
    public partial class UserCreatorForm : Form
    {
        public UserCreatorForm()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=liza.umcs.lublin.pl;user=krudzki;database=krudzki;password=kwiecien0404;SslMode=none");
        String id;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO members(username,password) VALUES(@username,@password)", connection);

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = textBoxLogin.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            ExecMyQuery(command, "Użytkownik dodany");
        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            connection.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(myMsg);
            }
            else
            {
                MessageBox.Show("Query Not Executed");
            }
            connection.Close();
        }
    }
}
