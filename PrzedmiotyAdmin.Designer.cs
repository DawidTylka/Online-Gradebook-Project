namespace Tylka
{
    partial class PrzedmiotyAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrzedmiotyAdmin));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.przedmiotyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.onlinegradebookprojectDataSet1 = new Tylka.onlinegradebookprojectDataSet();
            this.przedmiotyTableAdapter1 = new Tylka.onlinegradebookprojectDataSetTableAdapters.PrzedmiotyTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idprzedmiotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnauczycielaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przedmiotyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1052, 31);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Tylka.Properties.Resources.odswiezbtn_Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // przedmiotyBindingSource1
            // 
            this.przedmiotyBindingSource1.DataMember = "Przedmioty";
            this.przedmiotyBindingSource1.DataSource = this.onlinegradebookprojectDataSet1;
            // 
            // onlinegradebookprojectDataSet1
            // 
            this.onlinegradebookprojectDataSet1.DataSetName = "onlinegradebookprojectDataSet";
            this.onlinegradebookprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // przedmiotyTableAdapter1
            // 
            this.przedmiotyTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprzedmiotuDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.idnauczycielaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.przedmiotyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 42);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(1052, 450);
            this.dataGridView2.TabIndex = 2;
            // 
            // idprzedmiotuDataGridViewTextBoxColumn
            // 
            this.idprzedmiotuDataGridViewTextBoxColumn.DataPropertyName = "id_przedmiotu";
            this.idprzedmiotuDataGridViewTextBoxColumn.HeaderText = "id_przedmiotu";
            this.idprzedmiotuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprzedmiotuDataGridViewTextBoxColumn.Name = "idprzedmiotuDataGridViewTextBoxColumn";
            this.idprzedmiotuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprzedmiotuDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idnauczycielaDataGridViewTextBoxColumn
            // 
            this.idnauczycielaDataGridViewTextBoxColumn.DataPropertyName = "id_nauczyciela";
            this.idnauczycielaDataGridViewTextBoxColumn.HeaderText = "id_nauczyciela";
            this.idnauczycielaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idnauczycielaDataGridViewTextBoxColumn.Name = "idnauczycielaDataGridViewTextBoxColumn";
            this.idnauczycielaDataGridViewTextBoxColumn.Width = 125;
            // 
            // przedmiotyBindingSource
            // 
            this.przedmiotyBindingSource.DataMember = "Przedmioty";
            this.przedmiotyBindingSource.DataSource = this.onlinegradebookprojectDataSet1;
            // 
            // PrzedmiotyAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bindingNavigator1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrzedmiotyAdmin";
            this.Size = new System.Drawing.Size(1052, 492);
            this.Load += new System.EventHandler(this.PrzedmiotyAdmin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource przedmiotyBindingSource1;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet1;
        private onlinegradebookprojectDataSetTableAdapters.PrzedmiotyTableAdapter przedmiotyTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprzedmiotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnauczycielaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource przedmiotyBindingSource;
    }
}
