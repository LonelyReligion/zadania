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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bReturn = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 121);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 145);
            this.textBox1.TabIndex = 12;
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
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(12, 47);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(42, 16);
            this.lType.TabIndex = 10;
            this.lType.Text = "Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(376, 6);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(95, 31);
            this.bReturn.TabIndex = 8;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(15, 272);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(105, 30);
            this.bAdd.TabIndex = 7;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 308);
            this.Controls.Add(this.lAddNewTask);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.bAdd);
            this.Name = "AddTask";
            this.Text = "Task Management System - Adding new task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAddNewTask;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Button bAdd;
    }
}