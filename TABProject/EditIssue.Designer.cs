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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.lEditIssue = new System.Windows.Forms.Label();
            this.bReturn = new System.Windows.Forms.Button();
            this.tbIssueID = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lType = new System.Windows.Forms.Label();
            this.cbProdM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
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
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(15, 215);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(160, 24);
            this.cbStatus.TabIndex = 15;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxPM_SelectedIndexChanged);
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
            // tbIssueID
            // 
            this.tbIssueID.Location = new System.Drawing.Point(15, 43);
            this.tbIssueID.Multiline = true;
            this.tbIssueID.Name = "tbIssueID";
            this.tbIssueID.ReadOnly = true;
            this.tbIssueID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbIssueID.Size = new System.Drawing.Size(464, 79);
            this.tbIssueID.TabIndex = 22;
            // 
            // cbType
            // 
            this.cbType.AutoCompleteCustomSource.AddRange(new string[] {
            "Bug",
            "Feature",
            "Improve"});
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(15, 161);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(160, 24);
            this.cbType.TabIndex = 24;
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
            // cbProdM
            // 
            this.cbProdM.FormattingEnabled = true;
            this.cbProdM.Location = new System.Drawing.Point(15, 271);
            this.cbProdM.Name = "cbProdM";
            this.cbProdM.Size = new System.Drawing.Size(160, 24);
            this.cbProdM.TabIndex = 26;
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
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(214, 163);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(357, 76);
            this.tbDesc.TabIndex = 27;
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
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.cbProdM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.tbIssueID);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.lEditIssue);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lStatus);
            this.Name = "EditIssue";
            this.Text = "Task Management System - Editing Issue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditIssue_FormClosed);
            this.Load += new System.EventHandler(this.EditIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lEditIssue;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.TextBox tbIssueID;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.ComboBox cbProdM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label lDescription;
    }
}