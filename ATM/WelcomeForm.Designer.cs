namespace ATM
{
    partial class WelcomeForm
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
            this.btnBalanceForm = new System.Windows.Forms.Button();
            this.btnChangePINForm = new System.Windows.Forms.Button();
            this.btnWithdrawForm = new System.Windows.Forms.Button();
            this.btnTransferForm = new System.Windows.Forms.Button();
            this.btnHistoryForm = new System.Windows.Forms.Button();
            this.btnWelcomeToLogin = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToWelcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBalanceForm
            // 
            this.btnBalanceForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBalanceForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBalanceForm.Location = new System.Drawing.Point(53, 65);
            this.btnBalanceForm.Name = "btnBalanceForm";
            this.btnBalanceForm.Size = new System.Drawing.Size(258, 63);
            this.btnBalanceForm.TabIndex = 0;
            this.btnBalanceForm.Text = "Баланс";
            this.btnBalanceForm.UseVisualStyleBackColor = false;
            this.btnBalanceForm.Click += new System.EventHandler(this.btnBalanceForm_Click);
            // 
            // btnChangePINForm
            // 
            this.btnChangePINForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChangePINForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangePINForm.Location = new System.Drawing.Point(421, 230);
            this.btnChangePINForm.Name = "btnChangePINForm";
            this.btnChangePINForm.Size = new System.Drawing.Size(265, 61);
            this.btnChangePINForm.TabIndex = 1;
            this.btnChangePINForm.Text = "Смена PIN";
            this.btnChangePINForm.UseVisualStyleBackColor = false;
            this.btnChangePINForm.Click += new System.EventHandler(this.btnLoanForm_Click);
            // 
            // btnWithdrawForm
            // 
            this.btnWithdrawForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnWithdrawForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWithdrawForm.Location = new System.Drawing.Point(421, 65);
            this.btnWithdrawForm.Name = "btnWithdrawForm";
            this.btnWithdrawForm.Size = new System.Drawing.Size(265, 63);
            this.btnWithdrawForm.TabIndex = 2;
            this.btnWithdrawForm.Text = "Снять деньги";
            this.btnWithdrawForm.UseVisualStyleBackColor = false;
            this.btnWithdrawForm.Click += new System.EventHandler(this.btnWithdrawForm_Click);
            // 
            // btnTransferForm
            // 
            this.btnTransferForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTransferForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransferForm.Location = new System.Drawing.Point(53, 230);
            this.btnTransferForm.Name = "btnTransferForm";
            this.btnTransferForm.Size = new System.Drawing.Size(258, 63);
            this.btnTransferForm.TabIndex = 3;
            this.btnTransferForm.Text = "Перевести ";
            this.btnTransferForm.UseVisualStyleBackColor = false;
            this.btnTransferForm.Click += new System.EventHandler(this.btnTransferForm_Click);
            // 
            // btnHistoryForm
            // 
            this.btnHistoryForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHistoryForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHistoryForm.Location = new System.Drawing.Point(421, 381);
            this.btnHistoryForm.Name = "btnHistoryForm";
            this.btnHistoryForm.Size = new System.Drawing.Size(258, 63);
            this.btnHistoryForm.TabIndex = 4;
            this.btnHistoryForm.Text = "История";
            this.btnHistoryForm.UseVisualStyleBackColor = false;
            this.btnHistoryForm.Click += new System.EventHandler(this.btnHistoryForm_Click);
            // 
            // btnWelcomeToLogin
            // 
            this.btnWelcomeToLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnWelcomeToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWelcomeToLogin.Location = new System.Drawing.Point(53, 381);
            this.btnWelcomeToLogin.Name = "btnWelcomeToLogin";
            this.btnWelcomeToLogin.Size = new System.Drawing.Size(258, 63);
            this.btnWelcomeToLogin.TabIndex = 6;
            this.btnWelcomeToLogin.Text = "Назад";
            this.btnWelcomeToLogin.UseVisualStyleBackColor = false;
            this.btnWelcomeToLogin.Click += new System.EventHandler(this.btnWelcomeToLogin_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.Location = new System.Drawing.Point(317, 212);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(0, 58);
            this.labelBalance.TabIndex = 7;
            this.labelBalance.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(148, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ваш остаток на счете:";
            this.label1.Visible = false;
            // 
            // btnToWelcome
            // 
            this.btnToWelcome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnToWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToWelcome.Location = new System.Drawing.Point(235, 414);
            this.btnToWelcome.Name = "btnToWelcome";
            this.btnToWelcome.Size = new System.Drawing.Size(258, 63);
            this.btnToWelcome.TabIndex = 9;
            this.btnToWelcome.Text = "Назад";
            this.btnToWelcome.UseVisualStyleBackColor = false;
            this.btnToWelcome.Click += new System.EventHandler(this.btnToWelcome_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(736, 514);
            this.Controls.Add(this.btnToWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.btnWelcomeToLogin);
            this.Controls.Add(this.btnHistoryForm);
            this.Controls.Add(this.btnTransferForm);
            this.Controls.Add(this.btnWithdrawForm);
            this.Controls.Add(this.btnChangePINForm);
            this.Controls.Add(this.btnBalanceForm);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBalanceForm;
        private System.Windows.Forms.Button btnChangePINForm;
        private System.Windows.Forms.Button btnWithdrawForm;
        private System.Windows.Forms.Button btnTransferForm;
        private System.Windows.Forms.Button btnHistoryForm;
        private System.Windows.Forms.Button btnWelcomeToLogin;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToWelcome;
    }
}