namespace StockManagementSystem
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.addStockItembtn = new System.Windows.Forms.Button();
            this.menuWelcomelbl = new System.Windows.Forms.Label();
            this.viewStockLevelbtn = new System.Windows.Forms.Button();
            this.viewLogbtn = new System.Windows.Forms.Button();
            this.menuPnl = new System.Windows.Forms.Panel();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.updateItemBtn = new System.Windows.Forms.Button();
            this.menuPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // addStockItembtn
            // 
            this.addStockItembtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addStockItembtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addStockItembtn.BackgroundImage")));
            this.addStockItembtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockItembtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addStockItembtn.Location = new System.Drawing.Point(21, 73);
            this.addStockItembtn.Name = "addStockItembtn";
            this.addStockItembtn.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.addStockItembtn.Size = new System.Drawing.Size(315, 106);
            this.addStockItembtn.TabIndex = 0;
            this.addStockItembtn.Text = "Add Stock Item";
            this.addStockItembtn.UseVisualStyleBackColor = false;
            this.addStockItembtn.Click += new System.EventHandler(this.addStockItembtn_Click);
            // 
            // menuWelcomelbl
            // 
            this.menuWelcomelbl.AutoSize = true;
            this.menuWelcomelbl.BackColor = System.Drawing.Color.Transparent;
            this.menuWelcomelbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuWelcomelbl.Location = new System.Drawing.Point(315, 0);
            this.menuWelcomelbl.Name = "menuWelcomelbl";
            this.menuWelcomelbl.Size = new System.Drawing.Size(139, 33);
            this.menuWelcomelbl.TabIndex = 1;
            this.menuWelcomelbl.Text = "Welcome";
            this.menuWelcomelbl.Click += new System.EventHandler(this.menuWelcomelbl_Click);
            // 
            // viewStockLevelbtn
            // 
            this.viewStockLevelbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.viewStockLevelbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewStockLevelbtn.BackgroundImage")));
            this.viewStockLevelbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStockLevelbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewStockLevelbtn.Location = new System.Drawing.Point(392, 208);
            this.viewStockLevelbtn.Name = "viewStockLevelbtn";
            this.viewStockLevelbtn.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.viewStockLevelbtn.Size = new System.Drawing.Size(315, 106);
            this.viewStockLevelbtn.TabIndex = 2;
            this.viewStockLevelbtn.Text = "View Stock Levels";
            this.viewStockLevelbtn.UseVisualStyleBackColor = false;
            this.viewStockLevelbtn.Click += new System.EventHandler(this.viewStockLevelbtn_Click);
            // 
            // viewLogbtn
            // 
            this.viewLogbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.viewLogbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewLogbtn.BackgroundImage")));
            this.viewLogbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewLogbtn.Location = new System.Drawing.Point(21, 343);
            this.viewLogbtn.Name = "viewLogbtn";
            this.viewLogbtn.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.viewLogbtn.Size = new System.Drawing.Size(315, 106);
            this.viewLogbtn.TabIndex = 3;
            this.viewLogbtn.Text = "View Transaction Log";
            this.viewLogbtn.UseVisualStyleBackColor = false;
            this.viewLogbtn.Click += new System.EventHandler(this.viewLogbtn_Click);
            // 
            // menuPnl
            // 
            this.menuPnl.BackColor = System.Drawing.Color.Transparent;
            this.menuPnl.Controls.Add(this.deleteItemBtn);
            this.menuPnl.Controls.Add(this.updateItemBtn);
            this.menuPnl.Controls.Add(this.viewStockLevelbtn);
            this.menuPnl.Controls.Add(this.menuWelcomelbl);
            this.menuPnl.Controls.Add(this.viewLogbtn);
            this.menuPnl.Controls.Add(this.addStockItembtn);
            this.menuPnl.Location = new System.Drawing.Point(23, 12);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(728, 472);
            this.menuPnl.TabIndex = 4;
            this.menuPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPnl_Paint);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deleteItemBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteItemBtn.BackgroundImage")));
            this.deleteItemBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteItemBtn.Location = new System.Drawing.Point(392, 73);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.deleteItemBtn.Size = new System.Drawing.Size(315, 106);
            this.deleteItemBtn.TabIndex = 5;
            this.deleteItemBtn.Text = "Delete Stock Item ";
            this.deleteItemBtn.UseVisualStyleBackColor = false;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // updateItemBtn
            // 
            this.updateItemBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.updateItemBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateItemBtn.BackgroundImage")));
            this.updateItemBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateItemBtn.Location = new System.Drawing.Point(21, 208);
            this.updateItemBtn.Name = "updateItemBtn";
            this.updateItemBtn.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.updateItemBtn.Size = new System.Drawing.Size(315, 106);
            this.updateItemBtn.TabIndex = 4;
            this.updateItemBtn.Text = "Update Stock Item ";
            this.updateItemBtn.UseVisualStyleBackColor = false;
            this.updateItemBtn.Click += new System.EventHandler(this.updateItemBtn_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 496);
            this.Controls.Add(this.menuPnl);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.menuPnl.ResumeLayout(false);
            this.menuPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStockItembtn;
        private System.Windows.Forms.Label menuWelcomelbl;
        private System.Windows.Forms.Button viewStockLevelbtn;
        private System.Windows.Forms.Button viewLogbtn;
        private System.Windows.Forms.Panel menuPnl;
        private System.Windows.Forms.Button updateItemBtn;
        private System.Windows.Forms.Button deleteItemBtn;
    }
}