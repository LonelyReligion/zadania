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
            this.bDeactivate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bActivate = new System.Windows.Forms.Button();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lChangePassword = new System.Windows.Forms.Label();
            this.bChange = new System.Windows.Forms.Button();
            this.lNewPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRepeat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(679, 12);
            this.bLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(109, 50);
            this.bLogOut.TabIndex = 21;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(15, 107);
            this.tbemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(183, 22);
            this.tbemail.TabIndex = 22;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(15, 161);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(183, 22);
            this.tbPassword.TabIndex = 23;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(15, 214);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(167, 24);
            this.comboBoxType.TabIndex = 24;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(12, 253);
            this.bAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(91, 33);
            this.bAdd.TabIndex = 25;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // lAddNewUser
            // 
            this.lAddNewUser.AutoSize = true;
            this.lAddNewUser.Location = new System.Drawing.Point(12, 46);
            this.lAddNewUser.Name = "lAddNewUser";
            this.lAddNewUser.Size = new System.Drawing.Size(91, 16);
            this.lAddNewUser.TabIndex = 26;
            this.lAddNewUser.Text = "Add new user:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(12, 88);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(81, 16);
            this.lEmail.TabIndex = 27;
            this.lEmail.Text = "User\'s login:";
            this.lEmail.Click += new System.EventHandler(this.lEmail_Click);
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(12, 142);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(111, 16);
            this.lPassword.TabIndex = 28;
            this.lPassword.Text = "User\'s password:";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(12, 195);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(42, 16);
            this.lType.TabIndex = 29;
            this.lType.Text = "Type:";
            // 
            // bDeactivate
            // 
            this.bDeactivate.Location = new System.Drawing.Point(341, 388);
            this.bDeactivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDeactivate.Name = "bDeactivate";
            this.bDeactivate.Size = new System.Drawing.Size(122, 32);
            this.bDeactivate.TabIndex = 31;
            this.bDeactivate.Text = "Deactivate user";
            this.bDeactivate.UseVisualStyleBackColor = true;
            this.bDeactivate.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(376, 354);
            this.dataGridView1.TabIndex = 33;
            // 
            // bActivate
            // 
            this.bActivate.Location = new System.Drawing.Point(213, 388);
            this.bActivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bActivate.Name = "bActivate";
            this.bActivate.Size = new System.Drawing.Size(122, 32);
            this.bActivate.TabIndex = 34;
            this.bActivate.Text = "Activate user";
            this.bActivate.UseVisualStyleBackColor = true;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(609, 264);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(155, 22);
            this.tbNewPassword.TabIndex = 35;
            // 
            // lChangePassword
            // 
            this.lChangePassword.AutoSize = true;
            this.lChangePassword.Location = new System.Drawing.Point(606, 214);
            this.lChangePassword.Name = "lChangePassword";
            this.lChangePassword.Size = new System.Drawing.Size(158, 16);
            this.lChangePassword.TabIndex = 36;
            this.lChangePassword.Text = "Change user\'s password:";
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(609, 350);
            this.bChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(122, 32);
            this.bChange.TabIndex = 37;
            this.bChange.Text = "Change";
            this.bChange.UseVisualStyleBackColor = true;
            // 
            // lNewPassword
            // 
            this.lNewPassword.AutoSize = true;
            this.lNewPassword.Location = new System.Drawing.Point(606, 246);
            this.lNewPassword.Name = "lNewPassword";
            this.lNewPassword.Size = new System.Drawing.Size(99, 16);
            this.lNewPassword.TabIndex = 38;
            this.lNewPassword.Text = "New password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Repeat password:";
            // 
            // tbRepeat
            // 
            this.tbRepeat.Location = new System.Drawing.Point(609, 315);
            this.tbRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRepeat.Name = "tbRepeat";
            this.tbRepeat.Size = new System.Drawing.Size(155, 22);
            this.tbRepeat.TabIndex = 40;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbRepeat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNewPassword);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.lChangePassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.bActivate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bDeactivate);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lAddNewUser);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.bLogOut);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminView";
            this.Text = "Task Management System - Admin Console";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button bDeactivate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bActivate;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lChangePassword;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Label lNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRepeat;
    }
}