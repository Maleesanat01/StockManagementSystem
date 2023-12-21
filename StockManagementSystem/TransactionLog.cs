using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StockManagementSystem
{
    internal class TransactionLog: Item
    {
        private DateTime dt;
        private string status;

        //getters and setters
        public DateTime DT
        {
            get { return dt; }
            set { dt = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        //CONSTRUCTOR with name, code and quantity inherited from item class
        public TransactionLog(string name, string code, int quantity, string status) : base(name, code, quantity)
        {
            this.dt = DateTime.Now;
            this.status = status;
        }

        public DateTime getDateTime()
        {
            return dt;
        }

        public string getStatus()
        {
            return status;
        }

        public void AddTransactionToDataBase()
        {
            // Connection string to the database
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\source\\repos\\StockManagementSystem\\StockManagementSystem\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //add transaction to transaction log table
                    string insertQuery = "INSERT INTO TransactionLog (StockItemName, StockItemCode, StockItemQuantity, DateTime, Status) VALUES (@StockItemName, @StockItemCode, @StockItemQuantity, @DateTime, @Status)";


                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@StockItemName", Name);
                        insertCommand.Parameters.AddWithValue("@StockItemCode", Code);
                        insertCommand.Parameters.AddWithValue("@StockItemQuantity", Quantity);
                        insertCommand.Parameters.AddWithValue("@DateTime", dt);
                        insertCommand.Parameters.AddWithValue("@Status", status);

                        insertCommand.ExecuteNonQuery();

                        //MessageBox.Show("Transaction added successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

