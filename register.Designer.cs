namespace Tylka
{
    partial class register
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameTxtB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoginTxtB = new System.Windows.Forms.TextBox();
            this.SurnameTxtB = new System.Windows.Forms.TextBox();
            this.PasswordTxtB = new System.Windows.Forms.TextBox();
            this.RoleCBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterBtnC = new Tylka.CustomButton();
            this.ToLogBtnC = new Tylka.CustomButton();
            this.SuspendLayout();
            // 
            // NameTxtB
            // 
            this.NameTxtB.Location = new System.Drawing.Point(230, 41);
            this.NameTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.NameTxtB.Name = "NameTxtB";
            this.NameTxtB.Size = new System.Drawing.Size(92, 20);
            this.NameTxtB.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginTxtB
            // 
            this.LoginTxtB.Location = new System.Drawing.Point(230, 119);
            this.LoginTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.LoginTxtB.Name = "LoginTxtB";
            this.LoginTxtB.Size = new System.Drawing.Size(92, 20);
            this.LoginTxtB.TabIndex = 2;
            // 
            // SurnameTxtB
            // 
            this.SurnameTxtB.Location = new System.Drawing.Point(230, 80);
            this.SurnameTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameTxtB.Name = "SurnameTxtB";
            this.SurnameTxtB.Size = new System.Drawing.Size(92, 20);
            this.SurnameTxtB.TabIndex = 3;
            // 
            // PasswordTxtB
            // 
            this.PasswordTxtB.Location = new System.Drawing.Point(230, 157);
            this.PasswordTxtB.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTxtB.Name = "PasswordTxtB";
            this.PasswordTxtB.Size = new System.Drawing.Size(92, 20);
            this.PasswordTxtB.TabIndex = 4;
            // 
            // RoleCBox
            // 
            this.RoleCBox.FormattingEnabled = true;
            this.RoleCBox.Items.AddRange(new object[] {
            "Uczeń",
            "Rodzic",
            "Nauczyciel"});
            this.RoleCBox.Location = new System.Drawing.Point(230, 198);
            this.RoleCBox.Margin = new System.Windows.Forms.Padding(2);
            this.RoleCBox.Name = "RoleCBox";
            this.RoleCBox.Size = new System.Drawing.Size(92, 21);
            this.RoleCBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "imiem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "hasło";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "rola";
            // 
            // RegisterBtnC
            // 
            this.RegisterBtnC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterBtnC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegisterBtnC.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.RegisterBtnC.BorderRadius = 30;
            this.RegisterBtnC.BorderSize = 1;
            this.RegisterBtnC.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.RegisterBtnC.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.RegisterBtnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtnC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RegisterBtnC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.RegisterBtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtnC.ForeColor = System.Drawing.Color.White;
            this.RegisterBtnC.Location = new System.Drawing.Point(128, 226);
            this.RegisterBtnC.Margin = new System.Windows.Forms.Padding(5);
            this.RegisterBtnC.Name = "RegisterBtnC";
            this.RegisterBtnC.Size = new System.Drawing.Size(92, 43);
            this.RegisterBtnC.TabIndex = 14;
            this.RegisterBtnC.Text = "Register";
            this.RegisterBtnC.TextColor = System.Drawing.Color.White;
            this.RegisterBtnC.UseVisualStyleBackColor = false;
            this.RegisterBtnC.Click += new System.EventHandler(this.RegisterBtnC_Click);
            // 
            // ToLogBtnC
            // 
            this.ToLogBtnC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToLogBtnC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ToLogBtnC.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.ToLogBtnC.BorderRadius = 30;
            this.ToLogBtnC.BorderSize = 1;
            this.ToLogBtnC.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.ToLogBtnC.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.ToLogBtnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToLogBtnC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ToLogBtnC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.ToLogBtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToLogBtnC.ForeColor = System.Drawing.Color.White;
            this.ToLogBtnC.Location = new System.Drawing.Point(230, 226);
            this.ToLogBtnC.Margin = new System.Windows.Forms.Padding(5);
            this.ToLogBtnC.Name = "ToLogBtnC";
            this.ToLogBtnC.Size = new System.Drawing.Size(92, 43);
            this.ToLogBtnC.TabIndex = 13;
            this.ToLogBtnC.Text = "Back to log";
            this.ToLogBtnC.TextColor = System.Drawing.Color.White;
            this.ToLogBtnC.UseVisualStyleBackColor = false;
            this.ToLogBtnC.Click += new System.EventHandler(this.ToLogBtnC_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.RegisterBtnC);
            this.Controls.Add(this.ToLogBtnC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleCBox);
            this.Controls.Add(this.PasswordTxtB);
            this.Controls.Add(this.SurnameTxtB);
            this.Controls.Add(this.LoginTxtB);
            this.Controls.Add(this.NameTxtB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "register";
            this.Size = new System.Drawing.Size(484, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxtB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox LoginTxtB;
        private System.Windows.Forms.TextBox SurnameTxtB;
        private System.Windows.Forms.TextBox PasswordTxtB;
        private System.Windows.Forms.ComboBox RoleCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomButton ToLogBtnC;
        private CustomButton RegisterBtnC;
    }
}
