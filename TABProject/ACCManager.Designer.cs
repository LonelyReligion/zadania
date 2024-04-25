namespace TABProject
{
    partial class ACCManager
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
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.checkedListBoxIssues = new System.Windows.Forms.CheckedListBox();
            this.bAddNewIssue = new System.Windows.Forms.Button();
            this.bDeleteIssue = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.comboBoxRequests = new System.Windows.Forms.ComboBox();
            this.bSaveStatus = new System.Windows.Forms.Button();
            this.lChoodPM = new System.Windows.Forms.Label();
            this.comboBoxPM = new System.Windows.Forms.ComboBox();
            this.bOK = new System.Windows.Forms.Button();
            this.lIssueProperities = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.lRequest = new System.Windows.Forms.Label();
            this.lIssues = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(679, 12);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(109, 51);
            this.bLogOut.TabIndex = 2;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(367, 32);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(62, 20);
            this.cbDone.TabIndex = 3;
            this.cbDone.Text = "Done";
            this.cbDone.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(367, 58);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(69, 20);
            this.cbDelete.TabIndex = 4;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxIssues
            // 
            this.checkedListBoxIssues.FormattingEnabled = true;
            this.checkedListBoxIssues.Location = new System.Drawing.Point(44, 109);
            this.checkedListBoxIssues.Name = "checkedListBoxIssues";
            this.checkedListBoxIssues.Size = new System.Drawing.Size(239, 225);
            this.checkedListBoxIssues.TabIndex = 6;
            // 
            // bAddNewIssue
            // 
            this.bAddNewIssue.Location = new System.Drawing.Point(44, 343);
            this.bAddNewIssue.Name = "bAddNewIssue";
            this.bAddNewIssue.Size = new System.Drawing.Size(137, 31);
            this.bAddNewIssue.TabIndex = 7;
            this.bAddNewIssue.Text = "Add new issue";
            this.bAddNewIssue.UseVisualStyleBackColor = true;
            this.bAddNewIssue.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bDeleteIssue
            // 
            this.bDeleteIssue.Location = new System.Drawing.Point(44, 380);
            this.bDeleteIssue.Name = "bDeleteIssue";
            this.bDeleteIssue.Size = new System.Drawing.Size(137, 32);
            this.bDeleteIssue.TabIndex = 8;
            this.bDeleteIssue.Text = "Delete issue";
            this.bDeleteIssue.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 33);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // comboBoxRequests
            // 
            this.comboBoxRequests.FormattingEnabled = true;
            this.comboBoxRequests.Location = new System.Drawing.Point(41, 52);
            this.comboBoxRequests.Name = "comboBoxRequests";
            this.comboBoxRequests.Size = new System.Drawing.Size(230, 24);
            this.comboBoxRequests.TabIndex = 10;
            // 
            // bSaveStatus
            // 
            this.bSaveStatus.Location = new System.Drawing.Point(442, 32);
            this.bSaveStatus.Name = "bSaveStatus";
            this.bSaveStatus.Size = new System.Drawing.Size(106, 46);
            this.bSaveStatus.TabIndex = 1;
            this.bSaveStatus.Text = "Save status";
            this.bSaveStatus.UseVisualStyleBackColor = true;
            // 
            // lChoodPM
            // 
            this.lChoodPM.AutoSize = true;
            this.lChoodPM.Location = new System.Drawing.Point(366, 290);
            this.lChoodPM.Name = "lChoodPM";
            this.lChoodPM.Size = new System.Drawing.Size(163, 16);
            this.lChoodPM.TabIndex = 11;
            this.lChoodPM.Text = "Choose Product Manager:";
            // 
            // comboBoxPM
            // 
            this.comboBoxPM.FormattingEnabled = true;
            this.comboBoxPM.Location = new System.Drawing.Point(369, 310);
            this.comboBoxPM.Name = "comboBoxPM";
            this.comboBoxPM.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPM.TabIndex = 12;
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(536, 310);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 13;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // lIssueProperities
            // 
            this.lIssueProperities.AutoSize = true;
            this.lIssueProperities.Location = new System.Drawing.Point(367, 132);
            this.lIssueProperities.Name = "lIssueProperities";
            this.lIssueProperities.Size = new System.Drawing.Size(110, 16);
            this.lIssueProperities.TabIndex = 14;
            this.lIssueProperities.Text = "Issue Properities:";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(367, 163);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(81, 16);
            this.lDescription.TabIndex = 15;
            this.lDescription.Text = "Description: ";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(367, 190);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(47, 16);
            this.lStatus.TabIndex = 16;
            this.lStatus.Text = "Status:";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(367, 219);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(51, 16);
            this.lResult.TabIndex = 17;
            this.lResult.Text = "Result: ";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(367, 245);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(42, 16);
            this.lType.TabIndex = 18;
            this.lType.Text = "Type:";
            // 
            // lRequest
            // 
            this.lRequest.AutoSize = true;
            this.lRequest.Location = new System.Drawing.Point(38, 33);
            this.lRequest.Name = "lRequest";
            this.lRequest.Size = new System.Drawing.Size(61, 16);
            this.lRequest.TabIndex = 19;
            this.lRequest.Text = "Request:";
            // 
            // lIssues
            // 
            this.lIssues.AutoSize = true;
            this.lIssues.Location = new System.Drawing.Point(41, 85);
            this.lIssues.Name = "lIssues";
            this.lIssues.Size = new System.Drawing.Size(49, 16);
            this.lIssues.TabIndex = 20;
            this.lIssues.Text = "Issues:";
            // 
            // ACCManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lIssues);
            this.Controls.Add(this.lRequest);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lIssueProperities);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.comboBoxPM);
            this.Controls.Add(this.lChoodPM);
            this.Controls.Add(this.comboBoxRequests);
            this.Controls.Add(this.bDeleteIssue);
            this.Controls.Add(this.bAddNewIssue);
            this.Controls.Add(this.checkedListBoxIssues);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.cbDone);
            this.Controls.Add(this.bLogOut);
            this.Controls.Add(this.bSaveStatus);
            this.Name = "ACCManager";
            this.Text = "Task Management System - ACC Manager Console";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckedListBox checkedListBoxIssues;
        private System.Windows.Forms.Button bAddNewIssue;
        private System.Windows.Forms.Button bDeleteIssue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ComboBox comboBoxRequests;
        private System.Windows.Forms.Button bSaveStatus;
        private System.Windows.Forms.Label lChoodPM;
        private System.Windows.Forms.ComboBox comboBoxPM;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Label lIssueProperities;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lRequest;
        private System.Windows.Forms.Label lIssues;
    }
}