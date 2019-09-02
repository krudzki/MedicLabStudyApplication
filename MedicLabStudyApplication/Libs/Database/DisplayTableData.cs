using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicLabStudyApplication.Libs.Database
{
    class DisplayTableData
    {

        public DataGridView FillGrid(DataGridView dataGridView, String tableName, int imageColumn)
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
