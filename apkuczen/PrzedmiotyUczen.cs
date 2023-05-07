using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tylka.dziennik_funkcje;

namespace Tylka.apkuczen
{
    public partial class PrzedmiotyUczen : UserControl
    {
        public PrzedmiotyUczen()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void PrzedmiotyUczen_Load(object sender, EventArgs e)
        { // Add "teacher name" column to DataGridView
            dataGridView1.Columns.Add("teacher_name", "Nauczyciel");

            conn.Open();

            // First request: Get records from the Oceny table for the specific student
            SqlCommand cmdPrzedmioty = new SqlCommand();
            cmdPrzedmioty.Connection = conn;
            cmdPrzedmioty.CommandText = "SELECT * FROM przedmioty";
            SqlDataAdapter adapterOceny = new SqlDataAdapter(cmdPrzedmioty);

            DataTable dtPrzedmioty = new DataTable();
            adapterOceny.Fill(dtPrzedmioty);

            // Add "teacher_name" column to dtOceny
            dtPrzedmioty.Columns.Add("teacher_name");

            // Second request: Get the teacher's name from the Users table
            SqlCommand cmdUsers = new SqlCommand();
            cmdUsers.Connection = conn;
            cmdUsers.CommandText = "SELECT id, name, surname FROM Users";
            SqlDataAdapter adapterUsers = new SqlDataAdapter(cmdUsers);

            DataTable dtUsers = new DataTable();
            adapterUsers.Fill(dtUsers);
            dataGridView1.Columns["teacher_name"].DataPropertyName = "teacher_name";
            foreach (DataRow rowPrzedmioty in dtPrzedmioty.Rows)
            {
                Console.WriteLine(rowPrzedmioty);
                foreach (DataRow rowUsers in dtUsers.Rows)
                {
                    if (rowPrzedmioty["id_nauczyciela"].Equals(rowUsers["id"]))
                    {
                        rowPrzedmioty["teacher_name"] = rowUsers["name"].ToString() + " " + rowUsers["surname"].ToString();
                    }
                }
            }
            dataGridView1.DataSource = dtPrzedmioty;
            conn.Close();
            dataGridView1.RowHeadersVisible = false;
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }
    }
}
