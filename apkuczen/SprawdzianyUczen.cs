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

    public partial class SprawdzianyUczen : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public SprawdzianyUczen()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        private void SprawdzianyUczen_Load(object sender, EventArgs e)
        {
            // Add "teacher name" column to DataGridView
            dataGridView1.Columns.Add("teacher_name", "teacher_name");
            dataGridView1.Columns.Add("subject_name", "Przedmioty");
            dataGridView1.Columns.Add("teacher_id", "teacher_id");
            dataGridView1.Columns["subject_name"].DataPropertyName = "subject_name";
            dataGridView1.Columns["teacher_id"].DataPropertyName = "teacher_id";
            dataGridView1.Columns["teacher_name"].DataPropertyName = "teacher_name";

            conn.Open();

            // First request: Get records from the Oceny table for the specific student
            SqlCommand cmdSprawdziany = new SqlCommand();
            cmdSprawdziany.Connection = conn;
            cmdSprawdziany.CommandText = "SELECT * FROM Sprawdziany WHERE id_klasy = @val1";
            cmdSprawdziany.Parameters.AddWithValue("@val1", UserData.classid);
            SqlDataAdapter adapterSprawdziany = new SqlDataAdapter(cmdSprawdziany);

            DataTable dtSprawdziany = new DataTable();
            adapterSprawdziany.Fill(dtSprawdziany);

            // Add "teacher_name" column to dtOceny
            dtSprawdziany.Columns.Add("teacher_name");
            dtSprawdziany.Columns.Add("subject_name");
            dtSprawdziany.Columns.Add("teacher_id", typeof(int));
            // Second request: Get the teacher's name from the Users table
            SqlCommand cmdPrzedmioty = new SqlCommand();
            cmdPrzedmioty.Connection = conn;
            cmdPrzedmioty.CommandText = "SELECT id_przedmiotu, nazwa, id_nauczyciela FROM Przedmioty";
            SqlDataAdapter adapterPrzedmioty = new SqlDataAdapter(cmdPrzedmioty);

            DataTable dtPrzedmioty = new DataTable();
            adapterPrzedmioty.Fill(dtPrzedmioty);
            foreach (DataRow rowSprawdziany in dtSprawdziany.Rows)
            {
                foreach (DataRow rowPrzedmioty in dtPrzedmioty.Rows)
                {
                    if (rowSprawdziany["id_przedmiotu"].Equals(rowPrzedmioty["id_przedmiotu"]))
                    {
                        rowSprawdziany["subject_name"] = rowPrzedmioty["nazwa"].ToString();
                        rowSprawdziany["teacher_id"] = rowPrzedmioty["id_nauczyciela"];
                    }
                }
            }
            SqlCommand cmdUsers = new SqlCommand();
            cmdUsers.Connection = conn;
            cmdUsers.CommandText = "SELECT id, name, surname FROM users WHERE rola = 3";
            SqlDataAdapter adapterUsers = new SqlDataAdapter(cmdUsers);

            DataTable dtUsers = new DataTable();
            adapterUsers.Fill(dtUsers);
            foreach (DataRow rowSprawdziany in dtSprawdziany.Rows)
            {
                Console.WriteLine(rowSprawdziany);
                foreach (DataRow rowUsers in dtUsers.Rows)
                {
                    Console.WriteLine(rowSprawdziany["teacher_id"].GetType());
                    Console.WriteLine(rowUsers["id"].GetType());
                    if (rowSprawdziany["teacher_id"].Equals(rowUsers["id"]))
                    {
                        rowSprawdziany["teacher_name"] = rowUsers["name"].ToString() + " " + rowUsers["surname"].ToString();
                    }
                }
            }


            // Set DataTable as the DataGridView's data source
            dataGridView1.DataSource = dtSprawdziany;
            conn.Close();

            dataGridView1.Columns["teacher_name"].DisplayIndex = 0;
            dataGridView1.Columns["subject_name"].DisplayIndex = 1;
            dataGridView1.Columns["tematDataGridViewTextBoxColumn"].DisplayIndex = 2;
            dataGridView1.Columns["terminDataGridViewTextBoxColumn"].DisplayIndex = 3;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            // Hide unnecessary columns and resize DataGridView
            /*dataGridView1.Columns["teacher_name"].Visible = true;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            */

            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
