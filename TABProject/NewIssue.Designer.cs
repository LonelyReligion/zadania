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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lType = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.lAddNewIssue = new System.Windows.Forms.Label();
            this.lProdMan = new System.Windows.Forms.Label();
            this.cbProductMan = new System.Windows.Forms.ComboBox();
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
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(15, 65);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(158, 24);
            this.cbType.TabIndex = 2;
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
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(15, 120);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(341, 145);
            this.tbDesc.TabIndex = 5;
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
            // lProdMan
            // 
            this.lProdMan.AutoSize = true;
            this.lProdMan.Location = new System.Drawing.Point(185, 46);
            this.lProdMan.Name = "lProdMan";
            this.lProdMan.Size = new System.Drawing.Size(129, 16);
            this.lProdMan.TabIndex = 8;
            this.lProdMan.Text = "Product Manager ID:";
            // 
            // cbProductMan
            // 
            this.cbProductMan.FormattingEnabled = true;
            this.cbProductMan.Location = new System.Drawing.Point(188, 65);
            this.cbProductMan.Name = "cbProductMan";
            this.cbProductMan.Size = new System.Drawing.Size(158, 24);
            this.cbProductMan.TabIndex = 7;
            // 
            // NewIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 314);
            this.Controls.Add(this.lProdMan);
            this.Controls.Add(this.cbProductMan);
            this.Controls.Add(this.lAddNewIssue);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.bAdd);
            this.Name = "NewIssue";
            this.Text = "Task Management System - Adding new issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label lAddNewIssue;
        private System.Windows.Forms.Label lProdMan;
        private System.Windows.Forms.ComboBox cbProductMan;
    }
}