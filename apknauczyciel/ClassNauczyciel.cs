using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tylka.apknauczyciel
{
    public partial class ClassNauczyciel : UserControl
    {
        public ClassNauczyciel()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klasyBindingSource.EndEdit();
            this.klasyTableAdapter1.Update(onlinegradebookprojectDataSet1.Klasy);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.klasyTableAdapter1.Fill(onlinegradebookprojectDataSet1.Klasy);
        }
    }
}
