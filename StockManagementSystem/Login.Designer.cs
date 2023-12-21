namespace StockManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.clearbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.pwdlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.loginlbl = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.clearbtn);
            this.LoginPanel.Controls.Add(this.loginbtn);
            this.LoginPanel.Controls.Add(this.pwdtxt);
            this.LoginPanel.Controls.Add(this.usernametxt);
            this.LoginPanel.Controls.Add(this.pwdlbl);
            this.LoginPanel.Controls.Add(this.usernamelbl);
            this.LoginPanel.Controls.Add(this.loginlbl);
            this.LoginPanel.Location = new System.Drawing.Point(167, 95);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(421, 267);
            this.LoginPanel.TabIndex = 0;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.clearbtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearbtn.Location = new System.Drawing.Point(194, 209);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(82, 38);
            this.clearbtn.TabIndex = 6;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginbtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbtn.Location = new System.Drawing.Point(298, 209);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(80, 38);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Log In";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // pwdtxt
            // 
            this.pwdtxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdtxt.Location = new System.Drawing.Point(40, 170);
            this.pwdtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.PasswordChar = '•';
            this.pwdtxt.Size = new System.Drawing.Size(338, 25);
            this.pwdtxt.TabIndex = 4;
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(40, 100);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(338, 25);
            this.usernametxt.TabIndex = 3;
            // 
            // pwdlbl
            // 
            this.pwdlbl.AutoSize = true;
            this.pwdlbl.BackColor = System.Drawing.Color.Transparent;
            this.pwdlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdlbl.Location = new System.Drawing.Point(37, 139);
            this.pwdlbl.Name = "pwdlbl";
            this.pwdlbl.Size = new System.Drawing.Size(78, 18);
            this.pwdlbl.TabIndex = 2;
            this.pwdlbl.Text = "Password";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.usernamelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(37, 66);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(80, 18);
            this.usernamelbl.TabIndex = 1;
            this.usernamelbl.Text = "Username";
            this.usernamelbl.Click += new System.EventHandler(this.usernamelbl_Click);
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.BackColor = System.Drawing.Color.Transparent;
            this.loginlbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlbl.Location = new System.Drawing.Point(167, 9);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(94, 33);
            this.loginlbl.TabIndex = 0;
            this.loginlbl.Text = "Log In";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 442);
            this.Controls.Add(this.LoginPanel);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label pwdlbl;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Button clearbtn;
    }
}

