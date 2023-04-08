namespace Tylka.apknauczyciel
{
    partial class PanelNauczyciel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelNauczyciel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sprawdziany = new Tylka.CustomButton();
            this.Home = new Tylka.CustomButton();
            this.Przedmioty = new Tylka.CustomButton();
            this.Plany_Lekcji = new Tylka.CustomButton();
            this.Klasy = new Tylka.CustomButton();
            this.gradient1 = new Tylka.Gradient();
            this.przedmiotyNauczyciel1 = new Tylka.apknauczyciel.PrzedmiotyNauczyciel();
            this.plansNauczyciel1 = new Tylka.apknauczyciel.PlansNauczyciel();
            this.classNauczyciel1 = new Tylka.apknauczyciel.ClassNauczyciel();
            this.examsNauczyciel1 = new Tylka.apknauczyciel.ExamsNauczyciel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(47, 20, 47, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
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
            this.Sprawdziany.Location = new System.Drawing.Point(25, 277);
            this.Sprawdziany.Margin = new System.Windows.Forms.Padding(5);
            this.Sprawdziany.Name = "Sprawdziany";
            this.Sprawdziany.Size = new System.Drawing.Size(150, 30);
            this.Sprawdziany.TabIndex = 13;
            this.Sprawdziany.Text = "Sprawdziany";
            this.Sprawdziany.TextColor = System.Drawing.Color.White;
            this.Sprawdziany.UseVisualStyleBackColor = false;
            this.Sprawdziany.Click += new System.EventHandler(this.Sprawdziany_Click);
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
            this.Home.Location = new System.Drawing.Point(25, 117);
            this.Home.Margin = new System.Windows.Forms.Padding(5);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(150, 30);
            this.Home.TabIndex = 15;
            this.Home.Text = "Home";
            this.Home.TextColor = System.Drawing.Color.White;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
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
            this.Przedmioty.Location = new System.Drawing.Point(25, 237);
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
            this.Plany_Lekcji.Location = new System.Drawing.Point(25, 197);
            this.Plany_Lekcji.Margin = new System.Windows.Forms.Padding(5);
            this.Plany_Lekcji.Name = "Plany_Lekcji";
            this.Plany_Lekcji.Size = new System.Drawing.Size(150, 30);
            this.Plany_Lekcji.TabIndex = 11;
            this.Plany_Lekcji.Text = "Plany Lekcji";
            this.Plany_Lekcji.TextColor = System.Drawing.Color.White;
            this.Plany_Lekcji.UseVisualStyleBackColor = false;
            this.Plany_Lekcji.Click += new System.EventHandler(this.Plany_Lekcji_Click);
            // 
            // Klasy
            // 
            this.Klasy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Klasy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Klasy.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.Klasy.BorderRadius = 30;
            this.Klasy.BorderSize = 1;
            this.Klasy.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.Klasy.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.Klasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Klasy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.Klasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Klasy.ForeColor = System.Drawing.Color.White;
            this.Klasy.Location = new System.Drawing.Point(25, 157);
            this.Klasy.Margin = new System.Windows.Forms.Padding(5);
            this.Klasy.Name = "Klasy";
            this.Klasy.Size = new System.Drawing.Size(150, 30);
            this.Klasy.TabIndex = 10;
            this.Klasy.Text = "Klasy";
            this.Klasy.TextColor = System.Drawing.Color.White;
            this.Klasy.UseVisualStyleBackColor = false;
            this.Klasy.Click += new System.EventHandler(this.Klasy_Click);
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.gradient1.Controls.Add(this.examsNauczyciel1);
            this.gradient1.Controls.Add(this.przedmiotyNauczyciel1);
            this.gradient1.Controls.Add(this.plansNauczyciel1);
            this.gradient1.Controls.Add(this.classNauczyciel1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(800, 450);
            this.gradient1.TabIndex = 17;
            // 
            // przedmiotyNauczyciel1
            // 
            this.przedmiotyNauczyciel1.Location = new System.Drawing.Point(178, 45);
            this.przedmiotyNauczyciel1.Name = "przedmiotyNauczyciel1";
            this.przedmiotyNauczyciel1.Size = new System.Drawing.Size(610, 360);
            this.przedmiotyNauczyciel1.TabIndex = 2;
            // 
            // plansNauczyciel1
            // 
            this.plansNauczyciel1.Location = new System.Drawing.Point(178, 45);
            this.plansNauczyciel1.Name = "plansNauczyciel1";
            this.plansNauczyciel1.Size = new System.Drawing.Size(610, 360);
            this.plansNauczyciel1.TabIndex = 1;
            // 
            // classNauczyciel1
            // 
            this.classNauczyciel1.Location = new System.Drawing.Point(180, 45);
            this.classNauczyciel1.Name = "classNauczyciel1";
            this.classNauczyciel1.Size = new System.Drawing.Size(610, 360);
            this.classNauczyciel1.TabIndex = 0;
            // 
            // examsNauczyciel1
            // 
            this.examsNauczyciel1.Location = new System.Drawing.Point(178, 45);
            this.examsNauczyciel1.Name = "examsNauczyciel1";
            this.examsNauczyciel1.Size = new System.Drawing.Size(610, 360);
            this.examsNauczyciel1.TabIndex = 3;
            // 
            // PanelNauczyciel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sprawdziany);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Przedmioty);
            this.Controls.Add(this.Plany_Lekcji);
            this.Controls.Add(this.Klasy);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelNauczyciel";
            this.Text = "PanelNauczyciel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradient1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton Sprawdziany;
        private CustomButton Home;
        private CustomButton Przedmioty;
        private CustomButton Plany_Lekcji;
        private CustomButton Klasy;
        private Gradient gradient1;
        private ClassNauczyciel classNauczyciel1;
        private PlansNauczyciel plansNauczyciel1;
        private PrzedmiotyNauczyciel przedmiotyNauczyciel1;
        private ExamsNauczyciel examsNauczyciel1;
    }
}