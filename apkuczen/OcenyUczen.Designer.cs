namespace Tylka.apkuczen
{
    partial class OcenyUczen
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
            this.ocenyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlinegradebookprojectDataSet = new Tylka.onlinegradebookprojectDataSet();
            this.ocenyTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.OcenyTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ocenyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.identyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tematDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduczniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnauczycielaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datawystawieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprzedmiotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ocenyBindingSource
            // 
            this.ocenyBindingSource.DataMember = "Oceny";
            this.ocenyBindingSource.DataSource = this.onlinegradebookprojectDataSet;
            // 
            // onlinegradebookprojectDataSet
            // 
            this.onlinegradebookprojectDataSet.DataSetName = "onlinegradebookprojectDataSet";
            this.onlinegradebookprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ocenyTableAdapter
            // 
            this.ocenyTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identyfikatorDataGridViewTextBoxColumn,
            this.tematDataGridViewTextBoxColumn,
            this.iduczniaDataGridViewTextBoxColumn,
            this.idnauczycielaDataGridViewTextBoxColumn,
            this.datawystawieniaDataGridViewTextBoxColumn,
            this.idprzedmiotuDataGridViewTextBoxColumn,
            this.ocenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ocenyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // ocenyBindingSource1
            // 
            this.ocenyBindingSource1.DataMember = "Oceny";
            this.ocenyBindingSource1.DataSource = this.onlinegradebookprojectDataSet;
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
            // OcenyUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OcenyUczen";
            this.Size = new System.Drawing.Size(1052, 492);
            this.Load += new System.EventHandler(this.OcenyUczen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ocenyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn sSMATimeStampDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource ocenyBindingSource;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet;
        private onlinegradebookprojectDataSetTableAdapters.OcenyTableAdapter ocenyTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ocenyBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tematDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduczniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnauczycielaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datawystawieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprzedmiotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenaDataGridViewTextBoxColumn;
    }
}
