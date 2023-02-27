namespace ShoppingListApp.src.search
{
    partial class FilterForm
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.cbx_Asda = new System.Windows.Forms.CheckBox();
            this.cbx_Tesco = new System.Windows.Forms.CheckBox();
            this.cbx_Sainsburys = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.Goldenrod;
            this.btn_Close.Location = new System.Drawing.Point(42, 290);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(167, 63);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "OK";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // cbx_Asda
            // 
            this.cbx_Asda.AutoSize = true;
            this.cbx_Asda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Asda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Asda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbx_Asda.Location = new System.Drawing.Point(42, 39);
            this.cbx_Asda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Asda.Name = "cbx_Asda";
            this.cbx_Asda.Size = new System.Drawing.Size(68, 25);
            this.cbx_Asda.TabIndex = 1;
            this.cbx_Asda.Text = "Asda";
            this.cbx_Asda.UseVisualStyleBackColor = true;
            // 
            // cbx_Tesco
            // 
            this.cbx_Tesco.AutoSize = true;
            this.cbx_Tesco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Tesco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Tesco.Location = new System.Drawing.Point(42, 97);
            this.cbx_Tesco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Tesco.Name = "cbx_Tesco";
            this.cbx_Tesco.Size = new System.Drawing.Size(72, 25);
            this.cbx_Tesco.TabIndex = 2;
            this.cbx_Tesco.Text = "Tesco";
            this.cbx_Tesco.UseVisualStyleBackColor = true;
            // 
            // cbx_Sainsburys
            // 
            this.cbx_Sainsburys.AutoSize = true;
            this.cbx_Sainsburys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Sainsburys.Location = new System.Drawing.Point(42, 152);
            this.cbx_Sainsburys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Sainsburys.Name = "cbx_Sainsburys";
            this.cbx_Sainsburys.Size = new System.Drawing.Size(119, 25);
            this.cbx_Sainsburys.TabIndex = 3;
            this.cbx_Sainsburys.Text = "Sainsburys";
            this.cbx_Sainsburys.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 368);
            this.Controls.Add(this.cbx_Sainsburys);
            this.Controls.Add(this.cbx_Tesco);
            this.Controls.Add(this.cbx_Asda);
            this.Controls.Add(this.btn_Close);
            this.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FilterForm";
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Close;
        private CheckBox cbx_Asda;
        private CheckBox cbx_Tesco;
        private CheckBox cbx_Sainsburys;
    }
}