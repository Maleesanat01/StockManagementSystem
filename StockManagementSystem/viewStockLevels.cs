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
    public partial class viewStockLevelsForm : Form
    {
        public viewStockLevelsForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; //to fit screen size
            this.BackgroundImage = Image.FromFile(@"\Users\HP\source\repos\StockManagementSystem\StockManagementSystem\img\stockbg1.jpeg");
            this.BackgroundImageLayout = ImageLayout.Stretch; //to stretch background image to prevent duplication
                                                              //center the panel and its content
            viewStockLevelpnl.Anchor = AnchorStyles.None;
            viewStockLevelpnl.Location = new Point((this.ClientSize.Width - viewStockLevelpnl.Width) / 2, (this.ClientSize.Height - viewStockLevelpnl.Height) / 2);


            PopulateDataGridView(); // data from the database is automatically shown in the DataGridView
        }

        private void viewStockLevelpnl_Paint(object sender, PaintEventArgs e)
        {
            viewStockLevelpnl.BackColor = Color.FromArgb(204, Color.White);
        }

        private void ViewStockLevelsBackbtn_Click(object sender, EventArgs e)
        {
            menuForm menuform = new menuForm();
            this.Hide();
            menuform.ShowDialog();
            this.Close();
        }

        private void PopulateDataGridView()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\source\\repos\\StockManagementSystem\\StockManagementSystem\\Database.mdf;Integrated Security=True";

            string query = "SELECT * FROM StockLevels"; //retrieve data from table

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command); //data adapter to fill in table with the results of the query 
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewViewStockLevels.DataSource = dataTable; // dataGridView in viewStockLevels form contains the values from dataTable and is printed
                }
            }
        }

        private void viewStockLevelsForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewViewStockLevels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
