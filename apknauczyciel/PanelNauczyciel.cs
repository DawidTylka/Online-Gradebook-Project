using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tylka.apkuczen;
using Tylka.dziennik_funkcje;

namespace Tylka.apknauczyciel
{
    public partial class PanelNauczyciel : Form
    {
        public PanelNauczyciel()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            UserData.admin = false;
            chowaj();
        }

        private void chowaj()
        {
            classNauczyciel1.Hide();
            plansNauczyciel1.Hide();
            przedmiotyNauczyciel1.Hide();
            examsNauczyciel1.Hide();
            ocenyNauczyciel1.Hide();
            edycjaDanychNauczyciel1.Hide();
            sendMessage1.Hide();
            message1.Hide();
            home1.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            chowaj();
            home1.Show();
            label1.Text = "Home";
        }

        private void Klasy_Click(object sender, EventArgs e)
        {
            chowaj();
            classNauczyciel1.Show();
            label1.Text = "Klasy";
        }

        private void Plany_Lekcji_Click(object sender, EventArgs e)
        {
            chowaj();
            plansNauczyciel1.Show();
            label1.Text = "Plan lekcji";
        }

        private void Przedmioty_Click(object sender, EventArgs e)
        {
            chowaj();
            przedmiotyNauczyciel1.Show();
            label1.Text = "Przedmioty";
        }

        private void Sprawdziany_Click(object sender, EventArgs e)
        {
            chowaj();
            examsNauczyciel1.Show();
            label1.Text = "Sprawdziany";
        }

        private void PanelNauczyciel_Load(object sender, EventArgs e)
        {
            classNauczyciel1.Parent = this.gradient1;
            plansNauczyciel1.Parent = this.gradient1;
            przedmiotyNauczyciel1.Parent = this.gradient1;
            examsNauczyciel1.Parent = this.gradient1;
            home1.Parent = this.gradient1;
            home1.Show();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            chowaj();
            ocenyNauczyciel1.Show();
            label1.Text = "Oceny";
        }

        private void Edycja_Danych_Click(object sender, EventArgs e)
        {
            chowaj();
            edycjaDanychNauczyciel1.Show();
            label1.Text = "Edycja danych";
        }

        private void edycjaDanychNauczyciel1_Load(object sender, EventArgs e)
        {

        }

        private void wiadomosci_Click(object sender, EventArgs e)
        {
            chowaj();
            message1.Show();
            label1.Text = "Wiadomości";
        }
    }
}
