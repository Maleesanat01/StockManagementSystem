namespace StockManagementSystem
{
    partial class AddItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            this.stockDetailslbl = new System.Windows.Forms.Label();
            this.StockItemNametxt = new System.Windows.Forms.TextBox();
            this.StockItemCodetxt = new System.Windows.Forms.TextBox();
            this.StockItemNamelbl = new System.Windows.Forms.Label();
            this.StockItemCodelbl = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.addItembtn = new System.Windows.Forms.Button();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.StockItemDetailspnl = new System.Windows.Forms.Panel();
            this.addItemBackbtn = new System.Windows.Forms.Button();
            this.StockItemDetailspnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockDetailslbl
            // 
            this.stockDetailslbl.AutoSize = true;
            this.stockDetailslbl.BackColor = System.Drawing.Color.Transparent;
            this.stockDetailslbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailslbl.Location = new System.Drawing.Point(11, 18);
            this.stockDetailslbl.Name = "stockDetailslbl";
            this.stockDetailslbl.Size = new System.Drawing.Size(403, 27);
            this.stockDetailslbl.TabIndex = 0;
            this.stockDetailslbl.Text = "Enter Stock Item Details To Add Item";
            this.stockDetailslbl.Click += new System.EventHandler(this.stockDetailslbl_Click);
            // 
            // StockItemNametxt
            // 
            this.StockItemNametxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockItemNametxt.Location = new System.Drawing.Point(15, 98);
            this.StockItemNametxt.Name = "StockItemNametxt";
            this.StockItemNametxt.Size = new System.Drawing.Size(203, 25);
            this.StockItemNametxt.TabIndex = 1;
            this.StockItemNametxt.TextChanged += new System.EventHandler(this.StockItemNametxt_TextChanged);
            // 
            // StockItemCodetxt
            // 
            this.StockItemCodetxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockItemCodetxt.Location = new System.Drawing.Point(15, 173);
            this.StockItemCodetxt.Name = "StockItemCodetxt";
            this.StockItemCodetxt.Size = new System.Drawing.Size(203, 25);
            this.StockItemCodetxt.TabIndex = 2;
            // 
            // StockItemNamelbl
            // 
            this.StockItemNamelbl.AutoSize = true;
            this.StockItemNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.StockItemNamelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockItemNamelbl.Location = new System.Drawing.Point(13, 66);
            this.StockItemNamelbl.Name = "StockItemNamelbl";
            this.StockItemNamelbl.Size = new System.Drawing.Size(127, 18);
            this.StockItemNamelbl.TabIndex = 6;
            this.StockItemNamelbl.Text = "Stock Item Name";
            this.StockItemNamelbl.Click += new System.EventHandler(this.StockItemNamelbl_Click);
            // 
            // StockItemCodelbl
            // 
            this.StockItemCodelbl.AutoSize = true;
            this.StockItemCodelbl.BackColor = System.Drawing.Color.Transparent;
            this.StockItemCodelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockItemCodelbl.Location = new System.Drawing.Point(13, 142);
            this.StockItemCodelbl.Name = "StockItemCodelbl";
            this.StockItemCodelbl.Size = new System.Drawing.Size(124, 18);
            this.StockItemCodelbl.TabIndex = 7;
            this.StockItemCodelbl.Text = "Stock Item Code";
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.BackColor = System.Drawing.Color.Transparent;
            this.quantitylbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitylbl.Location = new System.Drawing.Point(13, 217);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(141, 18);
            this.quantitylbl.TabIndex = 8;
            this.quantitylbl.Text = "Stock Item Quantity";
            // 
            // addItembtn
            // 
            this.addItembtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addItembtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItembtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addItembtn.Location = new System.Drawing.Point(15, 296);
            this.addItembtn.Name = "addItembtn";
            this.addItembtn.Size = new System.Drawing.Size(71, 29);
            this.addItembtn.TabIndex = 9;
            this.addItembtn.Text = "Add";
            this.addItembtn.UseVisualStyleBackColor = false;
            this.addItembtn.Click += new System.EventHandler(this.addItembtn_Click);
            // 
            // quantitytxt
            // 
            this.quantitytxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytxt.Location = new System.Drawing.Point(15, 249);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(203, 25);
            this.quantitytxt.TabIndex = 10;
            // 
            // StockItemDetailspnl
            // 
            this.StockItemDetailspnl.BackColor = System.Drawing.Color.White;
            this.StockItemDetailspnl.Controls.Add(this.addItemBackbtn);
            this.StockItemDetailspnl.Controls.Add(this.stockDetailslbl);
            this.StockItemDetailspnl.Controls.Add(this.addItembtn);
            this.StockItemDetailspnl.Controls.Add(this.quantitytxt);
            this.StockItemDetailspnl.Controls.Add(this.StockItemNamelbl);
            this.StockItemDetailspnl.Controls.Add(this.StockItemNametxt);
            this.StockItemDetailspnl.Controls.Add(this.quantitylbl);
            this.StockItemDetailspnl.Controls.Add(this.StockItemCodelbl);
            this.StockItemDetailspnl.Controls.Add(this.StockItemCodetxt);
            this.StockItemDetailspnl.Location = new System.Drawing.Point(160, 75);
            this.StockItemDetailspnl.Name = "StockItemDetailspnl";
            this.StockItemDetailspnl.Size = new System.Drawing.Size(465, 378);
            this.StockItemDetailspnl.TabIndex = 11;
            this.StockItemDetailspnl.Paint += new System.Windows.Forms.PaintEventHandler(this.StockItemDetailspnl_Paint);
            // 
            // addItemBackbtn
            // 
            this.addItemBackbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addItemBackbtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBackbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addItemBackbtn.Location = new System.Drawing.Point(149, 296);
            this.addItemBackbtn.Name = "addItemBackbtn";
            this.addItemBackbtn.Size = new System.Drawing.Size(69, 29);
            this.addItemBackbtn.TabIndex = 11;
            this.addItemBackbtn.Text = "Back";
            this.addItemBackbtn.UseVisualStyleBackColor = false;
            this.addItemBackbtn.Click += new System.EventHandler(this.addItemBackbtn_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 485);
            this.Controls.Add(this.StockItemDetailspnl);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddItemForm";
            this.Text = "Add Stock Item";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            this.StockItemDetailspnl.ResumeLayout(false);
            this.StockItemDetailspnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label stockDetailslbl;
        private System.Windows.Forms.TextBox StockItemNametxt;
        private System.Windows.Forms.TextBox StockItemCodetxt;
        private System.Windows.Forms.Label StockItemNamelbl;
        private System.Windows.Forms.Label StockItemCodelbl;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Button addItembtn;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Panel StockItemDetailspnl;
        private System.Windows.Forms.Button addItemBackbtn;
    }
}