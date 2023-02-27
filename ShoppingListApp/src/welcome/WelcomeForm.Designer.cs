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
            this.lblWelcomeMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lblWelcomeMessage.Location = new System.Drawing.Point(95, 11);
            this.lblWelcomeMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(783, 38);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Welcome to the Brainvire Ltd. Shopping Comparison Program.";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtSearch.Location = new System.Drawing.Point(254, 286);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(498, 44);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnToList
            // 
            this.btnToList.BackColor = System.Drawing.Color.Goldenrod;
            this.btnToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToList.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToList.ForeColor = System.Drawing.Color.White;
            this.btnToList.Location = new System.Drawing.Point(16, 375);
            this.btnToList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(556, 195);
            this.btnToList.TabIndex = 3;
            this.btnToList.Text = "Go to shopping list";
            this.btnToList.UseVisualStyleBackColor = false;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Goldenrod;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(596, 375);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(530, 195);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter Shops";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSearch.Location = new System.Drawing.Point(762, 286);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(193, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblUsername.Location = new System.Drawing.Point(32, 574);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 31);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "User:";
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(959, 585);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(166, 58);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbxBrainVire
            // 
            this.pbxBrainVire.Image = global::ShoppingListApp.Properties.Resources.BrainVire_Logo;
            this.pbxBrainVire.Location = new System.Drawing.Point(677, 115);
            this.pbxBrainVire.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbxBrainVire.Name = "pbxBrainVire";
            this.pbxBrainVire.Size = new System.Drawing.Size(352, 144);
            this.pbxBrainVire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBrainVire.TabIndex = 2;
            this.pbxBrainVire.TabStop = false;
            // 
            // pbxUFix
            // 
            this.pbxUFix.Image = global::ShoppingListApp.Properties.Resources.UFix_Logo;
            this.pbxUFix.Location = new System.Drawing.Point(150, 72);
            this.pbxUFix.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbxUFix.Name = "pbxUFix";
            this.pbxUFix.Size = new System.Drawing.Size(165, 186);
            this.pbxUFix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUFix.TabIndex = 1;
            this.pbxUFix.TabStop = false;
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 660);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnToList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pbxBrainVire);
            this.Controls.Add(this.pbxUFix);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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