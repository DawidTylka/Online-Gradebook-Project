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
    public partial class ExamsAdmin : UserControl
    {
        public ExamsAdmin()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sprawdzianybindingSource1.EndEdit();
            this.sprawdzianyTableAdapter1.Update(onlinegradebookprojectDataSet1.Sprawdziany);
        }

        private void ExamsAdmin_Load(object sender, EventArgs e)
        {
            this.sprawdzianyTableAdapter1.Fill(onlinegradebookprojectDataSet1.Sprawdziany);
        }
    }
}
