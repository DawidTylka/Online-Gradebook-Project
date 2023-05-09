namespace Tylka.apknauczyciel
{
    partial class ExamsNauczyciel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamsNauczyciel));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.onlinegradebookprojectDataSet1 = new Tylka.onlinegradebookprojectDataSet();
            this.examsbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sprawdzianyTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.SprawdzianyTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idprzedmiotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tematDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_klasy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.bindingNavigator1.TabIndex = 4;
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
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Tylka.Properties.Resources.odswiezbtn_Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // onlinegradebookprojectDataSet1
            // 
            this.onlinegradebookprojectDataSet1.DataSetName = "onlinegradebookprojectDataSet";
            this.onlinegradebookprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examsbindingSource1
            // 
            this.examsbindingSource1.DataMember = "Sprawdziany";
            this.examsbindingSource1.DataSource = this.onlinegradebookprojectDataSet1;
            // 
            // sprawdzianyTableAdapter
            // 
            this.sprawdzianyTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprzedmiotuDataGridViewTextBoxColumn,
            this.tematDataGridViewTextBoxColumn,
            this.terminDataGridViewTextBoxColumn,
            this.id_klasy});
            this.dataGridView1.DataSource = this.examsbindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 450);
            this.dataGridView1.TabIndex = 5;
            // 
            // idprzedmiotuDataGridViewTextBoxColumn
            // 
            this.idprzedmiotuDataGridViewTextBoxColumn.DataPropertyName = "id_przedmiotu";
            this.idprzedmiotuDataGridViewTextBoxColumn.HeaderText = "id_przedmiotu";
            this.idprzedmiotuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprzedmiotuDataGridViewTextBoxColumn.Name = "idprzedmiotuDataGridViewTextBoxColumn";
            this.idprzedmiotuDataGridViewTextBoxColumn.Width = 125;
            // 
            // tematDataGridViewTextBoxColumn
            // 
            this.tematDataGridViewTextBoxColumn.DataPropertyName = "temat";
            this.tematDataGridViewTextBoxColumn.HeaderText = "temat";
            this.tematDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tematDataGridViewTextBoxColumn.Name = "tematDataGridViewTextBoxColumn";
            this.tematDataGridViewTextBoxColumn.Width = 125;
            // 
            // terminDataGridViewTextBoxColumn
            // 
            this.terminDataGridViewTextBoxColumn.DataPropertyName = "termin";
            this.terminDataGridViewTextBoxColumn.HeaderText = "termin";
            this.terminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.terminDataGridViewTextBoxColumn.Name = "terminDataGridViewTextBoxColumn";
            this.terminDataGridViewTextBoxColumn.Width = 125;
            // 
            // id_klasy
            // 
            this.id_klasy.DataPropertyName = "id_klasy";
            this.id_klasy.HeaderText = "id_klasy";
            this.id_klasy.MinimumWidth = 6;
            this.id_klasy.Name = "id_klasy";
            this.id_klasy.Width = 125;
            // 
            // ExamsNauczyciel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExamsNauczyciel";
            this.Size = new System.Drawing.Size(1052, 492);
            this.Load += new System.EventHandler(this.ExamsNauczyciel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet1;
        private System.Windows.Forms.BindingSource examsbindingSource1;
        private onlinegradebookprojectDataSetTableAdapters.SprawdzianyTableAdapter sprawdzianyTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprzedmiotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tematDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_klasy;
    }
}
