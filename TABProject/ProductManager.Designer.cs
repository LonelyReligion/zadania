namespace TABProject
{
    partial class ProductManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbIssueID = new System.Windows.Forms.TextBox();
            this.lTasks = new System.Windows.Forms.Label();
            this.lRequestName = new System.Windows.Forms.Label();
            this.bDeleteTask = new System.Windows.Forms.Button();
            this.bAddNewTask = new System.Windows.Forms.Button();
            this.bReturn = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lTaskStatus = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.bEditTask = new System.Windows.Forms.Button();
            this.rbFinal = new System.Windows.Forms.RadioButton();
            this.rbCancel = new System.Windows.Forms.RadioButton();
            this.rbInProgress = new System.Windows.Forms.RadioButton();
            this.tABDataSet = new TABProject.TABDataSet();
            this.workertaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worker_taskTableAdapter = new TABProject.TABDataSetTableAdapters.worker_taskTableAdapter();
            this.workertaskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idworkertaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtopenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtfinalcancelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertaskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertaskBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.DataSource = this.workertaskBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(29, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(722, 229);
            this.dataGridView1.TabIndex = 37;
            // 
            // tbIssueID
            // 
            this.tbIssueID.Location = new System.Drawing.Point(29, 48);
            this.tbIssueID.Multiline = true;
            this.tbIssueID.Name = "tbIssueID";
            this.tbIssueID.ReadOnly = true;
            this.tbIssueID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbIssueID.Size = new System.Drawing.Size(279, 71);
            this.tbIssueID.TabIndex = 35;
            // 
            // lTasks
            // 
            this.lTasks.AutoSize = true;
            this.lTasks.Location = new System.Drawing.Point(28, 139);
            this.lTasks.Name = "lTasks";
            this.lTasks.Size = new System.Drawing.Size(124, 16);
            this.lTasks.TabIndex = 34;
            this.lTasks.Text = "Tasks for this issue:";
            // 
            // lRequestName
            // 
            this.lRequestName.AutoSize = true;
            this.lRequestName.Location = new System.Drawing.Point(28, 24);
            this.lRequestName.Name = "lRequestName";
            this.lRequestName.Size = new System.Drawing.Size(49, 16);
            this.lRequestName.TabIndex = 33;
            this.lRequestName.Text = "Issues:";
            this.lRequestName.Click += new System.EventHandler(this.lRequest_Click);
            // 
            // bDeleteTask
            // 
            this.bDeleteTask.Location = new System.Drawing.Point(249, 398);
            this.bDeleteTask.Name = "bDeleteTask";
            this.bDeleteTask.Size = new System.Drawing.Size(101, 32);
            this.bDeleteTask.TabIndex = 29;
            this.bDeleteTask.Text = "Delete task";
            this.bDeleteTask.UseVisualStyleBackColor = true;
            this.bDeleteTask.Click += new System.EventHandler(this.bDeleteTask_Click);
            // 
            // bAddNewTask
            // 
            this.bAddNewTask.Location = new System.Drawing.Point(138, 398);
            this.bAddNewTask.Name = "bAddNewTask";
            this.bAddNewTask.Size = new System.Drawing.Size(105, 31);
            this.bAddNewTask.TabIndex = 28;
            this.bAddNewTask.Text = "Add new task";
            this.bAddNewTask.UseVisualStyleBackColor = true;
            this.bAddNewTask.Click += new System.EventHandler(this.bAddNewTask_Click_1);
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(749, 19);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(109, 51);
            this.bReturn.TabIndex = 25;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(462, 24);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(48, 16);
            this.lResult.TabIndex = 45;
            this.lResult.Text = "Result:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(465, 48);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(257, 81);
            this.tbResult.TabIndex = 44;
            // 
            // lTaskStatus
            // 
            this.lTaskStatus.AutoSize = true;
            this.lTaskStatus.Location = new System.Drawing.Point(339, 24);
            this.lTaskStatus.Name = "lTaskStatus";
            this.lTaskStatus.Size = new System.Drawing.Size(79, 16);
            this.lTaskStatus.TabIndex = 41;
            this.lTaskStatus.Text = "Task status:";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(749, 76);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(110, 56);
            this.bSave.TabIndex = 38;
            this.bSave.Text = "Save issue";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bEditTask
            // 
            this.bEditTask.Location = new System.Drawing.Point(27, 398);
            this.bEditTask.Name = "bEditTask";
            this.bEditTask.Size = new System.Drawing.Size(105, 31);
            this.bEditTask.TabIndex = 46;
            this.bEditTask.Text = "Edit task";
            this.bEditTask.UseVisualStyleBackColor = true;
            this.bEditTask.Click += new System.EventHandler(this.bEditTask_Click);
            // 
            // rbFinal
            // 
            this.rbFinal.AutoSize = true;
            this.rbFinal.Location = new System.Drawing.Point(342, 102);
            this.rbFinal.Name = "rbFinal";
            this.rbFinal.Size = new System.Drawing.Size(57, 20);
            this.rbFinal.TabIndex = 49;
            this.rbFinal.TabStop = true;
            this.rbFinal.Text = "Final";
            this.rbFinal.UseVisualStyleBackColor = true;
            // 
            // rbCancel
            // 
            this.rbCancel.AutoSize = true;
            this.rbCancel.Location = new System.Drawing.Point(342, 76);
            this.rbCancel.Name = "rbCancel";
            this.rbCancel.Size = new System.Drawing.Size(70, 20);
            this.rbCancel.TabIndex = 48;
            this.rbCancel.TabStop = true;
            this.rbCancel.Text = "Cancel";
            this.rbCancel.UseVisualStyleBackColor = true;
            // 
            // rbInProgress
            // 
            this.rbInProgress.AutoSize = true;
            this.rbInProgress.Location = new System.Drawing.Point(342, 50);
            this.rbInProgress.Name = "rbInProgress";
            this.rbInProgress.Size = new System.Drawing.Size(95, 20);
            this.rbInProgress.TabIndex = 47;
            this.rbInProgress.TabStop = true;
            this.rbInProgress.Text = "In progress";
            this.rbInProgress.UseVisualStyleBackColor = true;
            // 
            // tABDataSet
            // 
            this.tABDataSet.DataSetName = "TABDataSet";
            this.tABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workertaskBindingSource
            // 
            this.workertaskBindingSource.DataMember = "worker_task";
            this.workertaskBindingSource.DataSource = this.tABDataSet;
            // 
            // worker_taskTableAdapter
            // 
            this.worker_taskTableAdapter.ClearBeforeFill = true;
            // 
            // workertaskBindingSource1
            // 
            this.workertaskBindingSource1.DataMember = "worker_task";
            this.workertaskBindingSource1.DataSource = this.tABDataSet;
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
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // idworkerDataGridViewTextBoxColumn
            // 
            this.idworkerDataGridViewTextBoxColumn.DataPropertyName = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.HeaderText = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idworkerDataGridViewTextBoxColumn.Name = "idworkerDataGridViewTextBoxColumn";
            this.idworkerDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "result";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtopenDataGridViewTextBoxColumn
            // 
            this.dtopenDataGridViewTextBoxColumn.DataPropertyName = "dt_open";
            this.dtopenDataGridViewTextBoxColumn.HeaderText = "dt_open";
            this.dtopenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtopenDataGridViewTextBoxColumn.Name = "dtopenDataGridViewTextBoxColumn";
            this.dtopenDataGridViewTextBoxColumn.Width = 125;
            // 
            // idissueDataGridViewTextBoxColumn
            // 
            this.idissueDataGridViewTextBoxColumn.DataPropertyName = "id_issue";
            this.idissueDataGridViewTextBoxColumn.HeaderText = "id_issue";
            this.idissueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idissueDataGridViewTextBoxColumn.Name = "idissueDataGridViewTextBoxColumn";
            this.idissueDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtfinalcancelDataGridViewTextBoxColumn
            // 
            this.dtfinalcancelDataGridViewTextBoxColumn.DataPropertyName = "dt_final_cancel";
            this.dtfinalcancelDataGridViewTextBoxColumn.HeaderText = "dt_final_cancel";
            this.dtfinalcancelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtfinalcancelDataGridViewTextBoxColumn.Name = "dtfinalcancelDataGridViewTextBoxColumn";
            this.dtfinalcancelDataGridViewTextBoxColumn.Width = 125;
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.rbFinal);
            this.Controls.Add(this.rbCancel);
            this.Controls.Add(this.rbInProgress);
            this.Controls.Add(this.bEditTask);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lTaskStatus);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbIssueID);
            this.Controls.Add(this.lTasks);
            this.Controls.Add(this.lRequestName);
            this.Controls.Add(this.bDeleteTask);
            this.Controls.Add(this.bAddNewTask);
            this.Controls.Add(this.bReturn);
            this.Name = "ProductManager";
            this.Text = "Task Management System - Issues Details";
            this.Load += new System.EventHandler(this.ProductManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertaskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertaskBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbIssueID;
        private System.Windows.Forms.Label lTasks;
        private System.Windows.Forms.Label lRequestName;
        private System.Windows.Forms.Button bDeleteTask;
        private System.Windows.Forms.Button bAddNewTask;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lTaskStatus;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEditTask;
        private System.Windows.Forms.RadioButton rbFinal;
        private System.Windows.Forms.RadioButton rbCancel;
        private System.Windows.Forms.RadioButton rbInProgress;
        private TABDataSet tABDataSet;
        private System.Windows.Forms.BindingSource workertaskBindingSource;
        private TABDataSetTableAdapters.worker_taskTableAdapter worker_taskTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkertaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtopenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtfinalcancelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource workertaskBindingSource1;
    }
}