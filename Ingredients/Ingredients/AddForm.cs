using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Ingredients
{
    public partial class AddForm : Form
    {

        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public System.Windows.Forms.DataGridView dataGridView1;


        public AddForm()
        {
            InitializeComponent();
            txtID.ReadOnly = true;
            comboBox_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_CreatedBy.DropDownStyle = ComboBoxStyle.DropDownList;

            txtPrice.KeyDown += txtPrice_KeyDown;
            checkBox_isAvailable.KeyDown += checkBox_isAvailable_KeyDown;

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            //con.Open();
            //string insertQuery = "INSERT INTO Test (ID, Name, Description, UnitType, Created) VALUES (@ID, @Name, @Description, @UnitType, GETDATE())";
            //SqlCommand cmd = new SqlCommand(insertQuery, con);
            //cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            //cmd.Parameters.AddWithValue("@Name", txtName.Text);
            //cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            //cmd.Parameters.AddWithValue("@UnitType", comboBox_UnitType.Text);
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

            //this.DialogResult = DialogResult.OK;

            //this.Close();



            try
            {


                using (SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string insertQuery = "INSERT INTO Test (ID, Name, Description, Price, Availability, Category, Created, [Created by]) VALUES (@ID, @Name, @Description, @Price, @Availability, @Category, GETDATE(), @Createdby)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txtID.Text);
                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtName.Text;
                        cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = txtDescription.Text;
                        cmd.Parameters.Add("@Price", SqlDbType.Float).Value = float.Parse(txtPrice.Text);
                        cmd.Parameters.Add("@Availability", SqlDbType.Bit).Value = checkBox_isAvailable.Checked;
                        cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = comboBox_Category.Text;
                        cmd.Parameters.Add("@Createdby", SqlDbType.NVarChar).Value = comboBox_CreatedBy.Text;

                        MessageBox.Show(cmd.ExecuteNonQuery() > 0 ? "Insert Successful." : "Insert Error.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (this.Owner is Form1 mainForm)
                {
                    mainForm.LoadData();
                }

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //void BindData()
        //{
        //    SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        //    SqlCommand cmd = new("select * from Test", con);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dataTable = new DataTable();
        //    adapter.Fill(dataTable);

        //    //dataGridView1.DataSource = dataTable;
        //}

        //private void LoadData()
        //{
        //    string connectionString = "Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        //    string query = "SELECT * FROM Test";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        dataAdapter = new SqlDataAdapter(query, connection);
        //        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

        //        dataTable = new DataTable();
        //        dataAdapter.Fill(dataTable);

        //        if (dataGridView1 != null)
        //        {
        //            dataGridView1.DataSource = dataTable;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Error: dataGridView is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //    }
        //}


        private void AddForm_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtName.Focus();

            txtName.KeyDown += TextBox_KeyDown;
            txtDescription.KeyDown += TextBox_KeyDown;
            txtPrice.KeyDown += TextBox_KeyDown;
            comboBox_Category.KeyDown += TextBox_KeyDown;
            comboBox_CreatedBy.KeyDown += TextBox_KeyDown;
            checkBox_isAvailable.KeyDown += TextBox_KeyDown;
            OK_Button.KeyDown += TextBox_KeyDown;
            Cancel_Button.KeyDown += TextBox_KeyDown;

            //BindData();
            txtID.Text = GetNextID().ToString();
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

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (sender == comboBox_Category && comboBox_Category.Items.Count > 0)
                {
                    comboBox_Category.SelectedIndex = 0;
                    checkBox_isAvailable.Checked = true;
                    OK_Button.Focus();
                }
                else
                {
                    SelectNextControl((Control)sender, true, true, true, true);
                }

            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);

                if (comboBox_Category.Focused && comboBox_Category.Items.Count > 0)
                {
                    if (comboBox_Category.SelectedIndex == -1)
                    {
                        comboBox_Category.SelectedIndex = 0;
                    }
                }
            }
        }

        private void comboBox_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);

                if (comboBox_CreatedBy.Focused && comboBox_CreatedBy.Items.Count > 0)
                {
                    if (comboBox_CreatedBy.SelectedIndex == -1)
                    {
                        comboBox_CreatedBy.SelectedIndex = 0;
                    }
                }
            }
        }

        private void checkBox_isAvailable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                OK_Button.Focus();
            }
        }
        private void comboBox_CreatedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                checkBox_isAvailable.Focus();
            }
        }

        private void checkBox_isAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
