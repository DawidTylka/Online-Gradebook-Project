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

namespace Tylka.apknauczyciel
{
    public partial class ClassNauczyciel : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public ClassNauczyciel()
        {
            InitializeComponent();
        }
        private void ClassNauczyciel_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "DisplayText";
            comboBox1.ValueMember = "Value";

            List<object> items = new List<object>();
            items.Add(new { DisplayText = "1", Value = 1 });
            items.Add(new { DisplayText = "2", Value = 2 });
            items.Add(new { DisplayText = "3", Value = 3 });
            items.Add(new { DisplayText = "4", Value = 4 });

            comboBox1.DataSource = items;
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            dataGridView1.Visible = false;
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);

            dataGridView1.Columns.Add("fullname", "Uczeń");
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            conn.Open();
            int class_id = 1;

            class_id = Convert.ToInt32(comboBox1.SelectedValue);
            Console.WriteLine(class_id);
            Console.WriteLine(class_id.GetType()); ;
            // First request: Get records from the Oceny table for the specific student
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM klasy WHERE Klasa = "+class_id, conn);
            DataTable dtKlasy = new DataTable();
            Adapter.Fill(dtKlasy);

            dtKlasy.Columns.Add("fullname");

            // Second request: Get the teacher's name from the Users table
            SqlCommand cmdUsers = new SqlCommand();
            cmdUsers.Connection = conn;
            cmdUsers.CommandText = "SELECT id, name, surname FROM Users";
            SqlDataAdapter adapterUsers = new SqlDataAdapter(cmdUsers);

            DataTable dtUsers = new DataTable();
            adapterUsers.Fill(dtUsers);
            dataGridView1.Columns["fullname"].DataPropertyName = "fullname";
            foreach (DataRow rowKlasy in dtKlasy.Rows)
            {
                Console.WriteLine(rowKlasy);
                foreach (DataRow rowUsers in dtUsers.Rows)
                {
                    if (rowKlasy["user_id"].Equals(rowUsers["id"]))
                    {
                        rowKlasy["fullname"] = rowUsers["name"].ToString() + " " + rowUsers["surname"].ToString();
                    }
                }
            }
            dataGridView1.DataSource = dtKlasy;
            conn.Close();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[1].Visible = false;
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
