using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    internal class Item
    {
        private string name;
        private string code;
        private int quantity;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        //constructor
        public Item(string name, string code, int quantity)
        {
            this.code = code;
            this.name = name;
            this.quantity = quantity;
        }

        public string getStockItemName()
        {
            return name;
        }

        public string getStockItemCode()
        {
            return code;
        }

        public int getStockItemQuantity()
        {
            return quantity;
        }

        //method to check if item exists in database
        public bool ItemExists(SqlConnection connection)
        {
            try
            {
                // Check if the stock item already exists
                string checkQuery = "SELECT COUNT(*) FROM StockLevels WHERE StockItemName = @StockName AND StockItemCode = @StockCode";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@StockName", name);
                    checkCommand.Parameters.AddWithValue("@StockCode", code);

                    int count = (int)checkCommand.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false; // Return false in case of an exception
            }
        }

        //method to add item to data base
        public void AddItemToDataBase()
        {
            // Connection string to the database
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\source\\repos\\StockManagementSystem\\StockManagementSystem\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the stock item already exists
                    bool itemExists = ItemExists(connection);
                    if (itemExists)
                    {
                        MessageBox.Show("Stock item already exists");
                    }
                       
                        else
                        {
                            // Stock item does not exist, so add item
                            string insertQuery = "INSERT INTO StockLevels (StockItemName, StockItemCode, StockItemQuantity) VALUES (@StockName, @StockCode, @Quantity)";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@StockName", Name);
                                insertCommand.Parameters.AddWithValue("@StockCode", Code);
                                insertCommand.Parameters.AddWithValue("@Quantity", Quantity);

                                insertCommand.ExecuteNonQuery();

                               MessageBox.Show("Item added successfully.");
                            }
                        }
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //method to update item
        public void UpdateItemInDataBase()
        {
            // Connection string to the database
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\source\\repos\\StockManagementSystem\\StockManagementSystem\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the stock item already exists
                    bool itemExists = ItemExists(connection);
                    if (itemExists)
                    {
                        // Stock item does not exist, so add item
                        string updateQuery = "UPDATE StockLevels SET StockItemQuantity = @Quantity WHERE StockItemName = @StockName AND StockItemCode = @StockCode";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@StockName", Name);
                            updateCommand.Parameters.AddWithValue("@StockCode", Code);
                            updateCommand.Parameters.AddWithValue("@Quantity", Quantity);

                            updateCommand.ExecuteNonQuery();

                            MessageBox.Show("Item updated successfully.");
                        }
                        
                    }

                    else
                    {
                        // Stock item does not exist, so add item
                        MessageBox.Show("Stock item does not exist");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public bool DeleteItemFromDataBase()
        {
            // Connection string to the database
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\source\\repos\\StockManagementSystem\\StockManagementSystem\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the stock item exists
                    bool itemExists = ItemExists(connection);
                    if (itemExists)
                    {
                        // Check if the quantity is zero
                        string checkQuantityQuery = "SELECT StockItemQuantity FROM StockLevels WHERE StockItemName = @StockName AND StockItemCode = @StockCode";
                        using (SqlCommand checkQuantityCommand = new SqlCommand(checkQuantityQuery, connection))
                        {
                            checkQuantityCommand.Parameters.AddWithValue("@StockName", Name);
                            checkQuantityCommand.Parameters.AddWithValue("@StockCode", Code);

                            object result = checkQuantityCommand.ExecuteScalar();

                            if (result != null)
                            {
                                int quantity = Convert.ToInt32(result);

                                if (quantity == 0)
                                {
                                    // Quantity is zero, delete the entire row
                                    string deleteQuery = "DELETE FROM StockLevels WHERE StockItemName = @StockName AND StockItemCode = @StockCode";

                                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                                    {
                                        deleteCommand.Parameters.AddWithValue("@StockName", Name);
                                        deleteCommand.Parameters.AddWithValue("@StockCode", Code);

                                        deleteCommand.ExecuteNonQuery();

                                        MessageBox.Show("Item deleted successfully.");
                                        return true;
                                    }
                                }
                                else
                                {
                                    // Quantity is not zero
                                    MessageBox.Show("Item quantity is not zero. Cannot delete.");
                                    return false;
                                }
                            }
                            else
                            {
                                // Handle the case where ExecuteScalar returns null
                                MessageBox.Show("Error retrieving quantity information.");
                                return false;
                            }
                        }
                    }
                    else
                    {
                        // Stock item does not exist
                        MessageBox.Show("Stock item does not exist");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }



    }



}


