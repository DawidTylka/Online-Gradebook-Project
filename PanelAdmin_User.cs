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
using Tylka.dziennik_funkcje;

namespace Tylka
{
    public partial class PanelAdmin_User : Form
    {
        private void Hidef() 
        {
            usersAdmin1.Hide();
            plansAdmin1.Hide();
            classAdmin1.Hide();
            przedmiotyAdmin1.Hide();
            examsAdmin1.Hide();
            ocenyAdmin1.Hide();
            message1.Hide();
            home1.Hide();
        }
        public PanelAdmin_User()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            UserData.admin = true;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Hidef();
            home1.Show();
            label1.Text = "Home";
        }

        private void Klasy_Click(object sender, EventArgs e)
        {
            Hidef();
            classAdmin1.Show();
            label1.Text = "Klasy";
        }

        private void Plany_Lekcji_Click(object sender, EventArgs e)
        {
            Hidef();
            plansAdmin1.Show();
            label1.Text = "Plan lekcji";
        }

        private void Przedmioty_Click(object sender, EventArgs e)
        {
            Hidef();
            przedmiotyAdmin1.Show();
            label1.Text = "Przedmioty";

        }

        private void Sprawdziany_Click(object sender, EventArgs e)
        {
            Hidef();
            examsAdmin1.Show();
            label1.Text = "Sprawdziany";
        }

        private void Urzytkownicy_Click(object sender, EventArgs e)
        {
            Hidef();
            usersAdmin1.Show();
            label1.Text = "Użytkownicy";
        }

        private void PanelAdmin_User_Load(object sender, EventArgs e)
        {
            Hidef();
            home1.Show();
            usersAdmin1.Parent = this.gradient1;
            plansAdmin1.Parent = this.gradient1;
            classAdmin1.Parent = this.gradient1;
            przedmiotyAdmin1.Parent = this.gradient1;
            examsAdmin1.Parent = this.gradient1;
            home1.Parent = this.gradient1;
            // TODO: This line of code loads data into the 'onlinegradebookprojectDataSet.Users' table. You can move, or remove it, as needed.

        }

        private void usersTabAdmin1_Load(object sender, EventArgs e)
        {
            
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Hidef();
            ocenyAdmin1.Show();
            label1.Text = "Oceny";
        }

        private void ocenyAdmin1_Load(object sender, EventArgs e)
        {

        }

        private void wiadomosci_Click(object sender, EventArgs e)
        {
            Hidef();
            message1.Show();
            label1.Text = "Wiadomości";
        }
    }
}
