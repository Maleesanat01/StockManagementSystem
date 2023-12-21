using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class AddItemForm : Form
    {
        //form's constructor
        public AddItemForm()
        {
            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized; //to fit screen size
            this.BackgroundImage = Image.FromFile(@"\Users\HP\source\repos\StockManagementSystem\StockManagementSystem\img\stockbg1.jpeg");
            this.BackgroundImageLayout = ImageLayout.Stretch; //to stretch background image to prevent duplication
            //center the panel and its content
            StockItemDetailspnl.Anchor = AnchorStyles.None;
            StockItemDetailspnl.Location = new Point((this.ClientSize.Width - StockItemDetailspnl.Width) / 2, (this.ClientSize.Height - StockItemDetailspnl.Height) / 2);


        }

        private void addItembtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input from text boxes and assign value to variables
                string stockName = StockItemNametxt.Text;
                string stockCode = StockItemCodetxt.Text;
                int quantity = Convert.ToInt32(quantitytxt.Text);

             
                // Check if name & code input fields are empty
                if (string.IsNullOrWhiteSpace(stockName) || string.IsNullOrWhiteSpace(stockCode))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    StockItemNametxt.Text = "";
                    StockItemCodetxt.Text = "";
                    quantitytxt.Text = "";
                }
                

                else 
                { 
                    //create Item object and initialize values to attributes using constructor
                    Item item = new Item(stockName, stockCode, quantity);
                    TransactionLog transactionLog = new TransactionLog(stockName, stockCode, quantity, "Item added");

                    item.AddItemToDataBase();
                    //clear input fields after item added
                    StockItemNametxt.Text = "";
                    StockItemCodetxt.Text = "";
                    quantitytxt.Text = "";

                    transactionLog.AddTransactionToDataBase();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                StockItemNametxt.Text = "";
                StockItemCodetxt.Text = "";
                quantitytxt.Text = "";
            }
        }

        private void StockItemDetailspnl_Paint(object sender, PaintEventArgs e)
        {
            StockItemDetailspnl.BackColor = Color.FromArgb(204, Color.White);
        }

        private void addItemBackbtn_Click(object sender, EventArgs e)
        {
            menuForm menuform = new menuForm();
            this.Hide();
            menuform.ShowDialog();
            this.Close();
        }

        private void stockDetailslbl_Click(object sender, EventArgs e)
        {

        }

        private void StockItemNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void StockItemNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
