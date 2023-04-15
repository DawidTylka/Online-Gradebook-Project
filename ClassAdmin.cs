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
    public partial class ClassAdmin : UserControl
    {
        public ClassAdmin()
        {
            InitializeComponent();
        }

        private void ClassAdmin_Load(object sender, EventArgs e)
        {
            this.klasyTableAdapter1.Fill(onlinegradebookprojectDataSet.Klasy);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.KlasySource1.EndEdit();
            this.klasyTableAdapter1.Update(onlinegradebookprojectDataSet.Klasy);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.klasyTableAdapter1.Fill(onlinegradebookprojectDataSet.Klasy);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
