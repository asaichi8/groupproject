namespace ShoppingListApp
{
    partial class ListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.btn_welcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_welcome
            // 
            this.btn_welcome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_welcome.Location = new System.Drawing.Point(-2, -3);
            this.btn_welcome.Name = "btn_welcome";
            this.btn_welcome.Size = new System.Drawing.Size(157, 74);
            this.btn_welcome.TabIndex = 0;
            this.btn_welcome.Text = "Return to welcome page";
            this.btn_welcome.UseVisualStyleBackColor = true;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_welcome;
    }
}