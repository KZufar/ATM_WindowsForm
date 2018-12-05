namespace ATM
{
    partial class TransferForm
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.textTransferNum = new System.Windows.Forms.TextBox();
            this.btnToWelcome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textAmountTransfer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransfer.Location = new System.Drawing.Point(402, 412);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(258, 63);
            this.btnTransfer.TabIndex = 16;
            this.btnTransfer.Text = "Перевести";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // textTransferNum
            // 
            this.textTransferNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTransferNum.Location = new System.Drawing.Point(402, 150);
            this.textTransferNum.Name = "textTransferNum";
            this.textTransferNum.Size = new System.Drawing.Size(250, 41);
            this.textTransferNum.TabIndex = 15;
            // 
            // btnToWelcome
            // 
            this.btnToWelcome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnToWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToWelcome.Location = new System.Drawing.Point(58, 412);
            this.btnToWelcome.Name = "btnToWelcome";
            this.btnToWelcome.Size = new System.Drawing.Size(258, 63);
            this.btnToWelcome.TabIndex = 14;
            this.btnToWelcome.Text = "Назад";
            this.btnToWelcome.UseVisualStyleBackColor = false;
            this.btnToWelcome.Click += new System.EventHandler(this.btnToWelcome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.MaximumSize = new System.Drawing.Size(710, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 96);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите номер карты получателя и сумму ";
            // 
            // textAmountTransfer
            // 
            this.textAmountTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAmountTransfer.Location = new System.Drawing.Point(402, 269);
            this.textAmountTransfer.Name = "textAmountTransfer";
            this.textAmountTransfer.Size = new System.Drawing.Size(250, 41);
            this.textAmountTransfer.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "Сумма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 36);
            this.label3.TabIndex = 18;
            this.label3.Text = "Номер карты:";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(736, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAmountTransfer);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.textTransferNum);
            this.Controls.Add(this.btnToWelcome);
            this.Controls.Add(this.label1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox textTransferNum;
        private System.Windows.Forms.Button btnToWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAmountTransfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}