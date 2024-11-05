using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace Ingredients
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();

        }

        private void OrderForm_Load_1(object sender, EventArgs e)
        {
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellClick -= dataGridView_CellClick;

            AddButtonColumn();
            LoadDataGridView();

            dataGridView.Columns[0].Width = 80;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 50;
            dataGridView.Columns[4].Width = 300;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 140;
            dataGridView.Columns[7].Width = 80;

            dataGridView.AutoGenerateColumns = false;

            dataGridView.CellFormatting += DataGridView_CellFormatting;

            categoryCheckedListBox.ItemCheck += categoryCheckedListBox_ItemCheck;

            txtIDBill.Text = GenerateBillID().ToString();

            dataGridView.CellValueChanged -= dataGridView_CellValueChanged;
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
        }

        private void LoadDataGridView(List<string> selectedCategories = null)
        {
            string connectionString = "Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = "SELECT ID, Name, Price, Category, Availability FROM Test";

            if (selectedCategories != null && selectedCategories.Count > 0)
            {
                string categoryFilter = string.Join(",", selectedCategories.Select((_, index) => $"@Category{index}"));
                query += $" WHERE Category IN ({categoryFilter})";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                if (selectedCategories != null)
                {
                    for (int i = 0; i < selectedCategories.Count; i++)
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue($"@Category{i}", selectedCategories[i]);
                    }
                }

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;

            }

        }

        private void AddButtonColumn()
        {
            DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn();
            addButtonColumn.HeaderText = "Add";
            addButtonColumn.Name = "Add";
            addButtonColumn.Text = "Add";
            addButtonColumn.UseColumnTextForButtonValue = false;

            dataGridView.Columns.Add(addButtonColumn);
            dataGridView.CellFormatting += DataGridView_CellFormatting;


            //foreach (DataGridViewRow row in dataGridView.Rows)
            //{
            //    bool availaility = Convert.ToBoolean(row.Cells["Availability"].Value);

            //    if (!availaility)
            //    {
            //        row.Cells["Add"].Value = "Out of stock";
            //        row.Cells["Add"].Style.BackColor = Color.LightCoral;
            //        row.Cells["Add"].Style.ForeColor = Color.White;

            //    }
            //}
            //-----------------------------------------------------------------------------------------------------------------------------------------
            //foreach (DataGridViewRow row in dataGridView.Rows)
            //{
            //    if (row.Cells["Availability"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["Availability"].Value) == false)
            //    {
            //        row.Cells["Add"].Value = "Out of stock";
            //        row.Cells["Add"].Style.BackColor = Color.LightCoral;
            //        row.Cells["Add"].Style.ForeColor = Color.White;
            //    }
            //    else
            //    {
            //        row.Cells["Add"].Value = "Add";
            //        row.Cells["Add"].Style.BackColor = Color.LightGreen;
            //    }

            //}

        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Add")
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                bool availability = Convert.ToBoolean(row.Cells["Availability"].Value);

                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)row.Cells["Add"];

                if (availability)
                {
                    buttonCell.Value = "Add";
                    buttonCell.Style.BackColor = Color.LightBlue;
                    buttonCell.ReadOnly = false;

                }
                else
                {
                    buttonCell.Value = "Unavailable";
                    buttonCell.Style.BackColor = Color.LightCoral;
                    buttonCell.ReadOnly = true;
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.ColumnIndex == dataGridView.Columns["Add"].Index && e.RowIndex >= 0) 
            //{
            //    var row = dataGridView.Rows[e.RowIndex];
            //    string itemId = dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            //    string itemName = dataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            //    decimal itemPrice = Convert.ToDecimal(dataGridView.Rows[e.RowIndex].Cells["Price"].Value);
            //    //string itemCategory = dataGridView.Rows[e.RowIndex].Cells["Category"].Value.ToString();
            //    bool itemAvailability = (bool)dataGridView.Rows[e.RowIndex].Cells["Availability"].Value;


            //    AddItemToBill(itemId, itemName, itemPrice);
            //}

            if (e.ColumnIndex == dataGridView.Columns["Add"].Index && e.RowIndex >= 0)
            {
                var row = dataGridView.Rows[e.RowIndex];

                string itemId = dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string itemName = dataGridView.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                decimal itemPrice = Convert.ToDecimal(dataGridView.Rows[e.RowIndex].Cells["Price"].Value);
                //string itemCategory = dataGridView.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                bool itemAvailability = (bool)dataGridView.Rows[e.RowIndex].Cells["Availability"].Value;

                if (itemAvailability)
                {
                    DataGridViewRow existingRow = dataGridView.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r => r.Cells["ID"].Value.ToString() == itemId);

                    if (existingRow != null)
                    {
                        int quantity = Convert.ToInt32(existingRow.Cells["Quantity"].Value);
                        existingRow.Cells["Quantity"].Value = quantity + 1;
                        existingRow.Cells["ItemSum"].Value = (quantity + 1) * itemPrice;
                    }
                    else
                    {
                        AddItemToBill(itemId, itemName, itemPrice);
                    }
                    UpdateTotal();
                }
                else
                {
                    row.Cells["Add"].Value = "Unavailable";
                    row.Cells["Add"].Style.BackColor = Color.LightCoral;
                    row.Cells["Add"].ReadOnly = true;
                }
            }
        }

        private void AddItemToBill(string itemId, string itemName, decimal itemPrice)
        {

            //foreach (DataGridViewRow row in dataGridView.Rows)
            //{
            //    if (row.Cells["ID"].Value.ToString() == itemId)
            //    {
            //        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value) + 1;
            //        row.Cells["Quantity"].Value = quantity;
            //        row.Cells["ItemSum"].Value = quantity * itemPrice;
            //        UpdateTotal();
            //        return;
            //    }
            //}

            int newRowIndex = dataGridView.Rows.Add();
            DataGridViewRow newRow = dataGridView.Rows[newRowIndex];
            newRow.Cells["ID"].Value = itemId;
            newRow.Cells["Name"].Value = itemName;
            newRow.Cells["Price"].Value = itemPrice;
            newRow.Cells["Quantity"].Value = 1;
            newRow.Cells["ItemSum"].Value = itemPrice;

        }

        private void UpdateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                total += Convert.ToDecimal(row.Cells["ItemSum"].Value);
            }

            txtTotal.Text = $"Total amount: {total}";

        }

        private void categoryCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                var selectedCategories = categoryCheckedListBox.CheckedItems.Cast<string>().ToList();

                if (e.NewValue == CheckState.Checked)
                {
                    selectedCategories.Add(categoryCheckedListBox.Items[e.Index].ToString());
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    selectedCategories.Remove(categoryCheckedListBox.Items[e.Index].ToString());
                }

                LoadDataGridView(selectedCategories);
            });
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }

        private void ClearSelection()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Quantity"] != null)
                    row.Cells["Quantity"].Value = null;

                if (row.Cells["ItemSum"] != null)
                    row.Cells["ItemSum"].Value = null;
            }

            BillListView.Clear();

            txtTotal.Text = "Total amount: 0";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveBill();
            txtIDBill.Text = GenerateBillID().ToString();
            ClearSelection();
        }

        private void SaveBill()
        {
            bool containsItems = false;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Quantity"] != null && Convert.ToInt32(row.Cells["Quantity"].Value) > 0)
                {
                    containsItems = true;
                    break;
                }
            }

            if (!containsItems)
            {
                MessageBox.Show("Please add at least 1 item to the order before saving.");
                return;
            }

            string totalText = txtTotal.Text.Replace("Total amount: ", "").Trim();
            if (!decimal.TryParse(totalText, out decimal totalAmount))
            {
                MessageBox.Show("The total amount is in an invalid format");
                return;
            }

            string billID = txtIDBill.Text;


            string connectionString = "Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        //foreach (DataGridViewRow row in dataGridView.Rows)
                        //{
                        //    if (row.Cells["Quantity"] != null && Convert.ToInt32(row.Cells["Quantity"].Value) > 0)
                        //    {
                        //        string itemId = row.Cells["ID"].Value.ToString();
                        //        string itemName = row.Cells["Name"].Value.ToString();
                        //        decimal itemPrice = Convert.ToUInt32(row.Cells["Price"].Value);
                        //        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        //        decimal itemSum = Convert.ToDecimal(row.Cells["ItemSum"].Value);

                        //        string query = "INSERT INTO BillDetail (IDBill, ItemID, Items, ItemPrice, Quantity, ItemSum, Total, Created) VALUES (@IDBill, @ItemID, @Items, @ItemPrice, @Quantity, @ItemSum, @Total, GETDATE())";

                        //        using (SqlCommand cmd = new SqlCommand (query, conn, transaction))
                        //        {
                        //            cmd.Parameters.AddWithValue("@IDBill", billID);
                        //            cmd.Parameters.AddWithValue("ItemID", itemId);
                        //            cmd.Parameters.AddWithValue("@Items", itemName);
                        //            cmd.Parameters.AddWithValue("@ItemPrice", itemPrice);
                        //            cmd.Parameters.AddWithValue("@Quantity", quantity);
                        //            cmd.Parameters.AddWithValue("@ItemSum", itemSum);
                        //            cmd.Parameters.AddWithValue("@Total", totalAmount);

                        //            cmd.ExecuteNonQuery();
                        //        }
                        //    }
                        //}
                        string querySummary = "INSERT INTO SummaryBills (BillNo, BillAmount, DateTime) VALUES (@BillNo, @BillAmount, GETDATE())";

                        using (SqlCommand cmdsum = new SqlCommand(querySummary, conn, transaction))
                        {
                            cmdsum.Parameters.AddWithValue("@BillNo", billID);
                            cmdsum.Parameters.AddWithValue("@BillAmount", totalAmount);

                            cmdsum.ExecuteNonQuery();
                        }

                        string queryBill = "INSERT INTO BillDetail (IDBill, ItemID, Items, ItemPrice, Quantity, ItemSum, Total, Created) VALUES (@IDBill, @ItemID, @Items, @ItemPrice, @Quantity, @ItemSum, @Total, GETDATE())";
                        foreach (ListViewItem item in BillListView.Items)
                        {
                            using (SqlCommand cmd = new SqlCommand(queryBill, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@IDBill", billID);
                                cmd.Parameters.AddWithValue("ItemID", item.SubItems[0].Text);
                                cmd.Parameters.AddWithValue("@Items", item.SubItems[1].Text);
                                cmd.Parameters.AddWithValue("@ItemPrice", decimal.Parse(item.SubItems[2].Text));
                                cmd.Parameters.AddWithValue("@Quantity", int.Parse(item.SubItems[3].Text));
                                cmd.Parameters.AddWithValue("@ItemSum", decimal.Parse(item.SubItems[4].Text));
                                cmd.Parameters.AddWithValue("@Total", totalAmount);
                                cmd.ExecuteNonQuery();
                            }
                        }

                            transaction.Commit();
                        MessageBox.Show("Bill saved successfuly.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
        private int GenerateBillID()
        {
            int newBillID = 1;

            using (SqlConnection conn = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MAX(IDBill) FROM BillDetail", conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        newBillID = Convert.ToInt32(result) + 1;
                    }
                    //int count = (int)cmd.ExecuteScalar();
                    //newBillID = count + 1;
                }
            }
            return newBillID;
        }

        private void UpdateBillListView(string itemID, string itemName, decimal itemPrice, int quantity, decimal itemSum)
        {
            var existingItem = BillListView.Items.Cast<ListViewItem>().FirstOrDefault(i => i.SubItems[0].Text == itemID);

            if (existingItem != null)
            {
                existingItem.SubItems[2].Text = itemPrice.ToString();
                existingItem.SubItems[3].Text = quantity.ToString();
                existingItem.SubItems[4].Text = itemSum.ToString();
            }
            else
            {
                var newItem = new ListViewItem(new[]
                {
                    itemID, itemName, itemPrice.ToString(), quantity.ToString(), itemSum.ToString()
                });
                BillListView.Items.Add(newItem);
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns["Quantity"] != null && dataGridView.Columns["Price"] != null)
            {
                if (e.ColumnIndex == dataGridView.Columns["Quantity"].Index || e.ColumnIndex == dataGridView.Columns["Price"].Index)
                {
                    UpdateBillListViewFromDataGridView();
                }
            } 
        }

        private void UpdateBillListViewFromDataGridView()
        {
            foreach (DataGridViewRow row in  dataGridView.Rows)
            {
                if (row.Cells["Quantity"].Value != null && Convert.ToInt32(row.Cells["Quantity"].Value) > 0)
                {
                    string itemID = row.Cells["ID"].Value.ToString();
                    string itemName = row.Cells["Name"].Value.ToString();
                    decimal itemPrice = Convert.ToDecimal(row.Cells["Price"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal itemSum = itemPrice * quantity;

                    UpdateBillListView(itemID, itemName, itemPrice, quantity, itemSum);
                }
            }
        }
    }
}
