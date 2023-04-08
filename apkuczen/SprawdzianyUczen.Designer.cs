namespace Tylka.apkuczen
{
    partial class SprawdzianyUczen
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
            this.onlinegradebookprojectDataSet1 = new Tylka.onlinegradebookprojectDataSet1();
            this.dniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dniTableAdapter = new Tylka.onlinegradebookprojectDataSet1TableAdapters.DniTableAdapter();
            this.onlinegradebookprojectDataSet = new Tylka.onlinegradebookprojectDataSet();
            this.sprawdzianyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprawdzianyTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.SprawdzianyTableAdapter();
            this.idprzedmiotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tematDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprawdzianyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprzedmiotuDataGridViewTextBoxColumn,
            this.tematDataGridViewTextBoxColumn,
            this.terminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sprawdzianyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(80, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // onlinegradebookprojectDataSet1
            // 
            this.onlinegradebookprojectDataSet1.DataSetName = "onlinegradebookprojectDataSet1";
            this.onlinegradebookprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dniBindingSource
            // 
            this.dniBindingSource.DataMember = "Dni";
            this.dniBindingSource.DataSource = this.onlinegradebookprojectDataSet1;
            // 
            // dniTableAdapter
            // 
            this.dniTableAdapter.ClearBeforeFill = true;
            // 
            // onlinegradebookprojectDataSet
            // 
            this.onlinegradebookprojectDataSet.DataSetName = "onlinegradebookprojectDataSet";
            this.onlinegradebookprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprawdzianyBindingSource
            // 
            this.sprawdzianyBindingSource.DataMember = "Sprawdziany";
            this.sprawdzianyBindingSource.DataSource = this.onlinegradebookprojectDataSet;
            // 
            // sprawdzianyTableAdapter
            // 
            this.sprawdzianyTableAdapter.ClearBeforeFill = true;
            // 
            // idprzedmiotuDataGridViewTextBoxColumn
            // 
            this.idprzedmiotuDataGridViewTextBoxColumn.DataPropertyName = "id_przedmiotu";
            this.idprzedmiotuDataGridViewTextBoxColumn.HeaderText = "id_przedmiotu";
            this.idprzedmiotuDataGridViewTextBoxColumn.Name = "idprzedmiotuDataGridViewTextBoxColumn";
            // 
            // tematDataGridViewTextBoxColumn
            // 
            this.tematDataGridViewTextBoxColumn.DataPropertyName = "temat";
            this.tematDataGridViewTextBoxColumn.HeaderText = "temat";
            this.tematDataGridViewTextBoxColumn.Name = "tematDataGridViewTextBoxColumn";
            // 
            // terminDataGridViewTextBoxColumn
            // 
            this.terminDataGridViewTextBoxColumn.DataPropertyName = "termin";
            this.terminDataGridViewTextBoxColumn.HeaderText = "termin";
            this.terminDataGridViewTextBoxColumn.Name = "terminDataGridViewTextBoxColumn";
            // 
            // SprawdzianyUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "SprawdzianyUczen";
            this.Size = new System.Drawing.Size(641, 405);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprawdzianyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprzedmiotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tematDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sprawdzianyBindingSource;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet;
        private onlinegradebookprojectDataSet1 onlinegradebookprojectDataSet1;
        private System.Windows.Forms.BindingSource dniBindingSource;
        private onlinegradebookprojectDataSet1TableAdapters.DniTableAdapter dniTableAdapter;
        private onlinegradebookprojectDataSetTableAdapters.SprawdzianyTableAdapter sprawdzianyTableAdapter;
    }
}
