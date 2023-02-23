namespace ShoppingListApp
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            lbl_title = new Label();
            txt_user = new TextBox();
            txt_password = new TextBox();
            lbl_Username = new Label();
            lbl_password = new Label();
            cbx_showPass = new CheckBox();
            btn_terms = new Button();
            btn_Login = new Button();
            btn_Register = new Button();
            lblLoginResponse = new Label();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(158, 11);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(43, 15);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Sign in";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(100, 34);
            txt_user.Margin = new Padding(3, 2, 3, 2);
            txt_user.MaxLength = 32;
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(164, 23);
            txt_user.TabIndex = 1;
            txt_user.TextChanged += loginInfo_TextChanged;
            txt_user.KeyPress += txt_user_KeyPress;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(100, 73);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.MaxLength = 128;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(164, 23);
            txt_password.TabIndex = 2;
            txt_password.UseSystemPasswordChar = true;
            txt_password.TextChanged += loginInfo_TextChanged;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new Point(23, 37);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(63, 15);
            lbl_Username.TabIndex = 3;
            lbl_Username.Text = "Username:";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(27, 78);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(60, 15);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Password:";
            // 
            // cbx_showPass
            // 
            cbx_showPass.AutoSize = true;
            cbx_showPass.Location = new Point(269, 75);
            cbx_showPass.Margin = new Padding(3, 2, 3, 2);
            cbx_showPass.Name = "cbx_showPass";
            cbx_showPass.Size = new Size(108, 19);
            cbx_showPass.TabIndex = 5;
            cbx_showPass.Text = "Show password";
            cbx_showPass.UseVisualStyleBackColor = true;
            cbx_showPass.CheckedChanged += cbx_showPass_CheckedChanged;
            // 
            // btn_terms
            // 
            btn_terms.Location = new Point(285, 9);
            btn_terms.Margin = new Padding(3, 2, 3, 2);
            btn_terms.Name = "btn_terms";
            btn_terms.Size = new Size(94, 39);
            btn_terms.TabIndex = 6;
            btn_terms.Text = "Terms of Service";
            btn_terms.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            btn_Login.Enabled = false;
            btn_Login.Location = new Point(100, 118);
            btn_Login.Margin = new Padding(3, 2, 3, 2);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(164, 37);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            // 
            // btn_Register
            // 
            btn_Register.Enabled = false;
            btn_Register.Location = new Point(270, 118);
            btn_Register.Margin = new Padding(3, 2, 3, 2);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(109, 37);
            btn_Register.TabIndex = 8;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
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
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(389, 166);
            Controls.Add(lblLoginResponse);
            Controls.Add(btn_Register);
            Controls.Add(btn_Login);
            Controls.Add(btn_terms);
            Controls.Add(cbx_showPass);
            Controls.Add(lbl_password);
            Controls.Add(lbl_Username);
            Controls.Add(txt_password);
            Controls.Add(txt_user);
            Controls.Add(lbl_title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_Login";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private TextBox txt_user;
        private TextBox txt_password;
        private Label lbl_Username;
        private Label lbl_password;
        private CheckBox cbx_showPass;
        private Button btn_terms;
        private Button btn_Login;
        private Button btn_Register;
        private Label lblLoginResponse;
    }
}