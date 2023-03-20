namespace Tylka.apkuczen
{
    partial class PanelUczen
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
            this.planLekcjiUczen1 = new Tylka.PlanLekcjiUczen();
            this.SuspendLayout();
            // 
            // planLekcjiUczen1
            // 
            this.planLekcjiUczen1.Location = new System.Drawing.Point(13, -111);
            this.planLekcjiUczen1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.planLekcjiUczen1.Name = "planLekcjiUczen1";
            this.planLekcjiUczen1.Size = new System.Drawing.Size(1267, 763);
            this.planLekcjiUczen1.TabIndex = 0;
            // 
            // PanelUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 632);
            this.Controls.Add(this.planLekcjiUczen1);
            this.Name = "PanelUczen";
            this.Text = "PanelUczen";
            this.ResumeLayout(false);

        }

        #endregion

        private Tylka.PlanLekcjiUczen planLekcjiUczen1;
    }
}