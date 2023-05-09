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

namespace Tylka.apknauczyciel
{
    public partial class ExamsNauczyciel : UserControl
    {
        public ExamsNauczyciel()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examsbindingSource1.EndEdit();
            this.sprawdzianyTableAdapter.Update(onlinegradebookprojectDataSet1.Sprawdziany);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.sprawdzianyTableAdapter.Fill(onlinegradebookprojectDataSet1.Sprawdziany);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void ExamsNauczyciel_Load(object sender, EventArgs e)
        {
            this.sprawdzianyTableAdapter.Fill(onlinegradebookprojectDataSet1.Sprawdziany);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
