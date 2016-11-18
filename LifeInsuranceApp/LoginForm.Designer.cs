namespace LifeInsuranceApp
{
    partial class LoginForm
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
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Username = new System.Windows.Forms.Label();
            this.Lbl_Pwd = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Lnk_ForgotPwd = new System.Windows.Forms.LinkLabel();
            this.Lbl_Header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Username
            // 
            this.TB_Username.Location = new System.Drawing.Point(269, 128);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(226, 20);
            this.TB_Username.TabIndex = 0;
            this.TB_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Username_KeyPress);
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(269, 168);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(226, 20);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Password_KeyPress);
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Username.Location = new System.Drawing.Point(135, 131);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(87, 15);
            this.Lbl_Username.TabIndex = 5;
            this.Lbl_Username.Text = "User Name: ";
            // 
            // Lbl_Pwd
            // 
            this.Lbl_Pwd.AutoSize = true;
            this.Lbl_Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Pwd.Location = new System.Drawing.Point(135, 173);
            this.Lbl_Pwd.Name = "Lbl_Pwd";
            this.Lbl_Pwd.Size = new System.Drawing.Size(77, 15);
            this.Lbl_Pwd.TabIndex = 1;
            this.Lbl_Pwd.Text = "Password: ";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(273, 218);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(92, 25);
            this.Btn_Login.TabIndex = 2;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.Location = new System.Drawing.Point(403, 218);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(92, 25);
            this.Btn_Reset.TabIndex = 3;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            // 
            // Lnk_ForgotPwd
            // 
            this.Lnk_ForgotPwd.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.Lnk_ForgotPwd.AutoSize = true;
            this.Lnk_ForgotPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnk_ForgotPwd.Location = new System.Drawing.Point(275, 285);
            this.Lnk_ForgotPwd.Name = "Lnk_ForgotPwd";
            this.Lnk_ForgotPwd.Size = new System.Drawing.Size(192, 15);
            this.Lnk_ForgotPwd.TabIndex = 4;
            this.Lnk_ForgotPwd.TabStop = true;
            this.Lnk_ForgotPwd.Text = "Forgot Password? Click Here";
            // 
            // Lbl_Header
            // 
            this.Lbl_Header.AutoSize = true;
            this.Lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Header.Location = new System.Drawing.Point(249, 27);
            this.Lbl_Header.Name = "Lbl_Header";
            this.Lbl_Header.Size = new System.Drawing.Size(287, 31);
            this.Lbl_Header.TabIndex = 7;
            this.Lbl_Header.Text = "INSURE APP LOGIN";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 435);
            this.Controls.Add(this.Lbl_Header);
            this.Controls.Add(this.Lnk_ForgotPwd);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Lbl_Pwd);
            this.Controls.Add(this.Lbl_Username);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Name = "LoginForm";
            this.Text = "Welcome to InsureApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label Lbl_Username;
        private System.Windows.Forms.Label Lbl_Pwd;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.LinkLabel Lnk_ForgotPwd;
        private System.Windows.Forms.Label Lbl_Header;
    }
}

