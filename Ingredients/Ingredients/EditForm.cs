using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ingredients
{
    public partial class EditForm : Form
    {
        public string UpdatedName { get; private set; }
        public string UpdatedDescription { get; private set; }
        public string UpdatedCategory { get; private set; }
        public float UpdatedPrice { get; private set; }
        public bool UpdatedAvailability { get; private set; }
        public EditForm(string id, string name, string description, float price, string category, bool availability, string createdBy)
        {
            InitializeComponent();

            comboBox_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_CreatedBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPrice.KeyDown += txtPrice_KeyDown;
            checkBox_isAvailable.KeyDown += checkBox_isAvailable_KeyDown;

            txtID.Text = id;
            txtID.ReadOnly = true;
            txtName.Text = name;
            txtDescription.Text = description;
            txtPrice.Text = price.ToString();
            checkBox_isAvailable.Checked = availability;
            //comboBox_Category.SelectedItem = category;
            //comboBox_CreatedBy.SelectedItem = createdBy;

            //MessageBox.Show(category);

            if (!comboBox_Category.Items.Contains(category))
            {
                comboBox_Category.Items.Add(category);
            }
            comboBox_Category.SelectedItem = category;

            if (!comboBox_CreatedBy.Items.Contains(createdBy))
            {
                comboBox_CreatedBy.Items.Add(createdBy);
            }
            comboBox_CreatedBy.SelectedItem = createdBy;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            string updateQuery = "UPDATE Test SET Name=@Name, Description=@Description, Price=@Price, Availability=@Availability, [Category]=@Category, [Created by]=@Createdby WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.Parameters.AddWithValue("@Price", float.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@Category", comboBox_Category.Text);
            cmd.Parameters.AddWithValue("@Availability", checkBox_isAvailable.Checked ? 1 : 0);
            cmd.Parameters.AddWithValue("@Createdby", comboBox_CreatedBy.Text);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Update Successful.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update error.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //try
            //{


            //    using (SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            //    {
            //        con.Open();
            //        string updateQuery = "UPDATE Test SET Name=@Name, Description=@Description, Price=@Price, isAvailable=@isAvailable Category=@Category WHERE ID=@ID";

            //        using (SqlCommand cmd = new SqlCommand(updateQuery, con))
            //        {
            //            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txtID.Text);
            //            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtName.Text;
            //            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = txtDescription.Text;
            //            cmd.Parameters.Add("@Price", SqlDbType.Float).Value = float.Parse(txtPrice.Text);
            //            cmd.Parameters.Add("@isAvailable", SqlDbType.Bit).Value = checkBox_isAvailable.Checked;
            //            cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = comboBox_Category.Text;

            //            MessageBox.Show(cmd.ExecuteNonQuery() > 0 ? "Insert Successful." : "Insert Error.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //    if (this.Owner is Form1 mainForm)
            //    {
            //        mainForm.LoadData();
            //    }

            //    this.DialogResult = DialogResult.OK;

            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

        private void comboBoxCategory_KeyDown(object sender, KeyEventArgs e)
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

        private void EditForm_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtName.Focus();

            txtName.KeyDown += TextBox_KeyDown;
            txtDescription.KeyDown += TextBox_KeyDown;
            txtPrice.KeyDown += TextBox_KeyDown;
            comboBox_Category.KeyDown += TextBox_KeyDown;
            comboBox_CreatedBy.KeyDown += TextBox_KeyDown;
            checkBox_isAvailable.KeyDown += TextBox_KeyDown;
            button1.KeyDown += TextBox_KeyDown;
            button2.KeyDown += TextBox_KeyDown;

            comboBox_Category.Items.Add("Starters");
            comboBox_Category.Items.Add("Soups");
            comboBox_Category.Items.Add("Main Dish");
            comboBox_Category.Items.Add("Side Dish");
            comboBox_Category.Items.Add("Beverage");
            comboBox_Category.Items.Add("Cocktails");
            comboBox_Category.Items.Add("Wine");
            comboBox_Category.Items.Add("Desserts");

            //if(comboBox_Category.Items.Contains(category))
            //{
            //    comboBox_Category.SelectedItem = category;
            //}
            //else
            //{
            //    MessageBox.Show($"Category '{category}' not found.");
            //}
        }

        private void ComboBox_CreatedBy_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                checkBox_isAvailable.Focus();
            }
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
                    button1.Focus();
                }
                else
                {
                    SelectNextControl((Control)sender, true, true, true, true);
                }

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

        private void checkBox_isAvailable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.Focus();
            }
        }
    }
}
