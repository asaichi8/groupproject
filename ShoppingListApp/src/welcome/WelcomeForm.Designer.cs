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
            this.lblBeginSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrainVire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUFix)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(24, 24);
            this.lblWelcomeMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(580, 28);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Welcome to the Brainvire Ltd. Shopping Comparison Program.";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtSearch.Location = new System.Drawing.Point(129, 309);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(450, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnToList
            // 
            this.btnToList.BackColor = System.Drawing.Color.Goldenrod;
            this.btnToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToList.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnToList.ForeColor = System.Drawing.Color.White;
            this.btnToList.Location = new System.Drawing.Point(14, 375);
            this.btnToList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(335, 81);
            this.btnToList.TabIndex = 3;
            this.btnToList.Text = "Go to shopping list";
            this.btnToList.UseVisualStyleBackColor = false;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Goldenrod;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(356, 375);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(335, 81);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter shops";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSearch.Location = new System.Drawing.Point(586, 309);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "🔎";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblUsername.Location = new System.Drawing.Point(14, 497);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(298, 20);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "IF YOU CAN SEE THIS, AN ERROR OCCURED";
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(525, 479);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(166, 38);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbxBrainVire
            // 
            this.pbxBrainVire.Image = global::ShoppingListApp.Properties.Resources.BrainVire_Logo;
            this.pbxBrainVire.Location = new System.Drawing.Point(312, 104);
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
            this.pbxUFix.Location = new System.Drawing.Point(46, 79);
            this.pbxUFix.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbxUFix.Name = "pbxUFix";
            this.pbxUFix.Size = new System.Drawing.Size(165, 186);
            this.pbxUFix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUFix.TabIndex = 1;
            this.pbxUFix.TabStop = false;
            // 
            // lblBeginSearch
            // 
            this.lblBeginSearch.AutoSize = true;
            this.lblBeginSearch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeginSearch.Location = new System.Drawing.Point(14, 314);
            this.lblBeginSearch.Name = "lblBeginSearch";
            this.lblBeginSearch.Size = new System.Drawing.Size(111, 21);
            this.lblBeginSearch.TabIndex = 8;
            this.lblBeginSearch.Text = "Begin search:";
            // 
            // FormHomePage
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 528);
            this.Controls.Add(this.lblBeginSearch);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHomePage_FormClosing);
            this.Load += new System.EventHandler(this.frmHomePage_Load);
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
        private Label lblBeginSearch;
    }
}