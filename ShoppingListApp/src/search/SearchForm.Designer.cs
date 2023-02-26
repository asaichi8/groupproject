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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.wbv_Asda = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.wbv_Tesco = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.wbv_Sainsburys = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.lbl_Asda = new System.Windows.Forms.Label();
            this.lbl_Tesco = new System.Windows.Forms.Label();
            this.lbl_Sainsburys = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wbv_Asda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbv_Tesco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbv_Sainsburys)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSearch.Location = new System.Drawing.Point(10, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 49);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Return to search menu";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtSearch.Location = new System.Drawing.Point(140, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(451, 32);
            this.txtSearch.TabIndex = 4;
            // 
            // wbv_Asda
            // 
            this.wbv_Asda.AllowExternalDrop = true;
            this.wbv_Asda.CreationProperties = null;
            this.wbv_Asda.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbv_Asda.Location = new System.Drawing.Point(6, 93);
            this.wbv_Asda.Name = "wbv_Asda";
            this.wbv_Asda.Size = new System.Drawing.Size(304, 414);
            this.wbv_Asda.Source = new System.Uri("https://groceries.asda.com", System.UriKind.Absolute);
            this.wbv_Asda.TabIndex = 5;
            this.wbv_Asda.ZoomFactor = 1D;
            // 
            // wbv_Tesco
            // 
            this.wbv_Tesco.AllowExternalDrop = true;
            this.wbv_Tesco.CreationProperties = null;
            this.wbv_Tesco.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbv_Tesco.Location = new System.Drawing.Point(338, 93);
            this.wbv_Tesco.Name = "wbv_Tesco";
            this.wbv_Tesco.Size = new System.Drawing.Size(304, 414);
            this.wbv_Tesco.Source = new System.Uri("https://www.tesco.com/groceries/en-GB", System.UriKind.Absolute);
            this.wbv_Tesco.TabIndex = 6;
            this.wbv_Tesco.ZoomFactor = 1D;
            // 
            // wbv_Sainsburys
            // 
            this.wbv_Sainsburys.AllowExternalDrop = true;
            this.wbv_Sainsburys.CreationProperties = null;
            this.wbv_Sainsburys.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbv_Sainsburys.Location = new System.Drawing.Point(668, 93);
            this.wbv_Sainsburys.Name = "wbv_Sainsburys";
            this.wbv_Sainsburys.Size = new System.Drawing.Size(304, 414);
            this.wbv_Sainsburys.Source = new System.Uri("https://www.sainsburys.co.uk", System.UriKind.Absolute);
            this.wbv_Sainsburys.TabIndex = 7;
            this.wbv_Sainsburys.ZoomFactor = 1D;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(613, 18);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(103, 32);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(406, 523);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(122, 56);
            this.btn_Filter.TabIndex = 9;
            this.btn_Filter.Text = "Filter Shops";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // lbl_Asda
            // 
            this.lbl_Asda.AutoSize = true;
            this.lbl_Asda.Location = new System.Drawing.Point(137, 77);
            this.lbl_Asda.Name = "lbl_Asda";
            this.lbl_Asda.Size = new System.Drawing.Size(31, 13);
            this.lbl_Asda.TabIndex = 10;
            this.lbl_Asda.Text = "Asda";
            // 
            // lbl_Tesco
            // 
            this.lbl_Tesco.AutoSize = true;
            this.lbl_Tesco.Location = new System.Drawing.Point(473, 77);
            this.lbl_Tesco.Name = "lbl_Tesco";
            this.lbl_Tesco.Size = new System.Drawing.Size(37, 13);
            this.lbl_Tesco.TabIndex = 11;
            this.lbl_Tesco.Text = "Tesco";
            // 
            // lbl_Sainsburys
            // 
            this.lbl_Sainsburys.AutoSize = true;
            this.lbl_Sainsburys.Location = new System.Drawing.Point(794, 77);
            this.lbl_Sainsburys.Name = "lbl_Sainsburys";
            this.lbl_Sainsburys.Size = new System.Drawing.Size(58, 13);
            this.lbl_Sainsburys.TabIndex = 12;
            this.lbl_Sainsburys.Text = "Sainsburys";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.lbl_Sainsburys);
            this.Controls.Add(this.lbl_Tesco);
            this.Controls.Add(this.lbl_Asda);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.wbv_Sainsburys);
            this.Controls.Add(this.wbv_Tesco);
            this.Controls.Add(this.wbv_Asda);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.wbv_Asda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbv_Tesco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbv_Sainsburys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbv_Asda;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbv_Tesco;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbv_Sainsburys;
        private Button btn_Search;
        private Button btn_Filter;
        private Label lbl_Asda;
        private Label lbl_Tesco;
        private Label lbl_Sainsburys;
    }
}