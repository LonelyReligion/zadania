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
            this.label = new System.Windows.Forms.Label();
            this.tbRequestID = new System.Windows.Forms.TextBox();
            this.lTasks = new System.Windows.Forms.Label();
            this.lRequestName = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.lChooseWorker = new System.Windows.Forms.Label();
            this.bDeleteTask = new System.Windows.Forms.Button();
            this.bAddNewTask = new System.Windows.Forms.Button();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.bReturn = new System.Windows.Forms.Button();
            this.bSaveStatus = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(547, 229);
            this.dataGridView1.TabIndex = 37;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(227, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(130, 16);
            this.label.TabIndex = 36;
            this.label.Text = "Choose issue status:";
            // 
            // tbRequestID
            // 
            this.tbRequestID.Location = new System.Drawing.Point(29, 58);
            this.tbRequestID.Multiline = true;
            this.tbRequestID.Name = "tbRequestID";
            this.tbRequestID.ReadOnly = true;
            this.tbRequestID.Size = new System.Drawing.Size(175, 48);
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
            this.lRequestName.Location = new System.Drawing.Point(28, 34);
            this.lRequestName.Name = "lRequestName";
            this.lRequestName.Size = new System.Drawing.Size(49, 16);
            this.lRequestName.TabIndex = 33;
            this.lRequestName.Text = "Issues:";
            this.lRequestName.Click += new System.EventHandler(this.lRequest_Click);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(585, 366);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 32;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(585, 336);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(160, 24);
            this.comboBoxWorker.TabIndex = 31;
            // 
            // lChooseWorker
            // 
            this.lChooseWorker.AutoSize = true;
            this.lChooseWorker.Location = new System.Drawing.Point(582, 316);
            this.lChooseWorker.Name = "lChooseWorker";
            this.lChooseWorker.Size = new System.Drawing.Size(104, 16);
            this.lChooseWorker.TabIndex = 30;
            this.lChooseWorker.Text = "Choose Worker:";
            // 
            // bDeleteTask
            // 
            this.bDeleteTask.Location = new System.Drawing.Point(31, 397);
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
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(230, 86);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(69, 20);
            this.cbDelete.TabIndex = 27;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(230, 60);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(62, 20);
            this.cbDone.TabIndex = 26;
            this.cbDone.Text = "Done";
            this.cbDone.UseVisualStyleBackColor = true;
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(664, 22);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(109, 51);
            this.bReturn.TabIndex = 25;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // bSaveStatus
            // 
            this.bSaveStatus.Location = new System.Drawing.Point(305, 60);
            this.bSaveStatus.Name = "bSaveStatus";
            this.bSaveStatus.Size = new System.Drawing.Size(136, 46);
            this.bSaveStatus.TabIndex = 24;
            this.bSaveStatus.Text = "Save issue status";
            this.bSaveStatus.UseVisualStyleBackColor = true;
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbRequestID);
            this.Controls.Add(this.lTasks);
            this.Controls.Add(this.lRequestName);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.comboBoxWorker);
            this.Controls.Add(this.lChooseWorker);
            this.Controls.Add(this.bDeleteTask);
            this.Controls.Add(this.bAddNewTask);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.cbDone);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.bSaveStatus);
            this.Name = "ProductManager";
            this.Text = "Task Management System - Issues Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbRequestID;
        private System.Windows.Forms.Label lTasks;
        private System.Windows.Forms.Label lRequestName;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.Label lChooseWorker;
        private System.Windows.Forms.Button bDeleteTask;
        private System.Windows.Forms.Button bAddNewTask;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Button bSaveStatus;
    }
}