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
using MedicLabStudyApplication.Libs.Database;

namespace MedicLabStudyApplication
{
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();
        }

        MySqlConnection connection = ConnectionToDatabase.getNewConnection();
        String id;
        DisplayTableData displayTableData = new DisplayTableData();

        private void insertIntoDatabase(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            photoBox.Image.Save(ms, photoBox.Image.RawFormat);

            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand($"INSERT INTO {DatabaseTables.Names.Doctors} (First_Name,Last_Name,Speciality,Phone_Number,Photo) VALUES (@first_Name,@last_Name,@speciality,@phone_Number,@photo)", connection);

            command.Parameters.Add("@first_Name", MySqlDbType.VarChar).Value = inputFirstName.Text;
            command.Parameters.Add("@last_Name", MySqlDbType.VarChar).Value = inputLastName.Text;
            command.Parameters.Add("@speciality", MySqlDbType.VarChar).Value = inputSpeciality.Text;
            command.Parameters.Add("@phone_Number", MySqlDbType.VarChar).Value = inputTelephone.Text;
            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Inserted");
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
            dataGridView1 = displayTableData.FillGrid(dataGridView1, $"{DatabaseTables.Names.Doctors}", 5);
        }

        private void loadDoctorsForm(object sender, EventArgs e)
        {
            dataGridView1 = displayTableData.FillGrid(dataGridView1, $"{DatabaseTables.Names.Doctors}", 5);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            photoBox.Image.Save(ms, photoBox.Image.RawFormat);

            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand($"UPDATE {DatabaseTables.Names.Doctors} SET First_Name=@first_Name,Last_Name=@last_Name,Speciality=@speciality,Phone_Number=@phone_Number,Photo=@photo WHERE ID = @id", connection);

            command.Parameters.Add("@first_Name", MySqlDbType.VarChar).Value = inputFirstName.Text;
            command.Parameters.Add("@last_Name", MySqlDbType.VarChar).Value = inputLastName.Text;
            command.Parameters.Add("@speciality", MySqlDbType.VarChar).Value = inputSpeciality.Text;
            command.Parameters.Add("@phone_Number", MySqlDbType.Int32).Value = inputTelephone.Text;
            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = img;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            ExecMyQuery(command, "Data Updated");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand($"DELETE FROM {DatabaseTables.Names.Doctors} WHERE ID =@id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


            ExecMyQuery(command, "Data Deleted");
        }

        private void buttonChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                photoBox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[5].Value;

            MemoryStream ms = new MemoryStream(img);

            photoBox.Image = Image.FromStream(ms);
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            inputFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            inputLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            inputSpeciality.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            inputTelephone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
