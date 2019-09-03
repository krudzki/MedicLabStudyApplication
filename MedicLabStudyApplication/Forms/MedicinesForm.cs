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
    public partial class MedicinesForm : Form
    {
        public MedicinesForm()
        {
            InitializeComponent();
        }

        MySqlConnection connection = ConnectionToDatabase.getNewConnection();
        String id;
        CRUD crud = new CRUD();

        private void insertIntoDatabase(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);

            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand($"INSERT INTO {DatabaseTables.Names.Medicines} (Producer,Description,Contens,Photo) VALUES (@producer,@description,@contens,@photo)", connection);

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
            updateDataGrid();
        }

        private void loadMedicinesForm(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void updateDataGrid()
        {
            dataGridView1 = crud.readDatabaseContent(dataGridView1, $"{DatabaseTables.Names.Medicines}", 4);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);

            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand($"UPDATE {DatabaseTables.Names.Medicines} SET Producer=@producer,Description=@description,Contens=@contens,Photo=@photo WHERE ID = @id", connection);

            command.Parameters.Add("@producer", MySqlDbType.VarChar).Value = textBoxProducer.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = textBoxDescription.Text;
            command.Parameters.Add("@contens", MySqlDbType.VarChar).Value = textBoxContens.Text;
            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = img;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            ExecMyQuery(command, "Data Updated");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand($"DELETE FROM {DatabaseTables.Names.Medicines} WHERE ID =@id", connection);

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
