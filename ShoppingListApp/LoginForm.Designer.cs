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
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.cbx_showPass = new System.Windows.Forms.CheckBox();
            this.btn_terms = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(181, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(54, 20);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Sign in";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(114, 46);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(187, 27);
            this.txt_user.TabIndex = 1;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(114, 97);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(187, 27);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(26, 49);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(78, 20);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(31, 104);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(73, 20);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password:";
            // 
            // cbx_showPass
            // 
            this.cbx_showPass.AutoSize = true;
            this.cbx_showPass.Location = new System.Drawing.Point(307, 99);
            this.cbx_showPass.Name = "cbx_showPass";
            this.cbx_showPass.Size = new System.Drawing.Size(139, 24);
            this.cbx_showPass.TabIndex = 5;
            this.cbx_showPass.Text = "Show Password?";
            this.cbx_showPass.UseVisualStyleBackColor = true;
            // 
            // btn_terms
            // 
            this.btn_terms.Location = new System.Drawing.Point(326, 12);
            this.btn_terms.Name = "btn_terms";
            this.btn_terms.Size = new System.Drawing.Size(107, 52);
            this.btn_terms.TabIndex = 6;
            this.btn_terms.Text = "Terms Of Service?";
            this.btn_terms.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(114, 137);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(187, 49);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(445, 201);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_terms);
            this.Controls.Add(this.cbx_showPass);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}