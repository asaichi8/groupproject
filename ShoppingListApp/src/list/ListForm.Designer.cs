namespace ShoppingListApp
{
    partial class FormList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
            btnWelcome = new Button();
            lblListForUser = new Label();
            SuspendLayout();
            // 
            // btnWelcome
            // 
            btnWelcome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnWelcome.Location = new Point(12, 11);
            btnWelcome.Margin = new Padding(3, 2, 3, 2);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(137, 56);
            btnWelcome.TabIndex = 0;
            btnWelcome.Text = "Return to welcome page";
            btnWelcome.UseVisualStyleBackColor = true;
            btnWelcome.Click += btnWelcome_Click;
            // 
            // lblListForUser
            // 
            lblListForUser.AutoSize = true;
            lblListForUser.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblListForUser.Location = new Point(12, 304);
            lblListForUser.Name = "lblListForUser";
            lblListForUser.Size = new Size(174, 25);
            lblListForUser.TabIndex = 1;
            lblListForUser.Text = "Showing list for user";
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(700, 338);
            Controls.Add(lblListForUser);
            Controls.Add(btnWelcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListForm";
            Load += frmList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWelcome;
        private Label lblListForUser;
    }
}