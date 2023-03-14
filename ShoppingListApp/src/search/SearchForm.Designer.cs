﻿namespace ShoppingListApp
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
            this.wbvSainsburys = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblAsda = new System.Windows.Forms.Label();
            this.lblTesco = new System.Windows.Forms.Label();
            this.lblSainsburys = new System.Windows.Forms.Label();
            this.btnAddAsda = new System.Windows.Forms.Button();
            this.btnAddTesco = new System.Windows.Forms.Button();
            this.btnAddSains = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbxTesco = new System.Windows.Forms.PictureBox();
            this.lblTescoName = new System.Windows.Forms.Label();
            this.lblTescoPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wbvAsda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbvSainsburys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTesco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1091, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(218, 75);
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
            this.txtSearch.Size = new System.Drawing.Size(694, 43);
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
            this.btnFilter.Size = new System.Drawing.Size(248, 43);
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
            this.lblAsda.Size = new System.Drawing.Size(49, 23);
            this.lblAsda.TabIndex = 10;
            this.lblAsda.Text = "Asda";
            // 
            // lblTesco
            // 
            this.lblTesco.AutoSize = true;
            this.lblTesco.Location = new System.Drawing.Point(491, 76);
            this.lblTesco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTesco.Name = "lblTesco";
            this.lblTesco.Size = new System.Drawing.Size(52, 23);
            this.lblTesco.TabIndex = 11;
            this.lblTesco.Text = "Tesco";
            // 
            // lblSainsburys
            // 
            this.lblSainsburys.AutoSize = true;
            this.lblSainsburys.Location = new System.Drawing.Point(972, 76);
            this.lblSainsburys.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSainsburys.Name = "lblSainsburys";
            this.lblSainsburys.Size = new System.Drawing.Size(96, 23);
            this.lblSainsburys.TabIndex = 12;
            this.lblSainsburys.Text = "Sainsburys";
            // 
            // btnAddAsda
            // 
            this.btnAddAsda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAsda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAsda.Location = new System.Drawing.Point(156, 752);
            this.btnAddAsda.Name = "btnAddAsda";
            this.btnAddAsda.Size = new System.Drawing.Size(175, 47);
            this.btnAddAsda.TabIndex = 13;
            this.btnAddAsda.Text = "Add to list";
            this.btnAddAsda.UseVisualStyleBackColor = true;
            // 
            // btnAddTesco
            // 
            this.btnAddTesco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTesco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTesco.Location = new System.Drawing.Point(648, 752);
            this.btnAddTesco.Name = "btnAddTesco";
            this.btnAddTesco.Size = new System.Drawing.Size(175, 47);
            this.btnAddTesco.TabIndex = 14;
            this.btnAddTesco.Text = "Add to list";
            this.btnAddTesco.UseVisualStyleBackColor = true;
            // 
            // btnAddSains
            // 
            this.btnAddSains.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSains.Location = new System.Drawing.Point(1134, 750);
            this.btnAddSains.Name = "btnAddSains";
            this.btnAddSains.Size = new System.Drawing.Size(175, 47);
            this.btnAddSains.TabIndex = 15;
            this.btnAddSains.Text = "Add to list";
            this.btnAddSains.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(592, 413);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 30);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(592, 462);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 30);
            this.textBox2.TabIndex = 17;
            // 
            // pbxTesco
            // 
            this.pbxTesco.Location = new System.Drawing.Point(524, 102);
            this.pbxTesco.Name = "pbxTesco";
            this.pbxTesco.Size = new System.Drawing.Size(410, 295);
            this.pbxTesco.TabIndex = 18;
            this.pbxTesco.TabStop = false;
            // 
            // lblTescoName
            // 
            this.lblTescoName.AutoSize = true;
            this.lblTescoName.Location = new System.Drawing.Point(524, 416);
            this.lblTescoName.Name = "lblTescoName";
            this.lblTescoName.Size = new System.Drawing.Size(62, 23);
            this.lblTescoName.TabIndex = 19;
            this.lblTescoName.Text = "Name:";
            // 
            // lblTescoPrice
            // 
            this.lblTescoPrice.AutoSize = true;
            this.lblTescoPrice.Location = new System.Drawing.Point(532, 465);
            this.lblTescoPrice.Name = "lblTescoPrice";
            this.lblTescoPrice.Size = new System.Drawing.Size(54, 23);
            this.lblTescoPrice.TabIndex = 20;
            this.lblTescoPrice.Text = "Price:";
            // 
            // FormSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1458, 809);
            this.Controls.Add(this.lblTescoPrice);
            this.Controls.Add(this.lblTescoName);
            this.Controls.Add(this.pbxTesco);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddSains);
            this.Controls.Add(this.btnAddTesco);
            this.Controls.Add(this.btnAddAsda);
            this.Controls.Add(this.lblSainsburys);
            this.Controls.Add(this.lblTesco);
            this.Controls.Add(this.lblAsda);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.wbvSainsburys);
            this.Controls.Add(this.wbvAsda);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.wbvAsda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbvSainsburys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTesco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private TextBox txtSearch;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbvAsda;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbvSainsburys;
        private Button btnSearch;
        private Button btnFilter;
        private Label lblAsda;
        private Label lblTesco;
        private Label lblSainsburys;
        private Button btnAddAsda;
        private Button btnAddTesco;
        private Button btnAddSains;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pbxTesco;
        private Label lblTescoName;
        private Label lblTescoPrice;
    }
}