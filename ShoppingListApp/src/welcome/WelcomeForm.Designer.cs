namespace ShoppingListApp
{
    partial class frmHomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            lblWelcomeMessage = new Label();
            pbxUFix = new PictureBox();
            pbxBrainVire = new PictureBox();
            txtSearch = new TextBox();
            btnToList = new Button();
            btnFilter = new Button();
            btnSearch = new Button();
            lblUsername = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxUFix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBrainVire).BeginInit();
            SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcomeMessage.Location = new Point(61, 7);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(534, 25);
            lblWelcomeMessage.TabIndex = 0;
            lblWelcomeMessage.Text = "Welcome to the Brainvire Ltd. Shopping Comparison Program.";
            // 
            // pbxUFix
            // 
            pbxUFix.Image = (Image)resources.GetObject("pbxUFix.Image");
            pbxUFix.Location = new Point(96, 44);
            pbxUFix.Margin = new Padding(3, 2, 3, 2);
            pbxUFix.Name = "pbxUFix";
            pbxUFix.Size = new Size(105, 112);
            pbxUFix.SizeMode = PictureBoxSizeMode.Zoom;
            pbxUFix.TabIndex = 1;
            pbxUFix.TabStop = false;
            // 
            // pbxBrainVire
            // 
            pbxBrainVire.Image = (Image)resources.GetObject("pbxBrainVire.Image");
            pbxBrainVire.Location = new Point(430, 69);
            pbxBrainVire.Margin = new Padding(3, 2, 3, 2);
            pbxBrainVire.Name = "pbxBrainVire";
            pbxBrainVire.Size = new Size(224, 87);
            pbxBrainVire.SizeMode = PictureBoxSizeMode.Zoom;
            pbxBrainVire.TabIndex = 2;
            pbxBrainVire.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(162, 172);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(318, 32);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Enter product name here...";
            txtSearch.TextChanged += txt_Search_TextChanged;
            // 
            // btnToList
            // 
            btnToList.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnToList.Location = new Point(42, 225);
            btnToList.Margin = new Padding(3, 2, 3, 2);
            btnToList.Name = "btnToList";
            btnToList.Size = new Size(200, 67);
            btnToList.TabIndex = 3;
            btnToList.Text = "Go to shopping list";
            btnToList.UseVisualStyleBackColor = true;
            btnToList.Click += btn_ToList_Click;
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilter.Location = new Point(455, 225);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(200, 67);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter Shops";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(485, 176);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(123, 26);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btn_Search_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(12, 309);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(41, 20);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "User:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(582, 297);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(106, 35);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(700, 338);
            Controls.Add(btnLogout);
            Controls.Add(lblUsername);
            Controls.Add(btnSearch);
            Controls.Add(btnFilter);
            Controls.Add(btnToList);
            Controls.Add(txtSearch);
            Controls.Add(pbxBrainVire);
            Controls.Add(pbxUFix);
            Controls.Add(lblWelcomeMessage);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += frmHomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pbxUFix).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBrainVire).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeMessage;
        private PictureBox pbxUFix;
        private PictureBox pbxBrainVire;
        private TextBox txtSearch;
        private Button btnToList;
        private Button btnFilter;
        private Button btnSearch;
        private Label lblUsername;
        private Button btnLogout;
    }
}