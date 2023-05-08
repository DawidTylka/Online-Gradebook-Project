namespace Tylka.apkuczen
{
    partial class PanelUczen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelUczen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ocenyTableAdapter1 = new Tylka.onlinegradebookprojectDataSetTableAdapters.OcenyTableAdapter();
            this.Home = new Tylka.CustomButton();
            this.gradient1 = new Tylka.Gradient();
            this.wiadomosci = new Tylka.CustomButton();
            this.ocenyUczen1 = new Tylka.apkuczen.OcenyUczen();
            this.edycjaDanychUczen1 = new Tylka.apkuczen.EdycjaDanychUczen();
            this.sprawdzianyUczen1 = new Tylka.apkuczen.SprawdzianyUczen();
            this.przedmiotyUczen1 = new Tylka.apkuczen.PrzedmiotyUczen();
            this.planLekcjiUczen1 = new Tylka.apkuczen.PlanLekcjiUczen();
            this.klasyUczen1 = new Tylka.apkuczen.KlasyUczen();
            this.home2 = new Tylka.dziennik_funkcje.home();
            this.gradient8 = new Tylka.Gradient();
            this.Sprawdziany = new Tylka.CustomButton();
            this.Przedmioty = new Tylka.CustomButton();
            this.Plany_Lekcji = new Tylka.CustomButton();
            this.Edycja_Danych = new Tylka.CustomButton();
            this.oceny = new Tylka.CustomButton();
            this.message1 = new Tylka.apknauczyciel.message();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(47, 20, 47, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // ocenyTableAdapter1
            // 
            this.ocenyTableAdapter1.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.Home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Home.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.Home.BorderRadius = 30;
            this.Home.BorderSize = 1;
            this.Home.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.Home.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(16, 135);
            this.Home.Margin = new System.Windows.Forms.Padding(5);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(150, 30);
            this.Home.TabIndex = 15;
            this.Home.Text = "Home";
            this.Home.TextColor = System.Drawing.Color.White;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.gradient1.Controls.Add(this.message1);
            this.gradient1.Controls.Add(this.wiadomosci);
            this.gradient1.Controls.Add(this.ocenyUczen1);
            this.gradient1.Controls.Add(this.edycjaDanychUczen1);
            this.gradient1.Controls.Add(this.sprawdzianyUczen1);
            this.gradient1.Controls.Add(this.przedmiotyUczen1);
            this.gradient1.Controls.Add(this.planLekcjiUczen1);
            this.gradient1.Controls.Add(this.klasyUczen1);
            this.gradient1.Controls.Add(this.home2);
            this.gradient1.Controls.Add(this.gradient8);
            this.gradient1.Controls.Add(this.Sprawdziany);
            this.gradient1.Controls.Add(this.Przedmioty);
            this.gradient1.Controls.Add(this.Plany_Lekcji);
            this.gradient1.Controls.Add(this.Edycja_Danych);
            this.gradient1.Controls.Add(this.oceny);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(984, 511);
            this.gradient1.TabIndex = 17;
            // 
            // wiadomosci
            // 
            this.wiadomosci.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wiadomosci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.wiadomosci.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.wiadomosci.BorderRadius = 30;
            this.wiadomosci.BorderSize = 1;
            this.wiadomosci.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.wiadomosci.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.wiadomosci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wiadomosci.FlatAppearance.BorderSize = 0;
            this.wiadomosci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wiadomosci.ForeColor = System.Drawing.Color.White;
            this.wiadomosci.Location = new System.Drawing.Point(14, 369);
            this.wiadomosci.Name = "wiadomosci";
            this.wiadomosci.Size = new System.Drawing.Size(150, 30);
            this.wiadomosci.TabIndex = 23;
            this.wiadomosci.Text = "Wiadomości";
            this.wiadomosci.TextColor = System.Drawing.Color.White;
            this.wiadomosci.UseVisualStyleBackColor = false;
            this.wiadomosci.Click += new System.EventHandler(this.wiadomosci_Click);
            // 
            // ocenyUczen1
            // 
            this.ocenyUczen1.BackColor = System.Drawing.Color.Transparent;
            this.ocenyUczen1.Location = new System.Drawing.Point(187, 47);
            this.ocenyUczen1.Name = "ocenyUczen1";
            this.ocenyUczen1.Size = new System.Drawing.Size(789, 400);
            this.ocenyUczen1.TabIndex = 21;
            // 
            // edycjaDanychUczen1
            // 
            this.edycjaDanychUczen1.BackColor = System.Drawing.Color.Transparent;
            this.edycjaDanychUczen1.Location = new System.Drawing.Point(187, 47);
            this.edycjaDanychUczen1.Margin = new System.Windows.Forms.Padding(4);
            this.edycjaDanychUczen1.Name = "edycjaDanychUczen1";
            this.edycjaDanychUczen1.Size = new System.Drawing.Size(789, 400);
            this.edycjaDanychUczen1.TabIndex = 20;
            // 
            // sprawdzianyUczen1
            // 
            this.sprawdzianyUczen1.BackColor = System.Drawing.Color.Transparent;
            this.sprawdzianyUczen1.Location = new System.Drawing.Point(187, 47);
            this.sprawdzianyUczen1.Margin = new System.Windows.Forms.Padding(4);
            this.sprawdzianyUczen1.Name = "sprawdzianyUczen1";
            this.sprawdzianyUczen1.Size = new System.Drawing.Size(789, 400);
            this.sprawdzianyUczen1.TabIndex = 19;
            // 
            // przedmiotyUczen1
            // 
            this.przedmiotyUczen1.BackColor = System.Drawing.Color.Transparent;
            this.przedmiotyUczen1.Location = new System.Drawing.Point(187, 47);
            this.przedmiotyUczen1.Margin = new System.Windows.Forms.Padding(4);
            this.przedmiotyUczen1.Name = "przedmiotyUczen1";
            this.przedmiotyUczen1.Size = new System.Drawing.Size(789, 400);
            this.przedmiotyUczen1.TabIndex = 18;
            // 
            // planLekcjiUczen1
            // 
            this.planLekcjiUczen1.BackColor = System.Drawing.Color.Transparent;
            this.planLekcjiUczen1.Location = new System.Drawing.Point(187, 47);
            this.planLekcjiUczen1.Margin = new System.Windows.Forms.Padding(2);
            this.planLekcjiUczen1.Name = "planLekcjiUczen1";
            this.planLekcjiUczen1.Size = new System.Drawing.Size(789, 400);
            this.planLekcjiUczen1.TabIndex = 17;
            // 
            // klasyUczen1
            // 
            this.klasyUczen1.BackColor = System.Drawing.Color.Transparent;
            this.klasyUczen1.Location = new System.Drawing.Point(187, 47);
            this.klasyUczen1.Margin = new System.Windows.Forms.Padding(4);
            this.klasyUczen1.Name = "klasyUczen1";
            this.klasyUczen1.Size = new System.Drawing.Size(789, 400);
            this.klasyUczen1.TabIndex = 16;
            // 
            // home2
            // 
            this.home2.BackColor = System.Drawing.Color.Transparent;
            this.home2.Location = new System.Drawing.Point(187, 47);
            this.home2.Margin = new System.Windows.Forms.Padding(2);
            this.home2.Name = "home2";
            this.home2.Size = new System.Drawing.Size(789, 400);
            this.home2.TabIndex = 15;
            // 
            // gradient8
            // 
            this.gradient8.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.gradient8.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.gradient8.Location = new System.Drawing.Point(175, 0);
            this.gradient8.Margin = new System.Windows.Forms.Padding(0);
            this.gradient8.Name = "gradient8";
            this.gradient8.Size = new System.Drawing.Size(10, 662);
            this.gradient8.TabIndex = 14;
            // 
            // Sprawdziany
            // 
            this.Sprawdziany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Sprawdziany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.Sprawdziany.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.Sprawdziany.BorderRadius = 30;
            this.Sprawdziany.BorderSize = 1;
            this.Sprawdziany.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.Sprawdziany.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.Sprawdziany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sprawdziany.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.Sprawdziany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sprawdziany.ForeColor = System.Drawing.Color.White;
            this.Sprawdziany.Location = new System.Drawing.Point(14, 295);
            this.Sprawdziany.Margin = new System.Windows.Forms.Padding(5);
            this.Sprawdziany.Name = "Sprawdziany";
            this.Sprawdziany.Size = new System.Drawing.Size(150, 30);
            this.Sprawdziany.TabIndex = 13;
            this.Sprawdziany.Text = "Sprawdziany";
            this.Sprawdziany.TextColor = System.Drawing.Color.White;
            this.Sprawdziany.UseVisualStyleBackColor = false;
            this.Sprawdziany.Click += new System.EventHandler(this.Sprawdziany_Click);
            // 
            // Przedmioty
            // 
            this.Przedmioty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Przedmioty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.Przedmioty.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.Przedmioty.BorderRadius = 30;
            this.Przedmioty.BorderSize = 1;
            this.Przedmioty.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.Przedmioty.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.Przedmioty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Przedmioty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.Przedmioty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Przedmioty.ForeColor = System.Drawing.Color.White;
            this.Przedmioty.Location = new System.Drawing.Point(14, 255);
            this.Przedmioty.Margin = new System.Windows.Forms.Padding(5);
            this.Przedmioty.Name = "Przedmioty";
            this.Przedmioty.Size = new System.Drawing.Size(150, 30);
            this.Przedmioty.TabIndex = 12;
            this.Przedmioty.Text = "Przedmioty";
            this.Przedmioty.TextColor = System.Drawing.Color.White;
            this.Przedmioty.UseVisualStyleBackColor = false;
            this.Przedmioty.Click += new System.EventHandler(this.Przedmioty_Click);
            // 
            // Plany_Lekcji
            // 
            this.Plany_Lekcji.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Plany_Lekcji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.Plany_Lekcji.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.Plany_Lekcji.BorderRadius = 30;
            this.Plany_Lekcji.BorderSize = 1;
            this.Plany_Lekcji.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.Plany_Lekcji.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.Plany_Lekcji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Plany_Lekcji.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Plany_Lekcji.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.Plany_Lekcji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plany_Lekcji.ForeColor = System.Drawing.Color.White;
            this.Plany_Lekcji.Location = new System.Drawing.Point(14, 215);
            this.Plany_Lekcji.Margin = new System.Windows.Forms.Padding(5);
            this.Plany_Lekcji.Name = "Plany_Lekcji";
            this.Plany_Lekcji.Size = new System.Drawing.Size(150, 30);
            this.Plany_Lekcji.TabIndex = 11;
            this.Plany_Lekcji.Text = "Plan Lekcji";
            this.Plany_Lekcji.TextColor = System.Drawing.Color.White;
            this.Plany_Lekcji.UseVisualStyleBackColor = false;
            this.Plany_Lekcji.Click += new System.EventHandler(this.Plany_Lekcji_Click);
            // 
            // Edycja_Danych
            // 
            this.Edycja_Danych.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Edycja_Danych.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.Edycja_Danych.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.Edycja_Danych.BorderRadius = 30;
            this.Edycja_Danych.BorderSize = 1;
            this.Edycja_Danych.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.Edycja_Danych.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.Edycja_Danych.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edycja_Danych.FlatAppearance.BorderSize = 0;
            this.Edycja_Danych.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edycja_Danych.ForeColor = System.Drawing.Color.White;
            this.Edycja_Danych.Location = new System.Drawing.Point(14, 333);
            this.Edycja_Danych.Name = "Edycja_Danych";
            this.Edycja_Danych.Size = new System.Drawing.Size(150, 30);
            this.Edycja_Danych.TabIndex = 4;
            this.Edycja_Danych.Text = "Edycja Danych";
            this.Edycja_Danych.TextColor = System.Drawing.Color.White;
            this.Edycja_Danych.UseVisualStyleBackColor = false;
            this.Edycja_Danych.Click += new System.EventHandler(this.Edycja_Danych_Click);
            // 
            // oceny
            // 
            this.oceny.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oceny.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oceny.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.oceny.BorderRadius = 30;
            this.oceny.BorderSize = 1;
            this.oceny.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.oceny.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.oceny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oceny.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.oceny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oceny.ForeColor = System.Drawing.Color.White;
            this.oceny.Location = new System.Drawing.Point(16, 175);
            this.oceny.Margin = new System.Windows.Forms.Padding(5);
            this.oceny.Name = "oceny";
            this.oceny.Size = new System.Drawing.Size(150, 30);
            this.oceny.TabIndex = 10;
            this.oceny.Text = "Oceny";
            this.oceny.TextColor = System.Drawing.Color.White;
            this.oceny.UseVisualStyleBackColor = false;
            this.oceny.Click += new System.EventHandler(this.oceny_Click);
            // 
            // message1
            // 
            this.message1.BackColor = System.Drawing.Color.Transparent;
            this.message1.Location = new System.Drawing.Point(187, 47);
            this.message1.Margin = new System.Windows.Forms.Padding(2);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(789, 400);
            this.message1.TabIndex = 24;
            // 
            // PanelUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelUczen";
            this.Text = "PanelUczen";
            this.Load += new System.EventHandler(this.PanelUczen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradient1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton Home;
        private dziennik_funkcje.home home1;
        private CustomButton oceny;
        private CustomButton Edycja_Danych;
        private CustomButton Plany_Lekcji;
        private CustomButton Przedmioty;
        private CustomButton Sprawdziany;
        private Gradient gradient8;
        private Gradient gradient1;
        private dziennik_funkcje.home home2;
        private SprawdzianyUczen sprawdzianyUczen1;
        private PrzedmiotyUczen przedmiotyUczen1;
        private PlanLekcjiUczen planLekcjiUczen1;
        private KlasyUczen klasyUczen1;
        private EdycjaDanychUczen edycjaDanychUczen1;
        private onlinegradebookprojectDataSetTableAdapters.OcenyTableAdapter ocenyTableAdapter1;
        private OcenyUczen ocenyUczen1;
        private CustomButton wiadomosci;
        private apknauczyciel.message message1;
    }
}