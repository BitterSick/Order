using System.Data.SqlClient;
using System;
using System.Data;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Linq.Expressions;
using System.Data.Common;
using System.Drawing.Text;




namespace Ingredients

{
    public partial class Form1 : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private int selectedRowIndex;

        public Form1()
        {
            InitializeComponent();
            //textBox3_KeyDown += new KeyPressEventHandler(textBox3_KeyDown);
            this.AcceptButton = button6;
            FocusStyle(button6);
            FocusStyle(button5);
            this.ContextMenuStrip = contextMenuStrip1;

        }

        private string GenerateUniqueID()
        {
            return "1";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            //con.Open();
            //string insertQuery = "INSERT INTO Test (ID, Name, Description, UnitType, Created) VALUES (@ID, @Name, @Description, @UnitType, GETDATE())";
            //SqlCommand cmd = new SqlCommand(insertQuery, con);
            //cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            //cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            //cmd.Parameters.AddWithValue("@Description", textBox3.Text);
            //cmd.Parameters.AddWithValue("@UnitType", comboBox1.Text);
            //int count = cmd.ExecuteNonQuery();
            //con.Close();
            //if (count > 0)
            //{
            //    MessageBox.Show("Insert Successful.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Insert error.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }
        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            SqlCommand cmd = new("SELECT * FROM Test", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
            //textBox1.Text = GetNextID().ToString();
            RefreshData();
            //this.AcceptButton = button6;
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 400;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 200;

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.SuppressKeyPress = true;
            //    comboBox1.Focus();
            //    comboBox1.DroppedDown = true;
            //}
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.SuppressKeyPress = true;
            //    button1.Focus();
            //}
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private int GetNextID()
        {
            int nextID = 1;
            using (SqlConnection conn = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Test", conn))
                {
                    int count = (int)cmd.ExecuteScalar();
                    nextID = count + 1;
                }
            }
            return nextID;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    RefreshData();
        //}

        private void RefreshData()
        {
            //textBox1.Clear();
            //textBox1.Text = GetNextID().ToString();

            LoadDataIntoGrid();
        }

        private void LoadDataIntoGrid()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Test", conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        //con.Open();
        //string updateQuery = "UPDATE Test SET Name=@Name, Description=@Description, UnitType=@UnitType WHERE ID=@ID";
        //SqlCommand cmd = new SqlCommand(updateQuery, con);
        //cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
        //cmd.Parameters.AddWithValue("@Name", textBox2.Text);
        //cmd.Parameters.AddWithValue("@Description", textBox3.Text);
        //cmd.Parameters.AddWithValue("@UnitType", comboBox1.Text);
        //int count = cmd.ExecuteNonQuery();
        //con.Close();
        //if (count > 0)
        //{
        //    MessageBox.Show("Update Successful.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        //else
        //{
        //    MessageBox.Show("Update error.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}


        //}

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            //con.Open();
            //string deleteQuery = "DELETE FROM Test WHERE ID=@ID";
            //SqlCommand cmd = new SqlCommand(deleteQuery, con);
            //cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            //int count = cmd.ExecuteNonQuery();
            //con.Close();
            //if (count > 0)
            //{
            //    MessageBox.Show("Delete Successful.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Delete error.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddForm form2 = new AddForm();
            form2.ShowDialog();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dataGridView1.Focused || dataGridView1.ContainsFocus)
                {
                    button6.PerformClick();
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FocusStyle(Button button)
        {
            button.GotFocus += (sender, e) =>
            {
                button.BackColor = Color.Aquamarine;
                button.ForeColor = Color.White;
            };

            button.LostFocus += (sender, e) =>
            {
                button.BackColor = SystemColors.Control;
                button.ForeColor = Color.Black;
            };
        }

        //private bool isEditable = false;

        //private void buttonEdit_Click(object sender, EventArgs e)
        //{
        //    isEditable = !isEditable;
        //    dataGridView1.ReadOnly = !isEditable;

        //    if (isEditable)
        //    {
        //        dataGridView1.DefaultCellStyle.BackColor = Color.White;
        //        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
        //    }
        //    else
        //    {
        //        dataGridView1.DefaultCellStyle.BackColor = Color.LightGray;
        //        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
        //    }
        //}

        private void editTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int rowIndex = -1;

            //if (rowIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

            //    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            //    string name = selectedRow.Cells["Name"].Value.ToString();

            //    string newName = Interaction.InputBox("Enter new name:", "Edit row", name);

            //    if (!string.IsNullOrEmpty(newName))
            //    {
            //        UpdateRowInDatabase(id, newName);
            //    }
            //}




            //string id = dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value.ToString();
            //string name = dataGridView1.Rows[selectedRowIndex].Cells["Name"].Value.ToString();
            //string description = dataGridView1.Rows[selectedRowIndex].Cells["Description"].Value.ToString();
            //float price = float.Parse(dataGridView1.Rows[selectedRowIndex].Cells["Price"].Value.ToString());
            //string category = dataGridView1.Rows[selectedRowIndex].Cells["Category"].Value.ToString();
            //bool availability = (bool)dataGridView1.Rows[selectedRowIndex].Cells["Availability"].Value;


            //EditForm form3 = new EditForm(id, name, description, price, category, availability);
            //if (form3.ShowDialog() == DialogResult.OK)
            //{
            //    dataGridView1.Rows[selectedRowIndex].Cells["Name"].Value = form3.UpdatedName;
            //    dataGridView1.Rows[selectedRowIndex].Cells["Description"].Value = form3.UpdatedDescription;
            //    dataGridView1.Rows[selectedRowIndex].Cells["Price"].Value = form3.UpdatedPrice;
            //    dataGridView1.Rows[selectedRowIndex].Cells["Category"].Value = form3.UpdatedCategory;
            //    dataGridView1.Rows[selectedRowIndex].Cells["Availability"].Value = form3.UpdatedAvailability;
            //}

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string id = selectedRow.Cells["ID"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                string description = selectedRow.Cells["Description"].Value.ToString();
                float price = float.Parse(selectedRow.Cells["Price"].Value.ToString());
                string category = selectedRow.Cells["Category"].Value.ToString();
                bool availability = (bool)selectedRow.Cells["Availability"].Value;
                string createdBy = selectedRow.Cells["Created by"].Value.ToString();

                EditForm editForm = new EditForm(id, name, description, price, category, availability, createdBy);
                editForm.ShowDialog();


            }

            LoadData();


        }

        private void UpdateRowInDatabase(int id, string newName, string newDescription, float newPrice, string newCategory)
        {
            string connectionString = "Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string updateQuery = "UPDATE Test SET Name=@Name Description=@Description, Price=@Price, Category=@Category WHERE ID @ID";


            using (SqlConnection conn = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", newName);
                    cmd.Parameters.AddWithValue("@Description", newDescription);
                    cmd.Parameters.AddWithValue("@Price", newPrice);
                    cmd.Parameters.AddWithValue("@Category", newCategory);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Rows updated successfully.");
                            RefreshData();
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter the ID of the row you want to delete", "Delete row", "", -1, -1);

            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int id))
            {
                DeleteRowFromDatabase(id);
            }
            else
            {
                MessageBox.Show("Invalid ID entered. Please enter a valid number");
            }
        }


        private void DeleteRowFromDatabase(int id)
        {
            string connectionString = "Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = "DELETE FROM Test WHERE ID = @ID";


            using (SqlConnection conn = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                //using SqlCommand cmd = new SqlConnection(connectionString); THIS CODE DOES NOT WORK
                SqlCommand cmd = new SqlCommand(query, conn);
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully.");
                            RefreshData();
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            int rowIndex = -1;
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    rowIndex = hit.RowIndex;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                }
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedCells.Count > 0)
            //{
            //    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

            //    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            //    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            //    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Delete Row", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        DeleteRowFromDatabase(id);

            //        dataGridView1.Rows.RemoveAt(selectedRowIndex);
            //        RefreshData();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No cell selected");
            //    }
            //}
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (dataGridView1.IsCurrentCellInEditMode)
                {
                    dataGridView1.EndEdit();
                }

                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                if (!selectedRow.IsNewRow)
                {
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Delete Row", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        DeleteRowFromDatabase(id);

                        //dataGridView1.Rows.RemoveAt(selectedRowIndex); - Uncommitted new row cannot be deleted

                        RefreshData();
                    }
                }
                else
                {
                    MessageBox.Show("Cannot delete an uncommitted new row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No cell selected.");
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //if (dataGridView1.SelectedCells.Count > 0)
            //{
            //    if(dataGridView1.IsCurrentCellDirty)
            //    {
            //        dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            //    }

            //    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            //    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            //    if (selectedRow.IsNewRow)
            //    {
            //        MessageBox.Show("Cannot delete an uncommitted new row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            //    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Delete Row", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        DeleteRowFromDatabase(id);

            //        dataGridView1.Rows.RemoveAt(selectedRowIndex);

            //        RefreshData();
            //    }
            //    else
            //    {
            //    MessageBox.Show("No cell selected.");
            //    }

            //}
        }

        public void LoadData()
        {
            string connectionString = "Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = "SELECT * FROM Test";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //dataAdapter = new SqlDataAdapter(query, connection);
                //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                //dataTable = new DataTable();
                //dataAdapter.Fill(dataTable);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Refresh();
                    dataTable.AcceptChanges();
                }
            }
        }

        private void ShowFormPopup()
        {
            FormPopup formPopup = new FormPopup();
            if (formPopup.ShowDialog() == DialogResult.OK)
            {
                LoadData();

            }
        }


        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                selectedRowIndex = e.RowIndex;

                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        //private void addToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FormPopup form2 = new FormPopup();
        //    form2.ShowDialog();
        //}

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddForm addForm = new AddForm();
            //addForm.ShowDialog();

            using (AddForm addForm = new AddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                    addForm.Close();
                }

            }
        }

        public void EndDataGridViewEdit()
        {
            dataGridView1.EndEdit();
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddForm addForm = new AddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                    addForm.Close();
                }

            }
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OrderForm orderForm = new OrderForm())
            {
                if(orderForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                    orderForm.Close();
                }
            }
        }

        public DataGridView DataGridViewControl
        { get { return dataGridView1; } }
    }
}

