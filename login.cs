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

namespace Tylka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            register1.Hide();
        }
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void ToRegBtnC_Click(object sender, EventArgs e)
        {
            register1.Show();
        }
        private void LoginBtnC_Click(object sender, EventArgs e)
        {
            LLoginTxtB.Focus();  //nie wiemy o conb
            String login, password; ;
            UserData.login_all = login = LLoginTxtB.Text;
            UserData.admin = false;

            //Create home data
            for (int x = 0; x < 6; x++)
            {
                UserData.data.Add(new Data("" + x, 1));
                UserData.dataAadmin.Add(new Data("" + x, (x*x)+5));
            }
            UserData.title = "oceny";
            UserData.adminTitle = "oceny";

            password = LPasswordTxtB.Text;
            int i = 0;
            try
            {
                String querry = "SELECT * FROM Users WHERE login = '" + login + "' AND password = '" + password + "'";//zapytanko do bazy
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);//tworzymy adapter by pozniej stworzyc baze danych i wypchac ją danymi pobranymi z komendy powyzej
                DataTable dtable = new DataTable();//to taki adapter bazy danych jakby
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {

                    string query = "SELECT name FROM Users WHERE login = '" + UserData.login_all + "'";

                    {
                        SqlCommand command = new SqlCommand(query, conn);

                        conn.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            UserData.Namedata = reader.GetString(0);
                        }
                        else
                        {
                            MessageBox.Show("No data found for the specified ID.");
                        }

                        reader.Close();
                        conn.Close();
                    }
                    {

                        string query1 = "SELECT id FROM Users WHERE login = @login";

                        {
                            SqlCommand command1 = new SqlCommand(query1, conn);
                            command1.Parameters.AddWithValue("@login", login);

                            conn.Open();

                            SqlDataReader reader1 = command1.ExecuteReader();

                            if (reader1.Read())
                            {
                                UserData.user_id = reader1.GetInt32(0);
                                reader1.Close();
                                string query2 = "SELECT Klasa FROM Klasy WHERE User_id = "+UserData.user_id;

                                {
                                    SqlCommand command2 = new SqlCommand(query2, conn);

                                    SqlDataReader reader2 = command2.ExecuteReader();

                                    if (reader2.Read())
                                    {
                                        UserData.classid = reader2.GetInt32(0);
                                    }
                                    reader2.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found for the specified ID.");
                            }

                            reader1.Close();
                            conn.Close();
                        }
                    }
                    DataRow[] admincheck = dtable.Select("admin = '" + true + "'");

                    DataRow[] rolecheck1 = dtable.Select("rola = '" + 1 + "'");// tutaj sprawdzamy czy w podanym userze istnieje cos co w kolumnie rola ma 1 czyli ucznia no i tak po koleji cale te
                    if (rolecheck1.Length != 0)
                    {
                        if (admincheck.Length != 0)
                        {   
                            UserData.admin = true;
                            loginpick11.Show();
                        }
                        else
                        {
                            apkuczen.PanelUczen paneluczen = new apkuczen.PanelUczen();
                            paneluczen.Show();
                        }
                        //MessageBox.Show("prrr", "uczen" + i, MessageBoxButtons.OK, MessageBoxIcon.Information);//to takie fajne message boxy co som jak wygrales iphone kliknij ok
                    }
                        
                    DataRow[] rolecheck2 = dtable.Select("rola = '" + 2 + "'");
                    if (rolecheck2.Length != 0)
                    {
                        if (admincheck.Length != 0)
                        {
                            UserData.admin = true;
                            loginpick21.Show();
                        }
                        else
                        {
                            apkrodzic.PanelRodzic panelrodzic = new apkrodzic.PanelRodzic();
                            panelrodzic.Show();
                            MessageBox.Show("prrr", "rodzic" + i, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    DataRow[] rolecheck3 = dtable.Select("rola = '" + 3 + "'");
                    if (rolecheck3.Length != 0)
                    {
                        if (admincheck.Length != 0)
                        {
                            UserData.admin = true;
                            loginpick31.Show();
                        }
                        else
                        {
                            apknauczyciel.PanelNauczyciel panelnauczyciel = new apknauczyciel.PanelNauczyciel();
                            MessageBox.Show("prrr", "nauczyciel" + i, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                else//jezeli nie to blad
                {
                    MessageBox.Show("nieprawidłowy login lub hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LLoginTxtB.Clear();
                    LPasswordTxtB.Clear();
                    LLoginTxtB.Focus();
                }
            }

            catch
            {
                MessageBox.Show("prrr", "błont", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally//zamknij polaczenie z baza danych
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginpick11.Hide();
            loginpick21.Hide();
            loginpick31.Hide();
            label1.Parent = this.gradient1;
            label2.Parent = this.gradient1;
            loginpick11.Parent = this.gradient1;
            loginpick21.Parent = this.gradient1;
            loginpick31.Parent = this.gradient1;
        }

    }
}
