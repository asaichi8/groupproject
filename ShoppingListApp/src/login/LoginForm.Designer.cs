namespace ShoppingListApp
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbxShowPass = new System.Windows.Forms.CheckBox();
            this.btnTerms = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLoginResponse = new System.Windows.Forms.Label();
            this.tmrResponseTimeout = new System.Windows.Forms.Timer(this.components);
            this.pbxBrainVire = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrainVire)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitle.Location = new System.Drawing.Point(33, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(77, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sign in";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(113, 172);
            this.txtUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUser.MaxLength = 32;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(304, 18);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.LoginInfo_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(113, 208);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPassword.MaxLength = 128;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(304, 18);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.LoginInfo_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(14, 172);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 19);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 208);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // cbxShowPass
            // 
            this.cbxShowPass.AutoSize = true;
            this.cbxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxShowPass.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.cbxShowPass.Location = new System.Drawing.Point(113, 234);
            this.cbxShowPass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbxShowPass.Name = "cbxShowPass";
            this.cbxShowPass.Size = new System.Drawing.Size(109, 19);
            this.cbxShowPass.TabIndex = 2;
            this.cbxShowPass.Text = "Show password";
            this.cbxShowPass.UseVisualStyleBackColor = true;
            this.cbxShowPass.CheckedChanged += new System.EventHandler(this.cbxShowPass_CheckedChanged);
            // 
            // btnTerms
            // 
            this.btnTerms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerms.FlatAppearance.BorderSize = 0;
            this.btnTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerms.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnTerms.Location = new System.Drawing.Point(0, 461);
            this.btnTerms.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTerms.Name = "btnTerms";
            this.btnTerms.Size = new System.Drawing.Size(436, 59);
            this.btnTerms.TabIndex = 5;
            this.btnTerms.TabStop = false;
            this.btnTerms.Text = "Terms of Service";
            this.btnTerms.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(12, 290);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(406, 69);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Enabled = false;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnRegister.Location = new System.Drawing.Point(12, 367);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(406, 69);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblLoginResponse
            // 
            this.lblLoginResponse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLoginResponse.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoginResponse.Location = new System.Drawing.Point(223, 234);
            this.lblLoginResponse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLoginResponse.Name = "lblLoginResponse";
            this.lblLoginResponse.Size = new System.Drawing.Size(194, 51);
            this.lblLoginResponse.TabIndex = 9;
            this.lblLoginResponse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tmrResponseTimeout
            // 
            this.tmrResponseTimeout.Interval = 2500;
            this.tmrResponseTimeout.Tick += new System.EventHandler(this.tmrResponseTimeout_Tick);
            // 
            // pbxBrainVire
            // 
            this.pbxBrainVire.Image = global::ShoppingListApp.Properties.Resources.BrainVire_Logo;
            this.pbxBrainVire.Location = new System.Drawing.Point(12, 62);
            this.pbxBrainVire.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbxBrainVire.Name = "pbxBrainVire";
            this.pbxBrainVire.Size = new System.Drawing.Size(406, 83);
            this.pbxBrainVire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBrainVire.TabIndex = 11;
            this.pbxBrainVire.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 520);
            this.Controls.Add(this.pbxBrainVire);
            this.Controls.Add(this.lblLoginResponse);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnTerms);
            this.Controls.Add(this.cbxShowPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrainVire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox pbxBrainVire;
        private System.Windows.Forms.Timer tmrResponseTimeout;
    }
}