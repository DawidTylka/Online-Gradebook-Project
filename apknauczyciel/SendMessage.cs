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
            if (UserData.messagepermission == 1)
            { }
            else
            {
                checkBox1.Visible = false;
            }
            conn.Open();

            SqlDataAdapter da1 = new SqlDataAdapter("SELECT id, CONCAT(name, ' ', surname) AS fullname FROM Users", conn);
            DataTable dtwiadomosci = new DataTable();
            da1.Fill(dtwiadomosci);

            comboBox1.DataSource = dtwiadomosci;
            comboBox1.DisplayMember = "fullname";
            comboBox1.ValueMember = "id";


            conn.Close();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Visible = false;
            }
            else { comboBox1.Visible = true; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String Subject, Text,id_receiver;
            Subject = textBox1.Text;
            Text = richTextBox1.Text;
            id_receiver = comboBox1.SelectedValue.ToString();
            conn.Open();
            if (checkBox1.Checked)
            {
                if (Subject !="" && Text !="")
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Wiadomosci(id_sender,publicmessage,subject,text,time) VALUES('" + UserData.user_id + "','" + 1 + "','" + Subject + "','" + Text + "','" + DateTime.Now.Date + "')", conn);

                    var i = cmd.ExecuteNonQuery();//uruchamamy komende
                    MessageBox.Show("Wysłano wiadomość", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wypełnij wszystkie pola", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            else
            {
                if (Subject != "" && Text != "")
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Wiadomosci(id_sender,id_receiver,publicmessage,subject,text,time) VALUES('" + UserData.user_id + "','" + id_receiver + "',0,'" + Subject + "','" + Text + "','" + DateTime.Now.Date + "')", conn);
                    var i = cmd.ExecuteNonQuery();//uruchamamy komende
                    MessageBox.Show("Wysłano wiadomość", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wypełnij wszystkie pola", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
