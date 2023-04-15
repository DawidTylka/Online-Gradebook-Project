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
    public partial class PrzedmiotyAdmin : UserControl
    {
        public PrzedmiotyAdmin()
        {
            InitializeComponent();
        }

        private void PrzedmiotyAdmin_Load(object sender, EventArgs e)
        {
            this.przedmiotyTableAdapter1.Fill(onlinegradebookprojectDataSet1.Przedmioty);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView2);
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.przedmiotyBindingSource1.EndEdit();
            this.przedmiotyTableAdapter1.Update(onlinegradebookprojectDataSet1.Przedmioty);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView2);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.przedmiotyTableAdapter1.Fill(onlinegradebookprojectDataSet1.Przedmioty);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView2);
        }

    }
}
