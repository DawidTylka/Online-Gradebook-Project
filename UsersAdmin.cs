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
    public partial class UsersAdmin : UserControl
    {
        public UsersAdmin()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.usersTableAdapter.Update(onlinegradebookprojectDataSet.Users);
        }

        private void UsersAdmin_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(onlinegradebookprojectDataSet.Users);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(onlinegradebookprojectDataSet.Users);
        }
    }
}
