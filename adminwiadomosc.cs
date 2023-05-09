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
    public partial class adminwiadomosc : UserControl
    {
        public adminwiadomosc()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wiadomosciBindingSource.EndEdit();
            this.wiadomosciTableAdapter.Update(onlinegradebookprojectDataSet.Wiadomosci);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.wiadomosciTableAdapter.Fill(onlinegradebookprojectDataSet.Wiadomosci);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void adminwiadomosc_Load(object sender, EventArgs e)
        {
            //this.wiadomosciTableAdapter.Fill(onlinegradebookprojectDataSet.Wiadomosci);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
