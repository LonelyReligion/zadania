namespace TABProject
{
    partial class ACCRequestList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgTabela = new System.Windows.Forms.DataGridView();
            this.dataTime = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbMine = new System.Windows.Forms.CheckBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.lRegistrationDate = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.bSelect = new System.Windows.Forms.Button();
            this.bLogOut = new System.Windows.Forms.Button();
            this.tABDataSet = new TABProject.TABDataSet();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestTableAdapter = new TABProject.TABDataSetTableAdapters.requestTableAdapter();
            this.idrequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idaccountmanagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idversionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtopenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtfinalcancelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTabela
            // 
            this.dgTabela.AutoGenerateColumns = false;
            this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrequestDataGridViewTextBoxColumn,
            this.idaccountmanagerDataGridViewTextBoxColumn,
            this.idversionDataGridViewTextBoxColumn,
            this.dtopenDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.dtfinalcancelDataGridViewTextBoxColumn});
            this.dgTabela.DataSource = this.requestBindingSource;
            this.dgTabela.Location = new System.Drawing.Point(42, 105);
            this.dgTabela.Name = "dgTabela";
            this.dgTabela.RowHeadersWidth = 51;
            this.dgTabela.RowTemplate.Height = 24;
            this.dgTabela.Size = new System.Drawing.Size(633, 311);
            this.dgTabela.TabIndex = 0;
            this.dgTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataTime
            // 
            this.dataTime.Checked = false;
            this.dataTime.Location = new System.Drawing.Point(42, 61);
            this.dataTime.Name = "dataTime";
            this.dataTime.ShowCheckBox = true;
            this.dataTime.Size = new System.Drawing.Size(200, 22);
            this.dataTime.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(281, 61);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // cbMine
            // 
            this.cbMine.AutoSize = true;
            this.cbMine.Location = new System.Drawing.Point(431, 63);
            this.cbMine.Name = "cbMine";
            this.cbMine.Size = new System.Drawing.Size(58, 20);
            this.cbMine.TabIndex = 3;
            this.cbMine.Text = "Mine";
            this.cbMine.UseVisualStyleBackColor = true;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(278, 35);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(47, 16);
            this.lStatus.TabIndex = 4;
            this.lStatus.Text = "Status:";
            this.lStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // lRegistrationDate
            // 
            this.lRegistrationDate.AutoSize = true;
            this.lRegistrationDate.Location = new System.Drawing.Point(42, 35);
            this.lRegistrationDate.Name = "lRegistrationDate";
            this.lRegistrationDate.Size = new System.Drawing.Size(112, 16);
            this.lRegistrationDate.TabIndex = 5;
            this.lRegistrationDate.Text = "Registration date:";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(509, 55);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(99, 35);
            this.bSearch.TabIndex = 6;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(681, 377);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(97, 39);
            this.bSelect.TabIndex = 7;
            this.bSelect.Text = "Select";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(669, 18);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(109, 51);
            this.bLogOut.TabIndex = 8;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // tABDataSet
            // 
            this.tABDataSet.DataSetName = "TABDataSet";
            this.tABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataMember = "request";
            this.requestBindingSource.DataSource = this.tABDataSet;
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // idrequestDataGridViewTextBoxColumn
            // 
            this.idrequestDataGridViewTextBoxColumn.DataPropertyName = "id_request";
            this.idrequestDataGridViewTextBoxColumn.HeaderText = "id_request";
            this.idrequestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrequestDataGridViewTextBoxColumn.Name = "idrequestDataGridViewTextBoxColumn";
            this.idrequestDataGridViewTextBoxColumn.ReadOnly = true;
            this.idrequestDataGridViewTextBoxColumn.Width = 125;
            // 
            // idaccountmanagerDataGridViewTextBoxColumn
            // 
            this.idaccountmanagerDataGridViewTextBoxColumn.DataPropertyName = "id_account_manager";
            this.idaccountmanagerDataGridViewTextBoxColumn.HeaderText = "id_account_manager";
            this.idaccountmanagerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idaccountmanagerDataGridViewTextBoxColumn.Name = "idaccountmanagerDataGridViewTextBoxColumn";
            this.idaccountmanagerDataGridViewTextBoxColumn.Width = 125;
            // 
            // idversionDataGridViewTextBoxColumn
            // 
            this.idversionDataGridViewTextBoxColumn.DataPropertyName = "id_version";
            this.idversionDataGridViewTextBoxColumn.HeaderText = "id_version";
            this.idversionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idversionDataGridViewTextBoxColumn.Name = "idversionDataGridViewTextBoxColumn";
            this.idversionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtopenDataGridViewTextBoxColumn
            // 
            this.dtopenDataGridViewTextBoxColumn.DataPropertyName = "dt_open";
            this.dtopenDataGridViewTextBoxColumn.HeaderText = "dt_open";
            this.dtopenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtopenDataGridViewTextBoxColumn.Name = "dtopenDataGridViewTextBoxColumn";
            this.dtopenDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "result";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtfinalcancelDataGridViewTextBoxColumn
            // 
            this.dtfinalcancelDataGridViewTextBoxColumn.DataPropertyName = "dt_final_cancel";
            this.dtfinalcancelDataGridViewTextBoxColumn.HeaderText = "dt_final_cancel";
            this.dtfinalcancelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtfinalcancelDataGridViewTextBoxColumn.Name = "dtfinalcancelDataGridViewTextBoxColumn";
            this.dtfinalcancelDataGridViewTextBoxColumn.Width = 125;
            // 
            // ACCRequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLogOut);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.lRegistrationDate);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.cbMine);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dataTime);
            this.Controls.Add(this.dgTabela);
            this.Name = "ACCRequestList";
            this.Text = "Task Management System - Request List";
            this.Load += new System.EventHandler(this.ACCRequestList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTabela;
        private System.Windows.Forms.DateTimePicker dataTime;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.CheckBox cbMine;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lRegistrationDate;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.Button bLogOut;
        private TABDataSet tABDataSet;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private TABDataSetTableAdapters.requestTableAdapter requestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaccountmanagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idversionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtopenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtfinalcancelDataGridViewTextBoxColumn;
    }
}