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
    public partial class PrzedmiotyNauczyciel : UserControl
    {
        public PrzedmiotyNauczyciel()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }
        private void PrzedmiotyNauczyciel_Load(object sender, EventArgs e)
        {
            this.przedmiotyTableAdapter.Fill(onlinegradebookprojectDataSet1.Przedmioty);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
