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
            this.bReturn = new System.Windows.Forms.Button();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.bAddNewIssue = new System.Windows.Forms.Button();
            this.bDeleteIssue = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.bSaveStatus = new System.Windows.Forms.Button();
            this.lChoodPM = new System.Windows.Forms.Label();
            this.comboBoxPM = new System.Windows.Forms.ComboBox();
            this.bOK = new System.Windows.Forms.Button();
            this.lRequest = new System.Windows.Forms.Label();
            this.lIssues = new System.Windows.Forms.Label();
            this.tbRequestID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(679, 12);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(109, 51);
            this.bReturn.TabIndex = 2;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(245, 50);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(62, 20);
            this.cbDone.TabIndex = 3;
            this.cbDone.Text = "Done";
            this.cbDone.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(245, 76);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(69, 20);
            this.cbDelete.TabIndex = 4;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // bAddNewIssue
            // 
            this.bAddNewIssue.Location = new System.Drawing.Point(153, 388);
            this.bAddNewIssue.Name = "bAddNewIssue";
            this.bAddNewIssue.Size = new System.Drawing.Size(105, 31);
            this.bAddNewIssue.TabIndex = 7;
            this.bAddNewIssue.Text = "Add new issue";
            this.bAddNewIssue.UseVisualStyleBackColor = true;
            this.bAddNewIssue.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bDeleteIssue
            // 
            this.bDeleteIssue.Location = new System.Drawing.Point(46, 387);
            this.bDeleteIssue.Name = "bDeleteIssue";
            this.bDeleteIssue.Size = new System.Drawing.Size(101, 32);
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
            // bSaveStatus
            // 
            this.bSaveStatus.Location = new System.Drawing.Point(320, 50);
            this.bSaveStatus.Name = "bSaveStatus";
            this.bSaveStatus.Size = new System.Drawing.Size(136, 46);
            this.bSaveStatus.TabIndex = 1;
            this.bSaveStatus.Text = "Save request status";
            this.bSaveStatus.UseVisualStyleBackColor = true;
            // 
            // lChoodPM
            // 
            this.lChoodPM.AutoSize = true;
            this.lChoodPM.Location = new System.Drawing.Point(597, 306);
            this.lChoodPM.Name = "lChoodPM";
            this.lChoodPM.Size = new System.Drawing.Size(163, 16);
            this.lChoodPM.TabIndex = 11;
            this.lChoodPM.Text = "Choose Product Manager:";
            // 
            // comboBoxPM
            // 
            this.comboBoxPM.FormattingEnabled = true;
            this.comboBoxPM.Location = new System.Drawing.Point(600, 326);
            this.comboBoxPM.Name = "comboBoxPM";
            this.comboBoxPM.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPM.TabIndex = 12;
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(600, 356);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 13;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // lRequest
            // 
            this.lRequest.AutoSize = true;
            this.lRequest.Location = new System.Drawing.Point(43, 24);
            this.lRequest.Name = "lRequest";
            this.lRequest.Size = new System.Drawing.Size(61, 16);
            this.lRequest.TabIndex = 19;
            this.lRequest.Text = "Request:";
            // 
            // lIssues
            // 
            this.lIssues.AutoSize = true;
            this.lIssues.Location = new System.Drawing.Point(43, 129);
            this.lIssues.Name = "lIssues";
            this.lIssues.Size = new System.Drawing.Size(138, 16);
            this.lIssues.TabIndex = 20;
            this.lIssues.Text = "Issues for this request:";
            // 
            // tbRequestID
            // 
            this.tbRequestID.Location = new System.Drawing.Point(44, 48);
            this.tbRequestID.Multiline = true;
            this.tbRequestID.Name = "tbRequestID";
            this.tbRequestID.ReadOnly = true;
            this.tbRequestID.Size = new System.Drawing.Size(175, 48);
            this.tbRequestID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Choose request status:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 229);
            this.dataGridView1.TabIndex = 23;
            // 
            // ACCManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRequestID);
            this.Controls.Add(this.lIssues);
            this.Controls.Add(this.lRequest);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.comboBoxPM);
            this.Controls.Add(this.lChoodPM);
            this.Controls.Add(this.bDeleteIssue);
            this.Controls.Add(this.bAddNewIssue);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.cbDone);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.bSaveStatus);
            this.Name = "ACCManager";
            this.Text = "Task Management System - Request Details";
            this.Load += new System.EventHandler(this.ACCManager_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.Button bAddNewIssue;
        private System.Windows.Forms.Button bDeleteIssue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button bSaveStatus;
        private System.Windows.Forms.Label lChoodPM;
        private System.Windows.Forms.ComboBox comboBoxPM;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Label lRequest;
        private System.Windows.Forms.Label lIssues;
        private System.Windows.Forms.TextBox tbRequestID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}