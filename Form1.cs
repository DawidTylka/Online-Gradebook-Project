using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tylka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.Hide();
        }
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void logbtn_Click(object sender, EventArgs e)
        {
            logbtn_Click(sender, e, true);
        }

        private void logbtn_Click(object sender, EventArgs e, bool v)
        {
            logtxt.Focus();  //nie wiemy o conb
            String login, password;;
            login = logtxt.Text;
            password = passtxt.Text;
            int i = 0;
            try
            {
                String querry = "SELECT * FROM users WHERE login = '" + login + "' AND password = '" + password + "'";//zapytanko do bazy
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);//tworzymy adapter by pozniej stworzyc baze danych i wypchac ją danymi pobranymi z komendy powyzej
                DataTable dtable = new DataTable();//to taki adapter bazy danych jakby
                sda.Fill(dtable);
                DataRow[] admincheck = dtable.Select("admin = '" + true + "'");

                DataRow[] rolecheck1 = dtable.Select("rola = '" + 1 + "'");// tutaj sprawdzamy czy w podanym userze istnieje cos co w kolumnie rola ma 1 czyli ucznia no i tak po koleji cale te
                if (rolecheck1.Length != 0)
                {
                    userControl11.Show();
                    userControl11.BringToFront();
                    MessageBox.Show("prrr", "uczen" + i, MessageBoxButtons.OK, MessageBoxIcon.Information);//to takie fajne message boxy co som jak wygrales iphone kliknij ok
                    if (admincheck.Length != 0)
                    {
                        //tu wjebać komunistyczne pierdolenie co sie bedzie dzialo jak masz admina
                    }
                }
                DataRow[] rolecheck2 = dtable.Select("rola = '" + 2 + "'");
                if (rolecheck2.Length != 0)
                {
                    userControl11.Show();
                    userControl11.BringToFront();
                    MessageBox.Show("prrr", "rodzic" + i, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (admincheck.Length != 0)
                    {
                        //tu wjebać komunistyczne pierdolenie co sie bedzie dzialo jak masz admina
                    }
                }
                DataRow[] rolecheck3 = dtable.Select("rola = '" + 3 + "'");
                if (rolecheck3.Length != 0)
                {
                    userControl11.Show();
                    userControl11.BringToFront();
                    MessageBox.Show("prrr", "nauczyciel" + i, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (admincheck.Length != 0)
                    {
                        //tu wjebać komunistyczne pierdolenie co sie bedzie dzialo jak masz admina
                    }
                }
            }
            
            catch
            {
                

                MessageBox.Show("prrr", "błont"+i, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            registerwindow1.Show();
            registerwindow1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            registerwindow1.Hide();
        }

        private void registerwindow1_Load(object sender, EventArgs e)
        {
            
        }

        private void registerwindow1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
