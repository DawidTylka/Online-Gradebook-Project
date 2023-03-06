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

namespace Tylka
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //tworze komende update by zaktualizowac kolumne cena biletu w bazie danych tabeli zabukowane
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users");
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admingrid.DataSource = dt;
            conn.Close();
            // TODO: This line of code loads data into the 'onlinegradebookprojectDataSet.Users' table. You can move, or remove it, as needed.

        }
    }
}
