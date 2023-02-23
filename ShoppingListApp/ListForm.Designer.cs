namespace ShoppingListApp
{
    partial class frmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmList));
            btnWelcome = new Button();
            SuspendLayout();
            // 
            // btnWelcome
            // 
            btnWelcome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnWelcome.Location = new Point(-2, -2);
            btnWelcome.Margin = new Padding(3, 2, 3, 2);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(137, 56);
            btnWelcome.TabIndex = 0;
            btnWelcome.Text = "Return to welcome page";
            btnWelcome.UseVisualStyleBackColor = true;
            // 
            // frmList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(700, 338);
            Controls.Add(btnWelcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmList";
            Text = "ListForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnWelcome;
    }
}