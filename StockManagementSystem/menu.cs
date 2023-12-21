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
    public partial class menuForm : Form
    {
        //form's constructor
        public menuForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; //to fit screen size
            this.BackgroundImage = Image.FromFile(@"\Users\HP\source\repos\StockManagementSystem\StockManagementSystem\img\menu-white-bg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch; //to stretch background image to prevent duplication
            //center the panel and its content
            menuPnl.Anchor = AnchorStyles.None;
            menuPnl.Location = new Point((this.ClientSize.Width - menuPnl.Width) / 2, (this.ClientSize.Height - menuPnl.Height) / 2);

        }

        private void addStockItembtn_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            this.Hide();
            addItemForm.ShowDialog();
            this.Close();
        }

        private void viewStockLevelbtn_Click(object sender, EventArgs e)
        {
            viewStockLevelsForm viewStockLevels = new viewStockLevelsForm();
            this.Hide();
            viewStockLevels.ShowDialog();
            this.Close();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }

        private void menuWelcomelbl_Click(object sender, EventArgs e)
        {

        }

        private void viewLogbtn_Click(object sender, EventArgs e)
        {
            viewLogForm viewlogForm = new viewLogForm();
            this.Hide();
            viewlogForm.ShowDialog();
            this.Close();
        }

        private void menuPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateItemBtn_Click(object sender, EventArgs e)
        {
            UpdateQuantityForm updateQuantityForm = new UpdateQuantityForm();
            this.Hide();
            updateQuantityForm.ShowDialog();
            this.Close();
        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            DeleteItemForm deleteItemForm = new DeleteItemForm();
            this.Hide();
            deleteItemForm.ShowDialog();
            this.Close();
        }
    }
}
