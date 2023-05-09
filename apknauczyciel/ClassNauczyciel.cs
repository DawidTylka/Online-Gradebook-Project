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
    public partial class ClassNauczyciel : UserControl
    {
        public ClassNauczyciel()
        {
            InitializeComponent();
        }
        private void ClassNauczyciel_Load(object sender, EventArgs e)
        {
            this.klasyTableAdapter1.Fill(onlinegradebookprojectDataSet1.Klasy);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
