﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tylka
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(onlinegradebookprojectDataSet.Users);
            // TODO: This line of code loads data into the 'onlinegradebookprojectDataSet.Users' table. You can move, or remove it, as needed.

        }
    }
}
