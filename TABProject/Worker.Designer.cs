namespace TABProject
{
    partial class Worker
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
            this.bSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idworkertaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtopenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtfinalcancelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workertaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lRegistrationDate = new System.Windows.Forms.Label();
            this.dataTime = new System.Windows.Forms.DateTimePicker();
            this.cbFinal = new System.Windows.Forms.CheckBox();
            this.cbInProgress = new System.Windows.Forms.CheckBox();
            this.cbCancel = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.cbMine = new System.Windows.Forms.CheckBox();
            this.bSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(504, 9);
            this.bLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(80, 38);
            this.bLogOut.TabIndex = 20;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(472, 303);
            this.bSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(80, 37);
            this.bSave.TabIndex = 26;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idworkertaskDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.idworkerDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dtopenDataGridViewTextBoxColumn,
            this.idissueDataGridViewTextBoxColumn,
            this.dtfinalcancelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workertaskBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(439, 269);
            this.dataGridView1.TabIndex = 28;
            // 
            // idworkertaskDataGridViewTextBoxColumn
            // 
            this.idworkertaskDataGridViewTextBoxColumn.DataPropertyName = "id_worker_task";
            this.idworkertaskDataGridViewTextBoxColumn.HeaderText = "id_worker_task";
            this.idworkertaskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idworkertaskDataGridViewTextBoxColumn.Name = "idworkertaskDataGridViewTextBoxColumn";
            this.idworkertaskDataGridViewTextBoxColumn.ReadOnly = true;
            this.idworkertaskDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // idworkerDataGridViewTextBoxColumn
            // 
            this.idworkerDataGridViewTextBoxColumn.DataPropertyName = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.HeaderText = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idworkerDataGridViewTextBoxColumn.Name = "idworkerDataGridViewTextBoxColumn";
            this.idworkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idworkerDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "result";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtopenDataGridViewTextBoxColumn
            // 
            this.dtopenDataGridViewTextBoxColumn.DataPropertyName = "dt_open";
            this.dtopenDataGridViewTextBoxColumn.HeaderText = "dt_open";
            this.dtopenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtopenDataGridViewTextBoxColumn.Name = "dtopenDataGridViewTextBoxColumn";
            this.dtopenDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtopenDataGridViewTextBoxColumn.Width = 125;
            // 
            // idissueDataGridViewTextBoxColumn
            // 
            this.idissueDataGridViewTextBoxColumn.DataPropertyName = "id_issue";
            this.idissueDataGridViewTextBoxColumn.HeaderText = "id_issue";
            this.idissueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idissueDataGridViewTextBoxColumn.Name = "idissueDataGridViewTextBoxColumn";
            this.idissueDataGridViewTextBoxColumn.ReadOnly = true;
            this.idissueDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtfinalcancelDataGridViewTextBoxColumn
            // 
            this.dtfinalcancelDataGridViewTextBoxColumn.DataPropertyName = "dt_final_cancel";
            this.dtfinalcancelDataGridViewTextBoxColumn.HeaderText = "dt_final_cancel";
            this.dtfinalcancelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtfinalcancelDataGridViewTextBoxColumn.Name = "dtfinalcancelDataGridViewTextBoxColumn";
            this.dtfinalcancelDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtfinalcancelDataGridViewTextBoxColumn.Width = 125;
            // 
            // workertaskBindingSource
            // 
            this.workertaskBindingSource.DataMember = "worker_task";
            // 
            // lRegistrationDate
            // 
            this.lRegistrationDate.AutoSize = true;
            this.lRegistrationDate.Location = new System.Drawing.Point(24, 19);
            this.lRegistrationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRegistrationDate.Name = "lRegistrationDate";
            this.lRegistrationDate.Size = new System.Drawing.Size(90, 13);
            this.lRegistrationDate.TabIndex = 30;
            this.lRegistrationDate.Text = "Registration date:";
            // 
            // dataTime
            // 
            this.dataTime.Location = new System.Drawing.Point(24, 41);
            this.dataTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataTime.Name = "dataTime";
            this.dataTime.ShowCheckBox = true;
            this.dataTime.Size = new System.Drawing.Size(151, 20);
            this.dataTime.TabIndex = 29;
            // 
            // cbFinal
            // 
            this.cbFinal.AutoSize = true;
            this.cbFinal.Location = new System.Drawing.Point(472, 110);
            this.cbFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFinal.Name = "cbFinal";
            this.cbFinal.Size = new System.Drawing.Size(48, 17);
            this.cbFinal.TabIndex = 31;
            this.cbFinal.Text = "Final";
            this.cbFinal.UseVisualStyleBackColor = true;
            this.cbFinal.CheckedChanged += new System.EventHandler(this.cbFinal_CheckedChanged);
            // 
            // cbInProgress
            // 
            this.cbInProgress.AutoSize = true;
            this.cbInProgress.Location = new System.Drawing.Point(472, 91);
            this.cbInProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbInProgress.Name = "cbInProgress";
            this.cbInProgress.Size = new System.Drawing.Size(78, 17);
            this.cbInProgress.TabIndex = 32;
            this.cbInProgress.Text = "In progress";
            this.cbInProgress.UseVisualStyleBackColor = true;
            this.cbInProgress.CheckedChanged += new System.EventHandler(this.cbInProgress_CheckedChanged);
            // 
            // cbCancel
            // 
            this.cbCancel.AutoSize = true;
            this.cbCancel.Location = new System.Drawing.Point(472, 130);
            this.cbCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCancel.Name = "cbCancel";
            this.cbCancel.Size = new System.Drawing.Size(59, 17);
            this.cbCancel.TabIndex = 33;
            this.cbCancel.Text = "Cancel";
            this.cbCancel.UseVisualStyleBackColor = true;
            this.cbCancel.CheckedChanged += new System.EventHandler(this.cbCancel_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 171);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 128);
            this.textBox1.TabIndex = 34;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(469, 155);
            this.lResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(40, 13);
            this.lResult.TabIndex = 35;
            this.lResult.Text = "Result:";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(470, 72);
            this.lStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(40, 13);
            this.lStatus.TabIndex = 36;
            this.lStatus.Text = "Status:";
            // 
            // cbMine
            // 
            this.cbMine.AutoSize = true;
            this.cbMine.Location = new System.Drawing.Point(190, 42);
            this.cbMine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMine.Name = "cbMine";
            this.cbMine.Size = new System.Drawing.Size(49, 17);
            this.cbMine.TabIndex = 37;
            this.cbMine.Text = "Mine";
            this.cbMine.UseVisualStyleBackColor = true;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(248, 37);
            this.bSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(69, 27);
            this.bSearch.TabIndex = 38;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 370);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cbMine);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbCancel);
            this.Controls.Add(this.cbInProgress);
            this.Controls.Add(this.cbFinal);
            this.Controls.Add(this.lRegistrationDate);
            this.Controls.Add(this.dataTime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bLogOut);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Worker";
            this.Text = "Task Management System - Worker Console";
            this.Load += new System.EventHandler(this.Worker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workertaskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource workertaskBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkertaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtopenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtfinalcancelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lRegistrationDate;
        private System.Windows.Forms.DateTimePicker dataTime;
        private System.Windows.Forms.CheckBox cbFinal;
        private System.Windows.Forms.CheckBox cbInProgress;
        private System.Windows.Forms.CheckBox cbCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.CheckBox cbMine;
        private System.Windows.Forms.Button bSearch;
    }
}