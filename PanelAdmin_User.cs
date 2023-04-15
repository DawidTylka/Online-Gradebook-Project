using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tylka
{
    public partial class PanelAdmin_User : Form
    {
        public void Hidef() 
        {
            usersAdmin1.Hide();
            plansAdmin1.Hide();
            classAdmin1.Hide();
            przedmiotyAdmin1.Hide();
            examsAdmin1.Hide();
        }
        public PanelAdmin_User()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Hidef();
        }

        private void Klasy_Click(object sender, EventArgs e)
        {
            Hidef();
            classAdmin1.Show();
        }

        private void Plany_Lekcji_Click(object sender, EventArgs e)
        {
            Hidef();
            plansAdmin1.Show();
        }

        private void Przedmioty_Click(object sender, EventArgs e)
        {
            Hidef();
            przedmiotyAdmin1.Show();
            
        }

        private void Sprawdziany_Click(object sender, EventArgs e)
        {
            Hidef();
            examsAdmin1.Show();
        }

        private void Urzytkownicy_Click(object sender, EventArgs e)
        {
            Hidef();
            usersAdmin1.Show();
        }

        private void PanelAdmin_User_Load(object sender, EventArgs e)
        {
            Hidef();
            // TODO: This line of code loads data into the 'onlinegradebookprojectDataSet.Users' table. You can move, or remove it, as needed.

        }

        private void usersTabAdmin1_Load(object sender, EventArgs e)
        {
            usersAdmin1.Parent = this.gradient1;
            plansAdmin1.Parent = this.gradient1;
            classAdmin1.Parent = this.gradient1;
            przedmiotyAdmin1.Parent = this.gradient1;
            examsAdmin1.Parent = this.gradient1;
        }
    }
}
