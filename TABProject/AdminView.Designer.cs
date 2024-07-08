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
            this.components = new System.ComponentModel.Container();
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
            this.dataSet1 = new TABProject.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appuserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.app_userTableAdapter1 = new TABProject.DataSet1TableAdapters.app_userTableAdapter();
            this.idappuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.appuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tABDataSet = new TABProject.TABDataSet();
            this.app_userTableAdapter = new TABProject.TABDataSetTableAdapters.app_userTableAdapter();
            this.workertaskTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appuserBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appuserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertaskTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appuserBindingSource2)).BeginInit();
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
            this.tbemail.Location = new System.Drawing.Point(11, 87);
            this.tbemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(138, 20);
            this.tbemail.TabIndex = 22;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(11, 131);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(138, 20);
            this.tbPassword.TabIndex = 23;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(11, 174);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(126, 21);
            this.comboBoxType.TabIndex = 24;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(9, 206);
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
            this.lAddNewUser.Location = new System.Drawing.Point(9, 37);
            this.lAddNewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAddNewUser.Name = "lAddNewUser";
            this.lAddNewUser.Size = new System.Drawing.Size(75, 13);
            this.lAddNewUser.TabIndex = 26;
            this.lAddNewUser.Text = "Add new user:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(9, 72);
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
            this.lPassword.Location = new System.Drawing.Point(9, 115);
            this.lPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(87, 13);
            this.lPassword.TabIndex = 28;
            this.lPassword.Text = "User\'s password:";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(9, 158);
            this.lType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(34, 13);
            this.lType.TabIndex = 29;
            this.lType.Text = "Type:";
            // 
            // bDeactivate
            // 
            this.bDeactivate.Location = new System.Drawing.Point(256, 315);
            this.bDeactivate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bDeactivate.Name = "bDeactivate";
            this.bDeactivate.Size = new System.Drawing.Size(92, 26);
            this.bDeactivate.TabIndex = 31;
            this.bDeactivate.Text = "Deactivate user";
            this.bDeactivate.UseVisualStyleBackColor = true;
            this.bDeactivate.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idappuserDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.appuserBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(160, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(282, 288);
            this.dataGridView1.TabIndex = 33;
            // 
            // bActivate
            // 
            this.bActivate.Location = new System.Drawing.Point(160, 315);
            this.bActivate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bActivate.Name = "bActivate";
            this.bActivate.Size = new System.Drawing.Size(92, 26);
            this.bActivate.TabIndex = 34;
            this.bActivate.Text = "Activate user";
            this.bActivate.UseVisualStyleBackColor = true;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(457, 214);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(117, 20);
            this.tbNewPassword.TabIndex = 35;
            // 
            // lChangePassword
            // 
            this.lChangePassword.AutoSize = true;
            this.lChangePassword.Location = new System.Drawing.Point(454, 174);
            this.lChangePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lChangePassword.Name = "lChangePassword";
            this.lChangePassword.Size = new System.Drawing.Size(125, 13);
            this.lChangePassword.TabIndex = 36;
            this.lChangePassword.Text = "Change user\'s password:";
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(457, 284);
            this.bChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(92, 26);
            this.bChange.TabIndex = 37;
            this.bChange.Text = "Change";
            this.bChange.UseVisualStyleBackColor = true;
            // 
            // lNewPassword
            // 
            this.lNewPassword.AutoSize = true;
            this.lNewPassword.Location = new System.Drawing.Point(454, 200);
            this.lNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNewPassword.Name = "lNewPassword";
            this.lNewPassword.Size = new System.Drawing.Size(80, 13);
            this.lNewPassword.TabIndex = 38;
            this.lNewPassword.Text = "New password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Repeat password:";
            // 
            // tbRepeat
            // 
            this.tbRepeat.Location = new System.Drawing.Point(457, 256);
            this.tbRepeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRepeat.Name = "tbRepeat";
            this.tbRepeat.Size = new System.Drawing.Size(117, 20);
            this.tbRepeat.TabIndex = 40;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // appuserBindingSource1
            // 
            this.appuserBindingSource1.DataMember = "app_user";
            this.appuserBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // app_userTableAdapter1
            // 
            this.app_userTableAdapter1.ClearBeforeFill = true;
            // 
            // idappuserDataGridViewTextBoxColumn
            // 
            this.idappuserDataGridViewTextBoxColumn.DataPropertyName = "id_app_user";
            this.idappuserDataGridViewTextBoxColumn.HeaderText = "id_app_user";
            this.idappuserDataGridViewTextBoxColumn.Name = "idappuserDataGridViewTextBoxColumn";
            this.idappuserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            // 
            // appuserBindingSource
            // 
            this.appuserBindingSource.DataMember = "app_user";
            this.appuserBindingSource.DataSource = this.tABDataSet;
            // 
            // tABDataSet
            // 
            this.tABDataSet.DataSetName = "TABDataSet";
            this.tABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // app_userTableAdapter
            // 
            this.app_userTableAdapter.ClearBeforeFill = true;
            // 
            // workertaskTableAdapterBindingSource
            // 
            this.workertaskTableAdapterBindingSource.DataSource = typeof(TABProject.TABDataSetTableAdapters.worker_taskTableAdapter);
            // 
            // appuserBindingSource2
            // 
            this.appuserBindingSource2.DataMember = "app_user";
            this.appuserBindingSource2.DataSource = this.dataSet1BindingSource;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminView";
            this.Text = "Task Management System - Admin Console";
            this.Load += new System.EventHandler(this.AdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appuserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertaskTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appuserBindingSource2)).EndInit();
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
        private TABDataSet tABDataSet;
        private System.Windows.Forms.BindingSource appuserBindingSource;
        private TABDataSetTableAdapters.app_userTableAdapter app_userTableAdapter;
        private System.Windows.Forms.BindingSource workertaskTableAdapterBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource appuserBindingSource1;
        private DataSet1TableAdapters.app_userTableAdapter app_userTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idappuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource appuserBindingSource2;
    }
}