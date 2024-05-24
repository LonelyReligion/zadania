namespace TABProject
{
    partial class ProductIssuesList
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
            this.bSelect = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.lRegistrationDate = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.cbMine = new System.Windows.Forms.CheckBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dataTime = new System.Windows.Forms.DateTimePicker();
            this.dgTabela = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(660, 18);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(109, 51);
            this.bLogOut.TabIndex = 17;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(672, 377);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(97, 39);
            this.bSelect.TabIndex = 16;
            this.bSelect.Text = "Select";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(500, 55);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(99, 35);
            this.bSearch.TabIndex = 15;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // lRegistrationDate
            // 
            this.lRegistrationDate.AutoSize = true;
            this.lRegistrationDate.Location = new System.Drawing.Point(33, 35);
            this.lRegistrationDate.Name = "lRegistrationDate";
            this.lRegistrationDate.Size = new System.Drawing.Size(112, 16);
            this.lRegistrationDate.TabIndex = 14;
            this.lRegistrationDate.Text = "Registration date:";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(269, 35);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(47, 16);
            this.lStatus.TabIndex = 13;
            this.lStatus.Text = "Status:";
            // 
            // cbMine
            // 
            this.cbMine.AutoSize = true;
            this.cbMine.Checked = true;
            this.cbMine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMine.Location = new System.Drawing.Point(422, 63);
            this.cbMine.Name = "cbMine";
            this.cbMine.Size = new System.Drawing.Size(58, 20);
            this.cbMine.TabIndex = 12;
            this.cbMine.Text = "Mine";
            this.cbMine.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(272, 61);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 11;
            // 
            // dataTime
            // 
            this.dataTime.Location = new System.Drawing.Point(33, 61);
            this.dataTime.Name = "dataTime";
            this.dataTime.ShowCheckBox = true;
            this.dataTime.Size = new System.Drawing.Size(200, 22);
            this.dataTime.TabIndex = 10;
            // 
            // dgTabela
            // 
            this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabela.Location = new System.Drawing.Point(33, 105);
            this.dgTabela.Name = "dgTabela";
            this.dgTabela.RowHeadersWidth = 51;
            this.dgTabela.RowTemplate.Height = 24;
            this.dgTabela.Size = new System.Drawing.Size(633, 311);
            this.dgTabela.TabIndex = 9;
            // 
            // ProductIssuesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLogOut);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.lRegistrationDate);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.cbMine);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dataTime);
            this.Controls.Add(this.dgTabela);
            this.Name = "ProductIssuesList";
            this.Text = "Task Management System - Issues List";
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Label lRegistrationDate;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.CheckBox cbMine;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dataTime;
        private System.Windows.Forms.DataGridView dgTabela;
    }
}