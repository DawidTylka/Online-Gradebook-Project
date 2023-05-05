using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tylka.dziennik_funkcje;

namespace Tylka
{
    public partial class ExamsAdmin : UserControl
    {
        public ExamsAdmin()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        private void ExamsAdmin_Load(object sender, EventArgs e)
        {
            this.sprawdzianyTableAdapter1.Fill(onlinegradebookprojectDataSet1.Sprawdziany);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sprawdzianybindingSource1.EndEdit();
            this.sprawdzianyTableAdapter1.Update(onlinegradebookprojectDataSet1.Sprawdziany);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.sprawdzianyTableAdapter1.Fill(onlinegradebookprojectDataSet1.Sprawdziany);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
