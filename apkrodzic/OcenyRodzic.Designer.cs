﻿namespace Tylka.apkrodzic
{
    partial class OcenyRodzic
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 366);
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
            this.identyfikatorDataGridViewTextBoxColumn.Name = "identyfikatorDataGridViewTextBoxColumn";
            this.identyfikatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tematDataGridViewTextBoxColumn
            // 
            this.tematDataGridViewTextBoxColumn.DataPropertyName = "temat";
            this.tematDataGridViewTextBoxColumn.HeaderText = "temat";
            this.tematDataGridViewTextBoxColumn.Name = "tematDataGridViewTextBoxColumn";
            // 
            // iduczniaDataGridViewTextBoxColumn
            // 
            this.iduczniaDataGridViewTextBoxColumn.DataPropertyName = "id_ucznia";
            this.iduczniaDataGridViewTextBoxColumn.HeaderText = "id_ucznia";
            this.iduczniaDataGridViewTextBoxColumn.Name = "iduczniaDataGridViewTextBoxColumn";
            // 
            // idnauczycielaDataGridViewTextBoxColumn
            // 
            this.idnauczycielaDataGridViewTextBoxColumn.DataPropertyName = "id_nauczyciela";
            this.idnauczycielaDataGridViewTextBoxColumn.HeaderText = "id_nauczyciela";
            this.idnauczycielaDataGridViewTextBoxColumn.Name = "idnauczycielaDataGridViewTextBoxColumn";
            // 
            // datawystawieniaDataGridViewTextBoxColumn
            // 
            this.datawystawieniaDataGridViewTextBoxColumn.DataPropertyName = "data_wystawienia";
            this.datawystawieniaDataGridViewTextBoxColumn.HeaderText = "data_wystawienia";
            this.datawystawieniaDataGridViewTextBoxColumn.Name = "datawystawieniaDataGridViewTextBoxColumn";
            // 
            // idprzedmiotuDataGridViewTextBoxColumn
            // 
            this.idprzedmiotuDataGridViewTextBoxColumn.DataPropertyName = "id_przedmiotu";
            this.idprzedmiotuDataGridViewTextBoxColumn.HeaderText = "id_przedmiotu";
            this.idprzedmiotuDataGridViewTextBoxColumn.Name = "idprzedmiotuDataGridViewTextBoxColumn";
            // 
            // ocenaDataGridViewTextBoxColumn
            // 
            this.ocenaDataGridViewTextBoxColumn.DataPropertyName = "ocena";
            this.ocenaDataGridViewTextBoxColumn.HeaderText = "ocena";
            this.ocenaDataGridViewTextBoxColumn.Name = "ocenaDataGridViewTextBoxColumn";
            // 
            // sSMATimeStampDataGridViewImageColumn
            // 
            this.sSMATimeStampDataGridViewImageColumn.DataPropertyName = "SSMA_TimeStamp";
            this.sSMATimeStampDataGridViewImageColumn.HeaderText = "SSMA_TimeStamp";
            this.sSMATimeStampDataGridViewImageColumn.Name = "sSMATimeStampDataGridViewImageColumn";
            this.sSMATimeStampDataGridViewImageColumn.ReadOnly = true;
            // 
            // OcenyRodzic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "OcenyRodzic";
            this.Size = new System.Drawing.Size(789, 400);
            this.Load += new System.EventHandler(this.OcenyRodzic_Load);
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
