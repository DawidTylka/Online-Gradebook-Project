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
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ToLogBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTxtB
            // 
            this.NameTxtB.Location = new System.Drawing.Point(306, 51);
            this.NameTxtB.Name = "NameTxtB";
            this.NameTxtB.Size = new System.Drawing.Size(100, 22);
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
            this.LoginTxtB.Location = new System.Drawing.Point(306, 147);
            this.LoginTxtB.Name = "LoginTxtB";
            this.LoginTxtB.Size = new System.Drawing.Size(100, 22);
            this.LoginTxtB.TabIndex = 2;
            // 
            // SurnameTxtB
            // 
            this.SurnameTxtB.Location = new System.Drawing.Point(306, 98);
            this.SurnameTxtB.Name = "SurnameTxtB";
            this.SurnameTxtB.Size = new System.Drawing.Size(100, 22);
            this.SurnameTxtB.TabIndex = 3;
            // 
            // PasswordTxtB
            // 
            this.PasswordTxtB.Location = new System.Drawing.Point(306, 193);
            this.PasswordTxtB.Name = "PasswordTxtB";
            this.PasswordTxtB.Size = new System.Drawing.Size(100, 22);
            this.PasswordTxtB.TabIndex = 4;
            // 
            // RoleCBox
            // 
            this.RoleCBox.FormattingEnabled = true;
            this.RoleCBox.Items.AddRange(new object[] {
            "Uczeń",
            "Rodzic",
            "Nauczyciel"});
            this.RoleCBox.Location = new System.Drawing.Point(306, 244);
            this.RoleCBox.Name = "RoleCBox";
            this.RoleCBox.Size = new System.Drawing.Size(121, 24);
            this.RoleCBox.TabIndex = 5;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(342, 296);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(121, 55);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ToLogBtn
            // 
            this.ToLogBtn.Location = new System.Drawing.Point(188, 296);
            this.ToLogBtn.Name = "ToLogBtn";
            this.ToLogBtn.Size = new System.Drawing.Size(123, 55);
            this.ToLogBtn.TabIndex = 7;
            this.ToLogBtn.Text = "back to log";
            this.ToLogBtn.UseVisualStyleBackColor = true;
            this.ToLogBtn.Click += new System.EventHandler(this.ToLogBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "imiem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "hasło";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "rola";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToLogBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.RoleCBox);
            this.Controls.Add(this.PasswordTxtB);
            this.Controls.Add(this.SurnameTxtB);
            this.Controls.Add(this.LoginTxtB);
            this.Controls.Add(this.NameTxtB);
            this.Name = "register";
            this.Size = new System.Drawing.Size(646, 380);
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
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ToLogBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
