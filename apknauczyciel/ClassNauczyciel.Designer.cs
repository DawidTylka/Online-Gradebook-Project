namespace Tylka.apknauczyciel
{
    partial class ClassNauczyciel
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
            this.klasyTableAdapter1 = new Tylka.onlinegradebookprojectDataSetTableAdapters.KlasyTableAdapter();
            this.onlinegradebookprojectDataSet1 = new Tylka.onlinegradebookprojectDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.klasyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.klasyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.identyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customButton1 = new Tylka.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // klasyTableAdapter1
            // 
            this.klasyTableAdapter1.ClearBeforeFill = true;
            // 
            // onlinegradebookprojectDataSet1
            // 
            this.onlinegradebookprojectDataSet1.DataSetName = "onlinegradebookprojectDataSet";
            this.onlinegradebookprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identyfikatorDataGridViewTextBoxColumn,
            this.User_id,
            this.Klasa,
            this.profilDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klasyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 450);
            this.dataGridView1.TabIndex = 2;
            // 
            // klasyBindingSource1
            // 
            this.klasyBindingSource1.DataMember = "Klasy";
            this.klasyBindingSource1.DataSource = this.onlinegradebookprojectDataSet1;
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
            // User_id
            // 
            this.User_id.DataPropertyName = "User_id";
            this.User_id.HeaderText = "User_id";
            this.User_id.MinimumWidth = 6;
            this.User_id.Name = "User_id";
            this.User_id.ReadOnly = true;
            this.User_id.Width = 125;
            // 
            // Klasa
            // 
            this.Klasa.DataPropertyName = "Klasa";
            this.Klasa.HeaderText = "Klasa";
            this.Klasa.MinimumWidth = 6;
            this.Klasa.Name = "Klasa";
            this.Klasa.ReadOnly = true;
            this.Klasa.Width = 125;
            // 
            // profilDataGridViewTextBoxColumn
            // 
            this.profilDataGridViewTextBoxColumn.DataPropertyName = "Profil";
            this.profilDataGridViewTextBoxColumn.HeaderText = "Profil";
            this.profilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.profilDataGridViewTextBoxColumn.Name = "profilDataGridViewTextBoxColumn";
            this.profilDataGridViewTextBoxColumn.ReadOnly = true;
            this.profilDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz klasę:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(228, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.customButton1.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(89)))), ((int)(((byte)(175)))));
            this.customButton1.BorderRadius = 35;
            this.customButton1.BorderSize = 0;
            this.customButton1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(129)))), ((int)(((byte)(182)))));
            this.customButton1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(389, 5);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(90, 35);
            this.customButton1.TabIndex = 5;
            this.customButton1.Text = "Pokaż";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // ClassNauczyciel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClassNauczyciel";
            this.Size = new System.Drawing.Size(1052, 492);
            this.Load += new System.EventHandler(this.ClassNauczyciel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private onlinegradebookprojectDataSetTableAdapters.KlasyTableAdapter klasyTableAdapter1;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet1;
        private System.Windows.Forms.BindingSource klasyBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource klasyBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CustomButton customButton1;
    }
}
