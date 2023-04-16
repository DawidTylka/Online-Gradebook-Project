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
            UserData.admin = false;
        }
        private void chowaj()
        {
            planLekcjiUczen1.Hide();
            przedmiotyUczen1.Hide();
            sprawdzianyUczen1.Hide();
            klasyUczen1.Hide();
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
            klasyUczen1.Show();
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
            home1.Show();
            planLekcjiUczen1.Parent = this.gradient1;
            przedmiotyUczen1.Parent = this.gradient1;
            sprawdzianyUczen1.Parent = this.gradient1;
            klasyUczen1.Parent = this.gradient1;
            home1.Parent = this.gradient1;
        }
    }
}
