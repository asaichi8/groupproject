namespace ShoppingListApp
{
    partial class FormList
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.lblListForUser = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWelcome
            // 
            this.btnWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWelcome.FlatAppearance.BorderSize = 0;
            this.btnWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcome.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcome.ForeColor = System.Drawing.Color.White;
            this.btnWelcome.Location = new System.Drawing.Point(14, 13);
            this.btnWelcome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(379, 88);
            this.btnWelcome.TabIndex = 0;
            this.btnWelcome.Text = "< Return to welcome page";
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // lblListForUser
            // 
            this.lblListForUser.AutoSize = true;
            this.lblListForUser.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListForUser.ForeColor = System.Drawing.Color.White;
            this.lblListForUser.Location = new System.Drawing.Point(9, 923);
            this.lblListForUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblListForUser.Name = "lblListForUser";
            this.lblListForUser.Size = new System.Drawing.Size(296, 19);
            this.lblListForUser.TabIndex = 1;
            this.lblListForUser.Text = "IF YOU CAN SEE THIS, AN ERROR OCCURED";
            // 
            // chart1
            // 
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(678, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(628, 970);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chrt_Shops";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1306, 970);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblListForUser);
            this.Controls.Add(this.btnWelcome);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListForm";
            this.Load += new System.EventHandler(this.frmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnWelcome;
        private Label lblListForUser;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}