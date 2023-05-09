namespace Tylka
{
    partial class PlansAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlansAdmin));
            this.dniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlinegradebookprojectDataSet = new Tylka.onlinegradebookprojectDataSet();
            this.dniTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.DniTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.dniBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1052, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Tylka.Properties.Resources.odswiezbtn_Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
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
            this.dataGridView1.DataSource = this.dniBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // iddniaDataGridViewTextBoxColumn
            // 
            this.iddniaDataGridViewTextBoxColumn.DataPropertyName = "iddnia";
            this.iddniaDataGridViewTextBoxColumn.HeaderText = "iddnia";
            this.iddniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddniaDataGridViewTextBoxColumn.Name = "iddniaDataGridViewTextBoxColumn";
            this.iddniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddniaDataGridViewTextBoxColumn.Width = 73;
            // 
            // idklasyDataGridViewTextBoxColumn
            // 
            this.idklasyDataGridViewTextBoxColumn.DataPropertyName = "id_klasy";
            this.idklasyDataGridViewTextBoxColumn.HeaderText = "id_klasy";
            this.idklasyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklasyDataGridViewTextBoxColumn.Name = "idklasyDataGridViewTextBoxColumn";
            this.idklasyDataGridViewTextBoxColumn.Width = 86;
            // 
            // godzinaDataGridViewTextBoxColumn
            // 
            this.godzinaDataGridViewTextBoxColumn.DataPropertyName = "godzina";
            this.godzinaDataGridViewTextBoxColumn.HeaderText = "godzina";
            this.godzinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.godzinaDataGridViewTextBoxColumn.Name = "godzinaDataGridViewTextBoxColumn";
            this.godzinaDataGridViewTextBoxColumn.Width = 84;
            // 
            // poniedziałeDataGridViewTextBoxColumn
            // 
            this.poniedziałeDataGridViewTextBoxColumn.DataPropertyName = "Poniedziałe";
            this.poniedziałeDataGridViewTextBoxColumn.HeaderText = "Poniedziałe";
            this.poniedziałeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poniedziałeDataGridViewTextBoxColumn.Name = "poniedziałeDataGridViewTextBoxColumn";
            this.poniedziałeDataGridViewTextBoxColumn.Width = 110;
            // 
            // wtorekDataGridViewTextBoxColumn
            // 
            this.wtorekDataGridViewTextBoxColumn.DataPropertyName = "Wtorek";
            this.wtorekDataGridViewTextBoxColumn.HeaderText = "Wtorek";
            this.wtorekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wtorekDataGridViewTextBoxColumn.Name = "wtorekDataGridViewTextBoxColumn";
            this.wtorekDataGridViewTextBoxColumn.Width = 79;
            // 
            // środaDataGridViewTextBoxColumn
            // 
            this.środaDataGridViewTextBoxColumn.DataPropertyName = "Środa";
            this.środaDataGridViewTextBoxColumn.HeaderText = "Środa";
            this.środaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.środaDataGridViewTextBoxColumn.Name = "środaDataGridViewTextBoxColumn";
            this.środaDataGridViewTextBoxColumn.Width = 73;
            // 
            // czwartekDataGridViewTextBoxColumn
            // 
            this.czwartekDataGridViewTextBoxColumn.DataPropertyName = "Czwartek";
            this.czwartekDataGridViewTextBoxColumn.HeaderText = "Czwartek";
            this.czwartekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.czwartekDataGridViewTextBoxColumn.Name = "czwartekDataGridViewTextBoxColumn";
            this.czwartekDataGridViewTextBoxColumn.Width = 90;
            // 
            // piątekDataGridViewTextBoxColumn
            // 
            this.piątekDataGridViewTextBoxColumn.DataPropertyName = "Piątek";
            this.piątekDataGridViewTextBoxColumn.HeaderText = "Piątek";
            this.piątekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.piątekDataGridViewTextBoxColumn.Name = "piątekDataGridViewTextBoxColumn";
            this.piątekDataGridViewTextBoxColumn.Width = 74;
            // 
            // sobotaDataGridViewTextBoxColumn
            // 
            this.sobotaDataGridViewTextBoxColumn.DataPropertyName = "Sobota";
            this.sobotaDataGridViewTextBoxColumn.HeaderText = "Sobota";
            this.sobotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sobotaDataGridViewTextBoxColumn.Name = "sobotaDataGridViewTextBoxColumn";
            this.sobotaDataGridViewTextBoxColumn.Width = 80;
            // 
            // niedzielaDataGridViewTextBoxColumn
            // 
            this.niedzielaDataGridViewTextBoxColumn.DataPropertyName = "Niedziela";
            this.niedzielaDataGridViewTextBoxColumn.HeaderText = "Niedziela";
            this.niedzielaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.niedzielaDataGridViewTextBoxColumn.Name = "niedzielaDataGridViewTextBoxColumn";
            this.niedzielaDataGridViewTextBoxColumn.Width = 93;
            // 
            // dniBindingSource1
            // 
            this.dniBindingSource1.DataMember = "Dni";
            this.dniBindingSource1.DataSource = this.onlinegradebookprojectDataSet;
            // 
            // PlansAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlansAdmin";
            this.Size = new System.Drawing.Size(1052, 492);
            this.Load += new System.EventHandler(this.PlansAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dniBindingSource;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet;
        private onlinegradebookprojectDataSetTableAdapters.DniTableAdapter dniTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.BindingSource dniBindingSource1;
    }
}
