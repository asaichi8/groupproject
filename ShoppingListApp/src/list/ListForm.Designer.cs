﻿namespace ShoppingListApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblListForUser = new System.Windows.Forms.Label();
            this.chrtShops = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtShops)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(-4, 577);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(570, 88);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "< Return to welcome page";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblListForUser
            // 
            this.lblListForUser.AutoSize = true;
            this.lblListForUser.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListForUser.ForeColor = System.Drawing.Color.White;
            this.lblListForUser.Location = new System.Drawing.Point(14, 9);
            this.lblListForUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblListForUser.Name = "lblListForUser";
            this.lblListForUser.Size = new System.Drawing.Size(361, 23);
            this.lblListForUser.TabIndex = 1;
            this.lblListForUser.Text = "IF YOU CAN SEE THIS, AN ERROR OCCURED";
            // 
            // chrtShops
            // 
            this.chrtShops.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea1.Name = "ChartArea1";
            this.chrtShops.ChartAreas.Add(chartArea1);
            this.chrtShops.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chrtShops.Legends.Add(legend1);
            this.chrtShops.Location = new System.Drawing.Point(564, 0);
            this.chrtShops.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.chrtShops.Name = "chrtShops";
            this.chrtShops.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtShops.Series.Add(series1);
            this.chrtShops.Size = new System.Drawing.Size(501, 665);
            this.chrtShops.TabIndex = 2;
            this.chrtShops.Text = "chrt_Shops";
            this.chrtShops.Click += new System.EventHandler(this.chrtShops_Click);
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 23;
            this.lbxList.Location = new System.Drawing.Point(59, 186);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(422, 257);
            this.lbxList.TabIndex = 3;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(55, 458);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(98, 23);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(1065, 665);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.chrtShops);
            this.Controls.Add(this.lblListForUser);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Your list";
            this.Load += new System.EventHandler(this.frmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtShops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReturn;
        private Label lblListForUser;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtShops;
        private ListBox lbxList;
        private Label lblTotalPrice;
    }
}