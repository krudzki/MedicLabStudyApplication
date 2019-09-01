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
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=liza.umcs.lublin.pl;user=krudzki;database=krudzki;password=kwiecien0404;SslMode=none");
        String id;

        public void FillGrid()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Doctors", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[5];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);

            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO Doctors (First_Name,Last_Name,Speciality,Phone_Number,Photo) VALUES (@first_Name,@last_Name,@speciality,@phone_Number,@photo)", connection);

            command.Parameters.Add("@first_Name", MySqlDbType.VarChar).Value = textBoxFirstName.Text;
            command.Parameters.Add("@last_Name", MySqlDbType.VarChar).Value = textBoxLastName.Text;
            command.Parameters.Add("@speciality", MySqlDbType.VarChar).Value = textBoxSpeciality.Text;
            command.Parameters.Add("@phone_Number", MySqlDbType.VarChar).Value = textBoxTelephone.Text;
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
            FillGrid();
        }

        private void F_Doctors_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);

            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE Doctors SET First_Name=@first_Name,Last_Name=@last_Name,Speciality=@speciality,Phone_Number=@phone_Number,Photo=@photo WHERE ID = @id", connection);

            command.Parameters.Add("@first_Name", MySqlDbType.VarChar).Value = textBoxFirstName.Text;
            command.Parameters.Add("@last_Name", MySqlDbType.VarChar).Value = textBoxLastName.Text;
            command.Parameters.Add("@speciality", MySqlDbType.VarChar).Value = textBoxSpeciality.Text;
            command.Parameters.Add("@phone_Number", MySqlDbType.Int32).Value = textBoxTelephone.Text;
            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = img;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            ExecMyQuery(command, "Data Updated");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM Doctors WHERE ID =@id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;


            ExecMyQuery(command, "Data Deleted");
        }

        private void buttonChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(opf.FileName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[5].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBoxPhoto.Image = Image.FromStream(ms);
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxSpeciality.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxTelephone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
