namespace Tylka.dziennik_funkcje
{
    partial class loginpick2
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
            this.customButton1 = new Tylka.CustomButton();
            this.customButton2 = new Tylka.CustomButton();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Red;
            this.customButton1.borderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 50;
            this.customButton1.BorderSize = 0;
            this.customButton1.ColorBottom = System.Drawing.Color.White;
            this.customButton1.ColorTop = System.Drawing.Color.Red;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(89, 44);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(200, 100);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "przejscie do panelu rodzica";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Red;
            this.customButton2.borderColor = System.Drawing.Color.White;
            this.customButton2.BorderRadius = 50;
            this.customButton2.BorderSize = 0;
            this.customButton2.ColorBottom = System.Drawing.Color.White;
            this.customButton2.ColorTop = System.Drawing.Color.Red;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(89, 191);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(200, 100);
            this.customButton2.TabIndex = 0;
            this.customButton2.Text = "przejscie do panelu admina";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // loginpick2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Name = "loginpick2";
            this.Size = new System.Drawing.Size(375, 355);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton customButton1;
        private CustomButton customButton2;
    }
}
