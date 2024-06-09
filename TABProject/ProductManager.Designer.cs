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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
    }
}