namespace Tylka
{
    partial class admintest
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
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Tylka.onlinegradebookprojectDataSetTableAdapters.UsersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idopiekunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.adminDataGridViewCheckBoxColumn,
            this.rolaDataGridViewTextBoxColumn,
            this.idopiekunaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(527, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // onlinegradebookprojectDataSet
            // 
            this.onlinegradebookprojectDataSet.DataSetName = "onlinegradebookprojectDataSet";
            this.onlinegradebookprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.onlinegradebookprojectDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "pesel";
            this.peselDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            this.peselDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "admin";
            this.adminDataGridViewCheckBoxColumn.HeaderText = "admin";
            this.adminDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            this.adminDataGridViewCheckBoxColumn.Width = 125;
            // 
            // rolaDataGridViewTextBoxColumn
            // 
            this.rolaDataGridViewTextBoxColumn.DataPropertyName = "rola";
            this.rolaDataGridViewTextBoxColumn.HeaderText = "rola";
            this.rolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rolaDataGridViewTextBoxColumn.Name = "rolaDataGridViewTextBoxColumn";
            this.rolaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idopiekunaDataGridViewTextBoxColumn
            // 
            this.idopiekunaDataGridViewTextBoxColumn.DataPropertyName = "idopiekuna";
            this.idopiekunaDataGridViewTextBoxColumn.HeaderText = "idopiekuna";
            this.idopiekunaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idopiekunaDataGridViewTextBoxColumn.Name = "idopiekunaDataGridViewTextBoxColumn";
            this.idopiekunaDataGridViewTextBoxColumn.Width = 125;
            // 
            // admintest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "admintest";
            this.Size = new System.Drawing.Size(688, 404);
            this.Load += new System.EventHandler(this.admintest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegradebookprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopiekunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private onlinegradebookprojectDataSet onlinegradebookprojectDataSet;
        private onlinegradebookprojectDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}
