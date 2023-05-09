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
    public partial class OcenyNauczyciel : UserControl
    {
        
        public OcenyNauczyciel()
        {
            InitializeComponent();
            dataGridView2.RowHeadersVisible = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ocenyBindingSource.EndEdit();
            this.ocenyTableAdapter.Update(onlinegradebookprojectDataSet.Oceny);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView2);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.ocenyTableAdapter.Fill(onlinegradebookprojectDataSet.Oceny);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView2);
        }

        private void OcenyNauczyciel_Load(object sender, EventArgs e)
        {

            this.ocenyTableAdapter.Fill(onlinegradebookprojectDataSet.Oceny);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView2);
        }
    }
}
