namespace Tylka.apkuczen
{
    partial class KlasyUczen
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
            this.identyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.onlinegradebookprojectDataSet = new Tylka.onlinegradebookprojectDataSet();
            this.klasyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klasyTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.KlasyTableAdapter();
            this.sprawdzianyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprawdzianyTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.SprawdzianyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprawdzianyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identyfikatorDataGridViewTextBoxColumn,
            this.profilDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klasyBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(789, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // identyfikatorDataGridViewTextBoxColumn
            // 
            this.identyfikatorDataGridViewTextBoxColumn.DataPropertyName = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.HeaderText = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.Name = "identyfikatorDataGridViewTextBoxColumn";
            this.identyfikatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profilDataGridViewTextBoxColumn
            // 
            this.profilDataGridViewTextBoxColumn.DataPropertyName = "Profil";
            this.profilDataGridViewTextBoxColumn.HeaderText = "Profil";
            this.profilDataGridViewTextBoxColumn.Name = "profilDataGridViewTextBoxColumn";
            this.profilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klasyBindingSource1
            // 
            this.klasyBindingSource1.DataMember = "Klasy";
            this.klasyBindingSource1.DataSource = this.onlinegradebookprojectDataSet;
            // 
            // onlinegradebookprojectDataSet
            // 
            this.onlinegradebookprojectDataSet.DataSetName = "onlinegradebookprojectDataSet";
            this.onlinegradebookprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klasyBindingSource
            // 
            this.klasyBindingSource.DataMember = "Klasy";
            this.klasyBindingSource.DataSource = this.onlinegradebookprojectDataSet;
            // 
            // klasyTableAdapter
            // 
            this.klasyTableAdapter.ClearBeforeFill = true;
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
            // KlasyUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "KlasyUczen";
            this.Size = new System.Drawing.Size(789, 400);
            this.Load += new System.EventHandler(this.KlasyUczen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprawdzianyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource klasyBindingSource;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet;
        private onlinegradebookprojectDataSetTableAdapters.KlasyTableAdapter klasyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource klasyBindingSource1;
        private System.Windows.Forms.BindingSource sprawdzianyBindingSource;
        private onlinegradebookprojectDataSetTableAdapters.SprawdzianyTableAdapter sprawdzianyTableAdapter;
    }
}
