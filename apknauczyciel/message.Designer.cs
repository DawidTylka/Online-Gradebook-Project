namespace Tylka.apknauczyciel
{
    partial class message
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
            this.pagenr = new System.Windows.Forms.Label();
            this.prvpage = new Tylka.CustomButton();
            this.nxtpage = new Tylka.CustomButton();
            this.SendBtn = new Tylka.CustomButton();
            this.SuspendLayout();
            // 
            // pagenr
            // 
            this.pagenr.AutoSize = true;
            this.pagenr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pagenr.Location = new System.Drawing.Point(484, 340);
            this.pagenr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pagenr.Name = "pagenr";
            this.pagenr.Size = new System.Drawing.Size(76, 13);
            this.pagenr.TabIndex = 4;
            this.pagenr.Text = "pagenumber";
            // 
            // prvpage
            // 
            this.prvpage.BackColor = System.Drawing.Color.Red;
            this.prvpage.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.prvpage.BorderRadius = 49;
            this.prvpage.BorderSize = 0;
            this.prvpage.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.prvpage.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.prvpage.FlatAppearance.BorderSize = 0;
            this.prvpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prvpage.ForeColor = System.Drawing.Color.White;
            this.prvpage.Location = new System.Drawing.Point(372, 325);
            this.prvpage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prvpage.Name = "prvpage";
            this.prvpage.Size = new System.Drawing.Size(107, 49);
            this.prvpage.TabIndex = 12;
            this.prvpage.Text = "Poprzednia strona";
            this.prvpage.TextColor = System.Drawing.Color.White;
            this.prvpage.UseVisualStyleBackColor = false;
            this.prvpage.Click += new System.EventHandler(this.prvpage_Click_1);
            // 
            // nxtpage
            // 
            this.nxtpage.BackColor = System.Drawing.Color.Red;
            this.nxtpage.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.nxtpage.BorderRadius = 49;
            this.nxtpage.BorderSize = 0;
            this.nxtpage.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.nxtpage.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.nxtpage.FlatAppearance.BorderSize = 0;
            this.nxtpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nxtpage.ForeColor = System.Drawing.Color.White;
            this.nxtpage.Location = new System.Drawing.Point(562, 325);
            this.nxtpage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nxtpage.Name = "nxtpage";
            this.nxtpage.Size = new System.Drawing.Size(106, 49);
            this.nxtpage.TabIndex = 11;
            this.nxtpage.Text = "Następna strona";
            this.nxtpage.TextColor = System.Drawing.Color.White;
            this.nxtpage.UseVisualStyleBackColor = false;
            this.nxtpage.Click += new System.EventHandler(this.nxtpage_Click_1);
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.Red;
            this.SendBtn.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.SendBtn.BorderRadius = 49;
            this.SendBtn.BorderSize = 0;
            this.SendBtn.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.SendBtn.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.SendBtn.FlatAppearance.BorderSize = 0;
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBtn.ForeColor = System.Drawing.Color.White;
            this.SendBtn.Location = new System.Drawing.Point(148, 325);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(107, 49);
            this.SendBtn.TabIndex = 10;
            this.SendBtn.Text = "Wyślij wiadomość";
            this.SendBtn.TextColor = System.Drawing.Color.White;
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prvpage);
            this.Controls.Add(this.nxtpage);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.pagenr);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "message";
            this.Size = new System.Drawing.Size(698, 384);
            this.Load += new System.EventHandler(this.message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pagenr;
        private CustomButton SendBtn;
        private CustomButton nxtpage;
        private CustomButton prvpage;
    }
}
