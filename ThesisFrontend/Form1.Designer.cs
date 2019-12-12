namespace ThesisFrontend
{
    partial class Form1
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
            this.rfidTag = new System.Windows.Forms.Label();
            this.btn_depo = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.txt_balance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TypoGraphica", 50F);
            this.label1.Location = new System.Drawing.Point(221, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "AlkanSHAP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rfidTag
            // 
            this.rfidTag.AutoSize = true;
            this.rfidTag.Font = new System.Drawing.Font("FORQUE", 25F);
            this.rfidTag.Location = new System.Drawing.Point(28, 384);
            this.rfidTag.Name = "rfidTag";
            this.rfidTag.Size = new System.Drawing.Size(101, 36);
            this.rfidTag.TabIndex = 1;
            this.rfidTag.Text = "1239123";
            this.rfidTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rfidTag.UseWaitCursor = true;
            // 
            // btn_depo
            // 
            this.btn_depo.Font = new System.Drawing.Font("FORQUE", 30F);
            this.btn_depo.Location = new System.Drawing.Point(308, 186);
            this.btn_depo.Name = "btn_depo";
            this.btn_depo.Size = new System.Drawing.Size(170, 104);
            this.btn_depo.TabIndex = 2;
            this.btn_depo.Text = "Deposit";
            this.btn_depo.UseVisualStyleBackColor = true;
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Font = new System.Drawing.Font("FORQUE", 30F);
            this.btn_withdraw.Location = new System.Drawing.Point(308, 316);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(170, 104);
            this.btn_withdraw.TabIndex = 3;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            // 
            // txt_balance
            // 
            this.txt_balance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_balance.AutoSize = true;
            this.txt_balance.Font = new System.Drawing.Font("FORQUE", 30F);
            this.txt_balance.Location = new System.Drawing.Point(339, 121);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(100, 43);
            this.txt_balance.TabIndex = 4;
            this.txt_balance.Text = "P 1000";
            this.txt_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_balance.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_depo);
            this.Controls.Add(this.rfidTag);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rfidTag;
        private System.Windows.Forms.Button btn_depo;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Label txt_balance;
    }
}

