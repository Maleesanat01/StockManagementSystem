using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class UpdateQuantityForm : Form
    {
        public UpdateQuantityForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; //to fit screen size
            this.BackgroundImage = Image.FromFile(@"\Users\HP\source\repos\StockManagementSystem\StockManagementSystem\img\stockbg1.jpeg");
            this.BackgroundImageLayout = ImageLayout.Stretch; //to stretch background image to prevent duplication
            //center the panel and its content
            updateItemDetailsPnl.Anchor = AnchorStyles.None;
            updateItemDetailsPnl.Location = new Point((this.ClientSize.Width - updateItemDetailsPnl.Width) / 2, (this.ClientSize.Height - updateItemDetailsPnl.Height) / 2);

        }

        private void UpdateQuantity_Load(object sender, EventArgs e)
        {

        }

        private void updateItemDetailsPnl_Paint(object sender, PaintEventArgs e)
        {
            updateItemDetailsPnl.BackColor = Color.FromArgb(204, Color.White);
        }

        private void updateBackbtn_Click(object sender, EventArgs e)
        {
            menuForm menuform = new menuForm();
            this.Hide();
            menuform.ShowDialog();
            this.Close();
        }

        private void updateItembtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input from text boxes and updating database 
                string stockName = updateItemNametxt.Text;
                string stockCode = updateItemCodetxt.Text;
                int quantity = Convert.ToInt32(updateQuantitytxt.Text);


                // Check if name & code input fields are empty
                if (string.IsNullOrWhiteSpace(stockName) || string.IsNullOrWhiteSpace(stockCode))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    updateItemNametxt.Text = "";
                    updateItemCodetxt.Text = "";
                    updateQuantitytxt.Text = "";
                }


                else
                {

                    //create Item object and initialize values to attributes using constructor
                    Item item = new Item(stockName, stockCode, quantity);
                    TransactionLog transactionLog = new TransactionLog(stockName, stockCode, quantity, "Item updated");

                    item.UpdateItemInDataBase();
                    //clear input fields after item added
                    updateItemNametxt.Text = "";
                    updateItemCodetxt.Text = "";
                    updateQuantitytxt.Text = "";

                    transactionLog.AddTransactionToDataBase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                updateItemNametxt.Text = "";
                updateItemCodetxt.Text = "";
                updateQuantitytxt.Text = "";
            }
        }
    }
}
