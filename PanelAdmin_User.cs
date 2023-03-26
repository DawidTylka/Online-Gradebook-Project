using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tylka
{
    public partial class PanelAdmin_User : Form
    {
        public PanelAdmin_User()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            usersAdmin1.Hide();
            plansAdmin1.Hide();
            classAdmin1.Hide();
            przedmiotyAdmin1.Hide();
            examsAdmin1.Hide();
        }

        private void Klasy_Click(object sender, EventArgs e)
        {
            classAdmin1.Show();
            usersAdmin1.Hide();
            plansAdmin1.Hide();
            przedmiotyAdmin1.Hide();
            examsAdmin1.Hide();
        }

        private void Plany_Lekcji_Click(object sender, EventArgs e)
        {
            usersAdmin1.Hide();
            classAdmin1.Hide();
            przedmiotyAdmin1.Hide();
            examsAdmin1.Hide();
            plansAdmin1.Show();
        }

        private void Przedmioty_Click(object sender, EventArgs e)
        {
            przedmiotyAdmin1.Show();
            usersAdmin1.Hide();
            classAdmin1.Hide();
            classAdmin1.Hide();
            examsAdmin1.Hide();
        }

        private void Sprawdziany_Click(object sender, EventArgs e)
        {
            examsAdmin1.Show();
            przedmiotyAdmin1.Hide();
            usersAdmin1.Hide();
            classAdmin1.Hide();
            classAdmin1.Hide();
        }

        private void Urzytkownicy_Click(object sender, EventArgs e)
        {
            usersAdmin1.Show();
            plansAdmin1.Hide();
            classAdmin1.Hide();
            przedmiotyAdmin1.Hide();
            examsAdmin1.Hide();
        }

        private void PanelAdmin_User_Load(object sender, EventArgs e)
        {
            usersAdmin1.Hide();
            plansAdmin1.Hide();
            classAdmin1.Hide();
            przedmiotyAdmin1.Hide();
            examsAdmin1.Hide();
            // TODO: This line of code loads data into the 'onlinegradebookprojectDataSet.Users' table. You can move, or remove it, as needed.

        }

        private void usersTabAdmin1_Load(object sender, EventArgs e)
        {

        }
    }
}
