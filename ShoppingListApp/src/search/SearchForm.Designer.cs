namespace ShoppingListApp
{
    partial class FormSearch
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.wbvAsda = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.wbvTesco = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.wbvSainsburys = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblAsda = new System.Windows.Forms.Label();
            this.lblTesco = new System.Windows.Forms.Label();
            this.lblSainsburys = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wbvAsda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbvTesco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbvSainsburys)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1208, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(236, 57);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Return to search menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.txtSearch.Location = new System.Drawing.Point(270, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(694, 34);
            this.txtSearch.TabIndex = 4;
            // 
            // wbvAsda
            // 
            this.wbvAsda.AllowExternalDrop = true;
            this.wbvAsda.CreationProperties = null;
            this.wbvAsda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wbvAsda.DefaultBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.wbvAsda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wbvAsda.Location = new System.Drawing.Point(14, 102);
            this.wbvAsda.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.wbvAsda.Name = "wbvAsda";
            this.wbvAsda.Size = new System.Drawing.Size(471, 640);
            this.wbvAsda.Source = new System.Uri("https://groceries.asda.com", System.UriKind.Absolute);
            this.wbvAsda.TabIndex = 5;
            this.wbvAsda.ZoomFactor = 1D;
            // 
            // wbvTesco
            // 
            this.wbvTesco.AllowExternalDrop = true;
            this.wbvTesco.CreationProperties = null;
            this.wbvTesco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wbvTesco.DefaultBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.wbvTesco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wbvTesco.Location = new System.Drawing.Point(495, 102);
            this.wbvTesco.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.wbvTesco.Name = "wbvTesco";
            this.wbvTesco.Size = new System.Drawing.Size(471, 640);
            this.wbvTesco.Source = new System.Uri("https://www.tesco.com/groceries/en-GB", System.UriKind.Absolute);
            this.wbvTesco.TabIndex = 6;
            this.wbvTesco.ZoomFactor = 1D;
            // 
            // wbvSainsburys
            // 
            this.wbvSainsburys.AllowExternalDrop = true;
            this.wbvSainsburys.CreationProperties = null;
            this.wbvSainsburys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wbvSainsburys.DefaultBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.wbvSainsburys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wbvSainsburys.Location = new System.Drawing.Point(976, 102);
            this.wbvSainsburys.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.wbvSainsburys.Name = "wbvSainsburys";
            this.wbvSainsburys.Size = new System.Drawing.Size(471, 640);
            this.wbvSainsburys.Source = new System.Uri("https://www.sainsburys.co.uk", System.UriKind.Absolute);
            this.wbvSainsburys.TabIndex = 7;
            this.wbvSainsburys.ZoomFactor = 1D;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(974, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 34);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "🔎 Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Goldenrod;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(14, 16);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(248, 34);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter Shops";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblAsda
            // 
            this.lblAsda.AutoSize = true;
            this.lblAsda.Location = new System.Drawing.Point(10, 76);
            this.lblAsda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAsda.Name = "lblAsda";
            this.lblAsda.Size = new System.Drawing.Size(42, 19);
            this.lblAsda.TabIndex = 10;
            this.lblAsda.Text = "Asda";
            // 
            // lblTesco
            // 
            this.lblTesco.AutoSize = true;
            this.lblTesco.Location = new System.Drawing.Point(491, 76);
            this.lblTesco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTesco.Name = "lblTesco";
            this.lblTesco.Size = new System.Drawing.Size(46, 19);
            this.lblTesco.TabIndex = 11;
            this.lblTesco.Text = "Tesco";
            // 
            // lblSainsburys
            // 
            this.lblSainsburys.AutoSize = true;
            this.lblSainsburys.Location = new System.Drawing.Point(972, 76);
            this.lblSainsburys.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSainsburys.Name = "lblSainsburys";
            this.lblSainsburys.Size = new System.Drawing.Size(81, 19);
            this.lblSainsburys.TabIndex = 12;
            this.lblSainsburys.Text = "Sainsburys";
            // 
            // FormSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1458, 756);
            this.Controls.Add(this.lblSainsburys);
            this.Controls.Add(this.lblTesco);
            this.Controls.Add(this.lblAsda);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.wbvSainsburys);
            this.Controls.Add(this.wbvTesco);
            this.Controls.Add(this.wbvAsda);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSearch_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.wbvAsda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbvTesco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbvSainsburys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private TextBox txtSearch;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbvAsda;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbvTesco;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbvSainsburys;
        private Button btnSearch;
        private Button btnFilter;
        private Label lblAsda;
        private Label lblTesco;
        private Label lblSainsburys;
    }
}