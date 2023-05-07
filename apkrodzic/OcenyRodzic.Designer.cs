namespace Tylka.apkrodzic
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
            this.identyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tematDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduczniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnauczycielaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datawystawieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprzedmiotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlinegradebookprojectDataSet = new Tylka.onlinegradebookprojectDataSet();
            this.ocenyTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.OcenyTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customButton1 = new Tylka.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).BeginInit();
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
            this.ocenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ocenyBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 450);
            this.dataGridView1.TabIndex = 0;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz Ucznia";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Red;
            this.customButton1.borderColor = System.Drawing.Color.White;
            this.customButton1.BorderRadius = 35;
            this.customButton1.BorderSize = 0;
            this.customButton1.ColorBottom = System.Drawing.Color.White;
            this.customButton1.ColorTop = System.Drawing.Color.Red;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(272, 3);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(87, 35);
            this.customButton1.TabIndex = 3;
            this.customButton1.Text = "Pokaż oceny";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // OcenyRodzic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OcenyRodzic";
            this.Size = new System.Drawing.Size(1052, 492);
            this.Load += new System.EventHandler(this.OcenyRodzic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private CustomButton customButton1;
    }
}
