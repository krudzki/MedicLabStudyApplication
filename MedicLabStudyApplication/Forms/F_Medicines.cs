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
    public partial class F_Medicines : Form
    {
        public F_Medicines()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=liza.umcs.lublin.pl;user=krudzki;database=krudzki;password=kwiecien0404;SslMode=none");
        String id;

        public void FillGrid()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Medicines", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[4];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);

            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("INSERT INTO Medicines (Producer,Description,Contens,Photo) VALUES (@producer,@description,@contens,@photo)", connection);

            command.Parameters.Add("@producer", MySqlDbType.VarChar).Value = textBoxProducer.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = textBoxDescription.Text;
            command.Parameters.Add("@contens", MySqlDbType.VarChar).Value = textBoxContens.Text;
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

        private void F_Medicines_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);

            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE Medicines SET Producer=@producer,Description=@description,Contens=@contens,Photo=@photo WHERE ID = @id", connection);

            command.Parameters.Add("@producer", MySqlDbType.VarChar).Value = textBoxProducer.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = textBoxDescription.Text;
            command.Parameters.Add("@contens", MySqlDbType.VarChar).Value = textBoxContens.Text;
            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = img;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            ExecMyQuery(command, "Data Updated");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM Medicines WHERE ID =@id", connection);

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
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[4].Value;

            MemoryStream ms = new MemoryStream(img);


            pictureBoxPhoto.Image = Image.FromStream(ms);
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxProducer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxContens.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
