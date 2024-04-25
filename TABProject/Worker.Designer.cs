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
            this.bLogOut = new System.Windows.Forms.Button();
            this.comboBoxTasks = new System.Windows.Forms.ComboBox();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.bSaveStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(672, 12);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(116, 53);
            this.bLogOut.TabIndex = 20;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // comboBoxTasks
            // 
            this.comboBoxTasks.FormattingEnabled = true;
            this.comboBoxTasks.Location = new System.Drawing.Point(36, 41);
            this.comboBoxTasks.Name = "comboBoxTasks";
            this.comboBoxTasks.Size = new System.Drawing.Size(260, 24);
            this.comboBoxTasks.TabIndex = 29;
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(319, 45);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(62, 20);
            this.cbDone.TabIndex = 27;
            this.cbDone.Text = "Done";
            this.cbDone.UseVisualStyleBackColor = true;
            // 
            // bSaveStatus
            // 
            this.bSaveStatus.Location = new System.Drawing.Point(319, 71);
            this.bSaveStatus.Name = "bSaveStatus";
            this.bSaveStatus.Size = new System.Drawing.Size(106, 46);
            this.bSaveStatus.TabIndex = 26;
            this.bSaveStatus.Text = "Save status";
            this.bSaveStatus.UseVisualStyleBackColor = true;
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxTasks);
            this.Controls.Add(this.cbDone);
            this.Controls.Add(this.bSaveStatus);
            this.Controls.Add(this.bLogOut);
            this.Name = "Worker";
            this.Text = "Task Management System - Worker Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.ComboBox comboBoxTasks;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.Button bSaveStatus;
    }
}