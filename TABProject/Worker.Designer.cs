namespace TABProject
{
    partial class Worker
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
            this.bLogOut = new System.Windows.Forms.Button();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.bSaveStatus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idworkertaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtopenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtfinalcancelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workertaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tABDataSet3 = new TABProject.TABDataSet3();
            this.worker_taskTableAdapter = new TABProject.TABDataSet3TableAdapters.worker_taskTableAdapter();
            this.lRegistrationDate = new System.Windows.Forms.Label();
            this.dataTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertaskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(493, 32);
            this.bLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(80, 38);
            this.bLogOut.TabIndex = 20;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(493, 259);
            this.cbDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(52, 17);
            this.cbDone.TabIndex = 27;
            this.cbDone.Text = "Done";
            this.cbDone.UseVisualStyleBackColor = true;
            // 
            // bSaveStatus
            // 
            this.bSaveStatus.Location = new System.Drawing.Point(493, 304);
            this.bSaveStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSaveStatus.Name = "bSaveStatus";
            this.bSaveStatus.Size = new System.Drawing.Size(80, 37);
            this.bSaveStatus.TabIndex = 26;
            this.bSaveStatus.Text = "Save status";
            this.bSaveStatus.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idworkertaskDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.idworkerDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dtopenDataGridViewTextBoxColumn,
            this.idissueDataGridViewTextBoxColumn,
            this.dtfinalcancelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workertaskBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 261);
            this.dataGridView1.TabIndex = 28;
            // 
            // idworkertaskDataGridViewTextBoxColumn
            // 
            this.idworkertaskDataGridViewTextBoxColumn.DataPropertyName = "id_worker_task";
            this.idworkertaskDataGridViewTextBoxColumn.HeaderText = "id_worker_task";
            this.idworkertaskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idworkertaskDataGridViewTextBoxColumn.Name = "idworkertaskDataGridViewTextBoxColumn";
            this.idworkertaskDataGridViewTextBoxColumn.ReadOnly = true;
            this.idworkertaskDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // idworkerDataGridViewTextBoxColumn
            // 
            this.idworkerDataGridViewTextBoxColumn.DataPropertyName = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.HeaderText = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idworkerDataGridViewTextBoxColumn.Name = "idworkerDataGridViewTextBoxColumn";
            this.idworkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idworkerDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "result";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtopenDataGridViewTextBoxColumn
            // 
            this.dtopenDataGridViewTextBoxColumn.DataPropertyName = "dt_open";
            this.dtopenDataGridViewTextBoxColumn.HeaderText = "dt_open";
            this.dtopenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtopenDataGridViewTextBoxColumn.Name = "dtopenDataGridViewTextBoxColumn";
            this.dtopenDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtopenDataGridViewTextBoxColumn.Width = 125;
            // 
            // idissueDataGridViewTextBoxColumn
            // 
            this.idissueDataGridViewTextBoxColumn.DataPropertyName = "id_issue";
            this.idissueDataGridViewTextBoxColumn.HeaderText = "id_issue";
            this.idissueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idissueDataGridViewTextBoxColumn.Name = "idissueDataGridViewTextBoxColumn";
            this.idissueDataGridViewTextBoxColumn.ReadOnly = true;
            this.idissueDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtfinalcancelDataGridViewTextBoxColumn
            // 
            this.dtfinalcancelDataGridViewTextBoxColumn.DataPropertyName = "dt_final_cancel";
            this.dtfinalcancelDataGridViewTextBoxColumn.HeaderText = "dt_final_cancel";
            this.dtfinalcancelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtfinalcancelDataGridViewTextBoxColumn.Name = "dtfinalcancelDataGridViewTextBoxColumn";
            this.dtfinalcancelDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtfinalcancelDataGridViewTextBoxColumn.Width = 125;
            // 
            // workertaskBindingSource
            // 
            this.workertaskBindingSource.DataMember = "worker_task";
            this.workertaskBindingSource.DataSource = this.tABDataSet3;
            // 
            // tABDataSet3
            // 
            this.tABDataSet3.DataSetName = "TABDataSet3";
            this.tABDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worker_taskTableAdapter
            // 
            this.worker_taskTableAdapter.ClearBeforeFill = true;
            // 
            // lRegistrationDate
            // 
            this.lRegistrationDate.AutoSize = true;
            this.lRegistrationDate.Location = new System.Drawing.Point(26, 17);
            this.lRegistrationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRegistrationDate.Name = "lRegistrationDate";
            this.lRegistrationDate.Size = new System.Drawing.Size(90, 13);
            this.lRegistrationDate.TabIndex = 30;
            this.lRegistrationDate.Text = "Registration date:";
            // 
            // dataTime
            // 
            this.dataTime.Location = new System.Drawing.Point(26, 39);
            this.dataTime.Margin = new System.Windows.Forms.Padding(2);
            this.dataTime.Name = "dataTime";
            this.dataTime.ShowCheckBox = true;
            this.dataTime.Size = new System.Drawing.Size(151, 20);
            this.dataTime.TabIndex = 29;
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 370);
            this.Controls.Add(this.lRegistrationDate);
            this.Controls.Add(this.dataTime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbDone);
            this.Controls.Add(this.bSaveStatus);
            this.Controls.Add(this.bLogOut);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Worker";
            this.Text = "Task Management System - Worker Console";
            this.Load += new System.EventHandler(this.Worker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertaskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.Button bSaveStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TABDataSet3 tABDataSet3;
        private System.Windows.Forms.BindingSource workertaskBindingSource;
        private TABDataSet3TableAdapters.worker_taskTableAdapter worker_taskTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkertaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtopenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtfinalcancelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lRegistrationDate;
        private System.Windows.Forms.DateTimePicker dataTime;
    }
}