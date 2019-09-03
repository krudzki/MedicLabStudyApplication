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
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        MySqlConnection connection = ConnectionToDatabase.getNewConnection();
        String id;
        CRUD crud = new CRUD();
        
        private void insertIntoDatabase(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO {DatabaseTables.Names.Medical_services}(Name,Description,Cost) VALUES(@name,@description,@cost)", connection);

            command.Parameters.Add($"@name", MySqlDbType.VarChar).Value = name.Text;
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
            updateDataGrid();
        }

        private void loadServicesForm(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void updateDataGrid()
        {
            dataGridView1 = crud.readDatabaseContent(dataGridView1, $"{DatabaseTables.Names.Medical_services}", -1);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand($"UPDATE {DatabaseTables.Names.Medical_services} SET Name=@name,Description=@description,Cost=@cost WHERE ID = @id", connection);

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = textBoxDescription.Text;
            command.Parameters.Add("@cost", MySqlDbType.Float).Value = textBoxCost.Text;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            ExecMyQuery(command, "Data Updated");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand($"DELETE FROM {DatabaseTables.Names.Medical_services} WHERE ID = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            ExecMyQuery(command, "Data Deleted");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxCost.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
