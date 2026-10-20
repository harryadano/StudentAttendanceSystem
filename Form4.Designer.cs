namespace WindowsFormsApp6
{
    partial class Form4
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
            this.lnkBackToLogin = new System.Windows.Forms.Panel();
            this.BackToLogin = new System.Windows.Forms.LinkLabel();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkBackToLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkBackToLogin
            // 
            this.lnkBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(47)))), ((int)(((byte)(80)))));
            this.lnkBackToLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkBackToLogin.Controls.Add(this.BackToLogin);
            this.lnkBackToLogin.Controls.Add(this.lblResult);
            this.lnkBackToLogin.Controls.Add(this.btnShowPassword);
            this.lnkBackToLogin.Controls.Add(this.txtEmail);
            this.lnkBackToLogin.Controls.Add(this.label3);
            this.lnkBackToLogin.Controls.Add(this.label2);
            this.lnkBackToLogin.Controls.Add(this.label1);
            this.lnkBackToLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkBackToLogin.Location = new System.Drawing.Point(0, 0);
            this.lnkBackToLogin.Name = "lnkBackToLogin";
            this.lnkBackToLogin.Size = new System.Drawing.Size(552, 665);
            this.lnkBackToLogin.TabIndex = 0;
            // 
            // BackToLogin
            // 
            this.BackToLogin.AutoSize = true;
            this.BackToLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToLogin.LinkColor = System.Drawing.Color.DodgerBlue;
            this.BackToLogin.Location = new System.Drawing.Point(216, 403);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(113, 23);
            this.BackToLogin.TabIndex = 17;
            this.BackToLogin.TabStop = true;
            this.BackToLogin.Text = "Back to Login";
            this.BackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackToLogin_LinkClicked);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.lblResult.Location = new System.Drawing.Point(145, 368);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(262, 25);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "Your password will appear here.";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowPassword.Location = new System.Drawing.Point(61, 304);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(440, 45);
            this.btnShowPassword.TabIndex = 15;
            this.btnShowPassword.Text = "Show Password";
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(61, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(439, 31);
            this.txtEmail.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(57, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registered Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(214)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(126, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your registered email address.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(143, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Password";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 665);
            this.Controls.Add(this.lnkBackToLogin);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.lnkBackToLogin.ResumeLayout(false);
            this.lnkBackToLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lnkBackToLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.LinkLabel BackToLogin;
    }
}