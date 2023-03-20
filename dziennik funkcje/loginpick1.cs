using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tylka.dziennik_funkcje
{
    public partial class loginpick1 : UserControl
    {
        public loginpick1()
        {
            InitializeComponent();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Tylka.PanelAdmin_User paneladmin = new Tylka.PanelAdmin_User();
            paneladmin.Show();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            apkuczen.PanelUczen paneluczen = new apkuczen.PanelUczen();
            paneluczen.Show();
        }
    }
}
