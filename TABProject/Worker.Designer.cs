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
            this.bLogOut.Location = new System.Drawing.Point(484, 18);
            this.bLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(119, 59);
            this.bLogOut.TabIndex = 20;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // comboBoxTasks
            // 
            this.comboBoxTasks.FormattingEnabled = true;
            this.comboBoxTasks.Location = new System.Drawing.Point(40, 34);
            this.comboBoxTasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTasks.Name = "comboBoxTasks";
            this.comboBoxTasks.Size = new System.Drawing.Size(292, 28);
            this.comboBoxTasks.TabIndex = 29;
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(40, 144);
            this.cbDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(74, 24);
            this.cbDone.TabIndex = 27;
            this.cbDone.Text = "Done";
            this.cbDone.UseVisualStyleBackColor = true;
            // 
            // bSaveStatus
            // 
            this.bSaveStatus.Location = new System.Drawing.Point(484, 110);
            this.bSaveStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bSaveStatus.Name = "bSaveStatus";
            this.bSaveStatus.Size = new System.Drawing.Size(119, 58);
            this.bSaveStatus.TabIndex = 26;
            this.bSaveStatus.Text = "Save status";
            this.bSaveStatus.UseVisualStyleBackColor = true;
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 190);
            this.Controls.Add(this.comboBoxTasks);
            this.Controls.Add(this.cbDone);
            this.Controls.Add(this.bSaveStatus);
            this.Controls.Add(this.bLogOut);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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