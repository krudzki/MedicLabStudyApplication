using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicLabStudyApplication.Libs.Database
{
    class CRUD
    {
        MySqlConnection connection = ConnectionToDatabase.getNewConnection();

        /*private void insertIntoDatabase(PictureBox pictureBox, String tableName, MySqlCommand mySqlCommand, List<String> columns, List<String> columnsParam, List<String> inputFields)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);

            byte[] img = ms.ToArray();

            String commandText = $"INSERT INTO " + tableName + "(";

            for (int element = 1; element < columns.Count(); element++)
            {
                if (element == columns.Count())
                {

                }
                commandText += (columns[element] + ",");
            }

            commandText += ") VALUES (";

            for (int element = 1; element < columnsParam.Count(); element++)
            {
                commandText += ("@" + columnsParam[element] + ",");
            }

            commandText += ")";

            MySqlCommand command = new MySqlCommand(commandText, connection);

            command.Parameters.Add("@first_Name", MySqlDbType.VarChar).Value = inputFirstName.Text;
            command.Parameters.Add("@last_Name", MySqlDbType.VarChar).Value = inputLastName.Text;
            command.Parameters.Add("@speciality", MySqlDbType.VarChar).Value = inputSpeciality.Text;
            command.Parameters.Add("@phone_Number", MySqlDbType.VarChar).Value = inputTelephone.Text;


            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Inserted");
        }*/

        public DataGridView readDatabaseContent(DataGridView dataGridView, String tableName, int imageColumn)
        {
            MySqlCommand command = new MySqlCommand($"SELECT * FROM {tableName}", ConnectionToDatabase.getNewConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.RowTemplate.Height = 60;
            dataGridView.AllowUserToAddRows = false;

            dataGridView.DataSource = table;


            if (imageColumn >= 0)
            {
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dataGridView.Columns[imageColumn];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            return dataGridView;
        }
    }
}
