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
    public partial class DeleteItemForm : Form
    {
        public DeleteItemForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; //to fit screen size
            this.BackgroundImage = Image.FromFile(@"\Users\HP\source\repos\StockManagementSystem\StockManagementSystem\img\stockbg1.jpeg");
        
            this.BackgroundImageLayout = ImageLayout.Stretch; //to stretch background image to prevent duplication
            //center the panel and its content
            DeleteItemPnl.Anchor = AnchorStyles.None;
            DeleteItemPnl.Location = new Point((this.ClientSize.Width - DeleteItemPnl.Width) / 2, (this.ClientSize.Height - DeleteItemPnl.Height) / 2);

        }

        private void DeleteItemBackbtn_Click(object sender, EventArgs e)
        {
            menuForm menuform = new menuForm();
            this.Hide();
            menuform.ShowDialog();
            this.Close();
        }

        private void DeleteItemPnl_Paint(object sender, PaintEventArgs e)
        {
            DeleteItemPnl.BackColor = Color.FromArgb(204, Color.White);
        }

        private void DeleteItembtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input from text boxes and updating database 
                string stockName = DeleteItemNametxt.Text;
                string stockCode = DeleteItemCodetxt.Text;
                int quantity = Convert.ToInt32(DeleteItemQuantitytxt.Text);


                // Check if name & code input fields are empty
                if (string.IsNullOrWhiteSpace(stockName) || string.IsNullOrWhiteSpace(stockCode))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    DeleteItemNametxt.Text = "";
                    DeleteItemCodetxt.Text = "";
                    DeleteItemQuantitytxt.Text = "";
                }


                else
                {

                    //create Item object and initialize values to attributes using constructor
                    Item item = new Item(stockName, stockCode, quantity);

                    // Delete item and check if successful
                    if (item.DeleteItemFromDataBase())
                    {
                        //clear input fields after item deleted
                        DeleteItemNametxt.Text = "";
                        DeleteItemCodetxt.Text = "";
                        DeleteItemQuantitytxt.Text = "";

                        // Add to transaction log only if the item is deleted
                        TransactionLog transactionLog = new TransactionLog(stockName, stockCode, quantity, "Item deleted");
                        transactionLog.AddTransactionToDataBase();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                DeleteItemNametxt.Text = "";
                DeleteItemCodetxt.Text = "";
                DeleteItemQuantitytxt.Text = "";
            }
        }
    }
}
