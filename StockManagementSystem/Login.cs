using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\source\\repos\\StockManagementSystem\\StockManagementSystem\\Database.mdf;Integrated Security=True";


        //form's constructor
        public LoginForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; //to fit screen size
            this.BackgroundImage = Image.FromFile(@"\Users\HP\source\repos\StockManagementSystem\StockManagementSystem\img\stockbg1.jpeg");
            this.BackgroundImageLayout = ImageLayout.Stretch; //to stretch background image to prevent duplication
            //center the panel and its content
            LoginPanel.Anchor = AnchorStyles.None;
            LoginPanel.Location = new Point((this.ClientSize.Width - LoginPanel.Width) / 2, (this.ClientSize.Height - LoginPanel.Height) / 2);

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {
           LoginPanel.BackColor = Color.FromArgb(204, Color.White); //background color with opacity for login panel
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string usernameInput = usernametxt.Text;
            string passwordInput = pwdtxt.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the username and password exactly matches the database credentials (used binary collation to make it case sensitive)
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM LoginTable WHERE username = @username COLLATE Latin1_General_BIN AND password = @password COLLATE Latin1_General_BIN", connection))
                {
                    cmd.Parameters.AddWithValue("@username", usernameInput);
                    cmd.Parameters.AddWithValue("@password", passwordInput);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        // Login successful
                        menuForm menuform = new menuForm();
                        this.Hide();
                        menuform.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password, please try again.");
                        usernametxt.Text = "";
                        pwdtxt.Text = "";
                    }
                }

            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            usernametxt.Text="";
            pwdtxt.Text = "";
        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
