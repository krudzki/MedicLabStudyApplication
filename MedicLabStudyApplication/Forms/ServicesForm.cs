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
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server=liza.umcs.lublin.pl;user=krudzki;database=krudzki;password=kwiecien0404;SslMode=none");
        String id;

        public void FillGrid()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM Medical_services", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;

            //DataGridViewImageColumn img = new DataGridViewImageColumn();
            //img = (DataGridViewImageColumn)dataGridView1.Columns[4];
            //img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            //MemoryStream ms = new MemoryStream();

            MySqlCommand command = new MySqlCommand("INSERT INTO Medical_services(Name,Description,Cost) VALUES(@name,@description,@cost)", connection);

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = textBoxDescription.Text;
            command.Parameters.Add("@cost", MySqlDbType.Float).Value = textBoxCost.Text;

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

        private void F_Services_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE Medical_services SET Name=@name,Description=@description,Cost=@cost WHERE ID = @id", connection);

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = textBoxDescription.Text;
            command.Parameters.Add("@cost", MySqlDbType.Float).Value = textBoxCost.Text;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            ExecMyQuery(command, "Data Updated");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM Medical_services WHERE ID = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            ExecMyQuery(command, "Data Deleted");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[4].Value;

            //MemoryStream ms = new MemoryStream(img);

            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxCost.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
