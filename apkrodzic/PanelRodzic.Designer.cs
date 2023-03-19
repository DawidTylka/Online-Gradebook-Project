namespace Tylka.apkuczen
{
    partial class PanelRodzic
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.onlinegradebookprojectDataSet = new Tylka.onlinegradebookprojectDataSet();
            this.dniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dniTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.DniTableAdapter();
            this.planLekcjiRodzic1 = new Tylka.apkrodzic.PlanLekcjiRodzic();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(942, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = " to co widzi rodzic";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // onlinegradebookprojectDataSet
            // 
            this.onlinegradebookprojectDataSet.DataSetName = "onlinegradebookprojectDataSet";
            this.onlinegradebookprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dniBindingSource
            // 
            this.dniBindingSource.DataMember = "Dni";
            this.dniBindingSource.DataSource = this.onlinegradebookprojectDataSet;
            // 
            // dniTableAdapter
            // 
            this.dniTableAdapter.ClearBeforeFill = true;
            // 
            // planLekcjiRodzic1
            // 
            this.planLekcjiRodzic1.Location = new System.Drawing.Point(72, 67);
            this.planLekcjiRodzic1.Name = "planLekcjiRodzic1";
            this.planLekcjiRodzic1.Size = new System.Drawing.Size(1272, 691);
            this.planLekcjiRodzic1.TabIndex = 1;
            // 
            // PanelRodzic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 684);
            this.Controls.Add(this.planLekcjiRodzic1);
            this.Controls.Add(this.textBox1);
            this.Name = "PanelRodzic";
            this.Text = "PanelRodzic";
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet;
        private System.Windows.Forms.BindingSource dniBindingSource;
        private onlinegradebookprojectDataSetTableAdapters.DniTableAdapter dniTableAdapter;
        private apkrodzic.PlanLekcjiRodzic planLekcjiRodzic1;
    }
}