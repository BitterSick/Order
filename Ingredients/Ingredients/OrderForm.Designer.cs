namespace Ingredients
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            Quantity = new DataGridViewTextBoxColumn();
            ItemSum = new DataGridViewTextBoxColumn();
            Availability = new DataGridViewCheckBoxColumn();
            txtTotal = new TextBox();
            categoryCheckedListBox = new CheckedListBox();
            label1 = new Label();
            clearButton = new Button();
            saveButton = new Button();
            txtIDBill = new TextBox();
            BillListView = new ListView();
            ItemID = new ColumnHeader();
            ItemName = new ColumnHeader();
            ItemPrice = new ColumnHeader();
            ItQty = new ColumnHeader();
            ItSum = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Quantity, ItemSum, Availability });
            dataGridView.Location = new Point(41, 37);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1332, 940);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 150;
            // 
            // ItemSum
            // 
            ItemSum.HeaderText = "ItemSum";
            ItemSum.MinimumWidth = 8;
            ItemSum.Name = "ItemSum";
            ItemSum.Width = 150;
            // 
            // Availability
            // 
            Availability.DataPropertyName = "Availability";
            Availability.HeaderText = "Availability";
            Availability.MinimumWidth = 8;
            Availability.Name = "Availability";
            Availability.ReadOnly = true;
            Availability.Width = 150;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTotal.Location = new Point(1585, 992);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(549, 34);
            txtTotal.TabIndex = 1;
            // 
            // categoryCheckedListBox
            // 
            categoryCheckedListBox.FormattingEnabled = true;
            categoryCheckedListBox.Items.AddRange(new object[] { "Starters", "Soups", "Main dish", "Side dish", "Beverage", "Cocktails", "Desserts" });
            categoryCheckedListBox.Location = new Point(1402, 64);
            categoryCheckedListBox.Name = "categoryCheckedListBox";
            categoryCheckedListBox.Size = new Size(140, 228);
            categoryCheckedListBox.TabIndex = 2;
            categoryCheckedListBox.ItemCheck += categoryCheckedListBox_ItemCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(1402, 33);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 3;
            label1.Text = "Category filter";
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            clearButton.Location = new Point(1401, 319);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(138, 72);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            saveButton.Location = new Point(1930, 1057);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(204, 76);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save Bill";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // txtIDBill
            // 
            txtIDBill.Location = new Point(1466, 992);
            txtIDBill.Name = "txtIDBill";
            txtIDBill.Size = new Size(87, 31);
            txtIDBill.TabIndex = 6;
            // 
            // BillListView
            // 
            BillListView.BackgroundImageTiled = true;
            BillListView.Columns.AddRange(new ColumnHeader[] { ItemID, ItemName, ItemPrice, ItQty, ItSum });
            BillListView.FullRowSelect = true;
            BillListView.Location = new Point(1585, 33);
            BillListView.Name = "BillListView";
            BillListView.Size = new Size(549, 944);
            BillListView.TabIndex = 7;
            BillListView.UseCompatibleStateImageBehavior = false;
            BillListView.View = View.Details;
            // 
            // ItemID
            // 
            ItemID.Text = "ID";
            ItemID.Width = 50;
            // 
            // ItemName
            // 
            ItemName.Text = "Item";
            ItemName.Width = 250;
            // 
            // ItemPrice
            // 
            ItemPrice.Text = "Price";
            ItemPrice.Width = 90;
            // 
            // ItQty
            // 
            ItQty.Text = "Qty";
            ItQty.Width = 50;
            // 
            // ItSum
            // 
            ItSum.Text = "Sum";
            ItSum.Width = 100;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2172, 1154);
            Controls.Add(BillListView);
            Controls.Add(txtIDBill);
            Controls.Add(saveButton);
            Controls.Add(clearButton);
            Controls.Add(label1);
            Controls.Add(categoryCheckedListBox);
            Controls.Add(txtTotal);
            Controls.Add(dataGridView);
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Form";
            Load += OrderForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox txtTotal;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ItemSum;
        private DataGridViewCheckBoxColumn Availability;
        private CheckedListBox categoryCheckedListBox;
        private Label label1;
        private Button clearButton;
        private Button saveButton;
        private TextBox txtIDBill;
        private ListView BillListView;
        private ColumnHeader ItemID;
        private ColumnHeader ItemName;
        private ColumnHeader ItQty;
        private ColumnHeader ItSum;
        private ColumnHeader ItemPrice;
    }
}