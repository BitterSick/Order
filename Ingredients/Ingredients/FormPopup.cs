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
using System.Data.Common; 

namespace Ingredients
{
    public partial class FormPopup : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public System.Windows.Forms.DataGridView dataGridView1;

        public FormPopup()
        {
            InitializeComponent();
            textBox1.Text = GenerateUniqueID();
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            button2.Click += new EventHandler(button2_Click);
            FocusStyle(button1);
            FocusStyle(button2);
            FocusStyle(button3);
            FocusStyle(button4);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(99, 107);
            label1.Name = "label1";
            label1.Size = new Size(50, 41);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(99, 313);
            label2.Name = "label2";
            label2.Size = new Size(155, 41);
            label2.TabIndex = 1;
            label2.Text = "Unit Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(99, 245);
            label3.Name = "label3";
            label3.Size = new Size(180, 41);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(99, 175);
            label4.Name = "label4";
            label4.Size = new Size(101, 41);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(289, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(538, 31);
            textBox1.TabIndex = 13;
            textBox1.TabStop = false;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(538, 31);
            textBox2.TabIndex = 4;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(538, 31);
            textBox3.TabIndex = 5;
            textBox3.KeyDown += textBox3_KeyDown;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Solid", "Liquid" });
            comboBox1.Location = new Point(289, 321);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(538, 33);
            comboBox1.TabIndex = 6;
            comboBox1.KeyDown += comboBox1_KeyDown;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(99, 460);
            button1.Name = "button1";
            button1.Size = new Size(254, 105);
            button1.TabIndex = 7;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(154, 61);
            button2.TabIndex = 9;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button3.Location = new Point(190, 17);
            button3.Name = "button3";
            button3.Size = new Size(137, 51);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.Location = new Point(573, 460);
            button4.Name = "button4";
            button4.Size = new Size(254, 105);
            button4.TabIndex = 8;
            button4.Text = "Exit Window";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormPopup
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(979, 705);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPopup";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormPopup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GenerateUniqueID()
        {
            return "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            string insertQuery = "INSERT INTO Test (ID, Name, Description, UnitType, Created) VALUES (@ID, @Name, @Description, @UnitType, GETDATE())";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Description", textBox3.Text);
            cmd.Parameters.AddWithValue("@UnitType", comboBox1.Text);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Insert Successful.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                LoadData();
            }
            else
            {
                MessageBox.Show("Insert error.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();

            LoadData();
        }

        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            SqlCommand cmd = new("select * from Test", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            //dataGridView1.DataSource = dataTable;
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

                    //dataGridView1.DataSource = dataTable;
                }
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                comboBox1.Focus();
                comboBox1.DroppedDown = true;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            textBox1.ReadOnly = true;
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

        private void FormPopup_Load(object sender, EventArgs e)
        {
            BindData();
            textBox1.Text = GetNextID().ToString();
            LoadDataIntoGrid();


            //if (textBox1.ReadOnly == true)
            //{ 
            //    textBox1.BackColor = Color.Gray;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            string updateQuery = "UPDATE Test SET Name=@Name, Description=@Description, UnitType=@UnitType WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Description", textBox3.Text);
            cmd.Parameters.AddWithValue("@UnitType", comboBox1.Text);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            string deleteQuery = "DELETE FROM Test WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            int count = cmd.ExecuteNonQuery();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Delete Successful.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete error.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void LoadData()
        {
            string connectionString = "Data Source=TUAN007\\MSSQLSERVER01;Initial Catalog=Gastronomy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = "SELECT * FROM Test";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dataAdapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                //dataGridView1.DataSource = dataTable;
            }
        }
    }
}
