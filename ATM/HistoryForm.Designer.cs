namespace ATM
{
    partial class HistoryForm
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
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsDataSet = new ATM.AccountsDataSet();
            this.historyTableAdapter = new ATM.AccountsDataSetTableAdapters.HistoryTableAdapter();
            this.btnToWelcome = new System.Windows.Forms.Button();
            this.accNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.AutoGenerateColumns = false;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridViewHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accNumberDataGridViewTextBoxColumn,
            this.currentBalanceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.accBalanceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridViewHistory.DataSource = this.historyBindingSource;
            this.dataGridViewHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridViewHistory.Location = new System.Drawing.Point(2, 0);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersVisible = false;
            this.dataGridViewHistory.RowTemplate.Height = 24;
            this.dataGridViewHistory.Size = new System.Drawing.Size(733, 381);
            this.dataGridViewHistory.TabIndex = 0;
            this.dataGridViewHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistory_CellContentClick);
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.accountsDataSet;
            // 
            // accountsDataSet
            // 
            this.accountsDataSet.DataSetName = "AccountsDataSet";
            this.accountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // btnToWelcome
            // 
            this.btnToWelcome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnToWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToWelcome.Location = new System.Drawing.Point(237, 413);
            this.btnToWelcome.Name = "btnToWelcome";
            this.btnToWelcome.Size = new System.Drawing.Size(258, 63);
            this.btnToWelcome.TabIndex = 10;
            this.btnToWelcome.Text = "Назад";
            this.btnToWelcome.UseVisualStyleBackColor = false;
            this.btnToWelcome.Click += new System.EventHandler(this.btnToWelcome_Click);
            // 
            // accNumberDataGridViewTextBoxColumn
            // 
            this.accNumberDataGridViewTextBoxColumn.DataPropertyName = "accNumber";
            this.accNumberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.accNumberDataGridViewTextBoxColumn.Name = "accNumberDataGridViewTextBoxColumn";
            this.accNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.accNumberDataGridViewTextBoxColumn.Width = 50;
            // 
            // currentBalanceDataGridViewTextBoxColumn
            // 
            this.currentBalanceDataGridViewTextBoxColumn.DataPropertyName = "currentBalance";
            this.currentBalanceDataGridViewTextBoxColumn.HeaderText = "Баланс";
            this.currentBalanceDataGridViewTextBoxColumn.Name = "currentBalanceDataGridViewTextBoxColumn";
            this.currentBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentBalanceDataGridViewTextBoxColumn.Width = 60;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Операция";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // accBalanceDataGridViewTextBoxColumn
            // 
            this.accBalanceDataGridViewTextBoxColumn.DataPropertyName = "accBalance";
            this.accBalanceDataGridViewTextBoxColumn.HeaderText = "Доступно";
            this.accBalanceDataGridViewTextBoxColumn.Name = "accBalanceDataGridViewTextBoxColumn";
            this.accBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.accBalanceDataGridViewTextBoxColumn.Width = 60;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 120;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(736, 514);
            this.Controls.Add(this.dataGridViewHistory);
            this.Controls.Add(this.btnToWelcome);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private AccountsDataSet accountsDataSet;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private AccountsDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
        private System.Windows.Forms.Button btnToWelcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn accNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}