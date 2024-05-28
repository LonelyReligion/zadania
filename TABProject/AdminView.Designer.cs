namespace TABProject
{
    partial class AdminView
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
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.lAddNewUser = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.checkedListBoxUsers = new System.Windows.Forms.CheckedListBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.lDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(509, 10);
            this.bLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(82, 41);
            this.bLogOut.TabIndex = 21;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(38, 88);
            this.tbemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(138, 20);
            this.tbemail.TabIndex = 22;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(38, 132);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(138, 20);
            this.tbPassword.TabIndex = 23;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(36, 182);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(126, 21);
            this.comboBoxType.TabIndex = 24;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(36, 214);
            this.bAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(68, 27);
            this.bAdd.TabIndex = 25;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // lAddNewUser
            // 
            this.lAddNewUser.AutoSize = true;
            this.lAddNewUser.Location = new System.Drawing.Point(36, 38);
            this.lAddNewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAddNewUser.Name = "lAddNewUser";
            this.lAddNewUser.Size = new System.Drawing.Size(75, 13);
            this.lAddNewUser.TabIndex = 26;
            this.lAddNewUser.Text = "Add new user:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(36, 72);
            this.lEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(64, 13);
            this.lEmail.TabIndex = 27;
            this.lEmail.Text = "User\'s login:";
            this.lEmail.Click += new System.EventHandler(this.lEmail_Click);
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(36, 116);
            this.lPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(87, 13);
            this.lPassword.TabIndex = 28;
            this.lPassword.Text = "User\'s password:";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(36, 159);
            this.lType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(34, 13);
            this.lType.TabIndex = 29;
            this.lType.Text = "Type:";
            // 
            // checkedListBoxUsers
            // 
            this.checkedListBoxUsers.FormattingEnabled = true;
            this.checkedListBoxUsers.Location = new System.Drawing.Point(262, 38);
            this.checkedListBoxUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBoxUsers.Name = "checkedListBoxUsers";
            this.checkedListBoxUsers.Size = new System.Drawing.Size(188, 274);
            this.checkedListBoxUsers.TabIndex = 30;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(455, 284);
            this.bDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(76, 26);
            this.bDelete.TabIndex = 31;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // lDelete
            // 
            this.lDelete.AutoSize = true;
            this.lDelete.Location = new System.Drawing.Point(454, 263);
            this.lDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDelete.Name = "lDelete";
            this.lDelete.Size = new System.Drawing.Size(69, 13);
            this.lDelete.TabIndex = 32;
            this.lDelete.Text = "Delete users:";
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lDelete);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.checkedListBoxUsers);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lAddNewUser);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.bLogOut);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminView";
            this.Text = "Task Management System - Admin Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lAddNewUser;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.CheckedListBox checkedListBoxUsers;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label lDelete;
    }
}