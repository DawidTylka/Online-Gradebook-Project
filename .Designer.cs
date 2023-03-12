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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ToRegBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LLoginTxtB = new System.Windows.Forms.TextBox();
            this.LPasswordTxtB = new System.Windows.Forms.TextBox();
            this.register1 = new Tylka.register();
            this.admintest1 = new Tylka.admintest();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // ToRegBtn
            // 
            this.ToRegBtn.Location = new System.Drawing.Point(196, 208);
            this.ToRegBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToRegBtn.Name = "ToRegBtn";
            this.ToRegBtn.Size = new System.Drawing.Size(82, 37);
            this.ToRegBtn.TabIndex = 2;
            this.ToRegBtn.Text = "regis";
            this.ToRegBtn.UseVisualStyleBackColor = true;
            this.ToRegBtn.Click += new System.EventHandler(this.ToRegBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(309, 208);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(82, 37);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LLoginTxtB
            // 
            this.LLoginTxtB.Location = new System.Drawing.Point(309, 90);
            this.LLoginTxtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LLoginTxtB.Name = "LLoginTxtB";
            this.LLoginTxtB.Size = new System.Drawing.Size(76, 20);
            this.LLoginTxtB.TabIndex = 4;
            // 
            // LPasswordTxtB
            // 
            this.LPasswordTxtB.Location = new System.Drawing.Point(309, 150);
            this.LPasswordTxtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LPasswordTxtB.Name = "LPasswordTxtB";
            this.LPasswordTxtB.Size = new System.Drawing.Size(76, 20);
            this.LPasswordTxtB.TabIndex = 5;
            // 
            // register1
            // 
            this.register1.Location = new System.Drawing.Point(425, 33);
            this.register1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(484, 309);
            this.register1.TabIndex = 6;
            // 
            // admintest1
            // 
            this.admintest1.Location = new System.Drawing.Point(145, 27);
            this.admintest1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admintest1.Name = "admintest1";
            this.admintest1.Size = new System.Drawing.Size(516, 328);
            this.admintest1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.admintest1);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.LPasswordTxtB);
            this.Controls.Add(this.LLoginTxtB);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ToRegBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ToRegBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox LLoginTxtB;
        private System.Windows.Forms.TextBox LPasswordTxtB;
        private register register1;
        private admintest admintest1;
    }
}

