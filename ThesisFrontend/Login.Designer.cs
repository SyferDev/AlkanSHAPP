namespace ThesisFrontend
{
    partial class Login
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
            this.txt_login = new System.Windows.Forms.Label();
            this.btn_testlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.AutoSize = true;
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.txt_login.Location = new System.Drawing.Point(262, 132);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(272, 76);
            this.txt_login.TabIndex = 0;
            this.txt_login.Text = "tap ur id";
            // 
            // btn_testlogin
            // 
            this.btn_testlogin.Location = new System.Drawing.Point(358, 295);
            this.btn_testlogin.Name = "btn_testlogin";
            this.btn_testlogin.Size = new System.Drawing.Size(75, 23);
            this.btn_testlogin.TabIndex = 1;
            this.btn_testlogin.Text = "ok submit";
            this.btn_testlogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_testlogin);
            this.Controls.Add(this.txt_login);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_login;
        private System.Windows.Forms.Button btn_testlogin;
    }
}