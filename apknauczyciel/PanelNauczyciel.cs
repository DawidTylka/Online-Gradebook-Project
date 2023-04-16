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
            chowaj();
            UserData.admin = false;
        }

        private void chowaj()
        {
            classNauczyciel1.Hide();
            plansNauczyciel1.Hide();
            przedmiotyNauczyciel1.Hide();
            examsNauczyciel1.Hide();
            home1.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            chowaj();
            home1.Show();
        }

        private void Klasy_Click(object sender, EventArgs e)
        {
            chowaj();
            classNauczyciel1.Show();
        }

        private void Plany_Lekcji_Click(object sender, EventArgs e)
        {
            chowaj();
            plansNauczyciel1.Show();
        }

        private void Przedmioty_Click(object sender, EventArgs e)
        {
            chowaj();
            przedmiotyNauczyciel1.Show();
        }

        private void Sprawdziany_Click(object sender, EventArgs e)
        {
            chowaj();
            examsNauczyciel1.Show();
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
    }
}
