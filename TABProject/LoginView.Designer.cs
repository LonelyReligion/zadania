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
            this.bLogin = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lLoginResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(384, 314);
            this.bLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(98, 42);
            this.bLogin.TabIndex = 0;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(328, 186);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(214, 26);
            this.tbEmail.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(328, 266);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(214, 26);
            this.tbPassword.TabIndex = 2;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(325, 149);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(52, 20);
            this.lEmail.TabIndex = 3;
            this.lEmail.Text = "Email:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(325, 230);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(82, 20);
            this.lPassword.TabIndex = 4;
            this.lPassword.Text = "Password:";
            // 
            // lLoginResults
            // 
            this.lLoginResults.AutoSize = true;
            this.lLoginResults.ForeColor = System.Drawing.Color.Firebrick;
            this.lLoginResults.Location = new System.Drawing.Point(272, 368);
            this.lLoginResults.Name = "lLoginResults";
            this.lLoginResults.Size = new System.Drawing.Size(0, 20);
            this.lLoginResults.TabIndex = 5;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.lLoginResults);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.bLogin);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginView";
            this.Text = "Task Management System - Sign in";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginView_KeyUp);
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
    }
}

