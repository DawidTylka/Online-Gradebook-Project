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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Tylka
{
    public partial class UsersAdmin : UserControl
    {
        public UsersAdmin()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.usersTableAdapter.Update(onlinegradebookprojectDataSet.Users);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void UsersAdmin_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(onlinegradebookprojectDataSet.Users);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(onlinegradebookprojectDataSet.Users);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

    }
}
