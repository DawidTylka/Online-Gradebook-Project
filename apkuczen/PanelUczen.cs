using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tylka.apkrodzic;
using Tylka.dziennik_funkcje;

namespace Tylka.apkuczen
{
    public partial class PanelUczen : Form
    {
        public PanelUczen()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            UserData.admin = false;
        }
        private void chowaj()
        {
            sprawdzianyUczen1.Hide();
            przedmiotyUczen1.Hide();
            planLekcjiUczen1.Hide();
            klasyUczen1.Hide();
            edycjaDanychUczen1.Hide();
            ocenyUczen1.Hide();
            message1.Hide();
            home2.Hide();

        }
        private void Home_Click(object sender, EventArgs e)
        {
            chowaj();
            home2.Show();
        }


        private void Plany_Lekcji_Click(object sender, EventArgs e)
        {
            chowaj();
            planLekcjiUczen1.Show();
        }

        private void Przedmioty_Click(object sender, EventArgs e)
        {
            chowaj();
            przedmiotyUczen1.Show();
        }

        private void Sprawdziany_Click(object sender, EventArgs e)
        {
            chowaj();
            sprawdzianyUczen1.Show();
        }

        private void PanelUczen_Load(object sender, EventArgs e)
        {
            chowaj();
            home2.Show();
        }

        private void Edycja_Danych_Click(object sender, EventArgs e)
        {
            chowaj();
            edycjaDanychUczen1.Show();
        }

        private void oceny_Click(object sender, EventArgs e)
        {
            chowaj();
            ocenyUczen1.Show();
        }

        private void wiadomosci_Click(object sender, EventArgs e)
        {
            chowaj();
            message1.Show();
        }
    }
}
