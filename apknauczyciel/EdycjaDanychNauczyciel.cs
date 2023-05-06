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
    public partial class EdycjaDanychNauczyciel : UserControl
    {

        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public EdycjaDanychNauczyciel()
        {
            InitializeComponent();
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            String LoginT, PasswordT, NameT, SurnameT, emai, telefon, pes;
            LoginT = login.Text;
            PasswordT = haslo.Text;
            NameT = imie.Text;
            SurnameT = nazwisko.Text;
            emai = email.Text;
            telefon = tel.Text;
            pes = pesel.Text;
            
            conn.Open();
            if (LoginT != UserData.login_all)
            {
                string query = "Select login from Users where login= '" + LoginT + "'";//wynbieram wszystkie wartosci ktore sa rowne loginowi
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    conn.Close();
                    MessageBox.Show("Login zajęty", "czyli zły", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                reader.Close();
            }
            conn.Close();
            if ((PasswordT != "") && (LoginT != "") && (NameT != "") && (SurnameT != "") &&  (pes.Length == 11 && Int64.TryParse(pes, out Int64 z) || pes == "") && (telefon.Length == 9 && Int32.TryParse(telefon, out int j) || telefon == "")  )
            {
                string help = "";
                if (telefon.Length == 9)
                {
                    help = ", telefon = " + telefon;
                }
                else 
                {
                    help = ", telefon =  NULL";
                }
                if (pes.Length == 11)
                {
                    help += ", pesel = " + pes;
                }
                else
                {
                    help += ", pesel =  NULL";
                }
                //ustalamy komende do wsadzenia do bazdy danych wszystkich tekstow z rejestracji
                SqlCommand cmd = new SqlCommand("UPDATE Users SET login = '"+ LoginT + "', password = '"+ PasswordT + "', name = '"+ NameT + "', surname = '"+ SurnameT + "', email = '"+ emai + "'" + help + "  WHERE id = "+ UserData.user_id + "", conn);
                conn.Open();//otwieramy polaczenie

                var i = cmd.ExecuteNonQuery();//uruchamamy komende

                conn.Close();
                UserData.login_all = LoginT;
                if (i != 0)
                {
                    MessageBox.Show("pomyślnie edytowano", "Gratuluje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("nieprawidłowe dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Users WHERE id = " + UserData.user_id + "";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(1))
                    login.Text = reader.GetString(1);
                if (!reader.IsDBNull(2))
                    haslo.Text = reader.GetString(2);
                if (!reader.IsDBNull(3))
                    imie.Text = reader.GetString(3);
                if (!reader.IsDBNull(4))
                    nazwisko.Text = reader.GetString(4);
                if (!reader.IsDBNull(5))
                    email.Text = reader.GetString(5);
                if (!reader.IsDBNull(6))
                    tel.Text = reader.GetInt32(6).ToString();
                if (!reader.IsDBNull(7))
                    pesel.Text = reader.GetInt64(7).ToString();
            }
            conn.Close();
            reader.Close();
        }

        private void EdycjaDanychNauczyciel_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Users WHERE id = " + UserData.user_id + "";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            haslo.PasswordChar = '*';
            if (reader.Read())
            {
                if (!reader.IsDBNull(1))
                    login.Text = reader.GetString(1);
                if (!reader.IsDBNull(2))
                    haslo.Text = reader.GetString(2);
                if (!reader.IsDBNull(3))
                    imie.Text = reader.GetString(3);
                if (!reader.IsDBNull(4))
                    nazwisko.Text = reader.GetString(4);
                if (!reader.IsDBNull(5))
                    email.Text = reader.GetString(5);
                if (!reader.IsDBNull(6))
                    tel.Text = reader.GetInt32(6).ToString();
                if (!reader.IsDBNull(7))
                    pesel.Text = reader.GetInt64(7).ToString();
            }
            conn.Close();
            reader.Close();
        }
    }
}
