namespace TABProject
{
    partial class NewIssue
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
            this.bAdd = new System.Windows.Forms.Button();
            this.bReturn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lType = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lAddNewIssue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(15, 271);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(105, 30);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(365, 12);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(95, 31);
            this.bReturn.TabIndex = 1;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(12, 46);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(42, 16);
            this.lType.TabIndex = 3;
            this.lType.Text = "Type:";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(12, 101);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(78, 16);
            this.lDescription.TabIndex = 4;
            this.lDescription.Text = "Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 145);
            this.textBox1.TabIndex = 5;
            // 
            // lAddNewIssue
            // 
            this.lAddNewIssue.AutoSize = true;
            this.lAddNewIssue.Location = new System.Drawing.Point(12, 20);
            this.lAddNewIssue.Name = "lAddNewIssue";
            this.lAddNewIssue.Size = new System.Drawing.Size(97, 16);
            this.lAddNewIssue.TabIndex = 6;
            this.lAddNewIssue.Text = "Add new issue:";
            // 
            // NewIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 314);
            this.Controls.Add(this.lAddNewIssue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.bAdd);
            this.Name = "NewIssue";
            this.Text = "Task Management System - Adding new issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lAddNewIssue;
    }
}