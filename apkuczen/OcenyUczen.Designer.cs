namespace Tylka.apkuczen
{
    partial class OcenyUczen
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
            this.ocenyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocenyTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.OcenyTableAdapter();
            this.identyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tematDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduczniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnauczycielaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datawystawieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprzedmiotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSMATimeStampDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identyfikatorDataGridViewTextBoxColumn,
            this.tematDataGridViewTextBoxColumn,
            this.iduczniaDataGridViewTextBoxColumn,
            this.idnauczycielaDataGridViewTextBoxColumn,
            this.datawystawieniaDataGridViewTextBoxColumn,
            this.idprzedmiotuDataGridViewTextBoxColumn,
            this.ocenaDataGridViewTextBoxColumn,
            this.sSMATimeStampDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.ocenyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // onlinegradebookprojectDataSet
            // 
            this.onlinegradebookprojectDataSet.DataSetName = "onlinegradebookprojectDataSet";
            this.onlinegradebookprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ocenyBindingSource
            // 
            this.ocenyBindingSource.DataMember = "Oceny";
            this.ocenyBindingSource.DataSource = this.onlinegradebookprojectDataSet;
            // 
            // ocenyTableAdapter
            // 
            this.ocenyTableAdapter.ClearBeforeFill = true;
            // 
            // identyfikatorDataGridViewTextBoxColumn
            // 
            this.identyfikatorDataGridViewTextBoxColumn.DataPropertyName = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.HeaderText = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.identyfikatorDataGridViewTextBoxColumn.Name = "identyfikatorDataGridViewTextBoxColumn";
            this.identyfikatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.identyfikatorDataGridViewTextBoxColumn.Width = 125;
            // 
            // tematDataGridViewTextBoxColumn
            // 
            this.tematDataGridViewTextBoxColumn.DataPropertyName = "temat";
            this.tematDataGridViewTextBoxColumn.HeaderText = "temat";
            this.tematDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tematDataGridViewTextBoxColumn.Name = "tematDataGridViewTextBoxColumn";
            this.tematDataGridViewTextBoxColumn.Width = 125;
            // 
            // iduczniaDataGridViewTextBoxColumn
            // 
            this.iduczniaDataGridViewTextBoxColumn.DataPropertyName = "id_ucznia";
            this.iduczniaDataGridViewTextBoxColumn.HeaderText = "id_ucznia";
            this.iduczniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iduczniaDataGridViewTextBoxColumn.Name = "iduczniaDataGridViewTextBoxColumn";
            this.iduczniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idnauczycielaDataGridViewTextBoxColumn
            // 
            this.idnauczycielaDataGridViewTextBoxColumn.DataPropertyName = "id_nauczyciela";
            this.idnauczycielaDataGridViewTextBoxColumn.HeaderText = "id_nauczyciela";
            this.idnauczycielaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idnauczycielaDataGridViewTextBoxColumn.Name = "idnauczycielaDataGridViewTextBoxColumn";
            this.idnauczycielaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datawystawieniaDataGridViewTextBoxColumn
            // 
            this.datawystawieniaDataGridViewTextBoxColumn.DataPropertyName = "data_wystawienia";
            this.datawystawieniaDataGridViewTextBoxColumn.HeaderText = "data_wystawienia";
            this.datawystawieniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datawystawieniaDataGridViewTextBoxColumn.Name = "datawystawieniaDataGridViewTextBoxColumn";
            this.datawystawieniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idprzedmiotuDataGridViewTextBoxColumn
            // 
            this.idprzedmiotuDataGridViewTextBoxColumn.DataPropertyName = "id_przedmiotu";
            this.idprzedmiotuDataGridViewTextBoxColumn.HeaderText = "id_przedmiotu";
            this.idprzedmiotuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprzedmiotuDataGridViewTextBoxColumn.Name = "idprzedmiotuDataGridViewTextBoxColumn";
            this.idprzedmiotuDataGridViewTextBoxColumn.Width = 125;
            // 
            // ocenaDataGridViewTextBoxColumn
            // 
            this.ocenaDataGridViewTextBoxColumn.DataPropertyName = "ocena";
            this.ocenaDataGridViewTextBoxColumn.HeaderText = "ocena";
            this.ocenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ocenaDataGridViewTextBoxColumn.Name = "ocenaDataGridViewTextBoxColumn";
            this.ocenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // sSMATimeStampDataGridViewImageColumn
            // 
            this.sSMATimeStampDataGridViewImageColumn.DataPropertyName = "SSMA_TimeStamp";
            this.sSMATimeStampDataGridViewImageColumn.HeaderText = "SSMA_TimeStamp";
            this.sSMATimeStampDataGridViewImageColumn.MinimumWidth = 6;
            this.sSMATimeStampDataGridViewImageColumn.Name = "sSMATimeStampDataGridViewImageColumn";
            this.sSMATimeStampDataGridViewImageColumn.ReadOnly = true;
            this.sSMATimeStampDataGridViewImageColumn.Width = 125;
            // 
            // OcenyUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "OcenyUczen";
            this.Size = new System.Drawing.Size(814, 413);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tematDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduczniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnauczycielaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datawystawieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprzedmiotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn sSMATimeStampDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource ocenyBindingSource;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet;
        private onlinegradebookprojectDataSetTableAdapters.OcenyTableAdapter ocenyTableAdapter;
    }
}
