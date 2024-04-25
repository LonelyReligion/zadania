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
            this.bLogOut.Location = new System.Drawing.Point(679, 12);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(109, 51);
            this.bLogOut.TabIndex = 21;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(58, 117);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(183, 22);
            this.tbemail.TabIndex = 22;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(58, 171);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(183, 22);
            this.tbPassword.TabIndex = 23;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(55, 233);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(166, 24);
            this.comboBoxType.TabIndex = 24;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(55, 273);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(91, 33);
            this.bAdd.TabIndex = 25;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // lAddNewUser
            // 
            this.lAddNewUser.AutoSize = true;
            this.lAddNewUser.Location = new System.Drawing.Point(55, 56);
            this.lAddNewUser.Name = "lAddNewUser";
            this.lAddNewUser.Size = new System.Drawing.Size(91, 16);
            this.lAddNewUser.TabIndex = 26;
            this.lAddNewUser.Text = "Add new user:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(55, 98);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(85, 16);
            this.lEmail.TabIndex = 27;
            this.lEmail.Text = "User\'s email:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(55, 152);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(111, 16);
            this.lPassword.TabIndex = 28;
            this.lPassword.Text = "User\'s password:";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(55, 205);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(42, 16);
            this.lType.TabIndex = 29;
            this.lType.Text = "Type:";
            // 
            // checkedListBoxUsers
            // 
            this.checkedListBoxUsers.FormattingEnabled = true;
            this.checkedListBoxUsers.Location = new System.Drawing.Point(343, 88);
            this.checkedListBoxUsers.Name = "checkedListBoxUsers";
            this.checkedListBoxUsers.Size = new System.Drawing.Size(170, 259);
            this.checkedListBoxUsers.TabIndex = 30;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(343, 353);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(101, 32);
            this.bDelete.TabIndex = 31;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // lDelete
            // 
            this.lDelete.AutoSize = true;
            this.lDelete.Location = new System.Drawing.Point(340, 56);
            this.lDelete.Name = "lDelete";
            this.lDelete.Size = new System.Drawing.Size(86, 16);
            this.lDelete.TabIndex = 32;
            this.lDelete.Text = "Delete users:";
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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