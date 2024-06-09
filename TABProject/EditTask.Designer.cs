namespace TABProject
{
    partial class EditTask
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
            this.lDescription = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.lChooseWorker = new System.Windows.Forms.Label();
            this.tbTaskID = new System.Windows.Forms.TextBox();
            this.bReturn = new System.Windows.Forms.Button();
            this.lEditTask = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(221, 141);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(126, 16);
            this.lDescription.TabIndex = 40;
            this.lDescription.Text = "Change description:";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(224, 163);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(357, 76);
            this.tbDesc.TabIndex = 39;
            // 
            // cbWorker
            // 
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(25, 217);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(160, 24);
            this.cbWorker.TabIndex = 38;
            // 
            // lChooseWorker
            // 
            this.lChooseWorker.AutoSize = true;
            this.lChooseWorker.Location = new System.Drawing.Point(22, 197);
            this.lChooseWorker.Name = "lChooseWorker";
            this.lChooseWorker.Size = new System.Drawing.Size(104, 16);
            this.lChooseWorker.TabIndex = 37;
            this.lChooseWorker.Text = "Choose Worker:";
            // 
            // tbTaskID
            // 
            this.tbTaskID.Location = new System.Drawing.Point(25, 43);
            this.tbTaskID.Multiline = true;
            this.tbTaskID.Name = "tbTaskID";
            this.tbTaskID.ReadOnly = true;
            this.tbTaskID.Size = new System.Drawing.Size(464, 79);
            this.tbTaskID.TabIndex = 34;
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(506, 12);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(84, 37);
            this.bReturn.TabIndex = 33;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // lEditTask
            // 
            this.lEditTask.AutoSize = true;
            this.lEditTask.Location = new System.Drawing.Point(22, 24);
            this.lEditTask.Name = "lEditTask";
            this.lEditTask.Size = new System.Drawing.Size(61, 16);
            this.lEditTask.TabIndex = 32;
            this.lEditTask.Text = "Edit task:";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(478, 245);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(103, 38);
            this.bSave.TabIndex = 31;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(25, 161);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(160, 24);
            this.cbStatus.TabIndex = 30;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(22, 141);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(95, 16);
            this.lStatus.TabIndex = 29;
            this.lStatus.Text = "Choose status:";
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 297);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.cbWorker);
            this.Controls.Add(this.lChooseWorker);
            this.Controls.Add(this.tbTaskID);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.lEditTask);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lStatus);
            this.Name = "EditTask";
            this.Text = "Task Management System - Editing Task";
            this.Load += new System.EventHandler(this.EditTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.Label lChooseWorker;
        private System.Windows.Forms.TextBox tbTaskID;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Label lEditTask;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lStatus;
    }
}