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
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void ToLogBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            String LoginT, PasswordT, NameT, SurnameT, RoleT;
            LoginT = LoginTxtB.Text;
            PasswordT = PasswordTxtB.Text;
            NameT = NameTxtB.Text;
            SurnameT = SurnameTxtB.Text;
            RoleT = RoleCBox.Text;
            int role = 0;
            if (RoleT == "Uczeń")
                role = 1;
            if (RoleT == "Rodzic")
                role = 2;
            if (RoleT == "Nauczyciel")
                role = 3;

            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Select login from Users where login=@name";//wynbieram wszystkie wartosci ktore sa rowne loginowi
            command.Parameters.AddWithValue("@name", LoginT);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();

            if ((PasswordT != "") && (LoginT != "") && (NameT != "") && (SurnameT != "") && (dt.Rows.Count <= 0))
            {
                //ustalamy komende do wsadzenia do bazdy danych wszystkich tekstow z rejestracji
                SqlCommand cmd = new SqlCommand("INSERT INTO Users(login,password,name,surname,rola,admin) VALUES('" + LoginT + "','" + PasswordT + "','" + NameT + "','" + SurnameT + "','" + role + "','" + 0 + "')", conn);
                conn.Open();//otwieramy polaczenie

                var i = cmd.ExecuteNonQuery();//uruchamamy komende

                conn.Close();

                if (i != 0)
                {
                    MessageBox.Show("Zarejestrowano pomyślnie", "Zarejestrowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("nieprawidłowe dane logowanie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
