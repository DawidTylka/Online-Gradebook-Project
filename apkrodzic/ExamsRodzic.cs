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

namespace Tylka.apkrodzic
{
    public partial class ExamsRodzic : UserControl
    {
        public ExamsRodzic()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examsbindingSource1.EndEdit();
            this.sprawdzianyTableAdapter.Update(onlinegradebookprojectDataSet1.Sprawdziany);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.sprawdzianyTableAdapter.Fill(onlinegradebookprojectDataSet1.Sprawdziany);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void ExamsRodzic_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("Select id,idopiekuna,CONCAT(name, ' ', surname) AS fullname FROM Users WHERE idopiekuna=" + UserData.user_id, conn);
            DataTable dtopiekun = new DataTable();
            da1.Fill(dtopiekun);
            comboBox1.DataSource = dtopiekun;
            comboBox1.DisplayMember = ("fullname");
            comboBox1.ValueMember = "id";
            dataGridView1.Visible = false;
            conn.Close();
            dataGridView1.Columns.Add("teacher_name", "teacher_name");
            dataGridView1.Columns.Add("subject_name", "Przedmioty");
            dataGridView1.Columns.Add("teacher_id", "teacher_id");
            dataGridView1.Columns["subject_name"].DataPropertyName = "subject_name";
            dataGridView1.Columns["teacher_id"].DataPropertyName = "teacher_id";
            dataGridView1.Columns["teacher_name"].DataPropertyName = "teacher_name";
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            conn.Open();
            int class_id = 0;
            int selectedId = (int)comboBox1.SelectedValue;
            string query2 = "SELECT Klasa FROM Klasy WHERE User_id = " + selectedId;

            {
                SqlCommand command2 = new SqlCommand(query2, conn);

                SqlDataReader reader2 = command2.ExecuteReader();

                if (reader2.Read())
                {
                    class_id = reader2.GetInt32(0);
                }
                reader2.Close();
            }
            // Add "teacher name" column to DataGridView


            // First request: Get records from the Oceny table for the specific student
            SqlCommand cmdSprawdziany = new SqlCommand();
            cmdSprawdziany.Connection = conn;
            cmdSprawdziany.CommandText = "SELECT * FROM Sprawdziany WHERE id_klasy = @val1";
            cmdSprawdziany.Parameters.AddWithValue("@val1", class_id);
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

            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
