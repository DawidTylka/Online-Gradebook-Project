﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tylka.apknauczyciel;
using Tylka.apkuczen;
using Tylka.dziennik_funkcje;

namespace Tylka.apkrodzic
{
    public partial class PanelRodzic : Form
    {
        public PanelRodzic()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            UserData.admin = false;
            chowaj();
        }

        private void chowaj()
        {
            plansRodzic1.Hide();
            przedmiotyRodzic1.Hide();
            examsRodzic1.Hide();
            ocenyRodzic1.Hide();
            edycjaDanychRodzic1.Hide();
            message1.Hide();
            home1.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            chowaj();
            home1.Show();
            label1.Text = "Home";
        }
        private void Plany_Lekcji_Click(object sender, EventArgs e)
        {
            chowaj();
            plansRodzic1.Show();
            label1.Text = "Plan lekcji";
        }

        private void Przedmioty_Click(object sender, EventArgs e)
        {
            chowaj();
            przedmiotyRodzic1.Show();
            label1.Text = "Przedmioty";
        }

        private void Sprawdziany_Click(object sender, EventArgs e)
        {
            chowaj();
            examsRodzic1.Show();
            label1.Text = "Sprawdziany";
        }

        private void PanelRodzic_Load(object sender, EventArgs e)
        {
            plansRodzic1.Parent = this.gradient1;
            przedmiotyRodzic1.Parent = this.gradient1;
            examsRodzic1.Parent = this.gradient1; 
            home1.Parent = this.gradient1;
            home1.Show();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            chowaj();
            ocenyRodzic1.Show();
        }

        private void Edycja_Danych_Click(object sender, EventArgs e)
        {
            chowaj();
            edycjaDanychRodzic1.Show();
            label1.Text = "Edycja danych";
        }

        private void wiadomosci_Click(object sender, EventArgs e)
        {
            chowaj();
            message1.Show();
            label1.Text = "Wiadomości";
        }
    }
}
