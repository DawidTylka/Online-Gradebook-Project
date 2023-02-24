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
            this.SuspendLayout();
            // 
            // logbtn
            // 
            this.logbtn.Location = new System.Drawing.Point(321, 219);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(75, 23);
            this.logbtn.TabIndex = 0;
            this.logbtn.Text = "button1";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logbtn_MouseClick);
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
            this.regbtn.Location = new System.Drawing.Point(170, 219);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(75, 23);
            this.regbtn.TabIndex = 5;
            this.regbtn.Text = "button1";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.regbtn_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.loglabel);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.logbtn);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

