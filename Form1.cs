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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            registerwindow1.Show();
            registerwindow1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            registerwindow1.Hide();
        }
    }
}
