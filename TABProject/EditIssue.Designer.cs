namespace TABProject
{
    partial class EditIssue
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
            this.bSave = new System.Windows.Forms.Button();
            this.comboBoxPM = new System.Windows.Forms.ComboBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.lEditIssue = new System.Windows.Forms.Label();
            this.bReturn = new System.Windows.Forms.Button();
            this.tbRequestID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lType = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(468, 280);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(103, 38);
            this.bSave.TabIndex = 16;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // comboBoxPM
            // 
            this.comboBoxPM.FormattingEnabled = true;
            this.comboBoxPM.Items.AddRange(new object[] {
            "Open",
            "In Prog",
            "Closed",
            "Cancelled"});
            this.comboBoxPM.Location = new System.Drawing.Point(15, 215);
            this.comboBoxPM.Name = "comboBoxPM";
            this.comboBoxPM.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPM.TabIndex = 15;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(12, 195);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(95, 16);
            this.lStatus.TabIndex = 14;
            this.lStatus.Text = "Choose status:";
            // 
            // lEditIssue
            // 
            this.lEditIssue.AutoSize = true;
            this.lEditIssue.Location = new System.Drawing.Point(12, 24);
            this.lEditIssue.Name = "lEditIssue";
            this.lEditIssue.Size = new System.Drawing.Size(68, 16);
            this.lEditIssue.TabIndex = 17;
            this.lEditIssue.Text = "Edit issue:";
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(496, 12);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(84, 37);
            this.bReturn.TabIndex = 18;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // tbRequestID
            // 
            this.tbRequestID.Location = new System.Drawing.Point(15, 43);
            this.tbRequestID.Multiline = true;
            this.tbRequestID.Name = "tbRequestID";
            this.tbRequestID.ReadOnly = true;
            this.tbRequestID.Size = new System.Drawing.Size(464, 79);
            this.tbRequestID.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Bug",
            "Feature",
            "Improve"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(12, 141);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(86, 16);
            this.lType.TabIndex = 23;
            this.lType.Text = "Choose type:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 271);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Choose Product Manager:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 76);
            this.textBox1.TabIndex = 27;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(211, 141);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(126, 16);
            this.lDescription.TabIndex = 28;
            this.lDescription.Text = "Change description:";
            // 
            // EditIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 330);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.tbRequestID);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.lEditIssue);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.comboBoxPM);
            this.Controls.Add(this.lStatus);
            this.Name = "EditIssue";
            this.Text = "Task Management System - Editing Issue";
            this.Load += new System.EventHandler(this.EditIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ComboBox comboBoxPM;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lEditIssue;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.TextBox tbRequestID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lDescription;
    }
}