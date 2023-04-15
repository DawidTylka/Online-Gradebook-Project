﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tylka.apkrodzic
{
    public partial class PrzedmiotyRodzic : UserControl
    {
        public PrzedmiotyRodzic()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.przedmiotybindingSource1.EndEdit();
            this.przedmiotyTableAdapter.Update(onlinegradebookprojectDataSet1.Przedmioty);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.przedmiotyTableAdapter.Fill(onlinegradebookprojectDataSet1.Przedmioty);
        }
    }
}
