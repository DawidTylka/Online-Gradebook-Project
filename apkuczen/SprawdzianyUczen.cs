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

namespace Tylka.apkuczen
{
    public partial class SprawdzianyUczen : UserControl
    {
        public SprawdzianyUczen()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        private void SprawdzianyUczen_Load(object sender, EventArgs e)
        {
            this.sprawdzianyTableAdapter.Fill(onlinegradebookprojectDataSet.Sprawdziany);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
