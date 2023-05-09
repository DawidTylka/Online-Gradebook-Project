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
    public partial class PlansNauczyciel : UserControl
    {
        public PlansNauczyciel()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planbindingSource1.EndEdit();
            this.dniTableAdapter.Update(onlinegradebookprojectDataSet1.Dni);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dniTableAdapter.Fill(onlinegradebookprojectDataSet1.Dni);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void PlansNauczyciel_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("Select Klasa FROM Klasy", conn);
            DataTable dtklasy = new DataTable();
            da1.Fill(dtklasy);
            comboBox1.DataSource = dtklasy;
            comboBox1.DisplayMember = ("Klasa");
            comboBox1.ValueMember = "Klasa";
            dataGridView1.Visible = false;
            conn.Close();
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            conn.Open();
            int class_id = (int)comboBox1.SelectedValue;
            SqlCommand cmdDni = new SqlCommand();
            cmdDni.Connection = conn;
            cmdDni.CommandText = "SELECT * FROM Dni WHERE id_klasy =" + class_id;
            SqlDataAdapter adapterOceny = new SqlDataAdapter(cmdDni);

            DataTable dtDni = new DataTable();
            adapterOceny.Fill(dtDni);
            dataGridView1.DataSource = dtDni;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            conn.Close();
        }
    }
}
