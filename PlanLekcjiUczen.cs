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
    public partial class PlanLekcjiUczen : UserControl
    {
        public PlanLekcjiUczen()
        {
            InitializeComponent();
        }

        private void PlanLekcjiUczen_Load(object sender, EventArgs e)
        {
            this.dniTableAdapter.Fill(onlinegradebookprojectDataSet.Dni);
        }
    }
}
