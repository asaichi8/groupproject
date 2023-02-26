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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.wbv_Shop1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.wbv_Shop2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wbv_Shop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbv_Shop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
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
            // wbv_Shop1
            // 
            this.wbv_Shop1.AllowExternalDrop = true;
            this.wbv_Shop1.CreationProperties = null;
            this.wbv_Shop1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbv_Shop1.Location = new System.Drawing.Point(12, 93);
            this.wbv_Shop1.Name = "wbv_Shop1";
            this.wbv_Shop1.Size = new System.Drawing.Size(264, 414);
            this.wbv_Shop1.TabIndex = 5;
            this.wbv_Shop1.ZoomFactor = 1D;
            // 
            // wbv_Shop2
            // 
            this.wbv_Shop2.AllowExternalDrop = true;
            this.wbv_Shop2.CreationProperties = null;
            this.wbv_Shop2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbv_Shop2.Location = new System.Drawing.Point(321, 93);
            this.wbv_Shop2.Name = "wbv_Shop2";
            this.wbv_Shop2.Size = new System.Drawing.Size(285, 414);
            this.wbv_Shop2.TabIndex = 6;
            this.wbv_Shop2.ZoomFactor = 1D;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(641, 93);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(288, 414);
            this.webView21.TabIndex = 7;
            this.webView21.ZoomFactor = 1D;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(613, 18);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(103, 32);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
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
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(936, 591);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.wbv_Shop2);
            this.Controls.Add(this.wbv_Shop1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.wbv_Shop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbv_Shop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbv_Shop1;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbv_Shop2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btn_Search;
        private Button btn_Filter;
    }
}