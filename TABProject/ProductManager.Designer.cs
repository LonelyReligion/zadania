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
            this.tbRequestID = new System.Windows.Forms.TextBox();
            this.lTasks = new System.Windows.Forms.Label();
            this.lRequestName = new System.Windows.Forms.Label();
            this.bDeleteTask = new System.Windows.Forms.Button();
            this.bAddNewTask = new System.Windows.Forms.Button();
            this.bReturn = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.cbInProgress = new System.Windows.Forms.CheckBox();
            this.cbFinal = new System.Windows.Forms.CheckBox();
            this.lTaskStatus = new System.Windows.Forms.Label();
            this.cbCancel = new System.Windows.Forms.CheckBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bEditTask = new System.Windows.Forms.Button();
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
            // tbRequestID
            // 
            this.tbRequestID.Location = new System.Drawing.Point(29, 48);
            this.tbRequestID.Multiline = true;
            this.tbRequestID.Name = "tbRequestID";
            this.tbRequestID.ReadOnly = true;
            this.tbRequestID.Size = new System.Drawing.Size(279, 71);
            this.tbRequestID.TabIndex = 35;
            // 
            // lTasks
            // 
            this.lTasks.AutoSize = true;
            this.lTasks.Location = new System.Drawing.Point(28, 139);
            this.lTasks.Name = "lTasks";
            this.lTasks.Size = new System.Drawing.Size(137, 16);
            this.lTasks.TabIndex = 34;
            this.lTasks.Text = "Tasks for this request:";
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
            // cbInProgress
            // 
            this.cbInProgress.AutoSize = true;
            this.cbInProgress.Location = new System.Drawing.Point(342, 50);
            this.cbInProgress.Name = "cbInProgress";
            this.cbInProgress.Size = new System.Drawing.Size(96, 20);
            this.cbInProgress.TabIndex = 43;
            this.cbInProgress.Text = "In progress";
            this.cbInProgress.UseVisualStyleBackColor = true;
            // 
            // cbFinal
            // 
            this.cbFinal.AutoSize = true;
            this.cbFinal.Location = new System.Drawing.Point(342, 102);
            this.cbFinal.Name = "cbFinal";
            this.cbFinal.Size = new System.Drawing.Size(58, 20);
            this.cbFinal.TabIndex = 42;
            this.cbFinal.Text = "Final";
            this.cbFinal.UseVisualStyleBackColor = true;
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
            // cbCancel
            // 
            this.cbCancel.AutoSize = true;
            this.cbCancel.Location = new System.Drawing.Point(342, 76);
            this.cbCancel.Name = "cbCancel";
            this.cbCancel.Size = new System.Drawing.Size(71, 20);
            this.cbCancel.TabIndex = 40;
            this.cbCancel.Text = "Cancel";
            this.cbCancel.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(749, 76);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(110, 56);
            this.bSave.TabIndex = 38;
            this.bSave.Text = "Save request";
            this.bSave.UseVisualStyleBackColor = true;
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
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.bEditTask);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.cbInProgress);
            this.Controls.Add(this.cbFinal);
            this.Controls.Add(this.lTaskStatus);
            this.Controls.Add(this.cbCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbRequestID);
            this.Controls.Add(this.lTasks);
            this.Controls.Add(this.lRequestName);
            this.Controls.Add(this.bDeleteTask);
            this.Controls.Add(this.bAddNewTask);
            this.Controls.Add(this.bReturn);
            this.Name = "ProductManager";
            this.Text = "Task Management System - Issues Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbRequestID;
        private System.Windows.Forms.Label lTasks;
        private System.Windows.Forms.Label lRequestName;
        private System.Windows.Forms.Button bDeleteTask;
        private System.Windows.Forms.Button bAddNewTask;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.CheckBox cbInProgress;
        private System.Windows.Forms.CheckBox cbFinal;
        private System.Windows.Forms.Label lTaskStatus;
        private System.Windows.Forms.CheckBox cbCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEditTask;
    }
}