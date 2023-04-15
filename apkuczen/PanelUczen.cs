using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tylka.apkuczen
{
    public partial class PanelUczen : Form
    {
        public PanelUczen()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            planLekcjiUczen1.Hide();
            przedmiotyUczen1.Hide();
            sprawdzianyUczen1.Hide();
            klasyUczen1.Hide();
        }

        private void Klasy_Click(object sender, EventArgs e)
        {
            klasyUczen1.Show();
            planLekcjiUczen1.Hide();
            przedmiotyUczen1.Hide();
            sprawdzianyUczen1.Hide();
        }

        private void Plany_Lekcji_Click(object sender, EventArgs e)
        {

            planLekcjiUczen1.Show();
            przedmiotyUczen1.Hide();
            sprawdzianyUczen1.Hide();
            klasyUczen1.Hide();
        }

        private void Przedmioty_Click(object sender, EventArgs e)
        {
            przedmiotyUczen1.Show();
            planLekcjiUczen1.Hide();
            sprawdzianyUczen1.Hide();
            klasyUczen1.Hide();
        }

        private void Sprawdziany_Click(object sender, EventArgs e)
        {
            sprawdzianyUczen1.Show();
            przedmiotyUczen1.Hide();
            planLekcjiUczen1.Hide();
            klasyUczen1.Hide();
        }

        private void PanelUczen_Load(object sender, EventArgs e)
        {
            planLekcjiUczen1.Hide();
            przedmiotyUczen1.Hide();
            sprawdzianyUczen1.Hide();
            klasyUczen1.Hide();
            planLekcjiUczen1.Parent = this.gradient1;
            przedmiotyUczen1.Parent = this.gradient1;
            sprawdzianyUczen1.Parent = this.gradient1;
            klasyUczen1.Parent = this.gradient1;
        }
    }
}
