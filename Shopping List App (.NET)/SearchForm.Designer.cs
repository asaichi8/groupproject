namespace Shopping_List_App__.NET_
{
    partial class frm_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Search));
            this.wv_Asda = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.wv_Tesco = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.wv_Sainsburys = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btn_Return = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ChangeOptions = new System.Windows.Forms.Button();
            this.lbl_Asda = new System.Windows.Forms.Label();
            this.lbl_Tesco = new System.Windows.Forms.Label();
            this.lbl_Sainsburys = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wv_Asda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wv_Tesco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wv_Sainsburys)).BeginInit();
            this.SuspendLayout();
            // 
            // wv_Asda
            // 
            this.wv_Asda.AllowExternalDrop = true;
            this.wv_Asda.CreationProperties = null;
            this.wv_Asda.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv_Asda.Location = new System.Drawing.Point(11, 108);
            this.wv_Asda.Margin = new System.Windows.Forms.Padding(2);
            this.wv_Asda.Name = "wv_Asda";
            this.wv_Asda.Size = new System.Drawing.Size(332, 436);
            this.wv_Asda.Source = new System.Uri("https://groceries.asda.com/search/bread/products?sort=price+asc", System.UriKind.Absolute);
            this.wv_Asda.TabIndex = 0;
            this.wv_Asda.ZoomFactor = 1D;
            // 
            // wv_Tesco
            // 
            this.wv_Tesco.AllowExternalDrop = true;
            this.wv_Tesco.CreationProperties = null;
            this.wv_Tesco.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv_Tesco.Location = new System.Drawing.Point(358, 108);
            this.wv_Tesco.Margin = new System.Windows.Forms.Padding(2);
            this.wv_Tesco.Name = "wv_Tesco";
            this.wv_Tesco.Size = new System.Drawing.Size(326, 436);
            this.wv_Tesco.Source = new System.Uri("https://www.tesco.com/groceries/en-GB/search?query=Bread&icid=tescohp_sws-1_m-ft_" +
        "in-Bread_ab-226-b_out-Bread&sortBy=price-ascending", System.UriKind.Absolute);
            this.wv_Tesco.TabIndex = 1;
            this.wv_Tesco.ZoomFactor = 1D;
            // 
            // wv_Sainsburys
            // 
            this.wv_Sainsburys.AllowExternalDrop = true;
            this.wv_Sainsburys.CreationProperties = null;
            this.wv_Sainsburys.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv_Sainsburys.Location = new System.Drawing.Point(697, 108);
            this.wv_Sainsburys.Margin = new System.Windows.Forms.Padding(2);
            this.wv_Sainsburys.Name = "wv_Sainsburys";
            this.wv_Sainsburys.Size = new System.Drawing.Size(317, 436);
            this.wv_Sainsburys.Source = new System.Uri("https://www.sainsburys.co.uk/gol-ui/SearchResults/bread/category:/sort:price", System.UriKind.Absolute);
            this.wv_Sainsburys.TabIndex = 2;
            this.wv_Sainsburys.ZoomFactor = 1D;
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(12, 12);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(137, 55);
            this.btn_Return.TabIndex = 3;
            this.btn_Return.Text = "Return to search menu";
            this.btn_Return.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(808, 23);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(154, 41);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(201, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(558, 29);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Enter product name here...";
            // 
            // btn_ChangeOptions
            // 
            this.btn_ChangeOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeOptions.Location = new System.Drawing.Point(444, 553);
            this.btn_ChangeOptions.Name = "btn_ChangeOptions";
            this.btn_ChangeOptions.Size = new System.Drawing.Size(157, 48);
            this.btn_ChangeOptions.TabIndex = 6;
            this.btn_ChangeOptions.Text = "Change shop options";
            this.btn_ChangeOptions.UseVisualStyleBackColor = true;
            // 
            // lbl_Asda
            // 
            this.lbl_Asda.AutoSize = true;
            this.lbl_Asda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Asda.Location = new System.Drawing.Point(132, 88);
            this.lbl_Asda.Name = "lbl_Asda";
            this.lbl_Asda.Size = new System.Drawing.Size(46, 20);
            this.lbl_Asda.TabIndex = 7;
            this.lbl_Asda.Text = "Asda";
            // 
            // lbl_Tesco
            // 
            this.lbl_Tesco.AutoSize = true;
            this.lbl_Tesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tesco.Location = new System.Drawing.Point(494, 88);
            this.lbl_Tesco.Name = "lbl_Tesco";
            this.lbl_Tesco.Size = new System.Drawing.Size(52, 20);
            this.lbl_Tesco.TabIndex = 8;
            this.lbl_Tesco.Text = "Tesco";
            // 
            // lbl_Sainsburys
            // 
            this.lbl_Sainsburys.AutoSize = true;
            this.lbl_Sainsburys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sainsburys.Location = new System.Drawing.Point(823, 86);
            this.lbl_Sainsburys.Name = "lbl_Sainsburys";
            this.lbl_Sainsburys.Size = new System.Drawing.Size(87, 20);
            this.lbl_Sainsburys.TabIndex = 9;
            this.lbl_Sainsburys.Text = "Sainsburys";
            // 
            // frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 609);
            this.Controls.Add(this.lbl_Sainsburys);
            this.Controls.Add(this.lbl_Tesco);
            this.Controls.Add(this.lbl_Asda);
            this.Controls.Add(this.btn_ChangeOptions);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.wv_Sainsburys);
            this.Controls.Add(this.wv_Tesco);
            this.Controls.Add(this.wv_Asda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Search";
            this.Text = "Search for an item";
            ((System.ComponentModel.ISupportInitialize)(this.wv_Asda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wv_Tesco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wv_Sainsburys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wv_Asda;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv_Tesco;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv_Sainsburys;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ChangeOptions;
        private System.Windows.Forms.Label lbl_Asda;
        private System.Windows.Forms.Label lbl_Tesco;
        private System.Windows.Forms.Label lbl_Sainsburys;
    }
}

