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
    public partial class PlansRodzic : UserControl
    {

        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public PlansRodzic()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }
        private void PlansRodzic_Load(object sender, EventArgs e)
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
        }

        private void PlansRodzic_Click(object sender, EventArgs e)
        {
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
                    reader2.Close();
                }
            }
            SqlCommand cmdDni = new SqlCommand();
            cmdDni.Connection = conn;
            cmdDni.CommandText = "SELECT * FROM Dni WHERE id_klasy ="+class_id;
            SqlDataAdapter adapterOceny = new SqlDataAdapter(cmdDni);

            DataTable dtDni = new DataTable();
            adapterOceny.Fill(dtDni);
            dataGridView1.DataSource = dtDni;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            conn.Close();
        }
    }
}
