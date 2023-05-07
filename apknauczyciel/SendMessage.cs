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
    public partial class SendMessage : UserControl
    {
        public SendMessage()
        {
            InitializeComponent();
        }
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private bool toall = false;
        private void SendMessage_Load(object sender, EventArgs e)
        {
            conn.Open();

            SqlDataAdapter da1 = new SqlDataAdapter("SELECT id, CONCAT(name, ' ', surname) AS fullname FROM Users", conn);
            DataTable dtwiadomosci = new DataTable();
            da1.Fill(dtwiadomosci);

            comboBox1.DataSource = dtwiadomosci;
            comboBox1.DisplayMember = "fullname";
            comboBox1.ValueMember = "id";


            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (radioButton1.Checked) {

                String Subject,Text;
                Subject = textBox1.Text;
                Text = richTextBox1.Text;


                SqlCommand cmd = new SqlCommand("INSERT INTO Wiadomosci(id_sender,publicmessage,subject,text,time) VALUES('" + UserData.user_id + "','" + 1 + "','" + Subject + "','" + Text + "','" + DateTime.Now.Date + "')", conn);

                var i = cmd.ExecuteNonQuery();//uruchamamy komende

                
            }
            conn.Close();
        }
    }
}
