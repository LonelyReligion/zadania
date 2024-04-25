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
            this.lResult = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.lTaskProperities = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.comboBoxWorkers = new System.Windows.Forms.ComboBox();
            this.lChooseWorker = new System.Windows.Forms.Label();
            this.comboBoxIssues = new System.Windows.Forms.ComboBox();
            this.bDeleteTask = new System.Windows.Forms.Button();
            this.bAddNewTask = new System.Windows.Forms.Button();
            this.checkedListBoxTasks = new System.Windows.Forms.CheckedListBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.bLogOut = new System.Windows.Forms.Button();
            this.bSaveStatus = new System.Windows.Forms.Button();
            this.lIssue = new System.Windows.Forms.Label();
            this.lTasks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(331, 237);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(51, 16);
            this.lResult.TabIndex = 32;
            this.lResult.Text = "Result: ";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(331, 208);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(47, 16);
            this.lStatus.TabIndex = 31;
            this.lStatus.Text = "Status:";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(331, 181);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(81, 16);
            this.lDescription.TabIndex = 30;
            this.lDescription.Text = "Description: ";
            // 
            // lTaskProperities
            // 
            this.lTaskProperities.AutoSize = true;
            this.lTaskProperities.Location = new System.Drawing.Point(331, 143);
            this.lTaskProperities.Name = "lTaskProperities";
            this.lTaskProperities.Size = new System.Drawing.Size(109, 16);
            this.lTaskProperities.TabIndex = 29;
            this.lTaskProperities.Text = "Task Properities:";
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(545, 314);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(83, 24);
            this.bOK.TabIndex = 28;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // comboBoxWorkers
            // 
            this.comboBoxWorkers.FormattingEnabled = true;
            this.comboBoxWorkers.Location = new System.Drawing.Point(331, 315);
            this.comboBoxWorkers.Name = "comboBoxWorkers";
            this.comboBoxWorkers.Size = new System.Drawing.Size(208, 24);
            this.comboBoxWorkers.TabIndex = 27;
            // 
            // lChooseWorker
            // 
            this.lChooseWorker.AutoSize = true;
            this.lChooseWorker.Location = new System.Drawing.Point(328, 296);
            this.lChooseWorker.Name = "lChooseWorker";
            this.lChooseWorker.Size = new System.Drawing.Size(104, 16);
            this.lChooseWorker.TabIndex = 26;
            this.lChooseWorker.Text = "Choose Worker:";
            // 
            // comboBoxIssues
            // 
            this.comboBoxIssues.FormattingEnabled = true;
            this.comboBoxIssues.Location = new System.Drawing.Point(31, 54);
            this.comboBoxIssues.Name = "comboBoxIssues";
            this.comboBoxIssues.Size = new System.Drawing.Size(253, 24);
            this.comboBoxIssues.TabIndex = 25;
            // 
            // bDeleteTask
            // 
            this.bDeleteTask.Location = new System.Drawing.Point(31, 391);
            this.bDeleteTask.Name = "bDeleteTask";
            this.bDeleteTask.Size = new System.Drawing.Size(137, 32);
            this.bDeleteTask.TabIndex = 24;
            this.bDeleteTask.Text = "Delete task";
            this.bDeleteTask.UseVisualStyleBackColor = true;
            // 
            // bAddNewTask
            // 
            this.bAddNewTask.Location = new System.Drawing.Point(31, 354);
            this.bAddNewTask.Name = "bAddNewTask";
            this.bAddNewTask.Size = new System.Drawing.Size(137, 31);
            this.bAddNewTask.TabIndex = 23;
            this.bAddNewTask.Text = "Add new task";
            this.bAddNewTask.UseVisualStyleBackColor = true;
            this.bAddNewTask.Click += new System.EventHandler(this.bAddNewTask_Click);
            // 
            // checkedListBoxTasks
            // 
            this.checkedListBoxTasks.FormattingEnabled = true;
            this.checkedListBoxTasks.Location = new System.Drawing.Point(31, 114);
            this.checkedListBoxTasks.Name = "checkedListBoxTasks";
            this.checkedListBoxTasks.Size = new System.Drawing.Size(221, 225);
            this.checkedListBoxTasks.TabIndex = 22;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(331, 68);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(69, 20);
            this.cbDelete.TabIndex = 21;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(331, 42);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(62, 20);
            this.cbDone.TabIndex = 20;
            this.cbDone.Text = "Done";
            this.cbDone.UseVisualStyleBackColor = true;
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(678, 12);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(110, 50);
            this.bLogOut.TabIndex = 19;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // bSaveStatus
            // 
            this.bSaveStatus.Location = new System.Drawing.Point(406, 42);
            this.bSaveStatus.Name = "bSaveStatus";
            this.bSaveStatus.Size = new System.Drawing.Size(106, 46);
            this.bSaveStatus.TabIndex = 18;
            this.bSaveStatus.Text = "Save status";
            this.bSaveStatus.UseVisualStyleBackColor = true;
            // 
            // lIssue
            // 
            this.lIssue.AutoSize = true;
            this.lIssue.Location = new System.Drawing.Point(28, 35);
            this.lIssue.Name = "lIssue";
            this.lIssue.Size = new System.Drawing.Size(42, 16);
            this.lIssue.TabIndex = 33;
            this.lIssue.Text = "Issue:";
            // 
            // lTasks
            // 
            this.lTasks.AutoSize = true;
            this.lTasks.Location = new System.Drawing.Point(28, 95);
            this.lTasks.Name = "lTasks";
            this.lTasks.Size = new System.Drawing.Size(48, 16);
            this.lTasks.TabIndex = 34;
            this.lTasks.Text = "Tasks:";
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lTasks);
            this.Controls.Add(this.lIssue);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lTaskProperities);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.comboBoxWorkers);
            this.Controls.Add(this.lChooseWorker);
            this.Controls.Add(this.comboBoxIssues);
            this.Controls.Add(this.bDeleteTask);
            this.Controls.Add(this.bAddNewTask);
            this.Controls.Add(this.checkedListBoxTasks);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.cbDone);
            this.Controls.Add(this.bLogOut);
            this.Controls.Add(this.bSaveStatus);
            this.Name = "ProductManager";
            this.Text = "Task Management System - Product Manager Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lTaskProperities;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.ComboBox comboBoxWorkers;
        private System.Windows.Forms.Label lChooseWorker;
        private System.Windows.Forms.ComboBox comboBoxIssues;
        private System.Windows.Forms.Button bDeleteTask;
        private System.Windows.Forms.Button bAddNewTask;
        private System.Windows.Forms.CheckedListBox checkedListBoxTasks;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Button bSaveStatus;
        private System.Windows.Forms.Label lIssue;
        private System.Windows.Forms.Label lTasks;
    }
}