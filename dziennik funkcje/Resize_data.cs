using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tylka.dziennik_funkcje
{
    public class Data
    {
        public String v1;
        public int v2;

        public Data(String x, int y)
        {
            v1 = x;
            v2 = y;
        }
    }
    static class UserData
    {
        public static String login_all;
        public static List<Data> data = new List<Data>();
        public static List<Data> dataAadmin = new List<Data>();
        public static bool admin = false;
        public static String title;
        public static String adminTitle;
    }
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
