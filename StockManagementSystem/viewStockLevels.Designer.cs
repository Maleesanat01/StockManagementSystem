namespace StockManagementSystem
{
    partial class viewStockLevelsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewStockLevelsForm));
            this.viewStockLevelpnl = new System.Windows.Forms.Panel();
            this.dataGridViewViewStockLevels = new System.Windows.Forms.DataGridView();
            this.ViewStockLevelsBackbtn = new System.Windows.Forms.Button();
            this.stockLevelslbl = new System.Windows.Forms.Label();
            this.viewStockLevelpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewStockLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // viewStockLevelpnl
            // 
            this.viewStockLevelpnl.Controls.Add(this.dataGridViewViewStockLevels);
            this.viewStockLevelpnl.Controls.Add(this.ViewStockLevelsBackbtn);
            this.viewStockLevelpnl.Controls.Add(this.stockLevelslbl);
            this.viewStockLevelpnl.Location = new System.Drawing.Point(112, 50);
            this.viewStockLevelpnl.Name = "viewStockLevelpnl";
            this.viewStockLevelpnl.Size = new System.Drawing.Size(544, 365);
            this.viewStockLevelpnl.TabIndex = 0;
            this.viewStockLevelpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.viewStockLevelpnl_Paint);
            // 
            // dataGridViewViewStockLevels
            // 
            this.dataGridViewViewStockLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewStockLevels.Location = new System.Drawing.Point(39, 63);
            this.dataGridViewViewStockLevels.Name = "dataGridViewViewStockLevels";
            this.dataGridViewViewStockLevels.Size = new System.Drawing.Size(463, 242);
            this.dataGridViewViewStockLevels.TabIndex = 13;
            this.dataGridViewViewStockLevels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViewStockLevels_CellContentClick);
            // 
            // ViewStockLevelsBackbtn
            // 
            this.ViewStockLevelsBackbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ViewStockLevelsBackbtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStockLevelsBackbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewStockLevelsBackbtn.Location = new System.Drawing.Point(427, 322);
            this.ViewStockLevelsBackbtn.Name = "ViewStockLevelsBackbtn";
            this.ViewStockLevelsBackbtn.Size = new System.Drawing.Size(75, 26);
            this.ViewStockLevelsBackbtn.TabIndex = 12;
            this.ViewStockLevelsBackbtn.Text = "Back";
            this.ViewStockLevelsBackbtn.UseVisualStyleBackColor = false;
            this.ViewStockLevelsBackbtn.Click += new System.EventHandler(this.ViewStockLevelsBackbtn_Click);
            // 
            // stockLevelslbl
            // 
            this.stockLevelslbl.AutoSize = true;
            this.stockLevelslbl.BackColor = System.Drawing.Color.Transparent;
            this.stockLevelslbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLevelslbl.Location = new System.Drawing.Point(34, 19);
            this.stockLevelslbl.Name = "stockLevelslbl";
            this.stockLevelslbl.Size = new System.Drawing.Size(147, 27);
            this.stockLevelslbl.TabIndex = 0;
            this.stockLevelslbl.Text = "Stock Levels";
            // 
            // viewStockLevelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 442);
            this.Controls.Add(this.viewStockLevelpnl);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "viewStockLevelsForm";
            this.Text = "View Stock Levels";
            this.Load += new System.EventHandler(this.viewStockLevelsForm_Load);
            this.viewStockLevelpnl.ResumeLayout(false);
            this.viewStockLevelpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewStockLevels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewStockLevelpnl;
        private System.Windows.Forms.Label stockLevelslbl;
        private System.Windows.Forms.Button ViewStockLevelsBackbtn;
        private System.Windows.Forms.DataGridView dataGridViewViewStockLevels;
    }
}