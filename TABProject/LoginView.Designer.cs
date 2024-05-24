namespace TABProject
{
    partial class LoginView
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
            this.bLogin = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.appuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tABDataSet = new TABProject.TABDataSet();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lLoginResults = new System.Windows.Forms.Label();
            this.app_userTableAdapter = new TABProject.TABDataSetTableAdapters.app_userTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(341, 251);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(87, 34);
            this.bLogin.TabIndex = 0;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(292, 149);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(191, 22);
            this.tbEmail.TabIndex = 1;
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
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(292, 213);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(191, 22);
            this.tbPassword.TabIndex = 2;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(289, 119);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(44, 16);
            this.lEmail.TabIndex = 3;
            this.lEmail.Text = "Email:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(289, 184);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(70, 16);
            this.lPassword.TabIndex = 4;
            this.lPassword.Text = "Password:";
            // 
            // lLoginResults
            // 
            this.lLoginResults.AutoSize = true;
            this.lLoginResults.ForeColor = System.Drawing.Color.Firebrick;
            this.lLoginResults.Location = new System.Drawing.Point(438, 261);
            this.lLoginResults.Name = "lLoginResults";
            this.lLoginResults.Size = new System.Drawing.Size(0, 16);
            this.lLoginResults.TabIndex = 5;
            // 
            // app_userTableAdapter
            // 
            this.app_userTableAdapter.ClearBeforeFill = true;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lLoginResults);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.bLogin);
            this.KeyPreview = true;
            this.Name = "LoginView";
            this.Text = "Task Management System - Sign in";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginView_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.appuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lLoginResults;
        private TABDataSet tABDataSet;
        private System.Windows.Forms.BindingSource appuserBindingSource;
        private TABDataSetTableAdapters.app_userTableAdapter app_userTableAdapter;
    }
}

