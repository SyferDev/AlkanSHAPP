namespace ThesisFrontend
{
    partial class Main
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.scr_main = new System.Windows.Forms.TableLayoutPanel();
            this.scr_login = new System.Windows.Forms.TableLayoutPanel();
            this.txt_login = new System.Windows.Forms.Label();
            this.btn_testsub = new System.Windows.Forms.Button();
            this.scr_main.SuspendLayout();
            this.scr_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TypoGraphica", 50F);
            this.label1.Location = new System.Drawing.Point(201, 3);
            this.label1.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "AlkanSHAP";
            // 
            // rfidTag
            // 
            this.rfidTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rfidTag.AutoSize = true;
            this.rfidTag.Font = new System.Drawing.Font("FORQUE", 25F);
            this.rfidTag.Location = new System.Drawing.Point(33, 382);
            this.rfidTag.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.rfidTag.Name = "rfidTag";
            this.rfidTag.Size = new System.Drawing.Size(101, 36);
            this.rfidTag.TabIndex = 1;
            this.rfidTag.Text = "1239123";
            this.rfidTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rfidTag.UseWaitCursor = true;
            // 
            // btn_depo
            // 
            this.btn_depo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_depo.AutoSize = true;
            this.btn_depo.Font = new System.Drawing.Font("FORQUE", 30F);
            this.btn_depo.Location = new System.Drawing.Point(298, 148);
            this.btn_depo.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.btn_depo.Name = "btn_depo";
            this.btn_depo.Size = new System.Drawing.Size(170, 86);
            this.btn_depo.TabIndex = 2;
            this.btn_depo.Text = "Deposit";
            this.btn_depo.UseVisualStyleBackColor = true;
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_withdraw.AutoSize = true;
            this.btn_withdraw.Font = new System.Drawing.Font("FORQUE", 30F);
            this.btn_withdraw.Location = new System.Drawing.Point(298, 270);
            this.btn_withdraw.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(170, 92);
            this.btn_withdraw.TabIndex = 3;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            // 
            // txt_balance
            // 
            this.txt_balance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_balance.AutoSize = true;
            this.txt_balance.Font = new System.Drawing.Font("FORQUE", 30F);
            this.txt_balance.Location = new System.Drawing.Point(333, 96);
            this.txt_balance.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(100, 33);
            this.txt_balance.TabIndex = 4;
            this.txt_balance.Text = "P 1000";
            this.txt_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_balance.UseWaitCursor = true;
            // 
            // scr_main
            // 
            this.scr_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scr_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scr_main.ColumnCount = 3;
            this.scr_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.77835F));
            this.scr_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.54124F));
            this.scr_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.68041F));
            this.scr_main.Controls.Add(this.rfidTag, 0, 4);
            this.scr_main.Controls.Add(this.btn_withdraw, 1, 3);
            this.scr_main.Controls.Add(this.txt_balance, 1, 1);
            this.scr_main.Controls.Add(this.btn_depo, 1, 2);
            this.scr_main.Controls.Add(this.label1, 1, 0);
            this.scr_main.Location = new System.Drawing.Point(12, 12);
            this.scr_main.Name = "scr_main";
            this.scr_main.RowCount = 5;
            this.scr_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.30556F));
            this.scr_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.69444F));
            this.scr_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.scr_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.scr_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.scr_main.Size = new System.Drawing.Size(775, 421);
            this.scr_main.TabIndex = 5;
            // 
            // scr_login
            // 
            this.scr_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scr_login.AutoSize = true;
            this.scr_login.ColumnCount = 3;
            this.scr_login.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scr_login.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.scr_login.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scr_login.Controls.Add(this.txt_login, 1, 0);
            this.scr_login.Controls.Add(this.btn_testsub, 1, 1);
            this.scr_login.Location = new System.Drawing.Point(12, 12);
            this.scr_login.Name = "scr_login";
            this.scr_login.RowCount = 2;
            this.scr_login.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scr_login.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scr_login.Size = new System.Drawing.Size(775, 421);
            this.scr_login.TabIndex = 5;
            // 
            // txt_login
            // 
            this.txt_login.AutoSize = true;
            this.txt_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.txt_login.Location = new System.Drawing.Point(3, 0);
            this.txt_login.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.txt_login.MinimumSize = new System.Drawing.Size(30, 30);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(769, 210);
            this.txt_login.TabIndex = 0;
            this.txt_login.Text = "tap ur id";
            this.txt_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_testsub
            // 
            this.btn_testsub.AutoSize = true;
            this.btn_testsub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_testsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testsub.Location = new System.Drawing.Point(30, 240);
            this.btn_testsub.Margin = new System.Windows.Forms.Padding(30);
            this.btn_testsub.Name = "btn_testsub";
            this.btn_testsub.Size = new System.Drawing.Size(715, 151);
            this.btn_testsub.TabIndex = 1;
            this.btn_testsub.Text = "ok submit";
            this.btn_testsub.UseVisualStyleBackColor = true;
            this.btn_testsub.Click += new System.EventHandler(this.btn_testsub_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(799, 445);
            this.Controls.Add(this.scr_login);
            this.Controls.Add(this.scr_main);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.scr_main.ResumeLayout(false);
            this.scr_main.PerformLayout();
            this.scr_login.ResumeLayout(false);
            this.scr_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rfidTag;
        private System.Windows.Forms.Button btn_depo;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Label txt_balance;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel scr_main;
        private System.Windows.Forms.TableLayoutPanel scr_login;
        private System.Windows.Forms.Label txt_login;
        private System.Windows.Forms.Button btn_testsub;
    }
}

