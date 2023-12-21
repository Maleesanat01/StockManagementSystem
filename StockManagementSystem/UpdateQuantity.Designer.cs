namespace StockManagementSystem
{
    partial class UpdateQuantityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateQuantityForm));
            this.updateItemDetailsPnl = new System.Windows.Forms.Panel();
            this.updateBackbtn = new System.Windows.Forms.Button();
            this.updateItemlbl = new System.Windows.Forms.Label();
            this.updateItembtn = new System.Windows.Forms.Button();
            this.updateQuantitytxt = new System.Windows.Forms.TextBox();
            this.updateItemNamelbl = new System.Windows.Forms.Label();
            this.updateItemNametxt = new System.Windows.Forms.TextBox();
            this.updateQuantitylbl = new System.Windows.Forms.Label();
            this.updateItemCodelbl = new System.Windows.Forms.Label();
            this.updateItemCodetxt = new System.Windows.Forms.TextBox();
            this.updateItemDetailsPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateItemDetailsPnl
            // 
            this.updateItemDetailsPnl.BackColor = System.Drawing.Color.White;
            this.updateItemDetailsPnl.Controls.Add(this.updateBackbtn);
            this.updateItemDetailsPnl.Controls.Add(this.updateItemlbl);
            this.updateItemDetailsPnl.Controls.Add(this.updateItembtn);
            this.updateItemDetailsPnl.Controls.Add(this.updateQuantitytxt);
            this.updateItemDetailsPnl.Controls.Add(this.updateItemNamelbl);
            this.updateItemDetailsPnl.Controls.Add(this.updateItemNametxt);
            this.updateItemDetailsPnl.Controls.Add(this.updateQuantitylbl);
            this.updateItemDetailsPnl.Controls.Add(this.updateItemCodelbl);
            this.updateItemDetailsPnl.Controls.Add(this.updateItemCodetxt);
            this.updateItemDetailsPnl.Location = new System.Drawing.Point(160, 75);
            this.updateItemDetailsPnl.Name = "updateItemDetailsPnl";
            this.updateItemDetailsPnl.Size = new System.Drawing.Size(465, 378);
            this.updateItemDetailsPnl.TabIndex = 12;
            this.updateItemDetailsPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.updateItemDetailsPnl_Paint);
            // 
            // updateBackbtn
            // 
            this.updateBackbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.updateBackbtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBackbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBackbtn.Location = new System.Drawing.Point(149, 296);
            this.updateBackbtn.Name = "updateBackbtn";
            this.updateBackbtn.Size = new System.Drawing.Size(69, 29);
            this.updateBackbtn.TabIndex = 11;
            this.updateBackbtn.Text = "Back";
            this.updateBackbtn.UseVisualStyleBackColor = false;
            this.updateBackbtn.Click += new System.EventHandler(this.updateBackbtn_Click);
            // 
            // updateItemlbl
            // 
            this.updateItemlbl.AutoSize = true;
            this.updateItemlbl.BackColor = System.Drawing.Color.Transparent;
            this.updateItemlbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemlbl.Location = new System.Drawing.Point(11, 18);
            this.updateItemlbl.Name = "updateItemlbl";
            this.updateItemlbl.Size = new System.Drawing.Size(324, 27);
            this.updateItemlbl.TabIndex = 0;
            this.updateItemlbl.Text = "Enter New Stock Item Details";
            // 
            // updateItembtn
            // 
            this.updateItembtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.updateItembtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItembtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateItembtn.Location = new System.Drawing.Point(15, 296);
            this.updateItembtn.Name = "updateItembtn";
            this.updateItembtn.Size = new System.Drawing.Size(71, 29);
            this.updateItembtn.TabIndex = 9;
            this.updateItembtn.Text = "Update";
            this.updateItembtn.UseVisualStyleBackColor = false;
            this.updateItembtn.Click += new System.EventHandler(this.updateItembtn_Click);
            // 
            // updateQuantitytxt
            // 
            this.updateQuantitytxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuantitytxt.Location = new System.Drawing.Point(15, 249);
            this.updateQuantitytxt.Name = "updateQuantitytxt";
            this.updateQuantitytxt.Size = new System.Drawing.Size(203, 25);
            this.updateQuantitytxt.TabIndex = 10;
            // 
            // updateItemNamelbl
            // 
            this.updateItemNamelbl.AutoSize = true;
            this.updateItemNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.updateItemNamelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemNamelbl.Location = new System.Drawing.Point(13, 66);
            this.updateItemNamelbl.Name = "updateItemNamelbl";
            this.updateItemNamelbl.Size = new System.Drawing.Size(127, 18);
            this.updateItemNamelbl.TabIndex = 6;
            this.updateItemNamelbl.Text = "Stock Item Name";
            // 
            // updateItemNametxt
            // 
            this.updateItemNametxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemNametxt.Location = new System.Drawing.Point(15, 98);
            this.updateItemNametxt.Name = "updateItemNametxt";
            this.updateItemNametxt.Size = new System.Drawing.Size(203, 25);
            this.updateItemNametxt.TabIndex = 1;
            // 
            // updateQuantitylbl
            // 
            this.updateQuantitylbl.AutoSize = true;
            this.updateQuantitylbl.BackColor = System.Drawing.Color.Transparent;
            this.updateQuantitylbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuantitylbl.Location = new System.Drawing.Point(13, 217);
            this.updateQuantitylbl.Name = "updateQuantitylbl";
            this.updateQuantitylbl.Size = new System.Drawing.Size(141, 18);
            this.updateQuantitylbl.TabIndex = 8;
            this.updateQuantitylbl.Text = "Stock Item Quantity";
            // 
            // updateItemCodelbl
            // 
            this.updateItemCodelbl.AutoSize = true;
            this.updateItemCodelbl.BackColor = System.Drawing.Color.Transparent;
            this.updateItemCodelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemCodelbl.Location = new System.Drawing.Point(13, 142);
            this.updateItemCodelbl.Name = "updateItemCodelbl";
            this.updateItemCodelbl.Size = new System.Drawing.Size(124, 18);
            this.updateItemCodelbl.TabIndex = 7;
            this.updateItemCodelbl.Text = "Stock Item Code";
            // 
            // updateItemCodetxt
            // 
            this.updateItemCodetxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemCodetxt.Location = new System.Drawing.Point(15, 173);
            this.updateItemCodetxt.Name = "updateItemCodetxt";
            this.updateItemCodetxt.Size = new System.Drawing.Size(203, 25);
            this.updateItemCodetxt.TabIndex = 2;
            // 
            // UpdateQuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 485);
            this.Controls.Add(this.updateItemDetailsPnl);
            this.Name = "UpdateQuantityForm";
            this.Text = "Update Stock Item Quantity";
            this.Load += new System.EventHandler(this.UpdateQuantity_Load);
            this.updateItemDetailsPnl.ResumeLayout(false);
            this.updateItemDetailsPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updateItemDetailsPnl;
        private System.Windows.Forms.Button updateBackbtn;
        private System.Windows.Forms.Label updateItemlbl;
        private System.Windows.Forms.Button updateItembtn;
        private System.Windows.Forms.TextBox updateQuantitytxt;
        private System.Windows.Forms.Label updateItemNamelbl;
        private System.Windows.Forms.TextBox updateItemNametxt;
        private System.Windows.Forms.Label updateQuantitylbl;
        private System.Windows.Forms.Label updateItemCodelbl;
        private System.Windows.Forms.TextBox updateItemCodetxt;
    }
}