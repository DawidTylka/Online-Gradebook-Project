namespace Tylka
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LLoginTxtB = new System.Windows.Forms.TextBox();
            this.LPasswordTxtB = new System.Windows.Forms.TextBox();
            this.gradient1 = new Tylka.Gradient();
            this.LoginBtnC = new Tylka.CustomButton();
            this.ToRegBtnC = new Tylka.CustomButton();
            this.loginpick11 = new Tylka.dziennik_funkcje.loginpick1();
            this.loginpick21 = new Tylka.dziennik_funkcje.loginpick2();
            this.loginpick31 = new Tylka.dziennik_funkcje.loginpick3();
            this.register1 = new Tylka.register();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(167, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(167, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło :";
            // 
            // LLoginTxtB
            // 
            this.LLoginTxtB.Location = new System.Drawing.Point(232, 85);
            this.LLoginTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.LLoginTxtB.Name = "LLoginTxtB";
            this.LLoginTxtB.Size = new System.Drawing.Size(91, 20);
            this.LLoginTxtB.TabIndex = 4;
            // 
            // LPasswordTxtB
            // 
            this.LPasswordTxtB.Location = new System.Drawing.Point(232, 145);
            this.LPasswordTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.LPasswordTxtB.Name = "LPasswordTxtB";
            this.LPasswordTxtB.Size = new System.Drawing.Size(91, 20);
            this.LPasswordTxtB.TabIndex = 5;
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.gradient1.Controls.Add(this.loginpick31);
            this.gradient1.Controls.Add(this.loginpick11);
            this.gradient1.Controls.Add(this.register1);
            this.gradient1.Controls.Add(this.loginpick21);
            this.gradient1.Controls.Add(this.LPasswordTxtB);
            this.gradient1.Controls.Add(this.LLoginTxtB);
            this.gradient1.Controls.Add(this.LoginBtnC);
            this.gradient1.Controls.Add(this.ToRegBtnC);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(501, 327);
            this.gradient1.TabIndex = 10;
            // 
            // LoginBtnC
            // 
            this.LoginBtnC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginBtnC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginBtnC.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.LoginBtnC.BorderRadius = 30;
            this.LoginBtnC.BorderSize = 1;
            this.LoginBtnC.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.LoginBtnC.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.LoginBtnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtnC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LoginBtnC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.LoginBtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtnC.ForeColor = System.Drawing.Color.White;
            this.LoginBtnC.Location = new System.Drawing.Point(247, 172);
            this.LoginBtnC.Margin = new System.Windows.Forms.Padding(5);
            this.LoginBtnC.Name = "LoginBtnC";
            this.LoginBtnC.Size = new System.Drawing.Size(76, 43);
            this.LoginBtnC.TabIndex = 11;
            this.LoginBtnC.Text = "Login";
            this.LoginBtnC.TextColor = System.Drawing.Color.White;
            this.LoginBtnC.UseVisualStyleBackColor = false;
            this.LoginBtnC.Click += new System.EventHandler(this.LoginBtnC_Click);
            // 
            // ToRegBtnC
            // 
            this.ToRegBtnC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToRegBtnC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ToRegBtnC.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.ToRegBtnC.BorderRadius = 30;
            this.ToRegBtnC.BorderSize = 1;
            this.ToRegBtnC.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.ToRegBtnC.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.ToRegBtnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToRegBtnC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ToRegBtnC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.ToRegBtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToRegBtnC.ForeColor = System.Drawing.Color.White;
            this.ToRegBtnC.Location = new System.Drawing.Point(161, 172);
            this.ToRegBtnC.Margin = new System.Windows.Forms.Padding(5);
            this.ToRegBtnC.Name = "ToRegBtnC";
            this.ToRegBtnC.Size = new System.Drawing.Size(76, 43);
            this.ToRegBtnC.TabIndex = 10;
            this.ToRegBtnC.Text = "Regis";
            this.ToRegBtnC.TextColor = System.Drawing.Color.White;
            this.ToRegBtnC.UseVisualStyleBackColor = false;
            this.ToRegBtnC.Click += new System.EventHandler(this.ToRegBtnC_Click);
            // 
            // loginpick11
            // 
            this.loginpick11.BackColor = System.Drawing.Color.Transparent;
            this.loginpick11.Location = new System.Drawing.Point(100, 11);
            this.loginpick11.Margin = new System.Windows.Forms.Padding(2);
            this.loginpick11.Name = "loginpick11";
            this.loginpick11.Size = new System.Drawing.Size(299, 297);
            this.loginpick11.TabIndex = 7;
            // 
            // loginpick21
            // 
            this.loginpick21.BackColor = System.Drawing.Color.Transparent;
            this.loginpick21.Location = new System.Drawing.Point(100, 12);
            this.loginpick21.Margin = new System.Windows.Forms.Padding(2);
            this.loginpick21.Name = "loginpick21";
            this.loginpick21.Size = new System.Drawing.Size(281, 288);
            this.loginpick21.TabIndex = 8;
            // 
            // loginpick31
            // 
            this.loginpick31.BackColor = System.Drawing.Color.Transparent;
            this.loginpick31.Location = new System.Drawing.Point(100, 11);
            this.loginpick31.Margin = new System.Windows.Forms.Padding(2);
            this.loginpick31.Name = "loginpick31";
            this.loginpick31.Size = new System.Drawing.Size(290, 257);
            this.loginpick31.TabIndex = 9;
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.Transparent;
            this.register1.Location = new System.Drawing.Point(2, 0);
            this.register1.Margin = new System.Windows.Forms.Padding(2);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(500, 300);
            this.register1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 327);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Jordan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LLoginTxtB;
        private System.Windows.Forms.TextBox LPasswordTxtB;
        private register register1;
        private dziennik_funkcje.loginpick1 loginpick11;
        private dziennik_funkcje.loginpick2 loginpick21;
        private dziennik_funkcje.loginpick3 loginpick31;
        private Gradient gradient1;
        private CustomButton ToRegBtnC;
        private CustomButton LoginBtnC;
    }
}

