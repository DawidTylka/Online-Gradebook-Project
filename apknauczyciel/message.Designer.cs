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
            this.nxtpage = new System.Windows.Forms.Button();
            this.prvpage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pagenr
            // 
            this.pagenr.AutoSize = true;
            this.pagenr.Location = new System.Drawing.Point(630, 352);
            this.pagenr.Name = "pagenr";
            this.pagenr.Size = new System.Drawing.Size(84, 16);
            this.pagenr.TabIndex = 4;
            this.pagenr.Text = "pagenumber";
            // 
            // nxtpage
            // 
            this.nxtpage.Location = new System.Drawing.Point(729, 339);
            this.nxtpage.Name = "nxtpage";
            this.nxtpage.Size = new System.Drawing.Size(125, 45);
            this.nxtpage.TabIndex = 7;
            this.nxtpage.Text = "NextPage";
            this.nxtpage.UseVisualStyleBackColor = true;
            // 
            // prvpage
            // 
            this.prvpage.Location = new System.Drawing.Point(530, 339);
            this.prvpage.Name = "prvpage";
            this.prvpage.Size = new System.Drawing.Size(94, 43);
            this.prvpage.TabIndex = 8;
            this.prvpage.Text = "Prev Page";
            this.prvpage.UseVisualStyleBackColor = true;
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prvpage);
            this.Controls.Add(this.nxtpage);
            this.Controls.Add(this.pagenr);
            this.Name = "message";
            this.Size = new System.Drawing.Size(931, 472);
            this.Load += new System.EventHandler(this.message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pagenr;
        private System.Windows.Forms.Button nxtpage;
        private System.Windows.Forms.Button prvpage;
    }
}
