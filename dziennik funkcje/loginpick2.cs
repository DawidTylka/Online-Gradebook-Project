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
    public partial class loginpick2 : UserControl
    {
        public loginpick2()
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
            apkrodzic.PanelRodzic panelrodzic = new apkrodzic.PanelRodzic();
            panelrodzic.Show();
        }
    }
}
