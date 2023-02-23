namespace ShoppingListApp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblTitle = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            cbxShowPass = new CheckBox();
            btnTerms = new Button();
            btnLogin = new Button();
            btnRegister = new Button();
            lblLoginResponse = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(158, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(43, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sign in";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(100, 34);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.MaxLength = 32;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(164, 23);
            txtUser.TabIndex = 1;
            txtUser.TextChanged += LoginInfo_TextChanged;
            txtUser.KeyPress += txtUser_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 73);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.MaxLength = 128;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(164, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += LoginInfo_TextChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(23, 37);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(27, 78);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // cbxShowPass
            // 
            cbxShowPass.AutoSize = true;
            cbxShowPass.Location = new Point(269, 75);
            cbxShowPass.Margin = new Padding(3, 2, 3, 2);
            cbxShowPass.Name = "cbxShowPass";
            cbxShowPass.Size = new Size(108, 19);
            cbxShowPass.TabIndex = 5;
            cbxShowPass.Text = "Show password";
            cbxShowPass.UseVisualStyleBackColor = true;
            cbxShowPass.CheckedChanged += cbxShowPass_CheckedChanged;
            // 
            // btnTerms
            // 
            btnTerms.Location = new Point(285, 9);
            btnTerms.Margin = new Padding(3, 2, 3, 2);
            btnTerms.Name = "btnTerms";
            btnTerms.Size = new Size(94, 39);
            btnTerms.TabIndex = 6;
            btnTerms.Text = "Terms of Service";
            btnTerms.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Enabled = false;
            btnLogin.Location = new Point(100, 118);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(164, 37);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Enabled = false;
            btnRegister.Location = new Point(270, 118);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(109, 37);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblLoginResponse
            // 
            lblLoginResponse.AutoSize = true;
            lblLoginResponse.Location = new Point(100, 98);
            lblLoginResponse.Name = "lblLoginResponse";
            lblLoginResponse.Size = new Size(149, 15);
            lblLoginResponse.TabIndex = 9;
            lblLoginResponse.Text = "login response placeholder";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(389, 166);
            Controls.Add(lblLoginResponse);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(btnTerms);
            Controls.Add(cbxShowPass);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private CheckBox cbxShowPass;
        private Button btnTerms;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblLoginResponse;
    }
}