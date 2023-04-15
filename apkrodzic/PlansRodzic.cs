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
    public partial class PlansRodzic : UserControl
    {
        public PlansRodzic()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plansbindingSource1.EndEdit();
            this.dniTableAdapter.Update(onlinegradebookprojectDataSet1.Dni);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dniTableAdapter.Fill(onlinegradebookprojectDataSet1.Dni);
        }
    }
}
