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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plansbindingSource1.EndEdit();
            this.dniTableAdapter.Update(onlinegradebookprojectDataSet1.Dni);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void PlansRodzic_Load(object sender, EventArgs e)
        {

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * FROM Dni WHERE id_klasy = '" + UserData.classid + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;

            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
