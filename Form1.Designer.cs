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
            this.logbtn = new System.Windows.Forms.Button();
            this.logtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.loglabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.regbtn = new System.Windows.Forms.Button();
            this.registerwindow1 = new Tylka.Registerwindow();
            this.SuspendLayout();
            // 
            // logbtn
            // 
            this.logbtn.Location = new System.Drawing.Point(307, 219);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(89, 44);
            this.logbtn.TabIndex = 0;
            this.logbtn.Text = "Zaloguj";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // logtxt
            // 
            this.logtxt.Location = new System.Drawing.Point(296, 103);
            this.logtxt.Name = "logtxt";
            this.logtxt.Size = new System.Drawing.Size(100, 22);
            this.logtxt.TabIndex = 1;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(296, 143);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(100, 22);
            this.passtxt.TabIndex = 2;
            // 
            // loglabel
            // 
            this.loglabel.AutoSize = true;
            this.loglabel.Location = new System.Drawing.Point(178, 103);
            this.loglabel.Name = "loglabel";
            this.loglabel.Size = new System.Drawing.Size(44, 16);
            this.loglabel.TabIndex = 3;
            this.loglabel.Text = "label1";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Location = new System.Drawing.Point(178, 149);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(44, 16);
            this.passlabel.TabIndex = 4;
            this.passlabel.Text = "label2";
            // 
            // regbtn
            // 
            this.regbtn.Location = new System.Drawing.Point(181, 219);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(89, 44);
            this.regbtn.TabIndex = 5;
            this.regbtn.Text = "Zarejestruj";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // registerwindow1
            // 
            this.registerwindow1.Location = new System.Drawing.Point(1, 1);
            this.registerwindow1.Name = "registerwindow1";
            this.registerwindow1.Size = new System.Drawing.Size(784, 453);
            this.registerwindow1.TabIndex = 6;
            this.registerwindow1.Load += new System.EventHandler(this.registerwindow1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.loglabel);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.registerwindow1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.TextBox logtxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label loglabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Button regbtn;
        private Registerwindow registerwindow1;
    }
}

