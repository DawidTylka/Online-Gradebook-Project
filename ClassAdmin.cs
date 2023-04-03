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
    public partial class ClassAdmin : UserControl
    {
        public ClassAdmin()
        {
            InitializeComponent();
        }

        private void ClassAdmin_Load(object sender, EventArgs e)
        {
            this.klasyTableAdapter1.Fill(onlinegradebookprojectDataSet.Klasy);
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.KlasySource1.EndEdit();
            this.klasyTableAdapter1.Update(onlinegradebookprojectDataSet.Klasy);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.klasyTableAdapter1.Fill(onlinegradebookprojectDataSet.Klasy);
        }
    }
}
