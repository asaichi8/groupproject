namespace Shopping_List_App__.NET_
{
    partial class frm_HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HomePage));
            this.btn_ToList = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.pbx_Ufix = new System.Windows.Forms.PictureBox();
            this.pbx_Brainvire = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ufix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Brainvire)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ToList
            // 
            this.btn_ToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ToList.Location = new System.Drawing.Point(42, 225);
            this.btn_ToList.Name = "btn_ToList";
            this.btn_ToList.Size = new System.Drawing.Size(200, 67);
            this.btn_ToList.TabIndex = 0;
            this.btn_ToList.Text = "Go to shopping list";
            this.btn_ToList.UseVisualStyleBackColor = true;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filter.Location = new System.Drawing.Point(455, 225);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(200, 67);
            this.btn_Filter.TabIndex = 1;
            this.btn_Filter.Text = "Filter Shops";
            this.btn_Filter.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(485, 176);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(123, 26);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(162, 172);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(318, 29);
            this.txt_Search.TabIndex = 3;
            this.txt_Search.Text = "Enter product name here...";
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.Location = new System.Drawing.Point(76, 9);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(531, 24);
            this.lbl_Message.TabIndex = 4;
            this.lbl_Message.Text = "Welcome to the Brainvire Ltd. Shopping Comparison Program.";
            // 
            // pbx_Ufix
            // 
            this.pbx_Ufix.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Ufix.Image")));
            this.pbx_Ufix.Location = new System.Drawing.Point(96, 44);
            this.pbx_Ufix.Name = "pbx_Ufix";
            this.pbx_Ufix.Size = new System.Drawing.Size(105, 112);
            this.pbx_Ufix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Ufix.TabIndex = 5;
            this.pbx_Ufix.TabStop = false;
            // 
            // pbx_Brainvire
            // 
            this.pbx_Brainvire.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Brainvire.Image")));
            this.pbx_Brainvire.Location = new System.Drawing.Point(431, 69);
            this.pbx_Brainvire.Name = "pbx_Brainvire";
            this.pbx_Brainvire.Size = new System.Drawing.Size(224, 87);
            this.pbx_Brainvire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Brainvire.TabIndex = 6;
            this.pbx_Brainvire.TabStop = false;
            // 
            // frm_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.pbx_Brainvire);
            this.Controls.Add(this.pbx_Ufix);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_ToList);
            this.Name = "frm_HomePage";
            this.Text = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Ufix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Brainvire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ToList;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.PictureBox pbx_Ufix;
        private System.Windows.Forms.PictureBox pbx_Brainvire;
    }
}