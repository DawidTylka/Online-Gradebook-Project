using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tylka.dziennik_funkcje;

namespace Tylka.apkuczen
{
    public partial class OcenyUczen : UserControl
    {

        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public OcenyUczen()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        private void OcenyUczen_Load(object sender, EventArgs e)
        {
            // Add "teacher name" column to DataGridView
            dataGridView1.Columns.Add("teacher_name", "Nauczyciel");
            dataGridView1.Columns.Add("subject_name", "Przedmioty");

            conn.Open();

            // First request: Get records from the Oceny table for the specific student
            SqlCommand cmdOceny = new SqlCommand();
            cmdOceny.Connection = conn;
            cmdOceny.CommandText = "SELECT * FROM Oceny WHERE id_ucznia = @val1";
            cmdOceny.Parameters.AddWithValue("@val1", UserData.user_id);
            SqlDataAdapter adapterOceny = new SqlDataAdapter(cmdOceny);

            DataTable dtOceny = new DataTable();
            adapterOceny.Fill(dtOceny);

            // Add "teacher_name" column to dtOceny
            dtOceny.Columns.Add("teacher_name");
            dtOceny.Columns.Add("subject_name");

            // Second request: Get the teacher's name from the Users table
            SqlCommand cmdUsers = new SqlCommand();
            cmdUsers.Connection = conn;
            cmdUsers.CommandText = "SELECT id, name, surname FROM Users";
            SqlDataAdapter adapterUsers = new SqlDataAdapter(cmdUsers);

            DataTable dtUsers = new DataTable();
            adapterUsers.Fill(dtUsers);
            dataGridView1.Columns["teacher_name"].DataPropertyName = "teacher_name";
            foreach (DataRow rowOceny in dtOceny.Rows)
            {
                Console.WriteLine(rowOceny);
                foreach (DataRow rowUsers in dtUsers.Rows)
                {
                    if (rowOceny["id_nauczyciela"].Equals(rowUsers["id"]))
                    {
                        rowOceny["teacher_name"] = rowUsers["name"].ToString() + " " + rowUsers["surname"].ToString();
                    }
                }
            }
            SqlCommand cmdSubject = new SqlCommand();
            cmdSubject.Connection = conn;
            cmdSubject.CommandText = "SELECT id_przedmiotu, nazwa FROM przedmioty";
            SqlDataAdapter adapterSubject = new SqlDataAdapter(cmdSubject);

            DataTable dtSubject = new DataTable();
            adapterSubject.Fill(dtSubject);
            dataGridView1.Columns["subject_name"].DataPropertyName = "subject_name";
            foreach (DataRow rowOceny in dtOceny.Rows)
            {
                Console.WriteLine(rowOceny);
                foreach (DataRow rowPrzedmioty in dtSubject.Rows)
                {
                    if (rowOceny["id_przedmiotu"].Equals(rowPrzedmioty["id_przedmiotu"]))
                    {
                        rowOceny["subject_name"] = rowPrzedmioty["nazwa"].ToString();
                    }
                }
            }


            // Set DataTable as the DataGridView's data source
            dataGridView1.DataSource = dtOceny;
            conn.Close();

            // Hide unnecessary columns and resize DataGridView
            dataGridView1.Columns["teacher_name"].Visible = true;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["teacher_name"].DisplayIndex = 1;
            dataGridView1.Columns["subject_name"].DisplayIndex = 0;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;


            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
