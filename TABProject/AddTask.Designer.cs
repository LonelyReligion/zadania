namespace TABProject
{
    partial class AddTask
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
            this.lAddNewTask = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.lWorkerID = new System.Windows.Forms.Label();
            this.cbWorkerID = new System.Windows.Forms.ComboBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lAddNewTask
            // 
            this.lAddNewTask.AutoSize = true;
            this.lAddNewTask.Location = new System.Drawing.Point(12, 21);
            this.lAddNewTask.Name = "lAddNewTask";
            this.lAddNewTask.Size = new System.Drawing.Size(90, 16);
            this.lAddNewTask.TabIndex = 13;
            this.lAddNewTask.Text = "Add new task:";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(15, 121);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(341, 145);
            this.tbDesc.TabIndex = 12;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(12, 102);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(78, 16);
            this.lDescription.TabIndex = 11;
            this.lDescription.Text = "Description:";
            // 
            // lWorkerID
            // 
            this.lWorkerID.AutoSize = true;
            this.lWorkerID.Location = new System.Drawing.Point(12, 47);
            this.lWorkerID.Name = "lWorkerID";
            this.lWorkerID.Size = new System.Drawing.Size(70, 16);
            this.lWorkerID.TabIndex = 10;
            this.lWorkerID.Text = "Worker ID:";
            // 
            // cbWorkerID
            // 
            this.cbWorkerID.FormattingEnabled = true;
            this.cbWorkerID.Location = new System.Drawing.Point(15, 66);
            this.cbWorkerID.Name = "cbWorkerID";
            this.cbWorkerID.Size = new System.Drawing.Size(158, 24);
            this.cbWorkerID.TabIndex = 9;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(15, 272);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(105, 30);
            this.bAdd.TabIndex = 7;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 308);
            this.Controls.Add(this.lAddNewTask);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lWorkerID);
            this.Controls.Add(this.cbWorkerID);
            this.Controls.Add(this.bAdd);
            this.Name = "AddTask";
            this.Text = "Task Management System - Adding new task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAddNewTask;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lWorkerID;
        private System.Windows.Forms.ComboBox cbWorkerID;
        private System.Windows.Forms.Button bAdd;
    }
}