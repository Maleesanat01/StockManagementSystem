namespace StockManagementSystem
{
    partial class viewLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewLogForm));
            this.viewLogPanel = new System.Windows.Forms.Panel();
            this.viewLogLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewViewLog = new System.Windows.Forms.DataGridView();
            this.viewLogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // viewLogPanel
            // 
            this.viewLogPanel.Controls.Add(this.dataGridViewViewLog);
            this.viewLogPanel.Controls.Add(this.button1);
            this.viewLogPanel.Controls.Add(this.viewLogLbl);
            this.viewLogPanel.Location = new System.Drawing.Point(29, 46);
            this.viewLogPanel.Name = "viewLogPanel";
            this.viewLogPanel.Size = new System.Drawing.Size(713, 405);
            this.viewLogPanel.TabIndex = 0;
            this.viewLogPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.viewLogPanel_Paint);
            // 
            // viewLogLbl
            // 
            this.viewLogLbl.AutoSize = true;
            this.viewLogLbl.BackColor = System.Drawing.Color.Transparent;
            this.viewLogLbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogLbl.Location = new System.Drawing.Point(34, 14);
            this.viewLogLbl.Name = "viewLogLbl";
            this.viewLogLbl.Size = new System.Drawing.Size(183, 27);
            this.viewLogLbl.TabIndex = 0;
            this.viewLogLbl.Text = "Transaction Log";
            this.viewLogLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(596, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewViewLog
            // 
            this.dataGridViewViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewLog.Location = new System.Drawing.Point(39, 57);
            this.dataGridViewViewLog.Name = "dataGridViewViewLog";
            this.dataGridViewViewLog.Size = new System.Drawing.Size(632, 289);
            this.dataGridViewViewLog.TabIndex = 2;
            this.dataGridViewViewLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // viewLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 485);
            this.Controls.Add(this.viewLogPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "viewLogForm";
            this.Text = "View Transaction Log";
            this.viewLogPanel.ResumeLayout(false);
            this.viewLogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewLogPanel;
        private System.Windows.Forms.Label viewLogLbl;
        private System.Windows.Forms.DataGridView dataGridViewViewLog;
        private System.Windows.Forms.Button button1;
    }
}