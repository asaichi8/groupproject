namespace ShoppingListApp
{
    partial class frm_HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HomePage));
            this.lbl_WelcomeMessage = new System.Windows.Forms.Label();
            this.pbx_UFix = new System.Windows.Forms.PictureBox();
            this.pbx_BrainVire = new System.Windows.Forms.PictureBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_ToList = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UFix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BrainVire)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_WelcomeMessage
            // 
            this.lbl_WelcomeMessage.AutoSize = true;
            this.lbl_WelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_WelcomeMessage.Location = new System.Drawing.Point(70, 9);
            this.lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
            this.lbl_WelcomeMessage.Size = new System.Drawing.Size(646, 31);
            this.lbl_WelcomeMessage.TabIndex = 0;
            this.lbl_WelcomeMessage.Text = "Welcome to the Brainvire Ltd. Shopping Comparison Program.";
            // 
            // pbx_UFix
            // 
            this.pbx_UFix.Image = ((System.Drawing.Image)(resources.GetObject("pbx_UFix.Image")));
            this.pbx_UFix.Location = new System.Drawing.Point(110, 59);
            this.pbx_UFix.Name = "pbx_UFix";
            this.pbx_UFix.Size = new System.Drawing.Size(120, 149);
            this.pbx_UFix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_UFix.TabIndex = 1;
            this.pbx_UFix.TabStop = false;
            // 
            // pbx_BrainVire
            // 
            this.pbx_BrainVire.Image = ((System.Drawing.Image)(resources.GetObject("pbx_BrainVire.Image")));
            this.pbx_BrainVire.Location = new System.Drawing.Point(492, 92);
            this.pbx_BrainVire.Name = "pbx_BrainVire";
            this.pbx_BrainVire.Size = new System.Drawing.Size(256, 116);
            this.pbx_BrainVire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_BrainVire.TabIndex = 2;
            this.pbx_BrainVire.TabStop = false;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Search.Location = new System.Drawing.Point(185, 230);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(363, 38);
            this.txt_Search.TabIndex = 3;
            this.txt_Search.Text = "Enter product name here...";
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // btn_ToList
            // 
            this.btn_ToList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ToList.Location = new System.Drawing.Point(48, 300);
            this.btn_ToList.Name = "btn_ToList";
            this.btn_ToList.Size = new System.Drawing.Size(228, 89);
            this.btn_ToList.TabIndex = 4;
            this.btn_ToList.Text = "Go to shopping list";
            this.btn_ToList.UseVisualStyleBackColor = true;
            this.btn_ToList.Click += new System.EventHandler(this.btn_ToList_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Filter.Location = new System.Drawing.Point(520, 300);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(228, 89);
            this.btn_Filter.TabIndex = 5;
            this.btn_Filter.Text = "Filter Shops";
            this.btn_Filter.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(554, 234);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(141, 34);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_ToList);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.pbx_BrainVire);
            this.Controls.Add(this.pbx_UFix);
            this.Controls.Add(this.lbl_WelcomeMessage);
            this.Name = "frm_HomePage";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_UFix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_BrainVire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_WelcomeMessage;
        private PictureBox pbx_UFix;
        private PictureBox pbx_BrainVire;
        private TextBox txt_Search;
        private Button btn_ToList;
        private Button btn_Filter;
        private Button btn_Search;
    }
}