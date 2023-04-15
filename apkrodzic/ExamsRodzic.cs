using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tylka.apkrodzic
{
    public partial class ExamsRodzic : UserControl
    {
        public ExamsRodzic()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examsbindingSource1.EndEdit();
            this.sprawdzianyTableAdapter.Update(onlinegradebookprojectDataSet1.Sprawdziany);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.sprawdzianyTableAdapter.Fill(onlinegradebookprojectDataSet1.Sprawdziany);
        }
    }
}
