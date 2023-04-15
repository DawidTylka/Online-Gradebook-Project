using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tylka.dziennik_funkcje
{
    internal class Resize_data
    {
            public void Table_auto_size(DataGridView dataGridView)
            {
                int addition = 0;
                int colw = 0;
                for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
                {
                
                colw = (dataGridView.Width - addition) / (dataGridView.Columns.Count - i);
                    int colw_help = dataGridView.Columns[i].Width;
                    if (colw_help * 1.5 < colw) colw = colw_help;
                    addition += colw;
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridView.Columns[i].Width = colw;
                }
                colw = (dataGridView.Width - addition - 20);
                dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView.Columns[dataGridView.Columns.Count - 1].Width = colw;
            }
    }
}
