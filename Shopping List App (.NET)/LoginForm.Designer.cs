namespace Shopping_List_App__.NET_
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Terms = new System.Windows.Forms.Button();
            this.cbx_ShowPass = new System.Windows.Forms.CheckBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(158, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(40, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Sign In";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(27, 38);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(58, 13);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "Username:";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(27, 77);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(56, 13);
            this.lbl_Pass.TabIndex = 2;
            this.lbl_Pass.Text = "Password:";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(111, 103);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(148, 36);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Terms
            // 
            this.btn_Terms.Location = new System.Drawing.Point(282, 9);
            this.btn_Terms.Name = "btn_Terms";
            this.btn_Terms.Size = new System.Drawing.Size(97, 38);
            this.btn_Terms.TabIndex = 4;
            this.btn_Terms.Text = "Terms of Service?";
            this.btn_Terms.UseVisualStyleBackColor = true;
            // 
            // cbx_ShowPass
            // 
            this.cbx_ShowPass.AutoSize = true;
            this.cbx_ShowPass.Location = new System.Drawing.Point(271, 77);
            this.cbx_ShowPass.Name = "cbx_ShowPass";
            this.cbx_ShowPass.Size = new System.Drawing.Size(108, 17);
            this.cbx_ShowPass.TabIndex = 5;
            this.cbx_ShowPass.Text = "Show Password?";
            this.cbx_ShowPass.UseVisualStyleBackColor = true;
            this.cbx_ShowPass.CheckedChanged += new System.EventHandler(this.cbx_ShowPass_CheckedChanged);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(91, 35);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(168, 20);
            this.txt_User.TabIndex = 6;
            this.txt_User.TextChanged += new System.EventHandler(this.txt_User_TextChanged);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(91, 74);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '•';
            this.txt_Pass.Size = new System.Drawing.Size(168, 20);
            this.txt_Pass.TabIndex = 7;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(389, 151);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.cbx_ShowPass);
            this.Controls.Add(this.btn_Terms);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.Text = "Please Sign In";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Terms;
        private System.Windows.Forms.CheckBox cbx_ShowPass;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Pass;
    }
}