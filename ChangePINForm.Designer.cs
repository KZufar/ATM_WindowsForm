namespace ATM
{
    partial class ChangePINForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textNewPIN = new System.Windows.Forms.TextBox();
            this.textOldPIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToWelcome = new System.Windows.Forms.Button();
            this.btnChangePIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(137, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 63);
            this.label3.TabIndex = 13;
            this.label3.Text = "Смена PIN кода";
            // 
            // textNewPIN
            // 
            this.textNewPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNewPIN.Location = new System.Drawing.Point(406, 306);
            this.textNewPIN.Name = "textNewPIN";
            this.textNewPIN.Size = new System.Drawing.Size(250, 41);
            this.textNewPIN.TabIndex = 10;
            // 
            // textOldPIN
            // 
            this.textOldPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOldPIN.Location = new System.Drawing.Point(406, 187);
            this.textOldPIN.Name = "textOldPIN";
            this.textOldPIN.Size = new System.Drawing.Size(250, 41);
            this.textOldPIN.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(80, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Новый PIN код:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Старый PIN код:";
            // 
            // btnToWelcome
            // 
            this.btnToWelcome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnToWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToWelcome.Location = new System.Drawing.Point(75, 408);
            this.btnToWelcome.Name = "btnToWelcome";
            this.btnToWelcome.Size = new System.Drawing.Size(258, 63);
            this.btnToWelcome.TabIndex = 15;
            this.btnToWelcome.Text = "Назад";
            this.btnToWelcome.UseVisualStyleBackColor = false;
            this.btnToWelcome.Click += new System.EventHandler(this.btnToWelcome_Click);
            // 
            // btnChangePIN
            // 
            this.btnChangePIN.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChangePIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangePIN.Location = new System.Drawing.Point(398, 408);
            this.btnChangePIN.Name = "btnChangePIN";
            this.btnChangePIN.Size = new System.Drawing.Size(258, 63);
            this.btnChangePIN.TabIndex = 16;
            this.btnChangePIN.Text = "Изменить";
            this.btnChangePIN.UseVisualStyleBackColor = false;
            this.btnChangePIN.Click += new System.EventHandler(this.btnChangePIN_Click);
            // 
            // ChangePINForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(736, 514);
            this.Controls.Add(this.btnChangePIN);
            this.Controls.Add(this.btnToWelcome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNewPIN);
            this.Controls.Add(this.textOldPIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePINForm";
            this.Text = "ChangePINForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNewPIN;
        private System.Windows.Forms.TextBox textOldPIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToWelcome;
        private System.Windows.Forms.Button btnChangePIN;
    }
}