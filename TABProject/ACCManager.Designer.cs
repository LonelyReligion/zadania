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
            this.bAddNewIssue = new System.Windows.Forms.Button();
            this.bDeleteIssue = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.lRequest = new System.Windows.Forms.Label();
            this.lIssues = new System.Windows.Forms.Label();
            this.tbRequestID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bEdit = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.rbInProgress = new System.Windows.Forms.RadioButton();
            this.rbCancel = new System.Windows.Forms.RadioButton();
            this.rbFinal = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(754, 12);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(109, 48);
            this.bReturn.TabIndex = 2;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // bAddNewIssue
            // 
            this.bAddNewIssue.Location = new System.Drawing.Point(145, 396);
            this.bAddNewIssue.Name = "bAddNewIssue";
            this.bAddNewIssue.Size = new System.Drawing.Size(105, 31);
            this.bAddNewIssue.TabIndex = 7;
            this.bAddNewIssue.Text = "Add new issue";
            this.bAddNewIssue.UseVisualStyleBackColor = true;
            this.bAddNewIssue.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bDeleteIssue
            // 
            this.bDeleteIssue.Location = new System.Drawing.Point(256, 396);
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
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(754, 71);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(110, 56);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save request";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lRequest
            // 
            this.lRequest.AutoSize = true;
            this.lRequest.Location = new System.Drawing.Point(32, 24);
            this.lRequest.Name = "lRequest";
            this.lRequest.Size = new System.Drawing.Size(61, 16);
            this.lRequest.TabIndex = 19;
            this.lRequest.Text = "Request:";
            // 
            // lIssues
            // 
            this.lIssues.AutoSize = true;
            this.lIssues.Location = new System.Drawing.Point(32, 149);
            this.lIssues.Name = "lIssues";
            this.lIssues.Size = new System.Drawing.Size(138, 16);
            this.lIssues.TabIndex = 20;
            this.lIssues.Text = "Issues for this request:";
            // 
            // tbRequestID
            // 
            this.tbRequestID.Location = new System.Drawing.Point(33, 48);
            this.tbRequestID.Multiline = true;
            this.tbRequestID.Name = "tbRequestID";
            this.tbRequestID.ReadOnly = true;
            this.tbRequestID.Size = new System.Drawing.Size(279, 81);
            this.tbRequestID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Request status:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 222);
            this.dataGridView1.TabIndex = 23;
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(34, 396);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(105, 31);
            this.bEdit.TabIndex = 24;
            this.bEdit.Text = "Edit issue";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(464, 46);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(257, 81);
            this.tbResult.TabIndex = 28;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(461, 24);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(48, 16);
            this.lResult.TabIndex = 29;
            this.lResult.Text = "Result:";
            // 
            // rbInProgress
            // 
            this.rbInProgress.AutoSize = true;
            this.rbInProgress.Location = new System.Drawing.Point(334, 49);
            this.rbInProgress.Name = "rbInProgress";
            this.rbInProgress.Size = new System.Drawing.Size(95, 20);
            this.rbInProgress.TabIndex = 30;
            this.rbInProgress.TabStop = true;
            this.rbInProgress.Text = "In progress";
            this.rbInProgress.UseVisualStyleBackColor = true;
            // 
            // rbCancel
            // 
            this.rbCancel.AutoSize = true;
            this.rbCancel.Location = new System.Drawing.Point(334, 75);
            this.rbCancel.Name = "rbCancel";
            this.rbCancel.Size = new System.Drawing.Size(70, 20);
            this.rbCancel.TabIndex = 31;
            this.rbCancel.TabStop = true;
            this.rbCancel.Text = "Cancel";
            this.rbCancel.UseVisualStyleBackColor = true;
            // 
            // rbFinal
            // 
            this.rbFinal.AutoSize = true;
            this.rbFinal.Location = new System.Drawing.Point(334, 101);
            this.rbFinal.Name = "rbFinal";
            this.rbFinal.Size = new System.Drawing.Size(57, 20);
            this.rbFinal.TabIndex = 32;
            this.rbFinal.TabStop = true;
            this.rbFinal.Text = "Final";
            this.rbFinal.UseVisualStyleBackColor = true;
            // 
            // ACCManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.rbFinal);
            this.Controls.Add(this.rbCancel);
            this.Controls.Add(this.rbInProgress);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRequestID);
            this.Controls.Add(this.lIssues);
            this.Controls.Add(this.lRequest);
            this.Controls.Add(this.bDeleteIssue);
            this.Controls.Add(this.bAddNewIssue);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.bSave);
            this.Name = "ACCManager";
            this.Load += new System.EventHandler(this.ACCManager_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Button bAddNewIssue;
        private System.Windows.Forms.Button bDeleteIssue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lRequest;
        private System.Windows.Forms.Label lIssues;
        private System.Windows.Forms.TextBox tbRequestID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.RadioButton rbInProgress;
        private System.Windows.Forms.RadioButton rbCancel;
        private System.Windows.Forms.RadioButton rbFinal;
    }
}