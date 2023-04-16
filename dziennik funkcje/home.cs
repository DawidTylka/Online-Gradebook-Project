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

namespace Tylka.dziennik_funkcje
{
    public partial class home : UserControl
    {
        public home(bool admint = false)
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            this.zalogowany.Text = "Witaj " + UserData.login_all;
            DateTime localDate = DateTime.Now;
            this.data.Text = localDate.ToString();
            chart1.Series["Salary"].IsValueShownAsLabel = true;
            //chart1.Series["Salary"].Points.AddXY("0", "0");
            if (UserData.admin)
            {
                foreach (Data series in UserData.dataAadmin)
                {
                    chart1.Series["Salary"].Points.AddXY(series.v1, series.v2);
                }
                chart1.Titles.Add("" + UserData.adminTitle);
            }
            else
            {
                foreach (Data series in UserData.data)
                {
                    chart1.Series["Salary"].Points.AddXY(series.v1, series.v2);
                }
                chart1.Titles.Add("" + UserData.title);
            }
        }
    }
}
