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
    public partial class ClassRodzic : UserControl
    {
        public ClassRodzic()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classbindingSource1.EndEdit();
            this.klasyTableAdapter.Update(onlinegradebookprojectDataSet1.Klasy);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.klasyTableAdapter.Fill(onlinegradebookprojectDataSet1.Klasy);
        }
    }
}
