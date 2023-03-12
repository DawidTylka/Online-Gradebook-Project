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

            //buttons disable
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //hide Tab control
            this.TabAdmin_User.ItemSize = new Size(0, 1);
            this.TabAdmin_User.SizeMode = TabSizeMode.Fixed;
            this.TabAdmin_User.SizeMode = TabSizeMode.FillToRight;
            this.TabAdmin_User.Multiline = true;
            this.TabAdmin_User.Padding = new Point(0, 0);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.TabAdmin_User.SelectTab(this.TabHome);
        }

        private void Klasy_Click(object sender, EventArgs e)
        {
            this.TabAdmin_User.SelectTab(this.TabKlasy);
        }

        private void Plany_Lekcji_Click(object sender, EventArgs e)
        {
            this.TabAdmin_User.SelectTab(this.TabPlanLekcji);
        }

        private void Przedmioty_Click(object sender, EventArgs e)
        {
            this.TabAdmin_User.SelectTab(this.TabPrzedmioty);
        }

        private void Sprawdziany_Click(object sender, EventArgs e)
        {
            this.TabAdmin_User.SelectTab(this.TabSprawdziany);
        }

        private void Urzytkownicy_Click(object sender, EventArgs e)
        {
            this.TabAdmin_User.SelectTab(this.TabUrzytkownicy);
        }

        
    }
}
