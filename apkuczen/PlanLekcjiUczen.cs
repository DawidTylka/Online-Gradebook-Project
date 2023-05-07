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
    public partial class PlanLekcjiUczen : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public PlanLekcjiUczen()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        private void PlanLekcjiUczen_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * FROM Dni WHERE id_klasy = '" +UserData.classid+ "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
