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
    public partial class viewLogForm : Form
    {
        public viewLogForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; //to fit screen size
            this.BackgroundImage = Image.FromFile(@"\Users\HP\source\repos\StockManagementSystem\StockManagementSystem\img\stockbg1.jpeg");
            this.BackgroundImageLayout = ImageLayout.Stretch; //to stretch background image to prevent duplication
            //center the panel and its content
            viewLogPanel.Anchor = AnchorStyles.None;
            viewLogPanel.Location = new Point((this.ClientSize.Width - viewLogPanel.Width) / 2, (this.ClientSize.Height - viewLogPanel.Height) / 2);
            
            PopulateDataGridViewTransLog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuForm menuform = new menuForm();
            this.Hide();
            menuform.ShowDialog();
            this.Close();
        }

        private void PopulateDataGridViewTransLog()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\source\\repos\\StockManagementSystem\\StockManagementSystem\\Database.mdf;Integrated Security=True";

            string query = "SELECT * FROM TransactionLog"; //retrieve data from table

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command); //data adapter to fill in table with the results of the query 
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewViewLog.DataSource = dataTable; // dataGridView in viewStockLevels form contains the values from dataTable and is printed
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewLogPanel_Paint(object sender, PaintEventArgs e)
        {
            viewLogPanel.BackColor = Color.FromArgb(204, Color.White);
        }
    }
}
