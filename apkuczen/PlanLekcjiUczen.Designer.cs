namespace Tylka.apkuczen
{
    partial class PlanLekcjiUczen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.onlinegradebookprojectDataSet = new Tylka.onlinegradebookprojectDataSet();
            this.dniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dniTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.DniTableAdapter();
            this.iddniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklasyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godzinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poniedziałeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wtorekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.środaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czwartekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piątekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niedzielaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddniaDataGridViewTextBoxColumn,
            this.idklasyDataGridViewTextBoxColumn,
            this.godzinaDataGridViewTextBoxColumn,
            this.poniedziałeDataGridViewTextBoxColumn,
            this.wtorekDataGridViewTextBoxColumn,
            this.środaDataGridViewTextBoxColumn,
            this.czwartekDataGridViewTextBoxColumn,
            this.piątekDataGridViewTextBoxColumn,
            this.sobotaDataGridViewTextBoxColumn,
            this.niedzielaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dniBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 334);
            this.dataGridView1.TabIndex = 0;
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
            // iddniaDataGridViewTextBoxColumn
            // 
            this.iddniaDataGridViewTextBoxColumn.DataPropertyName = "iddnia";
            this.iddniaDataGridViewTextBoxColumn.HeaderText = "iddnia";
            this.iddniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddniaDataGridViewTextBoxColumn.Name = "iddniaDataGridViewTextBoxColumn";
            this.iddniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddniaDataGridViewTextBoxColumn.Visible = false;
            this.iddniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idklasyDataGridViewTextBoxColumn
            // 
            this.idklasyDataGridViewTextBoxColumn.DataPropertyName = "id_klasy";
            this.idklasyDataGridViewTextBoxColumn.HeaderText = "id_klasy";
            this.idklasyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklasyDataGridViewTextBoxColumn.Name = "idklasyDataGridViewTextBoxColumn";
            this.idklasyDataGridViewTextBoxColumn.Width = 125;
            // 
            // godzinaDataGridViewTextBoxColumn
            // 
            this.godzinaDataGridViewTextBoxColumn.DataPropertyName = "godzina";
            this.godzinaDataGridViewTextBoxColumn.HeaderText = "godzina";
            this.godzinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.godzinaDataGridViewTextBoxColumn.Name = "godzinaDataGridViewTextBoxColumn";
            this.godzinaDataGridViewTextBoxColumn.Width = 125;
            // 
            // poniedziałeDataGridViewTextBoxColumn
            // 
            this.poniedziałeDataGridViewTextBoxColumn.DataPropertyName = "Poniedziałe";
            this.poniedziałeDataGridViewTextBoxColumn.HeaderText = "Poniedziałek";
            this.poniedziałeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poniedziałeDataGridViewTextBoxColumn.Name = "poniedziałeDataGridViewTextBoxColumn";
            this.poniedziałeDataGridViewTextBoxColumn.Width = 125;
            // 
            // wtorekDataGridViewTextBoxColumn
            // 
            this.wtorekDataGridViewTextBoxColumn.DataPropertyName = "Wtorek";
            this.wtorekDataGridViewTextBoxColumn.HeaderText = "Wtorek";
            this.wtorekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wtorekDataGridViewTextBoxColumn.Name = "wtorekDataGridViewTextBoxColumn";
            this.wtorekDataGridViewTextBoxColumn.Width = 125;
            // 
            // środaDataGridViewTextBoxColumn
            // 
            this.środaDataGridViewTextBoxColumn.DataPropertyName = "Środa";
            this.środaDataGridViewTextBoxColumn.HeaderText = "Środa";
            this.środaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.środaDataGridViewTextBoxColumn.Name = "środaDataGridViewTextBoxColumn";
            this.środaDataGridViewTextBoxColumn.Width = 125;
            // 
            // czwartekDataGridViewTextBoxColumn
            // 
            this.czwartekDataGridViewTextBoxColumn.DataPropertyName = "Czwartek";
            this.czwartekDataGridViewTextBoxColumn.HeaderText = "Czwartek";
            this.czwartekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.czwartekDataGridViewTextBoxColumn.Name = "czwartekDataGridViewTextBoxColumn";
            this.czwartekDataGridViewTextBoxColumn.Width = 125;
            // 
            // piątekDataGridViewTextBoxColumn
            // 
            this.piątekDataGridViewTextBoxColumn.DataPropertyName = "Piątek";
            this.piątekDataGridViewTextBoxColumn.HeaderText = "Piątek";
            this.piątekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.piątekDataGridViewTextBoxColumn.Name = "piątekDataGridViewTextBoxColumn";
            this.piątekDataGridViewTextBoxColumn.Width = 125;
            // 
            // sobotaDataGridViewTextBoxColumn
            // 
            this.sobotaDataGridViewTextBoxColumn.DataPropertyName = "Sobota";
            this.sobotaDataGridViewTextBoxColumn.HeaderText = "Sobota";
            this.sobotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sobotaDataGridViewTextBoxColumn.Name = "sobotaDataGridViewTextBoxColumn";
            this.sobotaDataGridViewTextBoxColumn.Visible = false;
            this.sobotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // niedzielaDataGridViewTextBoxColumn
            // 
            this.niedzielaDataGridViewTextBoxColumn.DataPropertyName = "Niedziela";
            this.niedzielaDataGridViewTextBoxColumn.HeaderText = "Niedziela";
            this.niedzielaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.niedzielaDataGridViewTextBoxColumn.Name = "niedzielaDataGridViewTextBoxColumn";
            this.niedzielaDataGridViewTextBoxColumn.Visible = false;
            this.niedzielaDataGridViewTextBoxColumn.Width = 125;
            // 
            // PlanLekcjiUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "PlanLekcjiUczen";
            this.Size = new System.Drawing.Size(1067, 490);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dniBindingSource;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet;
        private onlinegradebookprojectDataSetTableAdapters.DniTableAdapter dniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklasyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poniedziałeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wtorekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn środaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czwartekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piątekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niedzielaDataGridViewTextBoxColumn;
    }
}
