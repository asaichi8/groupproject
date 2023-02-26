namespace ShoppingListApp
{
    partial class FormHomePage
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
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnToList = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbxBrainVire = new System.Windows.Forms.PictureBox();
            this.pbxUFix = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrainVire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUFix)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lblWelcomeMessage.Location = new System.Drawing.Point(52, 6);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(534, 25);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Welcome to the Brainvire Ltd. Shopping Comparison Program.";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtSearch.Location = new System.Drawing.Point(139, 149);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 32);
            this.txtSearch.TabIndex = 1;
            // 
            // btnToList
            // 
            this.btnToList.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btnToList.Location = new System.Drawing.Point(36, 195);
            this.btnToList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(171, 58);
            this.btnToList.TabIndex = 3;
            this.btnToList.Text = "Go to shopping list";
            this.btnToList.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btnFilter.Location = new System.Drawing.Point(390, 195);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(171, 58);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter Shops";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(416, 153);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblUsername.Location = new System.Drawing.Point(10, 268);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(41, 20);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "User:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(499, 257);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // pbxBrainVire
            // 
            this.pbxBrainVire.Image = global::ShoppingListApp.Properties.Resources.BrainVire_Logo;
            this.pbxBrainVire.Location = new System.Drawing.Point(369, 60);
            this.pbxBrainVire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxBrainVire.Name = "pbxBrainVire";
            this.pbxBrainVire.Size = new System.Drawing.Size(192, 75);
            this.pbxBrainVire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBrainVire.TabIndex = 2;
            this.pbxBrainVire.TabStop = false;
            // 
            // pbxUFix
            // 
            this.pbxUFix.Image = global::ShoppingListApp.Properties.Resources.UFix_Logo;
            this.pbxUFix.Location = new System.Drawing.Point(82, 38);
            this.pbxUFix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxUFix.Name = "pbxUFix";
            this.pbxUFix.Size = new System.Drawing.Size(90, 97);
            this.pbxUFix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUFix.TabIndex = 1;
            this.pbxUFix.TabStop = false;
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(600, 293);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnToList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pbxBrainVire);
            this.Controls.Add(this.pbxUFix);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrainVire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUFix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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