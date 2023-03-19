namespace Tylka
{
    partial class PlanLekcjiUczen
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iddniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklasyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godzinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wtorekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.środaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czwartekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piątekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niedzielaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlinegradebookprojectDataSet = new Tylka.onlinegradebookprojectDataSet();
            this.dniTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.DniTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).BeginInit();
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
            this.wtorekDataGridViewTextBoxColumn,
            this.środaDataGridViewTextBoxColumn,
            this.czwartekDataGridViewTextBoxColumn,
            this.piątekDataGridViewTextBoxColumn,
            this.sobotaDataGridViewTextBoxColumn,
            this.niedzielaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dniBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(915, 473);
            this.dataGridView1.TabIndex = 0;
            // 
            // iddniaDataGridViewTextBoxColumn
            // 
            this.iddniaDataGridViewTextBoxColumn.DataPropertyName = "iddnia";
            this.iddniaDataGridViewTextBoxColumn.HeaderText = "iddnia";
            this.iddniaDataGridViewTextBoxColumn.Name = "iddniaDataGridViewTextBoxColumn";
            this.iddniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddniaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idklasyDataGridViewTextBoxColumn
            // 
            this.idklasyDataGridViewTextBoxColumn.DataPropertyName = "id_klasy";
            this.idklasyDataGridViewTextBoxColumn.HeaderText = "id_klasy";
            this.idklasyDataGridViewTextBoxColumn.Name = "idklasyDataGridViewTextBoxColumn";
            // 
            // godzinaDataGridViewTextBoxColumn
            // 
            this.godzinaDataGridViewTextBoxColumn.DataPropertyName = "godzina";
            this.godzinaDataGridViewTextBoxColumn.HeaderText = "godzina";
            this.godzinaDataGridViewTextBoxColumn.Name = "godzinaDataGridViewTextBoxColumn";
            // 
            // wtorekDataGridViewTextBoxColumn
            // 
            this.wtorekDataGridViewTextBoxColumn.DataPropertyName = "Wtorek";
            this.wtorekDataGridViewTextBoxColumn.HeaderText = "Wtorek";
            this.wtorekDataGridViewTextBoxColumn.Name = "wtorekDataGridViewTextBoxColumn";
            // 
            // środaDataGridViewTextBoxColumn
            // 
            this.środaDataGridViewTextBoxColumn.DataPropertyName = "Środa";
            this.środaDataGridViewTextBoxColumn.HeaderText = "Środa";
            this.środaDataGridViewTextBoxColumn.Name = "środaDataGridViewTextBoxColumn";
            // 
            // czwartekDataGridViewTextBoxColumn
            // 
            this.czwartekDataGridViewTextBoxColumn.DataPropertyName = "Czwartek";
            this.czwartekDataGridViewTextBoxColumn.HeaderText = "Czwartek";
            this.czwartekDataGridViewTextBoxColumn.Name = "czwartekDataGridViewTextBoxColumn";
            // 
            // piątekDataGridViewTextBoxColumn
            // 
            this.piątekDataGridViewTextBoxColumn.DataPropertyName = "Piątek";
            this.piątekDataGridViewTextBoxColumn.HeaderText = "Piątek";
            this.piątekDataGridViewTextBoxColumn.Name = "piątekDataGridViewTextBoxColumn";
            // 
            // sobotaDataGridViewTextBoxColumn
            // 
            this.sobotaDataGridViewTextBoxColumn.DataPropertyName = "Sobota";
            this.sobotaDataGridViewTextBoxColumn.HeaderText = "Sobota";
            this.sobotaDataGridViewTextBoxColumn.Name = "sobotaDataGridViewTextBoxColumn";
            this.sobotaDataGridViewTextBoxColumn.Visible = false;
            // 
            // niedzielaDataGridViewTextBoxColumn
            // 
            this.niedzielaDataGridViewTextBoxColumn.DataPropertyName = "Niedziela";
            this.niedzielaDataGridViewTextBoxColumn.HeaderText = "Niedziela";
            this.niedzielaDataGridViewTextBoxColumn.Name = "niedzielaDataGridViewTextBoxColumn";
            this.niedzielaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dniBindingSource
            // 
            this.dniBindingSource.DataMember = "Dni";
            this.dniBindingSource.DataSource = this.onlinegradebookprojectDataSet;
            // 
            // onlinegradebookprojectDataSet
            // 
            this.onlinegradebookprojectDataSet.DataSetName = "onlinegradebookprojectDataSet";
            this.onlinegradebookprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dniTableAdapter
            // 
            this.dniTableAdapter.ClearBeforeFill = true;
            // 
            // PlanLekcjiUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "PlanLekcjiUczen";
            this.Size = new System.Drawing.Size(950, 620);
            this.Load += new System.EventHandler(this.PlanLekcjiUczen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).EndInit();
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
