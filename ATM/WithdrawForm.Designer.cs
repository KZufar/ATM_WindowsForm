namespace ATM
{
    partial class WithdrawForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnToWelcome = new System.Windows.Forms.Button();
            this.textWithdraw = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите сумму для снятия";
            // 
            // btnToWelcome
            // 
            this.btnToWelcome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnToWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToWelcome.Location = new System.Drawing.Point(228, 398);
            this.btnToWelcome.Name = "btnToWelcome";
            this.btnToWelcome.Size = new System.Drawing.Size(258, 63);
            this.btnToWelcome.TabIndex = 10;
            this.btnToWelcome.Text = "Назад";
            this.btnToWelcome.UseVisualStyleBackColor = false;
            this.btnToWelcome.Click += new System.EventHandler(this.btnToWelcome_Click);
            // 
            // textWithdraw
            // 
            this.textWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textWithdraw.Location = new System.Drawing.Point(236, 148);
            this.textWithdraw.Name = "textWithdraw";
            this.textWithdraw.Size = new System.Drawing.Size(250, 41);
            this.textWithdraw.TabIndex = 11;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWithdraw.Location = new System.Drawing.Point(228, 250);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(258, 63);
            this.btnWithdraw.TabIndex = 12;
            this.btnWithdraw.Text = "Снять";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(736, 514);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.textWithdraw);
            this.Controls.Add(this.btnToWelcome);
            this.Controls.Add(this.label1);
            this.Name = "WithdrawForm";
            this.Text = "WithdrawForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToWelcome;
        private System.Windows.Forms.TextBox textWithdraw;
        private System.Windows.Forms.Button btnWithdraw;
    }
}