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
    public partial class PlansAdmin : UserControl
    {
        public PlansAdmin()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dniBindingSource.EndEdit();
            this.dniTableAdapter.Update(onlinegradebookprojectDataSet.Dni);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dniTableAdapter.Fill(onlinegradebookprojectDataSet.Dni);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
